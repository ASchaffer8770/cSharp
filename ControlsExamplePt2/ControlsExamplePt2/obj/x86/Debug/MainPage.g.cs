﻿#pragma checksum "C:\Users\alexL\Desktop\C#\ControlsExamplePt2\ControlsExamplePt2\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5575D1A429A83F91F408B1AE2B1EF4545AE09C18A09AFF734552BEC136157C1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlsExamplePt2
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::ControlsExamplePt2.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ProgressBar obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5ValueDisabled = false;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 127 && columnNumber == 22)
                {
                    isobj5ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // MainPage.xaml line 120
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::ControlsExamplePt2.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ControlsExamplePt2.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MySlider(obj.MySlider, phase);
                    }
                }
            }
            private void Update_MySlider(global::Windows.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MySlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MySlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_MySlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 120
                    if (!isobj5ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj5, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_MySlider(null);
                }

                public void DependencyPropertyChanged_MySlider_Value(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.Slider obj = sender as global::Windows.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_MySlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Slider cache_MySlider = null;
                private long tokenDPC_MySlider_Value = 0;
                public void UpdateChildListeners_MySlider(global::Windows.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_MySlider)
                    {
                        if (cache_MySlider != null)
                        {
                            cache_MySlider.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_MySlider_Value);
                            cache_MySlider = null;
                        }
                        if (obj != null)
                        {
                            cache_MySlider = obj;
                            tokenDPC_MySlider_Value = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_MySlider_Value);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 57
                {
                    this.MyFlyOutButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // MainPage.xaml line 99
                {
                    this.MyAutoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.MyAutoSuggestBox).TextChanged += this.MyAutoSuggestBox_TextChanged;
                }
                break;
            case 4: // MainPage.xaml line 110
                {
                    this.MySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 5: // MainPage.xaml line 120
                {
                    this.MyProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6: // MainPage.xaml line 130
                {
                    this.MyProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 7: // MainPage.xaml line 63
                {
                    this.MyFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 8: // MainPage.xaml line 66
                {
                    this.InnerFlyoutButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.InnerFlyoutButton).Click += this.InnerFlyoutButton_Click;
                }
                break;
            case 9: // MainPage.xaml line 50
                {
                    this.MyCalendarView = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.MyCalendarView).SelectedDatesChanged += this.MyCalendarView_SelectedDatesChanged;
                }
                break;
            case 10: // MainPage.xaml line 53
                {
                    this.CalendarViewResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

