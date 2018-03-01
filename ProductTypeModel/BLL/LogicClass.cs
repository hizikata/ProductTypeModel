using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Layout;

namespace BLL
{
    public class LogicClass
    {
        /// <summary>
        /// 根据页面名称判定页面是否存在
        /// </summary>
        /// <param name="documents"></param>
        /// <param name="pageName"></param>
        /// <returns></returns>
        public LayoutContent ShowDocumentFromName(ObservableCollection<LayoutContent> documents, string pageName)
        {
            LayoutContent document = null;
            foreach (var item in documents)
            {
                if (item.Title == pageName)
                    document = item;
            }
            return document;
        }
        /// <summary>
        /// 根据页面名称判定页面是否存在，不是则新建页面，是则打开已存在的页面
        /// </summary>
        /// <param name="dockingManager"></param>
        /// <param name="userControl">需要插入页面中的用户控件</param>
        /// <param name="pageName">页面名称，注意不能重复</param>
        public void Show(DockingManager dockingManager, UserControl userControl, string pageName)
        {
            var documentPane = dockingManager.Layout.Descendents().OfType<LayoutDocumentPane>().FirstOrDefault();

            if (documentPane != null)
            {
                //将主窗口的所有页面(LayoutContent)存入一个数组(documents),后续遍历数组来判定页面是否已经打开
                var documents = documentPane.Children;
                LayoutContent document = ShowDocumentFromName(documents, pageName);
                if (document == null)
                {
                    LayoutDocument layoutDocument = new LayoutDocument { Title = pageName };

                    //*********Here you could add whatever you want***********
                    //创建用户控件插入标签页组作为LayoutDocument的Content
                    layoutDocument.Content = userControl;

                    //Add the new LayoutDocument to the existing array
                    documents.Add(layoutDocument);
                    //设置新打开的标签前台显示
                    layoutDocument.IsSelected = true;

                }
                else
                {
                    document.IsSelected = true;
                }
            }
        }
        /// <summary>
        /// 根据输入信息显示筛选后的下拉框
        /// </summary>
        /// <param name="Text">输入的筛选内容</param>
        /// <param name="list">需要筛选前的列表</param>
        /// <returns></returns>
        public List<string> GetListFromInfo(string Text, List<string> list)
        {
            List<string> listFiltrate = new List<string>();
            foreach(var item in list)
            {
                if (item.Contains(Text))
                {
                    listFiltrate.Add(item);
                }
            }
            return listFiltrate;
        }
    }
}
