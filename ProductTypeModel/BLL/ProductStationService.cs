using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ProductStationService
    {
        DAL.ProductStationService ProStationSer = new DAL.ProductStationService();
        public int UpdateDB(ProductStation productStation,string tableName)
        {
            return ProStationSer.UpdateDB(productStation, tableName);
        }
    }
}
