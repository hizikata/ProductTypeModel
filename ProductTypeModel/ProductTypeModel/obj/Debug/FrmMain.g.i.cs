﻿#pragma checksum "..\..\FrmMain.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "51FC7860601BB5C358B5A0A99AC53B95"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using UI;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Controls;
using Xceed.Wpf.AvalonDock.Converters;
using Xceed.Wpf.AvalonDock.Layout;
using Xceed.Wpf.AvalonDock.Themes;


namespace UI {
    
    
    /// <summary>
    /// FrmMain
    /// </summary>
    public partial class FrmMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.AvalonDock.DockingManager dockingManager;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvProductType;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvProductStation;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvProductParameter;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvCommonParaSet;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvTemplateRedoSN;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvPackingExportPa;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvProductMatchSpecity;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FrmMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tvMaterialOrderParameter;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UI;component/frmmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FrmMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dockingManager = ((Xceed.Wpf.AvalonDock.DockingManager)(target));
            return;
            case 2:
            this.tvProductType = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 24 "..\..\FrmMain.xaml"
            this.tvProductType.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvProductType_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tvProductStation = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 25 "..\..\FrmMain.xaml"
            this.tvProductStation.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvProductStation_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tvProductParameter = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 26 "..\..\FrmMain.xaml"
            this.tvProductParameter.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvProductParameter_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tvCommonParaSet = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 27 "..\..\FrmMain.xaml"
            this.tvCommonParaSet.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvCommonParaSet_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tvTemplateRedoSN = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 28 "..\..\FrmMain.xaml"
            this.tvTemplateRedoSN.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvTemplateRedoSN_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tvPackingExportPa = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 29 "..\..\FrmMain.xaml"
            this.tvPackingExportPa.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvPackingExportPa_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tvProductMatchSpecity = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 30 "..\..\FrmMain.xaml"
            this.tvProductMatchSpecity.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvProductMatchSpecity_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tvMaterialOrderParameter = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 31 "..\..\FrmMain.xaml"
            this.tvMaterialOrderParameter.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tvMaterialOrderParameter_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
