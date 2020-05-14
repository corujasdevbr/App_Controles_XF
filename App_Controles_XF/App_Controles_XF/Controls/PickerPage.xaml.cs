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
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();

            pckEmpresasTi.SelectedItem = "Senai";
        }

        
        private void pckEmpresasTi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = ((Picker)sender);

            lblResultado.Text = picker.SelectedItem.ToString();
        }
    }
}