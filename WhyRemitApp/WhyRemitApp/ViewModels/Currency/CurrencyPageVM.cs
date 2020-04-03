using Acr.UserDialogs;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using WhyRemitApp.Views.Currencies;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels.Currency
{
    public class CurrencyPageVM : BaseViewModel
    {
        public List<string> ContextMenu = new List<string>();
        public SearchModel Currency;
        public ObservableCollection<SearchModel> AllCurrencyList = new ObservableCollection<SearchModel>();

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
            //MoreCommand = new Command(OnMoreAsync);
             
            int minutes = 1438;
            var time = TimeSpan.FromMinutes(minutes);
            string hour = string.Format("{0:00}", (int)time.TotalHours);
            string min = string.Format("{0:00}", (int)time.Minutes);

            int totalHours = Convert.ToInt32(hour);
            int totalMinutes = Convert.ToInt32(min);

            double days = minutes / 60 / 24;
            double hours = (minutes - days * 24 * 60) / 60;
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command ProfileCommand { get; set; }
        public Command SettingCommand { get; set; }
        //public DelegateCommand MoreCommand { get; set; }
        #endregion

        #region PROPERTIES 

        private ObservableCollection<SearchModel> _CurrencyModelList;
        public ObservableCollection<SearchModel> CurrencyModelList
        {
            get { return _CurrencyModelList; }
            set
            {
                if (_CurrencyModelList != value)
                {
                    _CurrencyModelList = value;
                    OnPropertyChanged("CurrencyModelList");
                }
            }
        }

        private bool _IsPageEnabled = true;
        public bool IsPageEnabled
        {
            get { return _IsPageEnabled; }
            set
            {
                if (_IsPageEnabled != value)
                {
                    _IsPageEnabled = value;
                    OnPropertyChanged("IsPageEnabled");
                }
            }
        }

        private bool _IsCurrencyAvailable = false;
        public bool IsCurrencyAvailable
        {
            get { return _IsCurrencyAvailable; }
            set
            {
                if (_IsCurrencyAvailable != value)
                {
                    _IsCurrencyAvailable = value;
                    OnPropertyChanged("IsCurrencyAvailable");
                }
            }
        }

        private bool _IsCurrencyNotAvailable = true;
        public bool IsCurrencyNotAvailable
        {
            get { return _IsCurrencyNotAvailable; }
            set
            {
                if (_IsCurrencyNotAvailable != value)
                {
                    _IsCurrencyNotAvailable = value;
                    OnPropertyChanged("IsCurrencyNotAvailable");
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
        /// To Get The List Of Currency
        /// </summary>
        /// <returns></returns>
        public async Task CallCurrenctList()
        {
            ContextMenu = new List<string>();
            ContextMenu.Add("Show Closed");
            ContextMenu.Add("Order By Most Recent");
            ContextMenu.Add("Order By Currency I Have");
            ContextMenu.Add("Order By Currency I Need");

            if (!string.IsNullOrEmpty(Helpers.LocalStorage.GeneralSearches))
            {
                var a = Helpers.LocalStorage.GeneralSearches;
                var searchDetail = JsonConvert.DeserializeObject<SearchResponseModel>(a);
                if (searchDetail.searches != null)
                {
                    //var activeSearches = AllCurrencyList.Where(c => c.statuscode != "CLOSED").ToList();
                    //CurrencyModelList = new ObservableCollection<SearchModel>(activeSearches);
                    if (searchDetail.searches.Count != 0)
                    {
                        UserDialog.HideLoading();
                        AllCurrencyList = new ObservableCollection<SearchModel>(searchDetail.searches);
                        var activeSearches = AllCurrencyList.Where(c => c.statuscode != "CLOSED").ToList();
                        CurrencyModelList = new ObservableCollection<SearchModel>(activeSearches);

                        IsCurrencyAvailable = true;
                        IsCurrencyNotAvailable = false;
                    }
                    else
                    {
                        UserDialog.HideLoading();
                        IsCurrencyAvailable = false;
                        IsCurrencyNotAvailable = true;
                    }
                }
            }
            try
            {
                if (string.IsNullOrEmpty(Helpers.LocalStorage.GeneralSearches))
                    UserDialogs.Instance.ShowLoading("Please Wait…", MaskType.Clear);
                if (CrossConnectivity.Current.IsConnected)
                {
                    await Task.Run(async () =>
                    {

                        if (_businessCode != null)
                        {
                            await _businessCode.SearchesApi(new ProfileRequestModel()
                            {
                                profiletoken = Helpers.LocalStorage.GeneralProfileToken,
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as SearchResponseModel);
                                    if (requestList.searches.Count != 0)
                                    {
                                        UserDialog.HideLoading();
                                        AllCurrencyList = new ObservableCollection<SearchModel>(requestList.searches);
                                        var activeSearches = AllCurrencyList.Where(c => c.statuscode != "CLOSED").ToList();
                                        CurrencyModelList = new ObservableCollection<SearchModel>(activeSearches);

                                        IsCurrencyAvailable = true;
                                        IsCurrencyNotAvailable = false;
                                    }
                                    else
                                    {
                                        UserDialog.HideLoading();
                                        IsCurrencyAvailable = false;
                                        IsCurrencyNotAvailable = true;
                                    }
                                });
                            }, (objj) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objj as ResendTokenResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        UserDialogs.Instance.Alert(requestList.responsemessage, "", "ok");
                                    }
                                });
                            });
                        }
                    }).ConfigureAwait(false);
                }
                else
                {
                    //UserDialogs.Instance.Loading().Hide();
                    //await UserDialogs.Instance.AlertAsync("No Network Connection found, Please try again!", "", "Okay");
                }
            }
            catch (Exception ex)
            {
                UserDialog.HideLoading();
            }
        }

        /// <summary>
        /// TODO : To Get Profile Details List...
        /// </summary>
        public async Task GetProfileData()
        {
            try
            {
                if (!string.IsNullOrEmpty(Helpers.LocalStorage.GeneralSearches))
                { }
                if (CrossConnectivity.Current.IsConnected)
                {
                    await Task.Run(async () =>
                    {
                        if (_businessCode != null)
                        {
                            await _businessCode.ProfileGetApi(new ProfileRequestModel()
                            {
                                profiletoken = Helpers.LocalStorage.GeneralProfileToken
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as ProfileDetailsResponseModel);
                                    if (requestList != null)
                                    { }
                                });
                            }, (objj) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objj as RegisterProfileResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        UserDialogs.Instance.Alert(requestList.responsemessage, "", "ok");
                                    }
                                });
                            });
                        }
                    }).ConfigureAwait(false);
                }
                else
                {
                    //UserDialogs.Instance.Loading().Hide();
                    //await UserDialogs.Instance.AlertAsync("No Network Connection found, Please try again!", "", "Okay");
                }
            }
            catch (Exception ex)
            {
                UserDialog.HideLoading();
            }
        }
        #endregion
    }
}
