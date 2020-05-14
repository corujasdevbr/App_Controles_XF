using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();
        }

        private void txtIdade_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblDuplicate.Text = e.NewTextValue;
        }

        private void txtComentario_Completed(object sender, EventArgs e)
        {
            lblQuantCaracteres.Text = txtComentario.Text.Length.ToString();
        }
    }
}