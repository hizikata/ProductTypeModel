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
    public class ProductMatchSpecifyService
    {
        SqlHelper sqlHelper = new SqlHelper(Models.EnumeData.DBName.LocalNBOSA);
        public DataSet SearchTypeInfo(string tableName, string productType)
        {
            string sqlStr = @"SELECT * FROM {0} WHERE ProductType=@ProductType";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras = { new SqlParameter("@ProductType", SqlDbType.NVarChar, 15) };
            paras[0].Value = productType;
            return sqlHelper.GetTableFromDb(sqlStr, paras);
        }
        public int UpdateDB(ProductMatchSpecify productMatchSpecify, string tableName)
        {
            // , , , , , , 
            //    
            string sqlStr = @"UPDATE {0} SET ProductType =@ProductType,LD_Spec =@LD_Spec,
APD_Spec =@APD_Spec,PD_Spec =@PD_Spec,Isolator_Spec =@Isolator_Spec,ZeroFilter_Spec =@ZeroFilter_Spec,
FortyFiveFilter_Spec =@FortyFiveFilter_Spec WHERE Id_Key=@Id_Key ";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras =
            {
                new SqlParameter("@ProductType",SqlDbType.NVarChar,100),
                new SqlParameter("@LD_Spec",SqlDbType.NVarChar,100),
                new SqlParameter("@APD_Spec",SqlDbType.NVarChar,100),
                new SqlParameter("@PD_Spec",SqlDbType.NVarChar,100),
                new SqlParameter("@Isolator_Spec",SqlDbType.NVarChar,100),
                new SqlParameter("@ZeroFilter_Spec",SqlDbType.NVarChar,100),
                new SqlParameter("@FortyFiveFilter_Spec",SqlDbType.NVarChar,100),
                new SqlParameter("@Id_Key",SqlDbType.Int,15)
            };
            paras[0].Value = productMatchSpecify.ProductType;
            paras[1].Value = string.IsNullOrEmpty(productMatchSpecify.LD_Spec) ?DBNull.Value:(object)productMatchSpecify.LD_Spec;
            paras[2].Value = string.IsNullOrEmpty(productMatchSpecify.APD_Spec) ? DBNull.Value : (object)productMatchSpecify.APD_Spec;
            paras[3].Value = string.IsNullOrEmpty(productMatchSpecify.PD_Spec) ? DBNull.Value : (object)productMatchSpecify.PD_Spec;
            paras[4].Value = string.IsNullOrEmpty(productMatchSpecify.Isolator_Spec) ? DBNull.Value : (object)productMatchSpecify.Isolator_Spec;
            paras[5].Value = string.IsNullOrEmpty(productMatchSpecify.ZeroFilter_Spec) ? DBNull.Value : (object)productMatchSpecify.ZeroFilter_Spec;
            paras[6].Value = string.IsNullOrEmpty(productMatchSpecify.FortyFiveFilter_Spec) ? DBNull.Value : (object)productMatchSpecify.FortyFiveFilter_Spec;
            paras[7].Value = productMatchSpecify.Id_Key;
            return sqlHelper.ExecuteNonQuery(sqlStr, paras);
        }
        public void SqlBulkCopyInsert(string tableName, DataTable dt)
        {
            sqlHelper.SqlBulkCopyInsert(tableName, dt);
        }
        public bool IsTypeExist(string productType, string tableName)
        {
            string sqlStr = @"SELECT ProductType FROM {0} WHERE ProductType=@ProductType";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras = { new SqlParameter("@ProductType", SqlDbType.NVarChar, 15) };
            paras[0].Value = productType;
            return sqlHelper.IsExist(sqlStr, paras);
        }
    }
}
