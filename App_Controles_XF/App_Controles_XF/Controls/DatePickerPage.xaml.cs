using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();

            dtpData.MinimumDate = DateTime.Now;
            dtpData.MaximumDate = DateTime.Now.AddDays(365);
            dtpData.Date = DateTime.Now;
        }

        private void dtpData_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblData.Text = e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}