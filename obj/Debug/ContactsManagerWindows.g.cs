﻿#pragma checksum "..\..\ContactsManagerWindows.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0445B61331846762E448BFE3CE5B846F"
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
using The_Email_Client;


namespace The_Email_Client {
    
    
    /// <summary>
    /// ContactsManagerWindows
    /// </summary>
    public partial class ContactsManagerWindows : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ContactsManagerWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid contactsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ContactsManagerWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailtextbox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ContactsManagerWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nametextbox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\ContactsManagerWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addcontactButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\ContactsManagerWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removecontactButton;
        
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
            System.Uri resourceLocater = new System.Uri("/The Email Client;component/contactsmanagerwindows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ContactsManagerWindows.xaml"
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
            this.contactsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\ContactsManagerWindows.xaml"
            this.contactsDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.contactsDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.emailtextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\ContactsManagerWindows.xaml"
            this.emailtextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.addcontacttextboxes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nametextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\ContactsManagerWindows.xaml"
            this.nametextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.addcontacttextboxes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addcontactButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\ContactsManagerWindows.xaml"
            this.addcontactButton.Click += new System.Windows.RoutedEventHandler(this.addcontactButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.removecontactButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\ContactsManagerWindows.xaml"
            this.removecontactButton.Click += new System.Windows.RoutedEventHandler(this.removecontactButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

