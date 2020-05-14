
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Controles_XF.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Layout : MasterDetailPage
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void goPageControl(object sender, System.EventArgs args)
        {

            string controlName = ((Button)sender).ClassId;

            switch (controlName)
            {
                case "activityindicator":
                    Detail = new NavigationPage(new Controls.ActivityIndicatorPage() { Title = "ActivityIndicator" });
                    break;
                case "progressbar":
                    Detail = new NavigationPage(new Controls.ProgressBarPage() { Title = "ProgressBar" });
                    break;
                case "boxview":
                    Detail = new NavigationPage(new Controls.BoxViewPage() { Title = "BoxView" });
                    break;
                case "label":
                    Detail = new NavigationPage(new Controls.LabelPage() { Title = "Label" });
                    break;
                case "button":
                    Detail = new NavigationPage(new Controls.ButtonPage() { Title = "Button" });
                    break;
                case "entryEditor":
                    Detail = new NavigationPage(new Controls.EntryEditorPage() { Title = "EntryEditor" });
                    break;
                case "datePicker":
                    Detail = new NavigationPage(new Controls.DatePickerPage() { Title = "DatePicker" });
                    break;
                case "timePicker":
                    Detail = new NavigationPage(new Controls.TimePickerPage() { Title = "TimePicker" });
                    break;
                case "picker":
                    Detail = new NavigationPage(new Controls.PickerPage() { Title = "Picker" });
                    break;
                case "searchBar":
                    Detail = new NavigationPage(new Controls.SearchBarPage() { Title = "SearchBar" });
                    break;
                case "sliderStepeer":
                    Detail = new NavigationPage(new Controls.SliderStepperPage() { Title = "SliderStepper" });
                    break;
                case "switch":
                    Detail = new NavigationPage(new Controls.SwitchPage() { Title = "Switch" });
                    break;
                case "image":
                    Detail = new NavigationPage(new Controls.ImagemPage() { Title = "Imagem" });
                    break;
                case "listView":
                    Detail = new NavigationPage(new Controls.ListViewPage() { Title = "ListView" });
                    break;
                case "tableView":
                    Detail = new NavigationPage(new Controls.TableViewPage() { Title = "TableView" });
                    break;
                case "webView":
                    Detail = new NavigationPage(new Controls.WebViewPage() { Title = "WebView" });
                    break;
            }

            IsPresented = false;
        }
    }
}