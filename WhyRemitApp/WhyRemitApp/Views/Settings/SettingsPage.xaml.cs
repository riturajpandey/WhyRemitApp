using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        SettingPageVM SettingVM;

        public SettingsPage()
        {
            InitializeComponent();
            SettingVM = new SettingPageVM(this.Navigation);
            this.BindingContext = SettingVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region Event Handler

        /// <summary>
        /// TODO : To Defeine On Page Appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await SettingVM.GetSettings();
        }

        /// <summary>
        /// TODO : To Define Event Handler For Notifications Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (SettingVM.IsNotification)
                SettingVM.IsNotification = false;
            else
                SettingVM.IsNotification = true;
        }

        /// <summary>
        /// TODO : To Define Event Handler For Sound Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoundSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (SettingVM.IsSound)
                SettingVM.IsSound = false;
            else
                SettingVM.IsSound = true;
        }

        /// <summary>
        /// TODO : To Define Event Handler For Vibrate Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VibrateSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (SettingVM.IsVibrate)
                SettingVM.IsVibrate = false;
            else
                SettingVM.IsVibrate = true;
        }
        #endregion 

    }
}