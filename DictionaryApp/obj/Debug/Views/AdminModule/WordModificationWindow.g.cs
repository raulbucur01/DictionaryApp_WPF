﻿#pragma checksum "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37B0FD67E55254591DD3D803479E37B5F87D09AE84D676A747355470DE52639F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DictionaryApp.Views.AdminModule;
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


namespace DictionaryApp.Views.AdminModule {
    
    
    /// <summary>
    /// WordModificationWindow
    /// </summary>
    public partial class WordModificationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveChangesBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label greetingLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox wordTb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTb;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoryCb;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newCategoryBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button photoSelectBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/DictionaryApp;component/views/adminmodule/wordmodificationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
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
            this.saveChangesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
            this.saveChangesBtn.Click += new System.Windows.RoutedEventHandler(this.saveChangesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.greetingLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.wordTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.descriptionTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.categoryCb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.newCategoryBtn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
            this.newCategoryBtn.Click += new System.Windows.RoutedEventHandler(this.newCategoryBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.photoSelectBtn = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Views\AdminModule\WordModificationWindow.xaml"
            this.photoSelectBtn.Click += new System.Windows.RoutedEventHandler(this.photoSelectBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

