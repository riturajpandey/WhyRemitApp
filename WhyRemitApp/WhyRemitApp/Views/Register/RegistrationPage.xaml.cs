using App.User.LocationInfo.Services;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels.Registration;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Register
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        private const string _name3 = @"^[0-9#?!@$%^&*-+_]+$";
        RegistrationPageVM RegistrationVM;
        public RegistrationPage()
        {
            InitializeComponent();
            RegistrationVM = new RegistrationPageVM(this.Navigation);
            this.BindingContext = RegistrationVM;

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
            await RegistrationVM.GetCountriesList();
            if (CrossConnectivity.Current.IsConnected)
            {
                var basic_userlocationInfo = await TrackingService.GetBasicLocatioInfoAsync();
                var countrydetails = RegistrationVM.TempCountryPickerListItem.Where(a => a.CountryISDCode == basic_userlocationInfo.CountryCallingCode).FirstOrDefault();
                RegistrationVM.CountryFlag = countrydetails.CountryFlag;
                RegistrationVM.CountryISDCode = countrydetails.CountryISDCode;
                RegistrationVM.CountryId = countrydetails.Id;
                RegistrationVM.CountryOfResidency = countrydetails.CountryName;
                RegistrationVM.CountryIS03Code = countrydetails.CountryIS03Code;
            }
        }

        /// <summary>
        /// TODO : To Define Event Handler For T&C Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (RegistrationVM.IsAgreedToTC)
                RegistrationVM.IsAgreedToTC = false;
            else
                RegistrationVM.IsAgreedToTC = true;
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

        private void TxtDisplayName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDisplayName.Text))
            {
                var a = TxtDisplayName.Text[TxtDisplayName.Text.Length - 1].ToString();
                bool isValid2 = (Regex.IsMatch(TxtDisplayName.Text[TxtDisplayName.Text.Length - 1].ToString(), _name3, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
                if (isValid2)
                {
                    TxtDisplayName.Text = TxtDisplayName.Text.Remove(TxtDisplayName.Text.Length - 1);
                }
            }
        }
        #endregion 
    }
}