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
    public class PackingExportParaService
    {
        SqlHelper sqlHelper = new SqlHelper(Models.EnumeData.DBName.LocalLightMasterMes);
        public int UpdateDB(PackingExportPara packingExportPara, string tableName)
        {
            string sqlStr = @"UPDATE {0} SET ProductType=@ProductType,StartRowIndex =@StartRowIndex,
EndColIndex =@EndColIndex,ExportSqlText =@ExportSqlText,SetRowType =@SetRowType,
IsNeedPrintPackingLabel =@IsNeedPrintPackingLabel,IsExportAboutHW =@IsExportAboutHW,
HwSnColNames =@HwSnColNames,HwVopColNames =@HwVopColNames,HwVbrColNames =@HwVbrColNames,
FillDataContent =@FillDataContent WHERE Id_Key=@Id_Key";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras =
            {
                new SqlParameter("@ProductType",SqlDbType.NVarChar,15),
                new SqlParameter("@StartRowIndex",SqlDbType.Int,15),
                new SqlParameter("@EndColIndex",SqlDbType.Int,15),
                new SqlParameter("@ExportSqlText",SqlDbType.Text),
                new SqlParameter("@SetRowType",SqlDbType.NVarChar,15),
                new SqlParameter("@IsNeedPrintPackingLabel",SqlDbType.Int,15),
                new SqlParameter("@IsExportAboutHW",SqlDbType.Int,15),
                new SqlParameter("@HwSnColNames",SqlDbType.NVarChar,15),
                new SqlParameter("@HwVopColNames",SqlDbType.NVarChar,15),
                new SqlParameter("@HwVbrColNames",SqlDbType.NVarChar,15),
                new SqlParameter("@FillDataContent",SqlDbType.NVarChar,15),
                new SqlParameter("@Id_Key",SqlDbType.Int,15)
            };
            paras[0].Value = packingExportPara.ProductType;
            paras[1].Value = packingExportPara.StartRowIndex;
            paras[2].Value = packingExportPara.EndColIndex;
            paras[3].Value = packingExportPara.ExportText;
            paras[4].Value = packingExportPara.SetRowType;
            paras[5].Value = packingExportPara.IsNeedPrintPackingLabel;
            paras[6].Value = packingExportPara.IsExportAboutHW;
            paras[7].Value = packingExportPara.HwSnColNames;
            paras[8].Value = packingExportPara.HwVopColNames;
            paras[9].Value = packingExportPara.HwVbrColNames;
            paras[10].Value = packingExportPara.FillDataContent;
            paras[11].Value = packingExportPara.Id_Key;
            return sqlHelper.ExecuteNonQuery(sqlStr, paras);

        }
    }
}
