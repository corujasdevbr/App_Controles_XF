using App_Controles_XF.Models;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            CarregarListViewPessoas();
        }

        private void CarregarListViewPessoas()
        {
            List<PessoaModel> list = new List<PessoaModel>();
            list.Add(new PessoaModel() { Nome = "Fernando", Idade = 41 });
            list.Add(new PessoaModel() { Nome = "Ligia", Idade = 36 });
            list.Add(new PessoaModel() { Nome = "Alexandre", Idade = 51 });
            list.Add(new PessoaModel() { Nome = "Eduardo", Idade = 79 });

            lsvPessoas.ItemsSource = list;
        }

        private void lsvPessoas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var pessoa = (PessoaModel)((ListView)sender).SelectedItem;

            DisplayAlert("Pessoa", $"{pessoa.Nome} - {pessoa.Idade}", "Ok");

            ((ListView)sender).BackgroundColor = Color.Transparent;
        }
    }
}