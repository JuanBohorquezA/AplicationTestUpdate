﻿#pragma checksum "..\..\..\..\..\..\Modals\ModalWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73AE375168B6C98E6FCF1D92DDCC6D775872CCC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace hantleDispenser.Modals {
    
    
    /// <summary>
    /// ModalWindow
    /// </summary>
    public partial class ModalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtTitle;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtMsg;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ProgressRing LoadGif;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BtnConfirm;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BtnAcept;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/hantleDispenser;component/modals/modalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
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
            this.TxtTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TxtMsg = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.LoadGif = ((MahApps.Metro.Controls.ProgressRing)(target));
            return;
            case 4:
            this.BtnConfirm = ((System.Windows.Controls.Border)(target));
            
            #line 94 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
            this.BtnConfirm.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonConfirm);
            
            #line default
            #line hidden
            
            #line 94 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
            this.BtnConfirm.PreviewTouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.ButtonConfirm);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAcept = ((System.Windows.Controls.Border)(target));
            
            #line 99 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
            this.BtnAcept.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonAcept);
            
            #line default
            #line hidden
            
            #line 99 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
            this.BtnAcept.PreviewTouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.ButtonAcept);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnCancel = ((System.Windows.Controls.Border)(target));
            
            #line 105 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
            this.BtnCancel.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonCancel);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\..\..\Modals\ModalWindow.xaml"
            this.BtnCancel.PreviewTouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.ButtonCancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

