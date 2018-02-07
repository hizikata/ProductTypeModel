using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Windows.Controls;
using DataGrid = System.Windows.Controls.DataGrid;

namespace DAL
{
    public class ExcelService
    {
        #region ExportToExcel
        /// <summary>
        /// 将DataTable中数据导出到Excel
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="dt"></param>
        public void ExportToExcel(string fileName, DataTable dt)
        {
            //获取表格的行数、列数
            int rowCount = dt.Rows.Count;
            int columnCount = dt.Columns.Count;
            //设置文件标题,在第一行显示
            string title = "讯息中心固定资产明细";

            //新建一个Excel实例
            Excel.Application xlsApp = new Excel.Application();
            xlsApp.Workbooks.Add(true);
            //填写选项卡标题
            xlsApp.ActiveSheet.Name = dt.TableName;
            //填写标题
            xlsApp.Cells[1][1] = title; ;
            //填写文件生成日期
            xlsApp.Cells[1][2] = "文件生成时间：" + DateTime.Now.ToString();
            //填写列标题
            for (int i = 1; i <= rowCount; i++)
            {


                for (int j = 1; j <= columnCount; j++)
                {
                    //第一行填写列标题
                    if (i == 1)
                    { xlsApp.Cells[j][(i + 2)] = dt.Columns[j - 1].ColumnName; }
                    //从第二行开始填写数据
                    else
                    { xlsApp.Cells[j][i + 2] = dt.Rows[i - 1][j - 1]; }
                }
            }
            //打开制作完毕的表格
            //xlsApp.Visible = true;//注释后，进程没有残留
            //存储excel文件
            xlsApp.ActiveWorkbook.SaveAs(fileName);
            xlsApp.Quit();
            xlsApp = null;
            GC.Collect();
        }
        public void ExportToExcel(string filePath, DataGridView dgv)
        {
            DataTable dt = this.DataGridViewToDataTable(dgv);
            this.ExportToExcel(filePath, dt);
        }
        public void ExportToExcel(string filePath, DataGrid dataGrid)
        {
            DataTable dt = this.DataGridToDataTable(dataGrid);
            this.ExportToExcel(filePath, dt);
        }
        /// <summary>
        /// 将WPF中ListView控件数据导出为Excel文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="listView"></param>
        public void ExportToExcel(string filePath, System.Windows.Controls.ListView listView)
        {

        }
        public DataTable ListViewToDataTable(System.Windows.Controls.ListView listView)
        {
            DataTable dt = new DataTable();
            GridView gridView = (GridView)listView.View;
            
            foreach(var item in listView.Items)
            {
                dt.Columns.Add(item.ToString());                
            }
            return dt;
            

        }
        #endregion


