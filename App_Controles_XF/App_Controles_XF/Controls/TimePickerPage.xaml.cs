
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerPage : ContentPage
    {
        public TimePickerPage()
        {
            InitializeComponent();
        }

        private void tmpHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                TimeSpan hour = ((TimePicker)sender).Time;
                lblHora.Text = $"{hour.Hours}:{hour.Minutes}";
            }
        }
    }
}