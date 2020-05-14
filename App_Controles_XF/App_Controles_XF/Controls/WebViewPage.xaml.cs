using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            btnVoltar.Text = "<";
            btnProximo.Text = ">";
        }

        private void btnIr_Clicked(object sender, EventArgs e)
        {
            webView.Source = txtUrl.Text;
        }

        private void btnProximo_Clicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            actIndicator.IsRunning = false;
            actIndicator.IsVisible = false;
        }

        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            actIndicator.IsRunning = true;
            actIndicator.IsVisible = true;
        }
    }
}