using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels.Currency
{
    public class CurrencyPageVM : BaseViewModel
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public CurrencyPageVM(INavigation nav)
        {
            Navigation = nav;
            ProfileCommand = new Command(OnProfileAsync);
            SettingCommand = new Command(OnSettingAsync);
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command ProfileCommand { get; set; }
        public Command SettingCommand { get; set; }
        #endregion

        #region PROPERTIES 
         
        private ObservableCollection<IndicatorModel> _IndicatorList;
        public ObservableCollection<IndicatorModel> IndicatorList
        {
            get { return _IndicatorList; }
            set
            {
                if (_IndicatorList != value)
                {
                    _IndicatorList = value;
                    OnPropertyChanged("IndicatorList");
                }
            }
        }
        #endregion

        #region Methods 

        /// <summary>
        /// TODO : To navigate To Profile Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnProfileAsync(object obj)
        {
            App.Current.MainPage = new Views.Profile.ProfilePage();
        }

        /// <summary>
        /// TODO : To navigate To Setting Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnSettingAsync(object obj)
        {
            App.Current.MainPage = new Views.Settings.SettingsPage();
        }

        /// <summary>
        /// TODO : To Get LoginHistory Details List...
        /// </summary>
        public async Task GetIntroductionList()
        { 
        }
        #endregion 
    }
}
