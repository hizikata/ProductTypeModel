using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CommonParaSetService
    {
        SqlHelper sqlHelper = new SqlHelper(Models.EnumeData.DBName.LocalLightMasterMes);
        public int UpdateDB(CommonParaSet commonParaSet,string tableName)
        {
            //ApplicationName, ProductType, ProductStation, ParameterName, ParameterValue, CurrentTemperature, Memo, 
            //    OpPerson, OpDate, Id_Key
            string sqlStr = @"UPDATE {0} SET ApplicationName=@ApplicationName,ProductType=@ProductType,
ProductStation=@ProductStation,ParameterName=@ParameterName,ParameterValue=@ParameterValue,
CurrentTemperature=@CurrentTemperature,Memo=@Memo,OpPerson=@OpPerson,OpDate=@OpDate 
WHERE Id_Key=@Id_Key";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras =
            {
                new SqlParameter("@ApplicationName",SqlDbType.NVarChar,15),
                new SqlParameter("@ProductType",SqlDbType.NVarChar,15),
                new SqlParameter("@ProductStation",SqlDbType.NVarChar,15),
                new SqlParameter("@ParameterName",SqlDbType.NVarChar,15),
                new SqlParameter("@ParameterValue",SqlDbType.NVarChar,15),
                new SqlParameter("@CurrentTemperature",SqlDbType.NVarChar,15),
                new SqlParameter("@Memo",SqlDbType.NVarChar,15),
                new SqlParameter("@OpPerson",SqlDbType.NVarChar,15),
                //数据格式为日期，是否需要转换？
                new SqlParameter("@OpDate",SqlDbType.SmallDateTime,15),
                new SqlParameter("@Id_Key",SqlDbType.Int,15)
            };
            paras[0].Value = commonParaSet.ApplicationName;
            paras[1].Value = commonParaSet.ProductType;
            paras[2].Value = commonParaSet.ProductStation;
            paras[3].Value = commonParaSet.ParameterName;
            paras[4].Value = commonParaSet.ParameterValue;
            paras[5].Value = commonParaSet.CurrentTemperature;
            paras[6].Value = commonParaSet.Memo;
            paras[7].Value = commonParaSet.OpPerson;
            paras[8].Value = commonParaSet.OpDate;
            paras[9].Value = commonParaSet.Id_Key;
            return sqlHelper.ExecuteNonQuery(sqlStr, paras);
        }
    }
}
