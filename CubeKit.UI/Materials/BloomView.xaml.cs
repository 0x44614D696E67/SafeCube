﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace CubeKit.UI.Materials
{
    public sealed partial class BloomView : UserControl
    {
        public BloomView()
        {
            this.InitializeComponent();
            BloomWebView.Height = Window.Current.Bounds.Height;
            BloomWebView.Width = Window.Current.Bounds.Width;
        }

        private void Bloom_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            BloomWebView.Height = Window.Current.Bounds.Height;
            BloomWebView.Width = Window.Current.Bounds.Width;
        }
    }
}
