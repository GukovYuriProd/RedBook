﻿#pragma checksum "..\..\..\AdminClient\FirstBTNOfMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "04E15143CDF6677389405641E29654DDCECBC26515A67779CFFCE5156236EA47"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RedBook.AdminClient;
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


namespace RedBook.AdminClient {
    
    
    /// <summary>
    /// FirstBTNOfMenu
    /// </summary>
    public partial class FirstBTNOfMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\..\AdminClient\FirstBTNOfMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EnterName;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\AdminClient\FirstBTNOfMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EnterAge;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\AdminClient\FirstBTNOfMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EnterLogin;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\AdminClient\FirstBTNOfMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EnterPassword;
        
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
            System.Uri resourceLocater = new System.Uri("/RedBook;component/adminclient/firstbtnofmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminClient\FirstBTNOfMenu.xaml"
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
            this.EnterName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.EnterAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EnterLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.EnterPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 150 "..\..\..\AdminClient\FirstBTNOfMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewStudent);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 155 "..\..\..\AdminClient\FirstBTNOfMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

