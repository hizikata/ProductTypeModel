using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace BLL
{
    public class ProductMatchSpecifyService
    {
        DAL.ProductMatchSpecifyService ProMatchSpecSer = new DAL.ProductMatchSpecifyService();
        public DataSet SearchTypeInfo(string tableName, string productType)
        {
            return ProMatchSpecSer.SearchTypeInfo(tableName, productType);
        }
        public int UpdateDB(ProductMatchSpecify productMatchSpecify,string tableName)
        {
            return ProMatchSpecSer.UpdateDB(productMatchSpecify, tableName);
        }
        public void SqlBulkCopyInsert(string tableName, DataTable dt)
        {
            ProMatchSpecSer.SqlBulkCopyInsert(tableName, dt);
        }
        public bool IsTypeExist(string productType, string tableName)
        {
            return ProMatchSpecSer.IsTypeExist(productType, tableName);
        }
    }
}
