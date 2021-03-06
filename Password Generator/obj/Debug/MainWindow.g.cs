﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF6470E69879AA1A10DC1C2B13D08C7B5D6125ECCE2C35B1E6F01627D356D542"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Password_Generator;
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


namespace Password_Generator {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CheckAllButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CapitalLettersCheckBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SmallLettersCheckBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DigitsCheckBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SpecialCharactersCheckBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GenerateButton;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LengthNumber;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordText;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VisibilityButton;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopyButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Password Generator;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.CheckAllButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.CheckAllButton.Click += new System.Windows.RoutedEventHandler(this.CheckAllButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CapitalLettersCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.CapitalLettersCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.CapitalLettersCheckBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            this.CapitalLettersCheckBox.Checked += new System.Windows.RoutedEventHandler(this.CapitalLettersCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SmallLettersCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.SmallLettersCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.SmallLettersCheckBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MainWindow.xaml"
            this.SmallLettersCheckBox.Checked += new System.Windows.RoutedEventHandler(this.SmallLettersCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DigitsCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.DigitsCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.DigitsCheckBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MainWindow.xaml"
            this.DigitsCheckBox.Checked += new System.Windows.RoutedEventHandler(this.DigitsCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SpecialCharactersCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.SpecialCharactersCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.SpecialCharactersCheckBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MainWindow.xaml"
            this.SpecialCharactersCheckBox.Checked += new System.Windows.RoutedEventHandler(this.SpecialCharactersCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GenerateButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.GenerateButton.Click += new System.Windows.RoutedEventHandler(this.GenerateButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LengthNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 88 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 91 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DownButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.PasswordText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.VisibilityButton = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\MainWindow.xaml"
            this.VisibilityButton.Click += new System.Windows.RoutedEventHandler(this.VisibilityButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CopyButton = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\MainWindow.xaml"
            this.CopyButton.Click += new System.Windows.RoutedEventHandler(this.CopyButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

