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
    public partial class ConfirmNumber : ContentPage
    { 
        //TODO : To Define class Level Variables...
        ConfirmNumberPageVM ConfirmVM;
         
        public ConfirmNumber()
        {
            InitializeComponent();
            ConfirmVM = new ConfirmNumberPageVM(this.Navigation);
            this.BindingContext = ConfirmVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}