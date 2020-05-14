
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderStepperPage : ContentPage
    {
        public SliderStepperPage()
        {
            InitializeComponent();

            lblResultadoSlider.Text = sldSlider.Value.ToString();
            lblResultadoSteeper.Text = stpStepeer.Value.ToString();
        }

        private void sldSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblResultadoSlider.Text = ((Slider)sender).Value.ToString();
        }

        private void stpStepeer_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblResultadoSteeper.Text = ((Stepper)sender).Value.ToString();
        }
    }
}