﻿using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using WhyRemitApp.ViewModels.Currency;
using Xam.Plugin;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Currencies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrenncyDetailPagexaml : ContentPage
    {
        //TODO : To Define class Level Variables...
        CurrenncyDetailVM CurrencyVM;
        PopupMenu Popup;
        SearchModel Currency;
        public CurrenncyDetailPagexaml(SearchModel currency)
        {
            InitializeComponent();
            CurrencyVM = new CurrenncyDetailVM(this.Navigation);
            this.BindingContext = CurrencyVM;
            Currency = currency;
            CurrencyVM.Currency = currency;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region EVENTHANDLER
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await CurrencyVM.GetMatchesList();
            await CurrencyVM.GetCurrencyDetailsList();
        }

        /// <summary>
        /// TODO : To Delete The Item...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Delete_Tapped(object sender, EventArgs e)
        {
            var item = (sender as Grid).BindingContext as MatchesModel;
            if (item != null)
            {
                //To Delete The Item...
                await CurrencyVM.PerformActionOnMatches("R", item.matchnumber);
                UserDialogs.Instance.Alert("Match rejected.", "Alert", "Ok");
                await CurrencyVM.GetCurrencyDetailsList();
            }
        }
        
        /// <summary>
        /// TODO : To Approve The Item...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Approve_Tapped(object sender, EventArgs e)
        {
            var item = (sender as Grid).BindingContext as MatchesModel;
            if (item != null)
            {
                //To Approve The Item...
                await CurrencyVM.PerformActionOnMatches("A",item.matchnumber);
                UserDialogs.Instance.Alert("Match accepted.", "Alert", "Ok");
                await CurrencyVM.GetCurrencyDetailsList();
            }
        }
        private void More_Tapped(object sender, EventArgs e)
        {
            Popup = new PopupMenu()
            {
                BindingContext = CurrencyVM.ContextMenu,
            };

            //Popup.SetBinding(PopupMenu.ItemsSourceProperty, "ContextMenu");
            Popup.ItemsSource = CurrencyVM.ContextMenu;
            Popup.ShowPopup(sender as Grid);
            Popup.OnItemSelected += popup_onitemselected;
        }
        private async void popup_onitemselected(string item)
        {
            if (item == "Edit")
            {
                await this.Navigation.PushModalAsync(new EditCurrencyPage(Currency));
            }
            if (item == "Delete")
            {
                var result = await UserDialogs.Instance.ConfirmAsync("Are you sure you want to delete the exchange?", null, "YES", "NO");
                var text = (result ? "YES" : "NO");
                if (text == "NO")
                { }
                else
                {
                    //To Delete The Item... 
                    await CurrencyVM.PerformActionOnSearches("D");
                }
            }
            if (item == "Close")
            { await CurrencyVM.PerformActionOnSearches("C"); }
            if (item == "SortByName")
            { }
            if (item == "SortByRate")
            { }
        }
       
        #endregion 
    }
}