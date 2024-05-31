﻿#pragma checksum "..\..\..\TransferWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7EA9617179092FF78E33898F17A279744FD0A981"
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
    /// TransferWindow
    /// </summary>
    public partial class TransferWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SelfTransferRadioButton;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OtherClientTransferRadioButton;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClientsComboBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AccountsComboBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_Bank_A_12;component/transferwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TransferWindow.xaml"
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
            this.SelfTransferRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 7 "..\..\..\TransferWindow.xaml"
            this.SelfTransferRadioButton.Checked += new System.Windows.RoutedEventHandler(this.SelfTransferRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OtherClientTransferRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 8 "..\..\..\TransferWindow.xaml"
            this.OtherClientTransferRadioButton.Checked += new System.Windows.RoutedEventHandler(this.OtherClientTransferRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ClientsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.AccountsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.AmountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 14 "..\..\..\TransferWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TransferButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 15 "..\..\..\TransferWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

