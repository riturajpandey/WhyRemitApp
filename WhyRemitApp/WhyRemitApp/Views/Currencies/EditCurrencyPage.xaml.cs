using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels.Currency;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Currencies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditCurrencyPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        EditCurrencyVM EditCurrencyVM;

        public EditCurrencyPage()
        {
            InitializeComponent();
            EditCurrencyVM = new EditCurrencyVM(this.Navigation);
            this.BindingContext = EditCurrencyVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}