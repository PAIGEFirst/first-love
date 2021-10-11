using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using BLL;

namespace WebApplication1.AJAX
{
    /// <summary>
    /// ReigstUsers 的摘要说明
    /// </summary>
    public class ReigstUsers : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string UName = context.Request.QueryString["uname"];
            string UPawd = context.Request.QueryString["pawd"];

            if (UName.Trim() != "" && UName.Trim() != null)
            {
                if (UPawd.Trim() != "" && UPawd.Trim() != null)
                {
                    if (Index3BLL.UsersSelectUName(UName: UName) == false)
                    {
                        if (Index3BLL.UsersInsert(UName: UName, UPawd: UPawd) == true)
                        {
                            context.Response.Write("注册成功！");
                        }
                        else 
                        {
                            context.Response.Write("注册失败！");
                        }
                    }
                    else 
                    {
                        context.Response.Write("您输入的用户名:" + UName + "已存在，请重新输入！");
                    }
                }
                else 
                {
                    context.Response.Write("密码不能为空！");
                }
            }
            else 
            {
                context.Response.Write("用户名不能为空！");
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