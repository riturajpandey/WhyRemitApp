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
        int countdown = 60;

        public ConfirmNumberPage()
        {
            InitializeComponent();
            CnfVM = new ConfirmNumberPageVM(this.Navigation);
            this.BindingContext = CnfVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            LblCountDown.Text = countdown.ToString() + " Seconds";

            //To restart countdown...
            MessagingCenter.Subscribe<string>(this, "StartCountDown", (sender) =>
            {
                LblCountDown.Text = countdown.ToString() +" Seconds";
                GrdCountDown.IsVisible = true;
                GrdResendLink.IsVisible = false;

                Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
                {
                    bool IsRepeat = true;
                    countdown = countdown - 1;
                    LblCountDown.Text = countdown.ToString() +" Seconds";

                    if (countdown == 0)
                    {
                        IsRepeat = false;
                        countdown = 60;
                        GrdCountDown.IsVisible = false;
                        GrdResendLink.IsVisible = true;
                    }
                    return IsRepeat;
                });
            }); 
        }

        #region Event Handler

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {
                bool IsRepeat = true;
                countdown = countdown - 1;
                LblCountDown.Text = countdown.ToString() + " Seconds";

                if (countdown == 0)
                {
                    IsRepeat = false;
                    countdown = 60;
                    GrdCountDown.IsVisible = false;
                    GrdResendLink.IsVisible = true;
                } 
                return IsRepeat;
            });
        }
        #endregion
    }
}