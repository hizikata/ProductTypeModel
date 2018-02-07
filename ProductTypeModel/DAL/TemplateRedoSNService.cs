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
    public class TemplateRedoSNService
    {
        SqlHelper sqlHelper = new SqlHelper(EnumeData.DBName.LocalLightMasterMes);
        public int UpdateDB(TemplateRedoSN templateRedoSN, string tableName)
        {
            string sqlStr = @"UPDATE {0} SET ProductSign=@ProductSign,PrintProductType=@PrintProductType,
ProductType=@ProductType,SnType=@SnType,TrayLabelTemplate=@TrayLabelTemplate,BoxingLabelTemplate=@BoxingLabelTemplate,
OutBoxLabelTemplate=@OutBoxLabelTemplate,HwUpdataPN=@HwUpdataPN,Memo=@Memo
WHERE Id_Key=@Id_Key ";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras =
            {
                new SqlParameter("@ProductSign",SqlDbType.NVarChar,15),
                new SqlParameter("@PrintProductType",SqlDbType.NVarChar,15),
                new SqlParameter("@ProductType",SqlDbType.NVarChar,15),
                new SqlParameter("@SnType",SqlDbType.NVarChar,15),
                new SqlParameter("@TrayLabelTemplate",SqlDbType.NVarChar,15),
                new SqlParameter("@BoxingLabelTemplate",SqlDbType.NVarChar,15),
                new SqlParameter("@OutBoxLabelTemplate",SqlDbType.NVarChar,15),
                new SqlParameter("@HwUpdataPN",SqlDbType.NVarChar,15),
                new SqlParameter("@Memo",SqlDbType.NVarChar,15),
                new SqlParameter("@Id_Key",SqlDbType.NVarChar,15)
                
            };
            paras[0].Value = templateRedoSN.ProductSign;
            paras[1].Value = templateRedoSN.PrintProductType;
            paras[2].Value = templateRedoSN.ProductType;
            paras[3].Value = templateRedoSN.SnType;
            //如果文本框为空，则数据库内字段为NULL
            paras[4].Value = string.IsNullOrEmpty(templateRedoSN.TrayLabelTemplate)?DBNull.Value:(object)templateRedoSN.TrayLabelTemplate;
            paras[5].Value = string.IsNullOrEmpty(templateRedoSN.BoxingLabelTemplate) ? DBNull.Value : (object)templateRedoSN.BoxingLabelTemplate; 
            paras[6].Value = string.IsNullOrEmpty(templateRedoSN.OutBoxLabelTemplate) ? DBNull.Value : (object)templateRedoSN.OutBoxLabelTemplate;
            paras[7].Value = string.IsNullOrEmpty(templateRedoSN.HwUpdataPN) ? DBNull.Value : (object)templateRedoSN.HwUpdataPN;
            paras[8].Value = string.IsNullOrEmpty(templateRedoSN.Memo) ? DBNull.Value : (object)templateRedoSN.Memo;
            paras[9].Value = templateRedoSN.Id_Key;
            return sqlHelper.ExecuteNonQuery(sqlStr, paras);
        }

    }
}
