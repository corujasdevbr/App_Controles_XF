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
    public partial class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            InitializeComponent();
        }

        private void btnUm_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Ok", "Clicou no botão", "Ok");
        }
    }
}