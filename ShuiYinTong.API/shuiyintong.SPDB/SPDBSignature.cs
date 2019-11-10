using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
/// <summary>
/// 浦发银行API开放平台接入示例代码（普通签名） for C#
/// date: 2019-08-01
/// version: v1.5
/// </summary>
namespace shuiyintong.SPDB
{
    public class SPDBSignature
    {       
        //签名
        public static string Sign(string data, string key)
        {
            string iv = Guid.NewGuid().ToString().Substring(0, 16);
            byte[] ivBuffer = Encoding.UTF8.GetBytes(iv);
            string contentDigest = SHA1Encrypt(data);
            byte[] keyBuffer = SHA256Encrypt(key);
            byte[] keyDigest = new byte[16];
            Array.Copy(keyBuffer, keyDigest, 16);

            byte[] encrypted = Encrypt(contentDigest, keyDigest, ivBuffer);

            byte[] cipherBuffer = new byte[16 + encrypted.Length];
            Array.Copy(ivBuffer, cipherBuffer, ivBuffer.Length);
            Buffer.BlockCopy(encrypted, 0, cipherBuffer, 16, encrypted.Length);
            return Convert.ToBase64String(cipherBuffer);
        }

        //验签
        public static bool ValidateSign(string data, string key, string sign)
        {
            string contentDigest = SHA1Encrypt(data);
            byte[] keyBuffer = SHA256Encrypt(key);
            byte[] keyDigest = new byte[16];
            Array.Copy(keyBuffer, keyDigest, 16);

            byte[] signBuffer = Convert.FromBase64String(sign);
            byte[] cipherBuffer = new byte[signBuffer.Length - 16];
            Buffer.BlockCopy(signBuffer, 16, cipherBuffer, 0, signBuffer.Length - 16);

            byte[] ivBuffer = new byte[16];
            Array.Copy(signBuffer, ivBuffer, 16);

            byte[] decrypted = Decrypt(cipherBuffer, keyDigest, ivBuffer);
            string decryptedStr = UTF8Encoding.UTF8.GetString(decrypted);

            return contentDigest == decryptedStr;
        }

        public static string SHA1Encrypt(string strIN)
        {
            byte[] tmpByte;

            SHA1 sha1 = new SHA1CryptoServiceProvider();
            tmpByte = sha1.ComputeHash(GetKeyByteArray(strIN));
            sha1.Clear();

            return Convert.ToBase64String(tmpByte);

        }

        public static byte[] SHA256Encrypt(string strIN)
        {
            byte[] tmpByte;

            SHA256 sha256 = new SHA256Managed();
            tmpByte = sha256.ComputeHash(GetKeyByteArray(strIN));
            sha256.Clear();

            return tmpByte;
        }

        private static byte[] GetKeyByteArray(string strKey)
        {
            ASCIIEncoding Asc = new ASCIIEncoding();
            int tmpStrLen = strKey.Length;
            byte[] tmpByte = new byte[tmpStrLen - 1];
            tmpByte = Asc.GetBytes(strKey);
            return tmpByte;
        }

        /// <summary>
        /// 有密码的AES加密 
        /// </summary>
        /// <param name="toEncrypt">加密字符</param>
        /// <param name="keyArray">加密的密码</param>
        /// <param name="ivArray">密钥</param>
        /// <returns></returns>
        public static byte[] Encrypt(string toEncrypt, byte[] keyArray, byte[] ivArray)
        {
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.IV = ivArray;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            return cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="toEncryptArray"></param>
        /// <param name="keyArray"></param>
        /// <param name="ivArray"></param>
        /// <returns></returns>
        public static byte[] Decrypt(byte[] toEncryptArray, byte[] keyArray, byte[] ivArray)
        {
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            return cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        }


        //大报文md5
        public static string BodyMD5(string data)
        {
            byte[] sor = Encoding.UTF8.GetBytes(data);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder strbul = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            return strbul.ToString();
        }

        //文件md5
        public static string FilesMD5(string[] files)
        {
            string md5hex = "";
            for (int j = 0; j < files.Length; j++)
            {
                FileStream file = new FileStream(files[j], FileMode.Open);
                MD5 md5 = MD5.Create();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                if ("".Equals(md5hex))
                {
                    md5hex = sb.ToString();
                }
                else
                {
                    md5hex = md5hex + "," + sb.ToString();
                }
            }
            return md5hex;
        }

    }
}
