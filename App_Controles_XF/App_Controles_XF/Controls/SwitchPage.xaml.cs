using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void swtSalvarSenha_Toggled(object sender, ToggledEventArgs e)
        {
            lblResultado.Text = $"{DateTime.Now.ToShortTimeString()} - {e.Value}";
        }
    }
}