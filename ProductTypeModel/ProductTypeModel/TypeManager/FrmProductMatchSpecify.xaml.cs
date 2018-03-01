using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;
using System.Data;
using Models;

namespace UI
{
    /// <summary>
    /// FrmProductMatchSpecity.xaml 的交互逻辑
    /// </summary>
    public partial class FrmProductMatchSpecify : UserControl
    {
        public FrmProductMatchSpecify()
        {
            InitializeComponent();
        }
        #region Copy
        int Len = 0;
        LogicClass LogClass = new LogicClass();
        ProductTypeSer ProTypeSer = new ProductTypeSer();
        List<string> listTypes = new List<string>();
        ProductMatchSpecifyService ProMatchSpecSer = new ProductMatchSpecifyService();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string TableName = "Ma_ProductMatchSpecify";

        //初始化Combobox下拉框内容方法
        private void ProductTypeInitialize()
        {
            string path = Environment.CurrentDirectory + "\\Items.txt";
            
            ProTypeSer.WriteToText(path);
            listTypes = ProTypeSer.ReadFromText(path);
            cmbAllType.ItemsSource = listTypes;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ProductTypeInitialize();
        }
        //替换按钮方法
        private void btReplaceType_Click(object sender, RoutedEventArgs e)
        {
            if (tbReplaceType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("替换型号为空", "错误提示");
                return;
            }
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    row["ProductType"] = tbReplaceType.Text.Trim();
                }
            }
            else
            {
                MessageBox.Show("表格无数据", "错误提示");
                return;
            }
        }
        //DataTable 插入数据库方法
        private void btInsertToDB_Click(object sender, RoutedEventArgs e)
        {

            if (tbReplaceType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入替换型号", "错误提示");
                return;
            }
            if (!ProTypeSer.IsTypeExist(tbReplaceType.Text.Trim(), "Para_ProductType"))
            {
                MessageBox.Show("请先在型号设置中添加型号", "错误提示");
                return;
            }
            //确认表格中有数据
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("表格无数据", "错误提示");
                return;
            }

            if (ProMatchSpecSer.IsTypeExist(tbReplaceType.Text.Trim(), TableName))
            {
                MessageBox.Show("该型号已存在，无需重复添加", "错误提示");
                return;
            }
            DataRow row0 = dt.Rows[0];
            string productType = row0["ProductType"].ToString().Trim();
            if (productType != tbReplaceType.Text.Trim())
            {
                MessageBox.Show("表格中型号未替换，请检查后重试", "错误提示");
                return;
            }
            MessageBoxResult boxResult = MessageBox.Show("此操作将更改数据库，是否确认", "写入提示", MessageBoxButton.OKCancel, MessageBoxImage.Asterisk);
            if (boxResult == MessageBoxResult.OK)
            {
                //对比datatable和datagrid数据是否同步
                if (dt.Rows.Count == dgInfo.Items.Count)
                {
                    string tableName = TableName;
                    if (tableName != null)
                    {
                        foreach (DataRow row in dt.Rows)
                            row["Id_Key"] = DBNull.Value;
                        ProMatchSpecSer.SqlBulkCopyInsert(tableName, dt);
                        MessageBox.Show("写入数据库成功", "成功提示", MessageBoxButton.OK);
                        //插入成功后更新数据库型号列表
                        ProductTypeInitialize();
                    }

                }
                else
                {
                    MessageBox.Show("表格数据未同步到DataTable,写入失败！", "写入失败", MessageBoxButton.OK);
                }
            }
        }
        //combobox选中项目后自动查询
        private void cmbAllType_DropDownClosed(object sender, EventArgs e)
        {
            ds = ProMatchSpecSer.SearchTypeInfo(TableName, cmbAllType.Text.Trim());
            dt = ds.Tables[0];
            dgInfo.ItemsSource = dt.DefaultView;
            tbAllRows.Text = "总行数:" + dgInfo.Items.Count + "行";
        }

        //初始化菜单栏方法
        private void dgInfo_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            tbSelectedRows.Text = string.Empty;
            tbAllRows.Text = string.Empty;
            tbCurrentRow.Text = "当前行号:第" + (dgInfo.SelectedIndex + 1) + "行";
            tbSelectedRows.Text = "选中行数:" + dgInfo.SelectedItems.Count + "行";
            tbAllRows.Text = "总行数:" + dgInfo.Items.Count + "行";
        }
        //DataGrid 右键菜单方法
        private void menuItemExtract_Click(object sender, RoutedEventArgs e)
        {
            if (dgInfo.SelectedItems.Count == 1)
            {
                
                try
                {
                    DataRow row = dt.Rows[dgInfo.SelectedIndex];
                    // , , , , , , 
                    //
                    if (!string.IsNullOrEmpty(row["ProductType"].ToString()))
                    {
                        tbProductType.Text = row["ProductType"].ToString();
                    }
                    if (!string.IsNullOrEmpty(row["LD_Spec"].ToString()))
                    {
                        tbLDSpec.Text = row["LD_Spec"].ToString();
                    }
                    if (!string.IsNullOrEmpty(row["APD_Spec"].ToString()))
                    {
                        tbAPDSpec.Text = row["APD_Spec"].ToString();
                    }
                    if (!string.IsNullOrEmpty(row["PD_Spec"].ToString()))
                    {
                        tbPDSpec.Text = row["PD_Spec"].ToString();
                    }
                   
                    if (!string.IsNullOrEmpty(row["Isolator_Spec"].ToString()))
                    {
                        tbIsolatorSpec.Text = row["Isolator_Spec"].ToString();
                    }
                    if (!string.IsNullOrEmpty(row["ZeroFilter_Spec"].ToString()))
                    {
                        tbZeroFilterSpec.Text = row["ZeroFilter_Spec"].ToString();
                    }
                    if (!string.IsNullOrEmpty(row["FortyFiveFilter_Spec"].ToString()))
                    {
                        tbFortyFiveFilterSpec.Text = row["FortyFiveFilter_Spec"].ToString();
                    }
                    if (!string.IsNullOrEmpty(row["Id_Key"].ToString()))
                    {
                        tbId_Key.Text = row["Id_Key"].ToString();
                    }

                }
                catch (Exception)
                {

                    throw;
                }


            }
            else
            {
                MessageBox.Show("请选择一行数据", "错误提示");
            }
        }

        private void btUpdateDB_Click(object sender, RoutedEventArgs e)
        {
            //不适用DataTable更新数据库，与ProductType表格不同，DataTable行数不止一行
            if (string.IsNullOrEmpty(tbProductType.Text.Trim()) && string.IsNullOrEmpty(tbId_Key.Text.Trim()))
            {
                MessageBox.Show("产品型号为空，请重试！", "错误提示");
            }
            ProductMatchSpecify productMatchSpecify = new ProductMatchSpecify();
            productMatchSpecify.ProductType = tbProductType.Text.Trim();
            productMatchSpecify.LD_Spec = tbLDSpec.Text.Trim();
            productMatchSpecify.APD_Spec = tbAPDSpec.Text.Trim();
            productMatchSpecify.PD_Spec = tbPDSpec.Text.Trim();
            productMatchSpecify.Isolator_Spec = tbIsolatorSpec.Text.Trim();
            productMatchSpecify.ZeroFilter_Spec = tbZeroFilterSpec.Text.Trim();
            productMatchSpecify.FortyFiveFilter_Spec = tbFortyFiveFilterSpec.Text.Trim();
            productMatchSpecify.Id_Key = Convert.ToInt32(tbId_Key.Text.Trim());
            //使用Id_Key的唯一性约束更新内容
            int count =ProMatchSpecSer.UpdateDB(productMatchSpecify, TableName);
            if (count == 1)
            {
                MessageBox.Show("更新数据库成功", "成功提示");
                cmbAllType_DropDownClosed(null, null);
            }
            else
            {
                MessageBox.Show("写入错误" + count, "错误提示");
            }
        }
        #endregion

        private void cmbAllType_GotFocus(object sender, RoutedEventArgs e)
        {
            this.cmbAllType.IsDropDownOpen = true;
        }

        private void cmbAllType_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbAllType.IsDropDownOpen != true)
                cmbAllType.IsDropDownOpen = true;
            int newlen = cmbAllType.Text.Trim().Length;
            if (Len != newlen)
            {
                List<string> listFiltrate = new List<string>();
                listFiltrate = LogClass.GetListFromInfo(cmbAllType.Text.Trim(), listTypes);
                cmbAllType.ItemsSource = listFiltrate;
            }
        }
    }
}
