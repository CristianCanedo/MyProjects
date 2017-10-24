﻿#pragma checksum "..\..\GuessCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6443134B9AB4D8E06C2A52B37EDD5D51"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GuessYourCard;
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


namespace GuessYourCard {
    
    
    /// <summary>
    /// GuessCard
    /// </summary>
    public partial class GuessCard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox leftBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox middleBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox rightBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLeft;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMiddle;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRight;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPickYourCard;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\GuessCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pickCardLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/GuessYourCard;component/guesscard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GuessCard.xaml"
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
            this.leftBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.middleBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.rightBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.btnLeft = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\GuessCard.xaml"
            this.btnLeft.Click += new System.Windows.RoutedEventHandler(this.btnLeft_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnMiddle = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\GuessCard.xaml"
            this.btnMiddle.Click += new System.Windows.RoutedEventHandler(this.btnMiddle_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRight = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\GuessCard.xaml"
            this.btnRight.Click += new System.Windows.RoutedEventHandler(this.btnRight_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnPickYourCard = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\GuessCard.xaml"
            this.btnPickYourCard.Click += new System.Windows.RoutedEventHandler(this.btnPickYourCard_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.pickCardLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 20 "..\..\GuessCard.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewGame_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 22 "..\..\GuessCard.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 25 "..\..\GuessCard.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DisplaySteps_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 27 "..\..\GuessCard.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.About_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
