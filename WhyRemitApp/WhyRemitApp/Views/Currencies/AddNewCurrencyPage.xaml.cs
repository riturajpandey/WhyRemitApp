﻿using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels.Currency;
using WhyRemitApp.Views.Popup;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Currencies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewCurrencyPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        AddNewCurrencyVM AddCurrencyVM;
        public SelectCurrencyPopup CountryPickerPopupVM;
        public AddNewCurrencyPage()
        {
            InitializeComponent();
            AddCurrencyVM = new AddNewCurrencyVM(this.Navigation);
            this.BindingContext = AddCurrencyVM;

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
        }

        /// <summary>
        /// TODO : To Define Event Handler For Rate Switch Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwtchRate_Toggled(object sender, EventArgs e)
        {
            if (AddCurrencyVM.IsBuyRate)
            {
                AddCurrencyVM.IsBuyRate = false;
                AddCurrencyVM.IsSellRate = true;
                AddCurrencyVM.RateImage ="bty1.png";
                AddCurrencyVM.Header = "Maximum rate you are willing to sell";
            }
            else
            {
                AddCurrencyVM.IsBuyRate = true;
                AddCurrencyVM.IsSellRate = false;
                AddCurrencyVM.RateImage = "bty01.png";
                AddCurrencyVM.Header = "Minimum rate you are willing to buy";
            }
        }


        /// <summary>
        /// TODO : To Define Event Handler For Currency Picker Tapped,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void HaveCurrency_Tapped(object sender, EventArgs e)
        {
            CountryPickerPopupVM = new SelectCurrencyPopup(AddCurrencyVM, "Have");
            await Navigation.PushPopupAsync(CountryPickerPopupVM, true);
        }

        /// <summary>
        /// TODO : To Define Event Handler For Currency Picker Tapped,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void NeedCurrency_Tapped(object sender, EventArgs e)
        {
            CountryPickerPopupVM = new SelectCurrencyPopup(AddCurrencyVM, "Need");
            await Navigation.PushPopupAsync(CountryPickerPopupVM, true);
        }

        /// <summary>
        /// TODO : To Define Event Handler For Currency Picker Currency Selected...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PckCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PckCurrency.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(AddCurrencyVM.NeedCurrency))
                {
                    if (AddCurrencyVM.NeedCurrency == PckCurrency.SelectedItem.ToString())
                    {
                        AddCurrencyVM.UserDialog.HideLoading();
                        AddCurrencyVM.UserDialog.Alert("Currency can not be same.", "Alert", "Ok");
                        return;
                    }
                } 
                AddCurrencyVM.HaveCurrency = PckCurrency.SelectedItem.ToString();
            }
        }

        /// <summary>
        /// TODO : To Define Event Handler For Currency Picker Currency Need Selected...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PckCurrencyNeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PckCurrencyNeed.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(AddCurrencyVM.HaveCurrency))
                {
                    if (AddCurrencyVM.HaveCurrency == PckCurrencyNeed.SelectedItem.ToString())
                    {
                        AddCurrencyVM.UserDialog.HideLoading();
                        AddCurrencyVM.UserDialog.Alert("Currency can not be same.", "Alert", "Ok");
                        return;
                    }
                }
                AddCurrencyVM.NeedCurrency = PckCurrencyNeed.SelectedItem.ToString();
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

        ///// <summary>
        ///// TODO : To Define Event Handler For Expiry Tapped,
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Expiry_Tapped(object sender, EventArgs e)
        //{
        //    PckExpiryTime.Focus();
        //}

        ///// <summary>
        ///// TODO : To Define Event Handler For Expiry Tapped...
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void PckExpiryTime_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (PckExpiryTime.SelectedIndex != -1)
        //    {
        //        AddCurrencyVM.ExpireTime = PckExpiryTime.SelectedItem.ToString();
        //    }
        //}
        #endregion 

    }
}