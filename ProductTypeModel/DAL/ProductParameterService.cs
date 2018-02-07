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
    public class ProductParameterService
    {
        SqlHelper sqlHelper = new SqlHelper(EnumeData.DBName.LocalLightMasterMes);
        public int UpdateDB(ProductParameter productParameter,string tableName)
        {

            string sqlStr = @"UPDATE {0} SET ProductType=@ProductType,ProductStation=@ProductStation,
ParameterName=@ParameterName,ParameterMax=@ParameterMax,ParameterMin=@ParameterMin,ParameterMemo=@ParameterMemo,
TempSign=@TempSign WHERE Id_Key=@Id_Key";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras =
            {
                new SqlParameter("@ProductType",SqlDbType.NVarChar,15),
                new SqlParameter("@ProductStation",SqlDbType.NVarChar,15),
                new SqlParameter("@ParameterName",SqlDbType.NVarChar,15),
                new SqlParameter("@ParameterMax",SqlDbType.NVarChar,15),
                new SqlParameter("@ParameterMin",SqlDbType.NVarChar,15),
                new SqlParameter("@ParameterMemo",SqlDbType.NVarChar,15),
                new SqlParameter("@TempSign",SqlDbType.NVarChar,15),
                new SqlParameter("@Id_Key",SqlDbType.Int,15),
            };
            paras[0].Value = productParameter.ProductType;
            paras[1].Value = productParameter.ProductStation;
            paras[2].Value = productParameter.ParameterName;
            paras[3].Value = productParameter.ParameterMax;
            paras[4].Value = productParameter.ParameterMin;
            paras[5].Value = productParameter.ParameterMemo;
            paras[6].Value = productParameter.TempSign;
            paras[7].Value = productParameter.Id_Key;
            return sqlHelper.ExecuteNonQuery(sqlStr, paras);
        }
    }
}
