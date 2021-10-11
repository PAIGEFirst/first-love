using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            /* -- 获取Users表数据 -- */
            using (FXEntities fx = new FXEntities())
            {
                ViewBag.UName = fx.Users.ToList();
            }
            return View();
        }

        /* -- 验证用户名是否存在 -- */
        [HttpPost] /* -- 非三层非AJXA版 -- */
        public ActionResult Index(string UName)
        {
            using (FXEntities fx = new FXEntities())
            {
                /* -- 获取Users表数据 -- */
                ViewBag.UName = fx.Users.ToList();

                if (UName != "")
                {
                    string sql = string.Format("SELECT * FROM Users WHERE UName='{0}'", UName);
                    if (fx.Database.SqlQuery<Users>(sql).ToList().Count > 0)
                    {
                        ViewBag.TC = "zhi";
                        ViewBag.name = UName;
                    }
                    else
                    {
                        ViewBag.TC = "kong2";
                        ViewBag.name = UName;
                    }
                }
                else
                {
                    ViewBag.TC = "kong";
                }

            }
            return View();
        }


        /* -- 验证用户名是否存在(非三层AJAX版) -- */
        public ActionResult Index2()
        {
            using (FXEntities fx = new FXEntities())
            {
                /* -- 获取Users表数据 -- */
                ViewBag.UName = fx.Users.ToList();
            }

            return View();
        }



    }
}