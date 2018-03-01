using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Controls;

namespace BLL
{
    public class CommonMethods
    {
        /// <summary>
        /// 将选中的Items生成一个新DataTable
        /// </summary>
        /// <param name="dgv"></param>
        public void SelectedItmesToDataTable(DataGrid dgv)
        {
            DataTable dt = new DataTable();
            dt.TableName = dgv.Name;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[i].Header.ToString());
                dt.Columns.Add(dc);
            }
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                DataRow dr = dt.NewRow();
                for(int i = 0; i < dgv.SelectedItems.Count; i++)
                {
                    
                }
            }
        }
    }
}
