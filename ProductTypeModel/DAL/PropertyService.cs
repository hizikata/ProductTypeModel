using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class PropertyService
    {
        SqlHelper sqlHelper = new SqlHelper();
        public DataSet GetPropertyInfo(string PropertyNo,string DepartmentName)
        {
            StringBuilder sqlStr = new StringBuilder();
            DataSet ds = new DataSet();
            if (PropertyNo != string.Empty && DepartmentName != string.Empty)
            {
                sqlStr.Append("SELECT PropertyNo,PropertyName,CONVERT(varchar(12),PropertyDate,111),PropertyType,DepartmentName,Staff FROM PropertyInfo ");
                sqlStr.Append("WHERE PropertyNo=@PropertyNo AND DepartmentName=@DepartmentName ");
                SqlParameter[] paras =
                {
                new SqlParameter("@PropertyNo",SqlDbType.NVarChar,15),
                new SqlParameter("@DepartmentName",SqlDbType.NVarChar,15)
                };
                paras[0].Value = PropertyNo;
                paras[1].Value = DepartmentName;
                ds = sqlHelper.GetTableFromDb(sqlStr.ToString(),paras);
                return ds;
            }

            else if (PropertyNo != string.Empty && DepartmentName == string.Empty)
            {
                //CONVERT(varchar(12),PropertyDate,111) AS PropertyDate 格式化日期字符串，111为格式化类型(代表 yy/mm/dd)
                sqlStr.Append("SELECT PropertyNo,PropertyName,CONVERT(varchar(12),PropertyDate,111) AS PropertyDate,PropertyType,DepartmentName,Staff FROM PropertyInfo ");
                sqlStr.Append("WHERE PropertyNo=@PropertyNo");
                SqlParameter[] paras =
                {
                new SqlParameter("@PropertyNo",SqlDbType.NVarChar,15),
                };
                paras[0].Value = PropertyNo;
                ds = sqlHelper.GetTableFromDb(sqlStr.ToString(),paras);
                return ds;
            }
            else if (PropertyNo == string.Empty && DepartmentName != string.Empty)
            {
                sqlStr.Append("SELECT PropertyNo,PropertyName,CONVERT(varchar(12),PropertyDate,111) AS PropertyDate,PropertyType,DepartmentName,Staff FROM PropertyInfo ");
                sqlStr.Append("WHERE DepartmentName=@DepartmentName ");
                SqlParameter[] paras =
                {
                new SqlParameter("@DepartmentName",SqlDbType.NVarChar,15)
                };
                paras[0].Value = DepartmentName;
                ds = sqlHelper.GetTableFromDb(sqlStr.ToString(),paras);
                return ds;
            }
            else if((PropertyNo == string.Empty && DepartmentName == string.Empty))
            {
                sqlStr.Append("SELECT PropertyNo,PropertyName,CONVERT(varchar(12),PropertyDate,111) AS PropertyDate,PropertyType,DepartmentName,Staff FROM PropertyInfo ");
                ds = sqlHelper.GetTableFromDb(sqlStr.ToString());
                return ds;
            }
                return ds = null;
        }
        /// <summary>
        /// 插入数据到数据库
        /// </summary>
        /// <param name="propertyModel">插入的数据模型</param>
        /// <returns></returns>
        public int InsertIntoDB(PropertyInfo propertyModel)
        {
            int count = 0;
            string sqlStr = @"INSERT INTO PropertyInfo(PropertyNo,PropertyName,PropertyDate,PropertyType,DepartmentName,Staff)
            VALUES(@PropertyNo,@PropertyName,@PropertyDate,@PropertyType,@DepartmentName,@Staff)";
            SqlParameter[] paras = 
                {
                    new SqlParameter("@PropertyNo",SqlDbType.NVarChar,15),
                    new SqlParameter("@PropertyName",SqlDbType.NVarChar,30),
                    new SqlParameter("@PropertyDate",SqlDbType.DateTime),
                    new SqlParameter("@PropertyType",SqlDbType.NVarChar,15),
                    new SqlParameter("@DepartmentName",SqlDbType.NVarChar,15),
                    new SqlParameter("@Staff",SqlDbType.NVarChar,15)
                };
            //SqlCommand 参数赋值
            paras[0].Value = propertyModel.PropertyNo;
            paras[1].Value = propertyModel.PropertyName;
            paras[2].Value = propertyModel.PropertyDate;
            paras[3].Value = propertyModel.PropertyType;
            paras[4].Value = propertyModel.DepartmentName;
            paras[5].Value = propertyModel.Staff;
            count = sqlHelper.ExecuteNonQuery(sqlStr, paras);
            return count;
        }
        /// <summary>
        /// 更新数据库数据
        /// </summary>
        /// <param name="propertyInfo">更新的数据模型</param>
        public int UpdataDB(PropertyInfo propertyModel)
        {
            int count = 0;
            string sqlStr = @"UPDATE PropertyInfo SET PropertyName=@PropertyName,
PropertyDate=@PropertyDate,PropertyType=@PropertyType,DepartmentName=@DepartmentName,
Staff=@Staff WHERE PropertyNo=@PropertyNo";
            SqlParameter[] paras =
                {
                    new SqlParameter("@PropertyNo",SqlDbType.NVarChar,15),
                    new SqlParameter("@PropertyName",SqlDbType.NVarChar,30),
                    new SqlParameter("@PropertyDate",SqlDbType.DateTime),
                    new SqlParameter("@PropertyType",SqlDbType.NVarChar,15),
                    new SqlParameter("@DepartmentName",SqlDbType.NVarChar,15),
                    new SqlParameter("@Staff",SqlDbType.NVarChar,15)
                };
            //SqlCommand 参数赋值
            paras[0].Value = propertyModel.PropertyNo;
            paras[1].Value = propertyModel.PropertyName;
            paras[2].Value = propertyModel.PropertyDate;
            paras[3].Value = propertyModel.PropertyType;
            paras[4].Value = propertyModel.DepartmentName;
            paras[5].Value = propertyModel.Staff;
            count = sqlHelper.ExecuteNonQuery(sqlStr, paras);
            return count;
        }
        public bool IsExist(string PropertyNo)
        {
            string sqlStr = @"SELECT COUNT(PropertyNo) FROM PropertyInfo WHERE PropertyNo=@PropertyNo";
            SqlParameter[] paras = { new SqlParameter("@PropertyNo", SqlDbType.NVarChar, 15) };
            paras[0].Value = PropertyNo;
            return sqlHelper.IsPropertyNumExist(sqlStr, paras);
        }
    }
}
