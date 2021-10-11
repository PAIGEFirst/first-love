using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace WebApplication1.AJAX
{
    /// <summary>
    /// UNameYZ 的摘要说明
    /// </summary>
    public class UNameYZ : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            /* -- 验证用户名是否存在，实现 AJAX -- */
            string srnr = context.Request.QueryString["UName"];
            if (srnr != "")
            {
                string sql = string.Format("SELECT * FROM Users WHERE UName='{0}'", srnr);
                using (FXEntities fx = new FXEntities())
                {
                    if (fx.Database.SqlQuery<Users>(sql).ToList().Count > 0)
                    {
                        context.Response.Write("您输入的用户名:" + srnr + "已存在！请重新输入！");
                    }
                    else
                    {
                        context.Response.Write("您的用户名:" + srnr + "可以进行注册！");
                    }
                }
            }
            else
            {
                context.Response.Write("请输入用户名！");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}