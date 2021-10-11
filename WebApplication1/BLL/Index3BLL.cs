using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class Index3BLL
    {
        /// <summary>
        /// 查询Users表(用户表)数据，用于查询用户表信息 -- 逻辑(List)
        /// </summary>
        /// <returns></returns>
        public static List<Users> UsersSelectALL() 
        {
            return Index3DAL.SelectUsersALL();
        }

        /// <summary>
        /// 查询Users表(用户表)UName字段，用于注册时判断是否重名 -- 逻辑(Bool)
        /// </summary>
        /// <param name="UName"></param>
        /// <returns></returns>
        public static bool UsersSelectUName(string UName) 
        {
            return Index3DAL.SelectUsersUName(UName: UName) > 0;
        }

        /// <summary>
        /// 添加Users表(用户表)数据，用于数据添加 -- 逻辑(Bool)
        /// </summary>
        /// <param name="UName"></param>
        /// <param name="UPawd"></param>
        /// <returns></returns>
        public static bool UsersInsert(string UName, string UPawd) 
        {
            return Index3DAL.InsertUsersALL(UName: UName, UPawd: UPawd) > 0;
        }



    }
}
