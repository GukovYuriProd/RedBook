﻿#pragma checksum "..\..\..\AdminClient\MainWIndow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6FE24BA5A6CE9EC6F241B496AAE912E6DEB7F636CF06E5E48B1661DAD524F3A"
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
    /// MainWIndow
    /// </summary>
    public partial class MainWIndow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\AdminClient\MainWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AdminsPanelStackPanel1;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\AdminClient\MainWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AdminsPanelStackPanel2;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\AdminClient\MainWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame AdminWorkArea;
        
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
            System.Uri resourceLocater = new System.Uri("/RedBook;component/adminclient/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminClient\MainWIndow.xaml"
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
            this.AdminsPanelStackPanel1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 55 "..\..\..\AdminClient\MainWIndow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickFirst);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 60 "..\..\..\AdminClient\MainWIndow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickSecond);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 65 "..\..\..\AdminClient\MainWIndow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickThird);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 70 "..\..\..\AdminClient\MainWIndow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickFour);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 75 "..\..\..\AdminClient\MainWIndow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickFive);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AdminsPanelStackPanel2 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            
            #line 86 "..\..\..\AdminClient\MainWIndow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FormateNewClass);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AdminWorkArea = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

