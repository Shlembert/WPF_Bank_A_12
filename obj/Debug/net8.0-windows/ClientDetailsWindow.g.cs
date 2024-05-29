﻿#pragma checksum "..\..\..\ClientDetailsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0361E8A56CBDB8DD2C5AC22BBF2EBDBE1AC06F7C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace BankApp {
    
    
    /// <summary>
    /// ClientDetailsWindow
    /// </summary>
    public partial class ClientDetailsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AccountNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InitialBalanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AccountTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FromAccountTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ToAccountTextBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TransferAmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AccountsListBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\ClientDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SelectedAccountTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Wpf_Bank_A_12;component/clientdetailswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ClientDetailsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ClientNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.AccountNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.InitialBalanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AccountTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 40 "..\..\..\ClientDetailsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenAccount_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 41 "..\..\..\ClientDetailsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseAccount_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FromAccountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ToAccountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TransferAmountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 63 "..\..\..\ClientDetailsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Transfer_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.AccountsListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 68 "..\..\..\ClientDetailsWindow.xaml"
            this.AccountsListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AccountsListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SelectedAccountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

