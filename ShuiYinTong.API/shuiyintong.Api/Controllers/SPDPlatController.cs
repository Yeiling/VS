using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common.Extend;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.Test_tuishui_Demo;
using shuiyintong.Entity.HttpRequestResultEntity;
using shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq;
using System;
using static shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq.DeductionEnum;
namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 浦发银行平台接口---税单贷自动付款(浦发银行--->>>平台)
    /// </summary>
    public class SPDPlatController : BaseController
    {
        #region 数据库操作相关服务
        /// <summary>
        /// 记录操作日志
        /// </summary>
        public IBaseService<tb_productOrderLog> ProductOrderLogServer { get; set; }

        /// <summary>
        /// 项目审批信息
        /// </summary>
        public IBaseService<tb_ProjectApproval> ProjectApprovalSer { get; set; }
        /// <summary>
        /// 订单表服务
        /// </summary>
        public IBaseService<tb_productOrder> ProductOrderSer { get; set; }

        /// <summary>
        /// 退税账户核验
        /// </summary>
        public IBaseService<tb_TaxVerification> TaxVerificationSer { get; set; }
        /// <summary>
        /// 公司账户
        /// </summary>
        public IBaseService<tb_companyAccount> CompanyAccountSer { get; set; }

        /// <summary>
        /// 用款服务
        /// </summary>
        public IBaseService<tb_Yongkuan> YongkuanSer { get; set; }

        /// <summary>
        /// 预警服务
        /// </summary>
        public IBaseService<tb_Warning> WarningSer { get; set; }


        #endregion


        #region 授信
        /// <summary>
        /// 2授信---项目审批信息,风险信息(尽调+征信)----------------------------------------(银行回传平台)接口开始----------------------------------------
        /// </summary>
        /// <param name="projectApproval"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CreditBKApprove([FromBody]ProjectApproval projectApproval)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (projectApproval == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //审批意见为“拒绝”，则需“备注”说明。approvalOpinion=true表示通过，approvalOpinion=false表示拒绝
            if (!projectApproval.approvalOpinion && string.IsNullOrWhiteSpace(projectApproval.remarks))
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "审批意见为“拒绝”，则必须填写“备注”说明",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            tb_ProjectApproval ProjectApprovalModel = new tb_ProjectApproval
            {
                platformAcctNo = projectApproval.platformAcctNo,
                enterpriseName = projectApproval.enterpriseName,
                approvalOpinion = projectApproval.approvalOpinion,
                remarks = projectApproval.remarks,
                enterpriseScale = projectApproval.enterpriseScale,
                planningEnterprise = projectApproval.planningEnterprise,
                businessIncome = projectApproval.businessIncome,
                practitioners = projectApproval.practitioners,
                totalAssets = projectApproval.totalAssets,
                IsFitReq = projectApproval.IsFitReq,
                proportion = projectApproval.proportion,
                overdueFrequency = projectApproval.overdueFrequency,
                overdueTotalFrequency = projectApproval.overdueTotalFrequency,
                createTime = DateTime.Now
            };
            bool bol = ProjectApprovalSer.AddOne(ProjectApprovalModel); //保存推送数据
            if (bol)
            {
                var PAModel = ProductOrderSer.GetSingle(p => p.OrderNo == projectApproval.platformAcctNo);
                //更新tb_productOrder表订单状态
                PAModel.status = projectApproval.approvalOpinion ? "0100" : "11";
                PAModel.updatetime = DateTime.Now;
                bol = ProductOrderSer.ModefyOne(PAModel);
                if (bol)
                {
                    //记录日志
                    ProductOrderLogServer.AddOne(new tb_productOrderLog
                    {
                        userName = "银行",
                        dates = DateTime.Now,
                        action = projectApproval.approvalOpinion ? "通过" : "拒绝",
                        remark = ProjectApprovalModel.remarks,
                        title = "银行审批",
                        orderId = PAModel?.Id.ToString()
                    });
                }
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = ProjectApprovalModel.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });

            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        /// <summary>
        /// 4授信---退税账户核验信息
        /// </summary>
        /// <param name="taxVerification"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CreditBKVer([FromBody]TaxVerification taxVerification)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (taxVerification == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            tb_TaxVerification TaxVerificationModel = new tb_TaxVerification
            {
                platformAcctNo = taxVerification.platformAcctNo,
                enterpriseName = taxVerification.enterpriseName,
                accountName = taxVerification.accountName,
                acctNo = taxVerification.acctNo,
                openBank = taxVerification.openBank,
                IsDrawback = taxVerification.IsDrawback,
                createTime = DateTime.Now
            };
            bool bol = TaxVerificationSer.AddOne(TaxVerificationModel); //保存推送数据
            if (bol)
            {
                var PAModel = ProductOrderSer.GetSingle(p => p.OrderNo == taxVerification.platformAcctNo);
                var CAModel = CompanyAccountSer.GetSingle(c => c.OrderNo == taxVerification.platformAcctNo);
                if (PAModel != null && CAModel != null)
                {
                    PAModel.updatetime = DateTime.Now;
                    switch (taxVerification.IsDrawback)
                    {
                        case true:
                            PAModel.status = "0100_pass";  //通过审批
                            CAModel.bankConfirmFlag = "1";  //退税账户
                            break;
                        default:
                            PAModel.status = "0100_fail";  //审批拒绝
                            CAModel.bankConfirmFlag = "0";  //非退税账户
                            break;
                    }
                    //更新tb_productOrder表订单状态
                    ProductOrderSer.ModefyOne(PAModel);
                    //更新tb_productOrder表订单状态
                    CompanyAccountSer.ModefyOne(CAModel);
                    return Json(new BaseResponse<string>
                    {
                        Code = 200,
                        ResponseType = (byte)InteractiveCode.Success,
                        Data = TaxVerificationModel.ToJson(),
                        DateTime = Now,
                        Msg = InteractiveCode.Success.GetDescription()
                    });
                }
                else
                {
                    return Json(new BaseResponse<string>
                    {
                        Code = 500,
                        ResponseType = (byte)InteractiveCode.Fail,
                        Data = "推送成功，并出现其他数据操作异常",
                        DateTime = Now,
                        Msg = InteractiveCode.Fail.GetDescription()
                    });
                }
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }
        #endregion

        #region 用款
        /// <summary>
        /// 8用款---项目审批信息,项目风险信息（征信）
        /// </summary>
        /// <param name="projectUsage"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult LoanBKApprove([FromBody]ProjectUsage projectUsage)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (projectUsage == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //审批意见为“拒绝”，则需“备注”说明。approvalOpinion=true表示通过，approvalOpinion=false表示拒绝
            if (!projectUsage.approvalOpinion && string.IsNullOrWhiteSpace(projectUsage.remarks))
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "审批意见为“拒绝”，则必须填写“备注”说明",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态
            bool bol = YongkuanSer.Modefy(p => p.OrderNo == projectUsage.platformAcctNo,
                  po => new tb_Yongkuan
                  {
                      //"3010"--通过审批  "3001"--审批拒绝
                      status = projectUsage.approvalOpinion ? "3010" : "3001",
                      DqSxEdu = projectUsage.currentCreditAmount, //当前授信额度
                      DbYkEdu = projectUsage.singlePaymentAmount, //单笔授信额度
                      updatetime = DateTime.Now
                  });
            if (bol)
            {
                var PAModel = ProductOrderSer.GetSingle(p => p.OrderNo == projectUsage.platformAcctNo);
                //日志记录
                ProductOrderLogServer.AddOne(new tb_productOrderLog
                {
                    userName = "银行",
                    dates = DateTime.Now,
                    action = "通过",
                    title = "银行用款审批",
                    orderId = PAModel?.Id.ToString()
                });
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = projectUsage.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        /// <summary>
        /// 16用款---银行放款信息
        /// </summary>
        /// <param name="loanInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CreditBKAdvance([FromBody]LoanInfo loanInfo)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (loanInfo == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 //"3060" 已放款
            bool bol = YongkuanSer.Modefy(p => p.OrderNo == loanInfo.platformAcctNo,
                   po => new tb_Yongkuan
                   {
                       status = "3060",
                       TkEdu = loanInfo.withdrawalAmount,  //提款金额
                       tkTime = loanInfo.withdrawalTime, //提款日期
                       tkAccNo = loanInfo.acctNo,  //提款账户账号
                       tkAccName = loanInfo.accountName, //提款账户户名
                       tkBankName = loanInfo.openBank, //提款账户开户行
                       jkEndTime = loanInfo.loanDueDate, //借款到期日
                       ZJyt = loanInfo.proceUse, //资金用途
                       JkHtNo = loanInfo.loanContractNo, //借款合同编号
                       updatetime = DateTime.Now
                   });
            if (bol)
            {
                var PAModel = ProductOrderSer.GetSingle(p => p.OrderNo == loanInfo.platformAcctNo);
                //日志记录
                ProductOrderLogServer.AddOne(new tb_productOrderLog
                {
                    userName = "银行",
                    dates = DateTime.Now,
                    action = "通过",
                    title = "银行放款信息",
                    orderId = PAModel?.Id.ToString()
                });
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = loanInfo.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }
        #endregion

        #region 贷后
        /// <summary>
        /// 18贷后预警阶段---银行选择推送担保的预警信息
        /// </summary>
        /// <param name="guarantWarn"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKRiskList([FromBody]GuarantWarn guarantWarn)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (guarantWarn == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 //"3060_A" 推送担保的预警信息
            //bool bol = ProductOrderSer.Modefy(p => p.OrderNo == guarantWarn.platformAcctNo,
            //       po => new tb_productOrder
            //       {
            //           status = "3060_A",
            //           updatetime = DateTime.Now
            //       });
            //if (bol)
            //{
            //    return Json(new BaseResponse<string>
            //    {
            //        Code = 200,
            //        ResponseType = (byte)InteractiveCode.Success,
            //        Data = guarantWarn.ToJson(),
            //        DateTime = Now,
            //        Msg = InteractiveCode.Success.GetDescription()
            //    });
            //}
            //else  //推送失败提示信息
            //{
            //    return Json(new BaseResponse<string>
            //    {
            //        Code = 200,
            //        ResponseType = (byte)InteractiveCode.Fail,
            //        DateTime = Now,
            //        Msg = InteractiveCode.Fail.GetDescription()
            //    });
            //}
            return null;
        }

        /// <summary>
        /// 19贷后预警阶段---接收担保所推送预警后的处理结果以及意见
        /// </summary>
        /// <param name="guarantWarnResult"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKRiskResult([FromBody]GuarantWarnResult guarantWarnResult)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (guarantWarnResult == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 //"3070" 
            //bool bol = ProductOrderSer.Modefy(p => p.OrderNo == guarantWarnResult.platformAcctNo,
            //       po => new tb_productOrder { status = "3070", updatetime = DateTime.Now });
            //if (bol)
            //{
            //    return Json(new BaseResponse<string>
            //    {
            //        Code = 200,
            //        ResponseType = (byte)InteractiveCode.Success,
            //        Data = guarantWarnResult.ToJson(),
            //        DateTime = Now,
            //        Msg = InteractiveCode.Success.GetDescription()
            //    });
            //}
            //else  //推送失败提示信息
            //{
            //    return Json(new BaseResponse<string>
            //    {
            //        Code = 200,
            //        ResponseType = (byte)InteractiveCode.Fail,
            //        DateTime = Now,
            //        Msg = InteractiveCode.Fail.GetDescription()
            //    });
            //}
            return null;
        }

        /// <summary>
        /// 20贷后预警阶段---征信指标
        /// </summary>
        /// <param name="creditStatement"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKEnquiry([FromBody]CreditStatement creditStatement)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (creditStatement == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 //"3060_A" 
            //bool bol = ProductOrderSer.Modefy(p => p.OrderNo == creditStatement.platformAcctNo,
            //       po => new tb_productOrder { status = "3060_A", updatetime = DateTime.Now });
            //if (bol)
            //{
            //    return Json(new BaseResponse<string>
            //    {
            //        Code = 200,
            //        ResponseType = (byte)InteractiveCode.Success,
            //        Data = creditStatement.ToJson(),
            //        DateTime = Now,
            //        Msg = InteractiveCode.Success.GetDescription()
            //    });
            //}
            //else  //推送失败提示信息
            //{
            //    return Json(new BaseResponse<string>
            //    {
            //        Code = 200,
            //        ResponseType = (byte)InteractiveCode.Fail,
            //        DateTime = Now,
            //        Msg = InteractiveCode.Fail.GetDescription()
            //    });
            //}
            return null;
        }


        /// <summary>
        /// 22成功扣款之后---用款项目扣款结项之后
        /// </summary>
        /// <param name="deductionAccount"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKPay([FromBody]DeductionAccount deductionAccount)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (deductionAccount == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态  //100
            bool bol = ProductOrderSer.Modefy(p => p.OrderNo == deductionAccount.platformAcctNo,
                   po => new tb_productOrder { status = "100", updatetime = DateTime.Now });
            if (bol)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = deductionAccount.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        /// <summary>
        /// 23成功扣款之后---逾期确认信息
        /// </summary>
        /// <param name="overdueInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKOverdue([FromBody]OverdueInfo overdueInfo)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (overdueInfo == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 
            bool bol = ProductOrderSer.Modefy(p => p.OrderNo == overdueInfo.platformAcctNo,
                   po => new tb_productOrder { status = "60", updatetime = DateTime.Now });
            if (bol)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = overdueInfo.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        /// <summary>
        /// 24成功扣款之后---结项信息
        /// </summary>
        /// <param name="loanInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKCollection([FromBody]LoanInfo loanInfo)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (loanInfo == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 //"3060" 已放款
            bool bol = ProductOrderSer.Modefy(p => p.OrderNo == loanInfo.platformAcctNo,
                   po => new tb_productOrder { status = "60_finish", updatetime = DateTime.Now });
            if (bol)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = loanInfo.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        /// <summary>
        /// 25银行发起代偿---发起代偿信息
        /// </summary>
        /// <param name="loanInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKCompensatory([FromBody]LoanInfo loanInfo)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (loanInfo == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 //"3060" 已放款
            bool bol = ProductOrderSer.Modefy(p => p.OrderNo == loanInfo.platformAcctNo,
                   po => new tb_productOrder { status = "60_bank", updatetime = DateTime.Now });
            if (bol)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = loanInfo.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        /// <summary>
        /// 28银行查看确认结项之后---结项信息----------------------------------------(银行回传平台)接口结束----------------------------------------
        /// </summary>
        /// <param name="loanInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PostLoanBKNodeTerm([FromBody]LoanInfo loanInfo)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (loanInfo == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //更新tb_productOrder表订单状态 //"3060" 已放款
            bool bol = ProductOrderSer.Modefy(p => p.OrderNo == loanInfo.platformAcctNo,
                   po => new tb_productOrder { status = "3060", updatetime = DateTime.Now });
            if (bol)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = loanInfo.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        #endregion

    }
}
