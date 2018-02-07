using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class ProductTypeSer
    {
        //自定义构造函数初始化，选择相应数据库
        SqlHelper sqlHelper = new SqlHelper(EnumeData.DBName.LocalLightMasterMes);
        /// <summary>
        /// 获取数据库所有型号名称
        /// </summary>
        public List<string> GetTypeList()
        {
            string sqlStr = @"SELECT ProductType FROM Para_ProductType";
            return sqlHelper.GetTypeList(sqlStr);
        }
        public DataSet SearchTypeInfo(string tableName, string productType)
        {
            string sqlStr = @"SELECT * FROM {0} WHERE ProductType=@ProductType";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras = {new SqlParameter("@ProductType", SqlDbType.NVarChar, 15)};
            paras[0].Value = productType;
            return sqlHelper.GetTableFromDb(sqlStr, paras);
        }
        public void UpdataFromDataTable(string productType,string tableName,DataSet ds)
        {
            string sqlStr = @"SELECT * FROM {0} WHERE ProductType=@ProductType";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras = { new SqlParameter("@ProductType", SqlDbType.NVarChar, 15) };
            paras[0].Value = productType;
            sqlHelper.UpdataFromDataTable(sqlStr, paras, ds, tableName);
        }

        public bool IsTypeExist(string typeName,string tableName)
        {
            string sqlStr = @"SELECT ProductType FROM {0} WHERE ProductType=@ProductType";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras = { new SqlParameter("@ProductType", SqlDbType.NVarChar, 15) };
            paras[0].Value = typeName;
            return sqlHelper.IsExist(sqlStr, paras);
        }
        public void SqlBulkCopyInsert(string tableName, DataTable dt)
        {
            sqlHelper.SqlBulkCopyInsert(tableName, dt);
        }
        public int Update(ProductType currentType,string tableName)
        {

            string sqlStr = @"UPDATE {0} SET ProductType=@ProductType ,TypeLength=@TypeLength,
TypeSign=@TypeSign,ApdSign=@ApdSign, TypeCatalog=@TypeCatalog, SnSign=@SnSign, 
TeCaculateMethod=@TeCaculateMethod,PackingType=@PackingType,IsSmsrSpotTest=@IsSmsrSpotTest, 
IsImd2SpotTest=IsImd2SpotTest,TypeVisible=@TypeVisible, MaterialId=@MaterialId, 
ProductTypeCommon=@ProductTypeCommon,CheckSnSubLength=@CheckSnSubLength, YearSign=@YearSign,
AlignType=@AlignType,IsUploadHwData=@IsUploadHwData, IsChangeToRedoData=@IsChangeToRedoData, 
HousingLaserSign=@HousingLaserSign, ThOneTestType=@ThOneTestType, TransmitRate=@TransmitRate
WHERE ProductType=@ProductType";
            sqlStr = string.Format(sqlStr, tableName);
            SqlParameter[] paras =
            {
                new SqlParameter("@ProductType",SqlDbType.NVarChar,15),
                new SqlParameter("@TypeLength",SqlDbType.Int,15),
                new SqlParameter("@TypeSign",SqlDbType.NVarChar,15),
                new SqlParameter("@ApdSign",SqlDbType.NVarChar,15),
                new SqlParameter("@TypeCatalog",SqlDbType.NVarChar,15),
                new SqlParameter("@SnSign",SqlDbType.NVarChar,15),
                new SqlParameter("@TeCaculateMethod",SqlDbType.NVarChar,15),
                new SqlParameter("@PackingType",SqlDbType.NVarChar,15),
                new SqlParameter("@IsSmsrSpotTest",SqlDbType.Int,15),
                new SqlParameter("@IsImd2SpotTest",SqlDbType.Int,15),
                new SqlParameter("@TypeVisible",SqlDbType.Int,15),
                new SqlParameter("@MaterialId",SqlDbType.NVarChar,15),
                new SqlParameter("@ProductTypeCommon",SqlDbType.NVarChar,15),
                new SqlParameter("@CheckSnSubLength",SqlDbType.Int,15),
                new SqlParameter("@YearSign",SqlDbType.NVarChar,15),
                new SqlParameter("@AlignType",SqlDbType.NVarChar,15),
                new SqlParameter("@IsUploadHwData",SqlDbType.Int,15),
                new SqlParameter("@IsChangeToRedoData",SqlDbType.Int,15),
                new SqlParameter("@HousingLaserSign",SqlDbType.NVarChar,15),
                new SqlParameter("@ThOneTestType",SqlDbType.NVarChar,15),
                new SqlParameter("@TransmitRate",SqlDbType.NVarChar,15)
                
            };
            paras[0].Value = currentType.ProductTypeName;
            paras[1].Value = currentType.TypeLength;
            paras[2].Value = currentType.TypeSign;
            paras[3].Value = currentType.ApdSign;
            paras[4].Value = currentType.TypeCatalog;
            paras[5].Value = currentType.SnSign;
            paras[6].Value = currentType.TeCaculateMethod;
            paras[7].Value = currentType.PackingType;
            paras[8].Value = currentType.IsSmsrSpotTest;
            paras[9].Value = currentType.IsImd2SpotTest;
            paras[10].Value = currentType.TypeVisible;
            paras[11].Value = currentType.MaterialId;
            paras[12].Value = currentType.ProductTypeCommon;
            paras[13].Value = currentType.CheckSnSubLength;
            paras[14].Value = currentType.YearSign;
            paras[15].Value = currentType.AlignType;
            paras[16].Value = currentType.IsUploadHwData;
            paras[17].Value = currentType.IsChangeToRedoData;
            paras[18].Value = currentType.HousingLaserSign;
            //if (string.IsNullOrEmpty(currentType.ThOneTestType))
            //    paras[19].Value = DBNull.Value;
            //else
            //{
            //    paras[19].Value = currentType.ThOneTestType;
            //}
            paras[19].Value = (string.IsNullOrEmpty(currentType.ThOneTestType) ? DBNull.Value : (object)currentType.ThOneTestType);
            paras[20].Value = currentType.TransmitRate;
            return sqlHelper.ExecuteNonQuery(sqlStr,paras);
        }
    }
}
