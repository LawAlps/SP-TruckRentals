﻿#pragma checksum "..\..\..\..\PresentationLayer\AddNewCustomer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D0C0383378C1C6119344C48DE3A0B3C2E49A71CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using TruckRentalManagement.PresentationLayer;


namespace TruckRentalManagement.PresentationLayer {
    
    
    /// <summary>
    /// AddNewCustomer
    /// </summary>
    public partial class AddNewCustomer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telephoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox licenseNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker licenseExpiryDatePicker;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addEmployeeButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TruckRentalManagement;component/presentationlayer/addnewcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.telephoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.licenseNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ageTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.licenseExpiryDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.returnButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
            this.returnButton.Click += new System.Windows.RoutedEventHandler(this.returnButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.addEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\PresentationLayer\AddNewCustomer.xaml"
            this.addEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.addEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
