﻿#pragma checksum "..\..\..\..\Views\ArtikelgruppeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ED3C7BA15ABF7CBC960171B90C25CA409CE6EBBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Auftragsverwaltung.Views;
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


namespace Auftragsverwaltung.Views {
    
    
    /// <summary>
    /// ArtikelgruppeWindow
    /// </summary>
    public partial class ArtikelgruppeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Views\ArtikelgruppeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArtikelGruppeSuchen;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\ArtikelgruppeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ArtikelGruppeHinzufuegen;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\ArtikelgruppeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ArtikelGruppeEditieren;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\ArtikelgruppeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ArtikelGruppeLoeschen;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\ArtikelgruppeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Artikel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Auftragsverwaltung;component/views/artikelgruppewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ArtikelgruppeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ArtikelGruppeSuchen = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\..\Views\ArtikelgruppeWindow.xaml"
            this.ArtikelGruppeSuchen.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ArtikelGruppeSuchen_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ArtikelGruppeHinzufuegen = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.ArtikelGruppeEditieren = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.ArtikelGruppeLoeschen = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Artikel = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

