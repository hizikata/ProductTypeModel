using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Models;

namespace BLL
{
    public class PropertyInfoService
    {
        DAL.PropertyService propertySer = new PropertyService();
        public DataSet GetDataTable(string PropertyNo,string DepartmentName)
        {
            return propertySer.GetPropertyInfo(PropertyNo, DepartmentName);
        }
        public DataSet GetDataTable(string PropertyNo)
        {
            return propertySer.GetPropertyInfo(PropertyNo, string.Empty);
        }
        public DataSet GetTable(string DepartmentName)
        {
            return propertySer.GetPropertyInfo(string.Empty, DepartmentName);
        }
        public int InsertIntoDB(PropertyInfo propertyModel)
        {
            return propertySer.InsertIntoDB(propertyModel);
        }
        public int UpdateDB(PropertyInfo propertyModel)
        {
            return propertySer.UpdataDB(propertyModel);
        }
        public bool IsExist(string PropertyNo)
        {
            return propertySer.IsExist(PropertyNo);
        }
    }
    
}
