﻿#pragma checksum "..\..\..\..\..\..\UserControls\MenuUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E81FD6294B5B8502D96CDB5B5354AE3D2078397"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using hantleDispenser.UserControls;


namespace hantleDispenser.UserControls {
    
    
    /// <summary>
    /// MenuUC
    /// </summary>
    public partial class MenuUC : hantleDispenser.UserControls.AppUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtWelcome;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ButtonInit;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ButtonDispend;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ButtonDispendQuantities;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ButtonGetSensor;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ButtonEject;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ButtonExit;
        
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
            System.Uri resourceLocater = new System.Uri("/hantleDispenser;component/usercontrols/menuuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
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
            this.txtWelcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ButtonInit = ((System.Windows.Controls.Border)(target));
            
            #line 41 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
            this.ButtonInit.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnInicialize);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonDispend = ((System.Windows.Controls.Border)(target));
            
            #line 46 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
            this.ButtonDispend.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnDispend);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonDispendQuantities = ((System.Windows.Controls.Border)(target));
            
            #line 51 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
            this.ButtonDispendQuantities.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnDispendQuantites);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonGetSensor = ((System.Windows.Controls.Border)(target));
            
            #line 64 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
            this.ButtonGetSensor.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnGetSensor);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonEject = ((System.Windows.Controls.Border)(target));
            
            #line 69 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
            this.ButtonEject.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtntryEject);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonExit = ((System.Windows.Controls.Border)(target));
            
            #line 74 "..\..\..\..\..\..\UserControls\MenuUC.xaml"
            this.ButtonExit.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnExit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

