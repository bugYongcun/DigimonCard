﻿

#pragma checksum "F:\Users\王永淳\Documents\Visual Studio 2012\Projects\DigimonCard\DigimonCard\RoomCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "012CB468C1444EB64335B0206D7312E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigimonCard
{
    partial class RoomCard : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 27 "..\..\RoomCard.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.BeSelect;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 38 "..\..\RoomCard.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.JoinIn_byPhoto;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 47 "..\..\RoomCard.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.joinInBtn_click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


