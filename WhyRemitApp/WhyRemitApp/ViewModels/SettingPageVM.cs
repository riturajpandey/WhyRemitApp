using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels
{
    public class SettingPageVM : BaseViewModel
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public SettingPageVM(INavigation nav)
        {
            Navigation = nav;
            CurrencyCommand = new Command(OnCurrencyAsync);
            ProfileCommand= new Command(OnProfileAsync);
            ShareCommand= new Command(OnShareAsync);
            AboutUsCommand= new Command(OnAboutUsAsync);
            PrivacyPolicyCommand= new Command(OnPrivacyAsync);
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command CurrencyCommand { get; set; }
        public Command ProfileCommand { get; set; }
        public Command ShareCommand { get; set; }
        public Command AboutUsCommand { get; set; }
        public Command PrivacyPolicyCommand { get; set; }
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
        private string _Version = " Version 123456.123";
        public string Version
        {
            get { return _Version; }
            set
            {
                if (_Version != value)
                {
                    _Version = value;
                    OnPropertyChanged("Version");
                }
            }
        }

        private bool _IsNotificationOn  = true;
        public bool IsNotificationOn
        {
            get { return _IsNotificationOn; }
            set
            {
                if (_IsNotificationOn != value)
                {
                    _IsNotificationOn = value;
                    OnPropertyChanged("IsNotificationOn");
                }
            }
        }

        private bool _IsSoundOn = true;
        public bool IsSoundOn
        {
            get { return _IsSoundOn; }
            set
            {
                if (_IsSoundOn != value)
                {
                    _IsSoundOn = value;
                    OnPropertyChanged("IsSoundOn");
                }
            }
        }

        private bool _IsVibrateOn = true;
        public bool IsVibrateOn
        {
            get { return _IsVibrateOn; }
            set
            {
                if (_IsVibrateOn != value)
                {
                    _IsVibrateOn = value;
                    OnPropertyChanged("IsVibrateOn");
                }
            }
        }

        public bool IsNotification = false;
        public bool IsSound = false;
        public bool IsVibrate = false;

        #endregion

        #region Methods 

        /// <summary>
        /// TODO : To navigate To Currency Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnCurrencyAsync(object obj)
        {
            App.Current.MainPage = new Views.Currencies.CurrencyPage();
        }

        /// <summary>
        /// TODO : To navigate To Profile Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnProfileAsync(object obj)
        {
            App.Current.MainPage = new Views.Profile.ProfilePage();
        }
        /// <summary>
        /// TODO : To Get Settings Details...
        /// </summary>
        public async Task GetSettings()
        {
        }

        /// <summary>
        /// TODO : To Share ...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnShareAsync(object obj)
        {
            
        }

        /// <summary>
        /// TODO : To Show About Us...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnAboutUsAsync(object obj)
        {

        }

        /// <summary>
        /// TODO : To Show Privacy Polcicy...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnPrivacyAsync(object obj)
        {

        }
        #endregion 
    }
}
