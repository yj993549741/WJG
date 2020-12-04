using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WJG.bll
{


    /// <summary>
    /// md5加密
    /// </summary>
    /// <param name="value"></param>
    /// <retruns></retruns>
    class commandClass
    {
        public  static string  getmd5(string value)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = Encoding.Default.GetBytes(value.Trim());
            byte[] output = md5.ComputeHash(result);
            string hashedpass = "";
            hashedpass = BitConverter.ToString(output).Replace("-","");
            return hashedpass;
        }
    }
}
