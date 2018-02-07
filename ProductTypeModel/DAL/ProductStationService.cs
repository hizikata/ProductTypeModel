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
    public class ProductStationService
    {
        SqlHelper sqlHelper = new SqlHelper(Models.EnumeData.DBName.LocalLightMasterMes);
        public int UpdateDB(ProductStation productStation,string tableName)
        {
            string sqlStr = @"UPDATE {0} SET ProductType=@ProductType,StationID=@StationID,
StationName=@StationName,StationVisible=@StationVisible WHERE Id_Key=@Id_Key";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras =
            {
                new SqlParameter("@ProductType",SqlDbType.NVarChar,15),
                new SqlParameter("@StationID",SqlDbType.NVarChar,15),
                new SqlParameter("@StationName",SqlDbType.NVarChar,15),
                new SqlParameter("@StationVisible",SqlDbType.NVarChar,15),
                new SqlParameter ("@Id_Key",SqlDbType.Int,15)
            };
            paras[0].Value = productStation.ProductType;
            paras[1].Value = productStation.StationID;
            paras[2].Value = productStation.StationName;
            paras[3].Value = productStation.StationVisible;
            paras[4].Value = productStation.Id_Key;
            return sqlHelper.ExecuteNonQuery(sqlStr, paras);
        }
    }
}
