﻿#pragma checksum "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D89B29EBABE6B714D14D419ED9D297B"
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


namespace UI {
    
    
    /// <summary>
    /// FrmMaterialOrderParameter
    /// </summary>
    public partial class FrmMaterialOrderParameter : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbReplaceType;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btReplaceType;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btInsertToDB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAllType;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgInfo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemExtract;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbCurrentRow;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSelectedRows;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbAllRows;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/typemanager/frmmaterialorderparameter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
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
            this.tbReplaceType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btReplaceType = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
            this.btReplaceType.Click += new System.Windows.RoutedEventHandler(this.btReplaceType_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btInsertToDB = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
            this.btInsertToDB.Click += new System.Windows.RoutedEventHandler(this.btInsertToDB_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbAllType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
            this.cmbAllType.DropDownClosed += new System.EventHandler(this.cmbAllType_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgInfo = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
            this.dgInfo.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.dgInfo_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menuItemExtract = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\TypeManager\FrmMaterialOrderParameter.xaml"
            this.menuItemExtract.Click += new System.Windows.RoutedEventHandler(this.menuItemExtract_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbCurrentRow = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.tbSelectedRows = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.tbAllRows = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

