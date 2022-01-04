﻿#pragma checksum "..\..\..\AuthWindowT\AuthWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4D6181C14DF84BC32C816FA1E5E23803822162941403B5E4B0E8D41BB8C6391"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RedBook.AuthWindow;
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


namespace RedBook.AuthWindow {
    
    
    /// <summary>
    /// AuthWindow
    /// </summary>
    public partial class AuthWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\AuthWindowT\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginPageEnterLogin;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\AuthWindowT\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox LoginPageEnterPassword;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\AuthWindowT\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LeftPin;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\AuthWindowT\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border RightPin;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\AuthWindowT\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ClassOfUser;
        
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
            System.Uri resourceLocater = new System.Uri("/RedBook;component/authwindowt/authwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AuthWindowT\AuthWindow.xaml"
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
            this.LoginPageEnterLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\AuthWindowT\AuthWindow.xaml"
            this.LoginPageEnterLogin.GotFocus += new System.Windows.RoutedEventHandler(this.LoginPageEnterLogin_GotFocus);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\AuthWindowT\AuthWindow.xaml"
            this.LoginPageEnterLogin.LostFocus += new System.Windows.RoutedEventHandler(this.LoginPageEnterLogin_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginPageEnterPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 94 "..\..\..\AuthWindowT\AuthWindow.xaml"
            this.LoginPageEnterPassword.GotFocus += new System.Windows.RoutedEventHandler(this.LoginPageEnterPassword_GotFocus);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\AuthWindowT\AuthWindow.xaml"
            this.LoginPageEnterPassword.LostFocus += new System.Windows.RoutedEventHandler(this.LoginPageEnterPassword_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 104 "..\..\..\AuthWindowT\AuthWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginOnAuthPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LeftPin = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            
            #line 121 "..\..\..\AuthWindowT\AuthWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SwitchFromTeacherToStudent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RightPin = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            
            #line 133 "..\..\..\AuthWindowT\AuthWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SwitchFromStudentToTeacher);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClassOfUser = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 165 "..\..\..\AuthWindowT\AuthWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenAdminsPanel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

