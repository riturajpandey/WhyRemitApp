using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels.Registration;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Register
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmNumberPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        ConfirmNumberPageVM CnfVM;

        public ConfirmNumberPage()
        {
            InitializeComponent();
            CnfVM = new ConfirmNumberPageVM(this.Navigation);
            this.BindingContext = CnfVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}