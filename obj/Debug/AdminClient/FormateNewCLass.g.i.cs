﻿#pragma checksum "..\..\..\AdminClient\FormateNewCLass.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89A596B445C5136217F48FD406EE194EE3B56516EE8403DB9389FAD65041E0B8"
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
    /// FormateNewCLass
    /// </summary>
    public partial class FormateNewCLass : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelTOP;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClassCheck;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfigurateClass;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SearchResults;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SwitchToStudentSearch;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SwitchToTeacherSearch;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\AdminClient\FormateNewCLass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StudentsInCLass;
        
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
            System.Uri resourceLocater = new System.Uri("/RedBook;component/adminclient/formatenewclass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminClient\FormateNewCLass.xaml"
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
            this.LabelTOP = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ClassCheck = ((System.Windows.Controls.ComboBox)(target));
            
            #line 74 "..\..\..\AdminClient\FormateNewCLass.xaml"
            this.ClassCheck.DropDownClosed += new System.EventHandler(this.ClassCheck_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ConfigurateClass = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\..\AdminClient\FormateNewCLass.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            
            #line 103 "..\..\..\AdminClient\FormateNewCLass.xaml"
            this.Search.LostFocus += new System.Windows.RoutedEventHandler(this.Search_LostFocus);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\AdminClient\FormateNewCLass.xaml"
            this.Search.GotFocus += new System.Windows.RoutedEventHandler(this.Search_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchResults = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.SwitchToStudentSearch = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            
            #line 130 "..\..\..\AdminClient\FormateNewCLass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StudentSearchSelected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SwitchToTeacherSearch = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            
            #line 149 "..\..\..\AdminClient\FormateNewCLass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TeacherSearchSelected);
            
            #line default
            #line hidden
            return;
            case 10:
            this.StudentsInCLass = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

