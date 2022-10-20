// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIExample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            // myButton.Content = "Clicked";
            Uri targetUri = new Uri(AddressTXT.Text);
            MyWebView.Source=targetUri;
            MyWebView.Focus(FocusState.Keyboard);
        }

        private async void Window_Activated(object sender, WindowActivatedEventArgs args)
        {            
            // MyWebView.Focus(FocusState.Keyboard);
        }

        private void MyWebView_NavigationCompleted(WebView2 sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs args)
        {
            // MyWebView.Focus(FocusState.Keyboard);
        }
    }
}
