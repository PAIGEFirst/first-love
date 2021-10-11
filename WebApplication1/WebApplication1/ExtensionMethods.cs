using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// 密码显示为6个*号 -- 扩展方法(string)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string PwdYC(this string str) 
        {
            if (str != "") 
            {
                str = "******";
            }
            return str;
        }


    }
}