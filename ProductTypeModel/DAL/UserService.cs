using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserService
    {
        SqlHelper sqlHelper = new SqlHelper();
        public bool IsUserExist(string LoginId, string LoginPwd)
        {
            //方法一
            //使用SELECT count(1)会返回true ?
            string sqlStr = @"SELECT AdminName FROM Login WHERE LoginId=@LoginId AND LoginPwd=@LoginPwd";
            SqlParameter[] parameters =
                {
                new SqlParameter("@LoginId",System.Data.SqlDbType.VarChar,15),
                new SqlParameter("@LoginPwd",System.Data.SqlDbType.VarChar,15)
                };
            parameters[0].Value = LoginId;
            parameters[1].Value = LoginPwd;
            return sqlHelper.IsExist(sqlStr, parameters);
            //方法二 使用string.Format()格式化查询语句
            //缺点是无法指定参数类型
        }
        /// <summary>
        /// 根据登录ID获取用户信息模型
        /// </summary>
        /// <param name="LoginId">登录ID</param>
        /// <returns></returns>
        public User GetModle(string LoginId)
        {
            DataSet ds = new DataSet();
            string sqlStr = @"SELECT TOP 1 Id_Key,LoginId,LoginPwd,AdminName,WorkStation,Privilege FROM Login WHERE LoginId=@LoginId";
            SqlParameter[] parameters =
                {
                    new SqlParameter("@LoginId",SqlDbType.NVarChar,15)
                };
            parameters[0].Value = LoginId;
            ds = sqlHelper.GetTableFromDb(sqlStr, parameters);
            if(ds.Tables[0].Rows.Count==1)//判定表格行数为1
            {
                return this.TableToModel(ds.Tables[0].Rows[0]);
            }
            else 
                return null;
            
        }
        public User TableToModel(DataRow row)
        {
            User user = new User();
            if (row != null)
            {
                if (row["Id_Key"] != null)
                {
                    user.Id_Key = Convert.ToInt32(row["Id_Key"]);
                }
                if (row["LoginId"] != null)
                {
                    user.LoginId = row["LoginId"].ToString();
                }
                if (row["LoginPwd"] != null)
                {
                    user.LoginPwd = row["LoginPwd"].ToString();
                }
                if (row["AdminName"] != null)
                {
                    user.AdminName = row["AdminName"].ToString();
                }
                if (row["WorkStation"] != null)
                {
                    user.WorkStation = row["WorkStation"].ToString();
                }
                if (row["Privilege"] != null)
                {
                    user.Privilege = row["Privilege"].ToString();
                }
                return user;

            }
            else
                return null;    

        }

    }
}
