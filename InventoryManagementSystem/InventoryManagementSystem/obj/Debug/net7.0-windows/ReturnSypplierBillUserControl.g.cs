﻿#pragma checksum "..\..\..\ReturnSypplierBillUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2CDE04CEBC481DC1F3F7DBC6470023B8823FE5EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InventoryManagementSystem;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace InventoryManagementSystem {
    
    
    /// <summary>
    /// ReturnSypplierBillUserControl
    /// </summary>
    public partial class ReturnSypplierBillUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReturnBillSupplerName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReturnBillInventory;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReturnBillQty;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReturnBillDate;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReturnBillTotal;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReturnBillReturnedTotal;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvReturnBillCurrentProducts;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReturnBillIdSearch;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturnBillSelectedQty;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtReturnBillQty;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturnBillSearch;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvReturnBillSelectedProducts;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReturnBillConfirm;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReturnBillReset;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\ReturnSypplierBillUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReturnBillRemove;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InventoryManagementSystem;component/returnsypplierbillusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ReturnSypplierBillUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ReturnBillSupplerName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ReturnBillInventory = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ReturnBillQty = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ReturnBillDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ReturnBillTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ReturnBillReturnedTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.lvReturnBillCurrentProducts = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.ReturnBillIdSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnReturnBillSelectedQty = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\ReturnSypplierBillUserControl.xaml"
            this.btnReturnBillSelectedQty.Click += new System.Windows.RoutedEventHandler(this.btnReturnBillSearch_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtReturnBillQty = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btnReturnBillSearch = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\ReturnSypplierBillUserControl.xaml"
            this.btnReturnBillSearch.Click += new System.Windows.RoutedEventHandler(this.btnReturnBillSelectedQty_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lvReturnBillSelectedProducts = ((System.Windows.Controls.ListView)(target));
            return;
            case 13:
            this.ReturnBillConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\ReturnSypplierBillUserControl.xaml"
            this.ReturnBillConfirm.Click += new System.Windows.RoutedEventHandler(this.ReturnBillConfirm_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ReturnBillReset = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\ReturnSypplierBillUserControl.xaml"
            this.ReturnBillReset.Click += new System.Windows.RoutedEventHandler(this.ReturnBillReset_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.ReturnBillRemove = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\ReturnSypplierBillUserControl.xaml"
            this.ReturnBillRemove.Click += new System.Windows.RoutedEventHandler(this.ReturnBillRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

