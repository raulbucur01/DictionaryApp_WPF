﻿#pragma checksum "..\..\..\Views\AdminMenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ABB559F08F94A5A54DDE81E57A35B9B025FE27590E941002041466D535E15752"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DictionaryApp.Views;
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


namespace DictionaryApp.Views {
    
    
    /// <summary>
    /// AdminMenuWindow
    /// </summary>
    public partial class AdminMenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock greetingTextBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addWordBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showWordsBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modifyWordBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteWordBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/DictionaryApp;component/views/adminmenuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AdminMenuWindow.xaml"
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
            this.greetingTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.addWordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\AdminMenuWindow.xaml"
            this.addWordBtn.Click += new System.Windows.RoutedEventHandler(this.addWordBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.showWordsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\AdminMenuWindow.xaml"
            this.showWordsBtn.Click += new System.Windows.RoutedEventHandler(this.showWordsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.modifyWordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Views\AdminMenuWindow.xaml"
            this.modifyWordBtn.Click += new System.Windows.RoutedEventHandler(this.modifyWordBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.deleteWordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Views\AdminMenuWindow.xaml"
            this.deleteWordBtn.Click += new System.Windows.RoutedEventHandler(this.deleteWordBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

