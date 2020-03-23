using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        //TODO : To Define class Level Variables...
        ProfilePageVM ProfileVM;
         
        public ProfilePage()
        {
            InitializeComponent();
            ProfileVM = new ProfilePageVM(this.Navigation);
            this.BindingContext = ProfileVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            //To Show Profile Pic
            MessagingCenter.Subscribe<string>("", "LoadImage", (sender) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(ProfileVM.UserProfileBase64))
                        {
                            imgUserProfile.Aspect = Aspect.AspectFill;
                            imgUserProfile.Source = Helpers.Constants.ImgFilePath;
                            ProfileVM.IsCamera = false;
                        }
                    }
                    catch (Exception)
                    { }
                });
            });

            //To Show Profile Pic
            MessagingCenter.Subscribe<string>("", "LoadApiImage", (sender) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(ProfileVM.UserProfileBase64))
                        {
                            imgUserProfile.Aspect = Aspect.AspectFill;
                            imgUserProfile.Source = Utilities.Utility.GetImageFromBase64(ProfileVM.UserProfileBase64);
                        }
                    }
                    catch (Exception)
                    { }
                });
            });
        }
        #region Event Handlers 

        /// <summary>
        /// TODO : To Define On Page Appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ProfileVM.GetProfileData();
        }

        /// <summary>
        /// TODO : To Define Event Handler For Media Picker Tapped...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediaPicker_Tapped(object sender, EventArgs e)
        {
            ProfileVM.OnMediaAsync();
        } 
        #endregion
    }
}