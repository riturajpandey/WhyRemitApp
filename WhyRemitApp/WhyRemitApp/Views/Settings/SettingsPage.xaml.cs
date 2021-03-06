﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels;
using Xamarin.Essentials;
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

            var s = Helpers.LocalStorage.GeneralIsNotification;

            if (!string.IsNullOrEmpty(Helpers.LocalStorage.GeneralIsNotification))
            {
                SwtchNotification.IsToggled = true;
            }
            if (!string.IsNullOrEmpty(Helpers.LocalStorage.GeneralIsSound))
            {
                SwtchSound.IsToggled = true;
            }
            if (!string.IsNullOrEmpty(Helpers.LocalStorage.GeneralIsVibrate))
            {
                SwtchVibrate.IsToggled = true;
            }
        }

        #region Event Handler

        /// <summary>
        /// TODO : To Defeine On Page Appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await SettingVM.GetSettings();
            VersionTracking.Track();
            var currentVersion = VersionTracking.CurrentVersion;
            LblVersion.Text = "Version " + currentVersion.ToString();
        }

        /// <summary>
        /// TODO : To Define Event Handler For Notifications Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (SettingVM.IsNotification)
            {
                SettingVM.IsNotification = false;
                SwtchSound.IsEnabled = false;
                SwtchVibrate.IsEnabled = false;
                SwtchSound.IsToggled = false;
                SwtchVibrate.IsToggled = false;
                SettingVM.IsSound = false;
                SettingVM.IsVibrate = false;
                Helpers.LocalStorage.GeneralIsNotification = string.Empty;
            }
            else
            {
                SettingVM.IsNotification = true;
                SwtchSound.IsEnabled = true;
                SwtchVibrate.IsEnabled = true;
                Helpers.LocalStorage.GeneralIsNotification = "true";
            }
        }

        /// <summary>
        /// TODO : To Define Event Handler For Sound Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoundSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (SettingVM.IsSound)
            {
                SettingVM.IsSound = false;
                Helpers.LocalStorage.GeneralIsSound = string.Empty;
            }
            else
            {
                SettingVM.IsSound = true;
                Helpers.LocalStorage.GeneralIsSound = "true";
            }
        }

        /// <summary>
        /// TODO : To Define Event Handler For Vibrate Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VibrateSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (SettingVM.IsVibrate)
            {
                SettingVM.IsVibrate = false;
                Helpers.LocalStorage.GeneralIsVibrate = string.Empty;
            }
            else
            {
                SettingVM.IsVibrate = true;
                Helpers.LocalStorage.GeneralIsVibrate = "true";

            }
        }

        /// <summary>
        /// TODO : To Open Terms and Conditions on browser...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpnTerms_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://whyremit.com/terms"));
        }


        /// <summary>
        /// TODO : To Open Privacy Policy on browser...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Privacy_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://whyremit.com/privacy"));
        }

        /// <summary>
        /// TODO : To Open Feedback link on browser...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Feedback_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://whyremit.com/feedback"));
        }


        /// <summary>
        /// TODO : To share...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Share_Tapped(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Title = "My App Data",
                Text = "WhyRemit is the exchange rates app: https://whyremit.com",
            });
        }
        #endregion

    }
}