        public DataTable DataGridViewToDataTable(DataGridView dgv)
        {
            DataTable dt1 = new DataTable();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                //使用指定的列名称创建列
                DataColumn dc = new DataColumn(dgv.Columns[i].Name.ToString());
                dt1.Columns.Add(dc);
            }
            DataRow dr = dt1.NewRow();
            for (int i = 0; i < dgv.Rows.Count; i++)//AllowUserToAddRow设置为true是会默认多一个空白行
            {
                dr = dt1.NewRow();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dr[j] = dgv.Rows[i].Cells[j].Value.ToString();
                }
                dt1.Rows.Add(dr);
            }
            return dt1;
        }
        /// <summary>
        /// 将Datagrid控件内数据装换为DataTable
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <returns></returns>
        public DataTable DataGridToDataTable( DataGrid dataGrid)
        {
            DataTable dt = new DataTable();
            dt.TableName = dataGrid.Name;
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                if (dataGrid.Columns[i].Visibility == System.Windows.Visibility.Visible)//只导出可见列  
                {
                    dt.Columns.Add(dataGrid.Columns[i].Header.ToString());//构建表头  

                }
            }

            for (int i = 0; i < dataGrid.Items.Count; i++)
            {
                int columnsIndex = 0;
                DataRow row = dt.NewRow();
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    if (dataGrid.Columns[j].Visibility == System.Windows.Visibility.Visible)
                    {
                        if (dataGrid.Items[i] != null && (dataGrid.Columns[j].GetCellContent(dataGrid.Items[i]) as TextBlock) != null)//填充可见列数据  
                        {
                            row[columnsIndex] = (dataGrid.Columns[j].GetCellContent(dataGrid.Items[i]) as TextBlock).Text.ToString();
                        }
                        else
                        {
                            row[columnsIndex] = "";
                        }
                        columnsIndex++;
                    }
                }
                dt.Rows.Add(row);
            }
            return dt;
        }       

    }
    #region DridView 导出为Excel
    /// <summary>
    /// 导出Excel类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class ExportToExcel<T, U>
        where T : class
        where U : List<T>
    {
        public List<T> DataToPrint;
        // Excel 对象实例.
        private Excel.Application _excelApp = null;
        private Excel.Workbooks _books = null;
        private Excel._Workbook _book = null;
        private Excel.Sheets _sheets = null;
        private Excel._Worksheet _sheet = null;
        private Excel.Range _range = null;
        private Excel.Font _font = null;

        // 可选 参数
        private object _optionalValue = Missing.Value;
        /// <summary>
        /// 生成报表，和其他功能
        /// </summary>
        /// <returns></returns>
        public int GenerateReport()
        {
            int result = 1;
            try
            {
                if (DataToPrint != null)
                {
                    if (DataToPrint.Count != 0)
                    {
                        CreateExcelRef();
                        FillSheet();
                        OpenReport();
                    }
                }
            }
            catch (Exception)
            {
                result = 0;
                //("Excel导出失敗！\n", e.Message);
            }
            finally
            {
                ReleaseObject(_sheet);
                ReleaseObject(_sheets);
                ReleaseObject(_book);
                ReleaseObject(_books);
                ReleaseObject(_excelApp);
            }
            return result;
        }
        /// <summary>
        /// 展示 Excel 程序
        /// </summary>
        private void OpenReport()
        {
            _excelApp.Visible = true;
        }
        /// <summary>
        /// 填充 Excel sheet
        /// </summary>
        private void FillSheet()
        {
            object[] header = CreateHeader();
            WriteData(header);
        }
        /// <summary>
        /// 将数据写入 Excel sheet
        /// </summary>
        /// <param name="header"></param>
        private void WriteData(object[] header)
        {
            object[,] objData = new object[DataToPrint.Count, header.Length];

            for (int j = 0; j < DataToPrint.Count; j++)
            {
                var item = DataToPrint[j];
                for (int i = 0; i < header.Length; i++)
                {
                    var y = typeof(T).InvokeMember(header[i].ToString(),
                    BindingFlags.GetProperty, null, item, null);
                    objData[j, i] = (y == null) ? "" : y.ToString();
                }
            }
            AddExcelRows("A2", DataToPrint.Count, header.Length, objData);
            AutoFitColumns("A1", DataToPrint.Count + 1, header.Length);
        }
        /// <summary>
        /// 根据数据拟合 列
        /// </summary>
        /// <param name="startRange"></param>
        /// <param name="rowCount"></param>
        /// <param name="colCount"></param>
        private void AutoFitColumns(string startRange, int rowCount, int colCount)
        {
            _range = _sheet.get_Range(startRange, _optionalValue);
            _range = _range.get_Resize(rowCount, colCount);
            _range.Columns.AutoFit();
        }
        /// <summary>
        /// 根据属性名创建列标题
        /// </summary>
        /// <returns></returns>
        private object[] CreateHeader()
        {
            PropertyInfo[] headerInfo = typeof(T).GetProperties();

            // 为 标头 创建 Array
            // 开始从 A1 处添加
            List<object> objHeaders = new List<object>();
            for (int n = 0; n < headerInfo.Length; n++)
            {
                objHeaders.Add(headerInfo[n].Name);
            }

            var headerToAdd = objHeaders.ToArray();
            AddExcelRows("A1", 1, headerToAdd.Length, headerToAdd);
            SetHeaderStyle();

            return headerToAdd;
        }
        /// <summary>
        /// 列标题设置为加粗字体
        /// </summary>
        private void SetHeaderStyle()
        {
            _font = _range.Font;
            _font.Bold = true;
        }
        /// <summary>
        /// 添加行
        /// </summary>
        /// <param name="startRange"></param>
        /// <param name="rowCount"></param>
        /// <param name="colCount"></param>
        /// <param name="values"></param>
        private void AddExcelRows(string startRange, int rowCount,
        int colCount, object values)
        {
            _range = _sheet.get_Range(startRange, _optionalValue);
            _range = _range.get_Resize(rowCount, colCount);
            _range.set_Value(_optionalValue, values);
        }
        /// <summary>
        /// 创建 Excel 传递的参数实例
        /// </summary>
        private void CreateExcelRef()
        {
            _excelApp = new Excel.Application();
            _books = (Excel.Workbooks)_excelApp.Workbooks;
            _book = (Excel._Workbook)(_books.Add(_optionalValue));
            _sheets = (Excel.Sheets)_book.Worksheets;
            _sheet = (Excel._Worksheet)(_sheets.get_Item(1));
        }
        /// <summary>
        /// 释放未使用的对象
        /// </summary>
        /// <param name="obj"></param>
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
                //MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                GC.Collect();
            }
        }
    }
    #endregion
}
