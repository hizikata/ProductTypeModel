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
        SqlHelper sqlHelper = new SqlHelper(EnumeData.DBName.LocalLightMasterMes);
        public bool IsUserExist(string userId, string password)
        {
            //方法一
            //使用SELECT count(1)当结果不存在还是会范围count=0的一行数据，故行数还是为1，返回True
            string sqlStr = @"SELECT Name FROM Users WHERE UserId=@UserId AND Password=@Password";
            SqlParameter[] parameters =
                {
                new SqlParameter("@UserId",System.Data.SqlDbType.VarChar,15),
                new SqlParameter("@Password",System.Data.SqlDbType.VarChar,15)
                };
            parameters[0].Value =userId;
            parameters[1].Value = password;
            return sqlHelper.IsExist(sqlStr, parameters);
            //方法二 使用string.Format()格式化查询语句
            //缺点是无法指定参数类型
        }
        /// <summary>
        /// 根据登录ID获取用户信息模型
        /// </summary>
        /// <param name="LoginId">登录ID</param>
        /// <returns></returns>
        public User GetModle(string UserId)
        {
            DataSet ds = new DataSet();
            string sqlStr = @"SELECT TOP 1 Id_Key,UserId,Password,Name,Position,Privilege FROM Users WHERE UserId=@UserId";
            SqlParameter[] parameters =
                {
                    new SqlParameter("@UserId",SqlDbType.NVarChar,15)
                };
            parameters[0].Value = UserId;
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
                if (row["UserId"] != null)
                {
                    user.UserId =Convert.ToInt32(row["UserId"].ToString());
                }
                if (row["Password"] != null)
                {
                    user.Password = row["Password"].ToString();
                }
                if (row["Name"] != null)
                {
                    user.Name = row["Name"].ToString();
                }
                if (row["Position"] != null)
                {
                    user.Position = row["Position"].ToString();
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
