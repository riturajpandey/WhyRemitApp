﻿using System;
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
    public partial class CurrencyPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        CurrencyPageVM CurrencyVM;
        PopupMenu Popup;

        public CurrencyPage()
        {
            InitializeComponent();
            CurrencyVM = new CurrencyPageVM(this.Navigation);
            this.BindingContext = CurrencyVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region EVENTHANDLER
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            BtnNewCurrency.IsEnabled = true;
            CurrencyVM.IsPageEnabled = true;
            await CurrencyVM.CallCurrenctList();
            await CurrencyVM.GetProfileData();
        }

        /// <summary>
        /// TODO : To Go To Currency Detail Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Currency_Tapped(object sender, EventArgs e)
        {
            BtnNewCurrency.IsEnabled = false;
            CurrencyVM.IsPageEnabled = false;
            var item = (sender as Grid).BindingContext as SearchModel;
            if (item != null)
                this.Navigation.PushModalAsync(new Views.Currencies.CurrenncyDetailPagexaml(item));
        }

        /// <summary>
        /// TODO : To Go To Add New Currency Page...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddNewCurrency_Tapped(object sender, EventArgs e)
        {
            BtnNewCurrency.IsEnabled = false;
            CurrencyVM.IsPageEnabled = false;
            await Navigation.PushModalAsync(new Views.Currencies.AddNewCurrencyPage());
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
            if (item == "Show")
            { }
            if (item == "Hide")
            { }
            if (item == "Closed")
            { }
            if (item == "Order By Currency I Have")
            { }
            if (item == "Order By Currency I Want")
            { }
        } 
        #endregion
    }
}