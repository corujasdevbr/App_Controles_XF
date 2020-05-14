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
    public partial class SearchBarPage : ContentPage
    {
        List<string> lstEmpresasTi;
        public SearchBarPage()
        {
            InitializeComponent();

            lstEmpresasTi = new List<string>();
            lstEmpresasTi.Add("Microsoft");
            lstEmpresasTi.Add("Apple");
            lstEmpresasTi.Add("IBM");
            lstEmpresasTi.Add("Senai");
            lstEmpresasTi.Add("Uber");
            lstEmpresasTi.Add("99Taxi");

            PreencherPicker(lstEmpresasTi);
        }

        private void PreencherPicker(List<String> empresas)
        {
            stkListResult.Children.Clear();
            foreach (var item in empresas)
            {
                stkListResult.Children.Add(new Label { Text = item });
            }
        }

        private void PesquisarButton(object sender, EventArgs args)
        {
            var resultado = lstEmpresasTi.Where(x => x.Contains(((SearchBar)sender).Text)).ToList();

            PreencherPicker(resultado);
        }

        private void stkListResult_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            StackLayout stkLayout = ((StackLayout)sender);
        }
    }
}