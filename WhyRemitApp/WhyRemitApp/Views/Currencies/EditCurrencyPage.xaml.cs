using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
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
        SearchModel Currency;

        public EditCurrencyPage(SearchModel currency)
        {
            InitializeComponent();
            EditCurrencyVM = new EditCurrencyVM(this.Navigation);
            this.BindingContext = EditCurrencyVM;
            Currency = currency;
            EditCurrencyVM.Currency = currency;

            if (currency.buyorsell == "S")
            {
                EditCurrencyVM.IsSellRate = true;
                EditCurrencyVM.IsBuyRate = false;
                EditCurrencyVM.RateImage = "bty1.png";
                EditCurrencyVM.Header = "Maximum rate you are willing to sell";
            }

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
            await EditCurrencyVM.GetCurrencyInfo();
        }

        /// <summary>
        /// TODO : To Define Event Handler For Rate Switch Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwtchRate_Toggled(object sender, EventArgs e)
        {
            if (EditCurrencyVM.IsBuyRate)
            {
                EditCurrencyVM.IsBuyRate = false;
                EditCurrencyVM.IsSellRate = true;
                EditCurrencyVM.RateImage = "bty1.png";
                EditCurrencyVM.Header = "Maximum rate you are willing to sell";
            }
            else
            {
                EditCurrencyVM.IsBuyRate = true;
                EditCurrencyVM.IsSellRate = false;
                EditCurrencyVM.RateImage = "bty01.png";
                EditCurrencyVM.Header = "Minimum rate you are willing to buy";
            }
        }

        /// <summary>
        /// TODO : To Define Event Handler For Expiry Tapped,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Expiry_Tapped(object sender, EventArgs e)
        {
            PckExpiryTime.Focus();
        }

        /// <summary>
        /// TODO : To Define Event Handler For Expiry Tapped...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PckExpiryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PckExpiryTime.SelectedIndex != -1)
            {
                EditCurrencyVM.ExpireTime = PckExpiryTime.SelectedItem.ToString();
            }
        }
        #endregion 
    }
}