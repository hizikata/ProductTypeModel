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
using System.Data;
using Models;
using BLL;

namespace UI
{
    /**********************************
     始终操作的是内存中的表DataTable而不是UI上的表格(DataGrid)
     *********************************/
    /// <summary>
    /// FrmProductType.xaml 的交互逻辑
    /// </summary>
    public partial class FrmProductType : UserControl
    {
        #region 字段
        //储存combobox文本长度，用于表示文本长度是否发生变化
        int Len = 0;
        BLL.ProductTypeSer productTypeSer = new BLL.ProductTypeSer();
        BLL.TableNames tableNames = new BLL.TableNames();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        LogicClass LogClass = new LogicClass();
        //下拉框型号列表
        List<string> listTypes = new List<string>();
        #endregion
        #region 初始化
        public FrmProductType()
        {
            InitializeComponent();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ProductTypeInitialize();
        }
        /// <summary>
        /// 更新、获取型号总览
        /// </summary>
        private void ProductTypeInitialize()
        {
            string path = Environment.CurrentDirectory + "\\Items.txt";

            productTypeSer.WriteToText(path);
            listTypes = productTypeSer.ReadFromText(path);
            cmbAllType.ItemsSource = listTypes;
        }
        #endregion
        #region Click 事件
        private void btInsertToDB_Click(object sender, RoutedEventArgs e)
        {
            if (tbReplaceType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入替换型号", "错误提示");
                return;
            }
            //确认表格中有数据
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("表格无数据", "错误提示");
                return;
            }
            DataRow row1 = dt.Rows[0];
            string productType = row1["ProductType"].ToString();
            if (productTypeSer.IsTypeExist(productType, tableNames["ProductType"]))
            {
                MessageBox.Show("该型号已存在，无需重复添加", "错误提示");
                return;
            }
            if (productType != tbReplaceType.Text.Trim())
            {
                MessageBox.Show("表格中型号未替换，请检查后重试", "错误提示");
                return;
            }
            MessageBoxResult boxResult = MessageBox.Show("此操作将更改数据库，是否确认", "写入提示", MessageBoxButton.OKCancel, MessageBoxImage.Asterisk);
            if (boxResult == MessageBoxResult.OK)
            {
                //对比datatable和datagrid数据是否同步
                if (dt.Rows.Count == dgvTypeInfo.Items.Count)
                {
                    string tableName = tableNames["ProductType"];
                    if (tableName != null)
                    {
                        foreach (DataRow row in dt.Rows)
                            row["Id_Key"] = DBNull.Value;
                        productTypeSer.SqlBulkCopyInsert(tableName, dt);
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

        private void menuItemExtract_Click(object sender, RoutedEventArgs e)
        {
            if (dgvTypeInfo.SelectedItems.Count == 1)
            {
                DataRow row = dt.Rows[0];
                if (!string.IsNullOrEmpty(row[0].ToString().Trim()))
                    tb1.Text = row[0].ToString();
                if (!string.IsNullOrEmpty(row[1].ToString().Trim()))
                    tb2.Text = row[1].ToString();
                if (!string.IsNullOrEmpty(row[2].ToString().Trim()))
                    tb3.Text = row[2].ToString();
                if (!string.IsNullOrEmpty(row[3].ToString().Trim()))
                    tb4.Text = row[3].ToString();
                if (!string.IsNullOrEmpty(row[4].ToString().Trim()))
                    tb5.Text = row[4].ToString();
                if (!string.IsNullOrEmpty(row[5].ToString().Trim()))
                    tb6.Text = row[5].ToString();
                if (!string.IsNullOrEmpty(row[6].ToString().Trim()))
                    tb7.Text = row[6].ToString();
                if (!string.IsNullOrEmpty(row[7].ToString().Trim()))
                    tb8.Text = row[7].ToString();
                if (!string.IsNullOrEmpty(row[8].ToString().Trim()))
                    tb9.Text = row[8].ToString();
                if (!string.IsNullOrEmpty(row[9].ToString().Trim()))
                    tb10.Text = row[9].ToString();
                if (!string.IsNullOrEmpty(row[10].ToString().Trim()))
                    tb11.Text = row[10].ToString();
                if (!string.IsNullOrEmpty(row[11].ToString().Trim()))
                    tb12.Text = row[11].ToString();
                if (!string.IsNullOrEmpty(row[12].ToString().Trim()))
                    tb13.Text = row[12].ToString();
                if (!string.IsNullOrEmpty(row[13].ToString().Trim()))
                    tb14.Text = row[13].ToString();
                if (!string.IsNullOrEmpty(row[14].ToString().Trim()))
                    tb15.Text = row[14].ToString();
                if (!string.IsNullOrEmpty(row[15].ToString().Trim()))
                    tb16.Text = row[15].ToString();
                if (!string.IsNullOrEmpty(row[16].ToString().Trim()))
                    tb17.Text = row[16].ToString();
                if (!string.IsNullOrEmpty(row[17].ToString().Trim()))
                    tb18.Text = row[17].ToString();
                if (!string.IsNullOrEmpty(row[18].ToString().Trim()))
                    tb19.Text = row[18].ToString();
                if (!string.IsNullOrEmpty(row[19].ToString().Trim()))
                    tb20.Text = row[19].ToString();
                if (!string.IsNullOrEmpty(row[20].ToString().Trim()))
                    tb21.Text = row[20].ToString();


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductType currentType = new ProductType();
            DataRow row = dt.Rows[0];  
            //更新数据库确认
            MessageBoxResult result= MessageBox.Show("此操作将更新数据库，是否确定?", "写入提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                try
                {
                    if (!string.IsNullOrEmpty(tb1.Text.Trim()))
                    {
                        row[0] = tb1.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb2.Text.Trim()))
                    {
                        row[1] = tb2.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb3.Text.Trim()))
                    {
                        row[2] = tb3.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb4.Text.Trim()))
                    {
                        row[3] = tb4.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb5.Text.Trim()))
                    {
                        row[4] = tb5.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb6.Text.Trim()))
                    {
                        row[5] = tb6.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb7.Text.Trim()))
                    {
                        row[6] = tb7.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb8.Text.Trim()))
                    {
                        row[7] = tb8.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb9.Text.Trim()))
                    {
                        row[8] = tb9.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb10.Text.Trim()))
                    {
                        row[9] = tb10.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb11.Text.Trim()))
                    {
                        row[10] = tb11.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb12.Text.Trim()))
                    {
                        row[11] = tb12.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb13.Text.Trim()))
                    {
                        row[12] = tb13.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb14.Text.Trim()))
                    {
                        row[13] = tb14.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb15.Text.Trim()))
                    {
                        row[14] = tb15.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb16.Text.Trim()))
                    {
                        row[15] = tb16.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb17.Text.Trim()))
                    {
                        row[16] = tb17.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb18.Text.Trim()))
                    {
                        row[17] = tb18.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb19.Text.Trim()))
                    {
                        row[18] = tb19.Text.Trim();
                    }
                    if (!string.IsNullOrEmpty(tb20.Text.Trim()))
                    {
                        row[19] = tb20.Text.Trim();
                    }
                    //dgvTypeInfo.ItemsSource = dt.DefaultView;
                    if (productTypeSer.IsTypeExist(row[0].ToString(), tableNames["ProductType"]))
                    {
                        currentType.ProductTypeName = row[0].ToString();
                        currentType.TypeLength = Convert.ToInt32(row[1]);
                        currentType.TypeSign = row[2].ToString();
                        currentType.ApdSign = row[3].ToString();
                        currentType.TypeCatalog = row[4].ToString();
                        currentType.SnSign = row[5].ToString();
                        currentType.TeCaculateMethod = row[6].ToString();
                        currentType.PackingType = row[7].ToString();
                        currentType.IsSmsrSpotTest = Convert.ToInt32(row[8]);
                        currentType.IsImd2SpotTest = Convert.ToInt32(row[9]);
                        currentType.TypeVisible = Convert.ToInt32(row[10]);
                        currentType.MaterialId = row[11].ToString();
                        currentType.ProductTypeCommon = row[12].ToString();
                        currentType.CheckSnSubLength = Convert.ToInt32(row[13]);
                        currentType.YearSign = row[14].ToString();
                        currentType.AlignType = row[15].ToString();
                        currentType.IsUploadHwData = Convert.ToInt32(row[16]);
                        currentType.IsChangeToRedoData = Convert.ToInt32(row[17]);
                        currentType.HousingLaserSign = row[18].ToString();
                        currentType.ThOneTestType = row[19].ToString();
                        currentType.TransmitRate = row[20].ToString();
                        int count = productTypeSer.Update(currentType, tableNames["ProductType"]);
                        if (count == 1)
                        {
                            MessageBox.Show("更新数据库成功", "成功提示");
                        }
                        else
                        {
                            MessageBox.Show("写入错误" + count, "错误提示");
                        }

                    }
                    else
                    {
                        MessageBox.Show("数据库中不存在该型号，请先行添加", "错误提示");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }                       
        }
        #endregion
        #region 型号 Combobox事件
        //文本长度发生变化时自动筛选下拉框
        private void cmbAllType_KeyUp(object sender, KeyEventArgs e)
        {
            //当输入信息时，设置下拉菜单打开状态
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
        //当ComboBox 获取到焦点时，展开下拉框
        private void cmbAllType_GotFocus(object sender, RoutedEventArgs e)
        {
            this.cmbAllType.IsDropDownOpen = true;
        }
        private void cmbAllType_DropDownClosed(object sender, EventArgs e)
        {
            ds = productTypeSer.SearchTypeInfo(tableNames["ProductType"], cmbAllType.Text.Trim());
            dt = ds.Tables[0];
            dgvTypeInfo.ItemsSource = dt.DefaultView;
        }
        #endregion
    }
}
