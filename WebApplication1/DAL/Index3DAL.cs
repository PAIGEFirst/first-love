using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class Index3DAL
    {
        /// <summary>
        /// 查询Users表(用户表)数据，用于查询用户表信息 -- 方法(List) 
        /// </summary>
        public static List<Users> SelectUsersALL() 
        {
            using (FXEntities fx = new FXEntities()) 
            {
                string sql = "SELECT * FROM Users";
                return fx.Database.SqlQuery<Users>(sql).ToList();
            }
        }

        /// <summary>
        /// 查询Users表(用户表)UName字段，用于注册时判断是否重名 -- 方法(Int)
        /// </summary>
        /// <param name="UName"></param>
        /// <returns></returns>
        public static int SelectUsersUName(string UName) 
        {
            using (FXEntities fx = new FXEntities()) 
            {
                string sql = string.Format("SELECT UName FROM Users WHERE UName='{0}'",UName);
                return fx.Database.SqlQuery<string>(sql).ToList().Count;
            }
        }

        /// <summary>
        /// 添加Users表(用户表)数据，用于数据添加 -- 方法(Int) 
        /// </summary>
        /// <param name="UName"></param>
        /// <param name="UPawd"></param>
        /// <returns></returns>
        public static int InsertUsersALL(string UName, string UPawd) 
        {
            using (FXEntities fx = new FXEntities()) 
            {
                string sql = string.Format("INSERT INTO Users(UName,UPawd) VALUES ('{0}','{1}')", UName, UPawd);
                return fx.Database.ExecuteSqlCommand(sql);
            }
        }

        /// <summary>
        /// 添加Users表(用户表)数据，用于下拉数据显示 -- 方法(List) 
        /// </summary>
        /// <returns></returns>
        public static List<IDandUName> SelectUsersIDandUName() 
        {
            using (FXEntities fx=new FXEntities()) 
            {
                string sql = string.Format("SELECT ID,UName FROM Users");
                return fx.Database.SqlQuery<IDandUName>(sql).ToList();
            }
        }

        /// <summary>
        /// 删除Users表(用户表)数据，用于删除用户信息功能 -- 方法(Int)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int DeleteUsersWhereID(int ID) 
        {
            using (FXEntities fx = new FXEntities()) 
            {
                string sql = string.Format("DELETE FROM Users WHERE ID='{0}'",ID);
                return fx.Database.ExecuteSqlCommand(sql);
            }
        }


    }
}
