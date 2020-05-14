using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndicatorPage : ContentPage
    {
        public ActivityIndicatorPage()
        {
            InitializeComponent();
        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            activity.IsRunning = true;
        }

        private void btnStop_Clicked(object sender, EventArgs e)
        {
            activity.IsRunning = false;
        }
    }
}