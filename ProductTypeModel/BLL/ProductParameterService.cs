using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class ProductParameterService
    {
        DAL.ProductParameterService ProParameterSer = new DAL.ProductParameterService();
        public int UpdateDB(ProductParameter productParameter,string tableName)
        {
            return ProParameterSer.UpdateDB(productParameter, tableName);
        }
    }
}
