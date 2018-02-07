using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;
using System.Data;
using Models;

namespace BLL
{
    public class ProductTypeSer
    {
        DAL.ProductTypeSer proTypeSer = new DAL.ProductTypeSer();
        //自定义构造函数初始化，选择相应数据库
        //SqlHelper sqlHelper = new SqlHelper(EnumeData.DBName.LocalLightMasterMes);
        /// <summary>
        /// 将型号信息写入本地Text文件；
        /// </summary>
        public void WriteToText(string filePath)
        {
            try
            {
                List<string> listStr = proTypeSer.GetTypeList();
                //采用覆盖的方式写入text文件
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    foreach (string item in listStr)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// 从本地text文件获取产品型号列表
        /// </summary>
        /// <param name="filePath"></param>
        public List<string> ReadFromText(string filePath)
        {
            List<string> listStr = new List<string>();
            if (File.Exists(filePath))
            {
                string typeName;
                using (StreamReader sr = File.OpenText(filePath))
                {
                    while ((typeName = sr.ReadLine()) != null)
                    {
                        if (typeName.Trim() != string.Empty)
                        {
                            typeName = typeName.Trim();
                            listStr.Add(typeName);
                        }
                    }
                }
                return listStr;
            }
            else
                return null;

        }
        public DataSet SearchTypeInfo(string tableName,string productType)
        {
            return proTypeSer.SearchTypeInfo(tableName,productType);
        }
        public void UpdataFromDataTable(string productType, string tableName, DataSet ds)
        {
            proTypeSer.UpdataFromDataTable(productType, tableName, ds);
        }
        public void SqlBulkCopyInsert(string tableName,DataTable dt)
        {
            proTypeSer.SqlBulkCopyInsert(tableName, dt);
        }
        public bool IsTypeExist(string typeName, string tableName)
        {
            return proTypeSer.IsTypeExist(typeName, tableName);
        }
        public int Update(ProductType currentType,string tableName)
        {
            return proTypeSer.Update(currentType,tableName);
        }
    }
}
