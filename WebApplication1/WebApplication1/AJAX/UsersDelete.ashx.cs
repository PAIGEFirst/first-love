using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace WebApplication1.AJAX
{
    /// <summary>
    /// UsersDelete 的摘要说明
    /// </summary>
    public class UsersDelete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int id = Convert.ToInt32(context.Request.QueryString["ID"]);
            if (Index3BLL.UsersDeleteWhereID(ID: id))
            {
                context.Response.Write("删除成功！");
            }
            else 
            {
                context.Response.Write("删除失败！");
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