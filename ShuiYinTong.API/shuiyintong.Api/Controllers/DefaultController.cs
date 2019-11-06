using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common.NPOIFile;
using shuiyintong.Entity.SPDBankEntity.SPDBankFile;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 测试使用
    /// </summary>
    public class DefaultController : BaseController
    {
        private Dictionary<string, string> DirData = new Dictionary<string, string>
        {
            { "BorrowingEnterprise","三星电子"}, //借款企业
            { "AgreementNumber","20190900110"}, //借款合同编号
            { "Loan","1022.52"}, //借款金额         
            { "GuaranteedMount","3600.00"},//担保的借款金额为人民币
            { "PeriodMonth","36"}, //申请借款的期限月
            { "InterestYear","2019"},//起息日
            { "AAA","12"},
            { "BBB","10"},
            { "DueYear","2025"},//到期日
            { "CCC","10"},
            { "DDD","15"},
            { "TotalMoney","4622.52"}
        };

        /// <summary>
        /// 生成Word文档GenerateDoc
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public void CreateWord(GuaranteeReq guaranteeReq)
        {
            string paths = @"F:\GitHubProject\ShuiYinTong.API\shuiyintong.Api\File\担保函.docx";
            NPOIHleper.Export(paths, @"C:\Users\Mypc\Desktop\1.docx", DirData);
        }

    }
}