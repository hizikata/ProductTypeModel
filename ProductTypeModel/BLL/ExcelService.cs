using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DAL;
using System.Data;

namespace BLL
{
    public class ExcelService
    {
        DAL.ExcelService excelSer = new DAL.ExcelService();
        public void ExportToExcel(string filePath,DataGrid dataGrid)
        {
            excelSer.ExportToExcel(filePath, dataGrid);
        }
        public DataTable ListViewToDataTable(ListView listView)
        {
            return excelSer.ListViewToDataTable(listView);
        }
        public void ExportToExcel(string fileName,DataTable dt)
        {
            excelSer.ExportToExcel(fileName, dt);
        }
    }
}
