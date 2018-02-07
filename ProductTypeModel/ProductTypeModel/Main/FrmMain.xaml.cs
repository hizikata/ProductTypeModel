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

namespace UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        BLL.LogicClass logicClass = new LogicClass();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tvProductType_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            logicClass.Show(dockingManager, new FrmProductType(), "型号设置");

        }

        private void tvProductStation_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            logicClass.Show(dockingManager, new FrmProductStation(), "站别设置");
        }

        private void tvProductParameter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            logicClass.Show(dockingManager, new FrmProductParameter(), "参数设置");
        }

        private void tvCommonParaSet_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            logicClass.Show(dockingManager, new FrmCommonParaSet(), "三合一参数");
        }

        private void tvTemplateRedoSN_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            logicClass.Show(dockingManager, new FrmTemplateRedoSN(), "标签管理");
        }

        private void tvPackingExportPa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            logicClass.Show(dockingManager, new FrmPackingExportPara(), "测报导出");
        }

        private void tvProductMatchSpecity_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            logicClass.Show(dockingManager, new FrmProductMatchSpecify(), "物料设置");
        }

        private void tvMaterialOrderParameter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            logicClass.Show(dockingManager, new FrmProductMatchSpecify(), "物料注册");
        }
    }
}
