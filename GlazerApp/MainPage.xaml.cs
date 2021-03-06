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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double width;
        private double height;

        public MainPage()
        {
            this.InitializeComponent();
            tintType.ItemsSource = Enum.GetValues(typeof(Tint));
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void heightInput_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void widthInput_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            width = widthInput.Value;
        }

        private void heightInput_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            height = heightInput.Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Today;
            widthOut.Text = "Width: " + width.ToString() + " meters";
            heightOut.Text = "Height: " + height.ToString() + " meters";
            tintOut.Text = "Tint: " + tintType.SelectedValue;
            lengthOut.Text = "Wood length: " + (2 * (width + height) * 3.25) + " square meters";
            areaOut.Text = "Glass area: " + (2 * (width * height)) + " square meters";
            dateOut.Text = "Date: " + date.ToString("d");
        }
    }
}
