﻿#pragma checksum "..\..\..\..\Pages\InviteSupplier.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F34BFFD0704963519F69CECBD28FF30B169D707D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Pharmacy.Data;
using Pharmacy.Pages;
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


namespace Pharmacy.Pages {
    
    
    /// <summary>
    /// InviteSupplier
    /// </summary>
    public partial class InviteSupplier : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Pages\InviteSupplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSupplierName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\InviteSupplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSupplierAddress;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\InviteSupplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSupplierPhone;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\InviteSupplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSupplierEmail;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\InviteSupplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageSupplier;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\InviteSupplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSupplierImage;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\InviteSupplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveSupplier;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pharmacy;component/pages/invitesupplier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\InviteSupplier.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbSupplierName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbSupplierAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbSupplierPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbSupplierEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ImageSupplier = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.AddSupplierImage = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Pages\InviteSupplier.xaml"
            this.AddSupplierImage.Click += new System.Windows.RoutedEventHandler(this.AddSupplierImage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnSaveSupplier = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Pages\InviteSupplier.xaml"
            this.BtnSaveSupplier.Click += new System.Windows.RoutedEventHandler(this.BtnSaveSupplier_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

