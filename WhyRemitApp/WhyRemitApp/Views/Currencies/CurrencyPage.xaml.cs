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
    public partial class CurrencyPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        CurrencyPageVM CurrencyVM;

        public CurrencyPage()
        {
            InitializeComponent();
            CurrencyVM = new CurrencyPageVM(this.Navigation);
            this.BindingContext = CurrencyVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}