﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace Ejemplo18
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async Task<string> FetchWebPage(string url)
        {
            HttpClient httpClient  = new HttpClient();
            string page = await httpClient.GetStringAsync(url);
            return page;
        }

        private async void LoadWebSiteButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Primero tomamos la url del TextBox
            string url = UrlTextBox.Text;

            try
            {
                HtmlResult.Text = await FetchWebPage(url);
                StatusTextBlock.Text = "Page loaded";
            }
            catch (Exception exception)
            {
                StatusTextBlock.Text = exception.Message;
            }
        }
    }
}
