﻿#pragma checksum "C:\Users\kinga\source\repos\miniPaint\miniPaint\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DEBEC0846015A6E4A2776262FFD667378AB8EF6AFEB98195E1C1C34C4349364A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace miniPaint
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.poleRysowania = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.poleRysowania).PointerPressed += this.poleRysowania_PointerPressed;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.poleRysowania).PointerMoved += this.poleRysowania_PointerMoved;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.poleRysowania).PointerReleased += this.poleRysowania_PointerReleased;
                }
                break;
            case 3: // MainPage.xaml line 14
                {
                    this.rdbProsta = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.rdbProsta).Checked += this.rdbProsta_Checked;
                }
                break;
            case 4: // MainPage.xaml line 15
                {
                    this.rdbDowolna = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.rdbDowolna).Checked += this.rdbDowolna_Checked;
                }
                break;
            case 5: // MainPage.xaml line 16
                {
                    this.spKolory = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.spKolory).PointerPressed += this.spKolory_PointerPressed;
                }
                break;
            case 6: // MainPage.xaml line 22
                {
                    this.sldGrubość = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.sldGrubość).ValueChanged += this.sldGrubość_ValueChanged;
                }
                break;
            case 7: // MainPage.xaml line 23
                {
                    this.btnUndo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUndo).Click += this.btnUndo_Click;
                }
                break;
            case 8: // MainPage.xaml line 24
                {
                    this.btnExit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnExit).Click += this.BtnExit_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

