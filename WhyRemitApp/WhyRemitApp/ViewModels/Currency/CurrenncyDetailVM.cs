using Acr.UserDialogs;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels.Currency
{
    public class CurrenncyDetailVM : BaseViewModel
    {
        #region CONSTRUCTOR
        public List<string> ContextMenu = new List<string>();
        public SearchModel Currency;
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenncyDetailVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public CurrenncyDetailVM(INavigation nav)
        {
            Navigation = nav;
            ProfileCommand = new Command(OnProfileAsync);
            SettingCommand = new Command(OnSettingAsync);
            BackCommand = new Command(OnBackAsync);
            ContextMenu.Add("Edit");
            ContextMenu.Add("Delete");
            ContextMenu.Add("Close");
            ContextMenu.Add("SortByName");
            ContextMenu.Add("SortByRate");
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command BackCommand { get; set; }
        public Command ProfileCommand { get; set; }
        public Command SettingCommand { get; set; }
        #endregion

        #region PROPERTIES  

        private ObservableCollection<MatchesModel> _CurrencyModelList;
        public ObservableCollection<MatchesModel> CurrencyMatchesList
        {
            get { return _CurrencyModelList; }
            set
            {
                if (_CurrencyModelList != value)
                {
                    _CurrencyModelList = value;
                    OnPropertyChanged("CurrencyMatchesList");
                }
            }
        }


        private string _CurrencyName = "GPB - NGN";
        public string CurrencyName
        {
            get { return _CurrencyName; }
            set
            {
                if (_CurrencyName != value)
                {
                    _CurrencyName = value;
                    OnPropertyChanged("CurrencyName");
                }
            }
        }
        private string _CreatedOn = "12/12/2019 10:00 AM";
        public string CreatedOn
        {
            get { return _CreatedOn; }
            set
            {
                if (_CreatedOn != value)
                {
                    _CreatedOn = value;
                    OnPropertyChanged("CreatedOn");
                }
            }
        }

        private string _ExpiresOn = "12/12/2019 10:00 AM";
        public string ExpiresOn
        {
            get { return _ExpiresOn; }
            set
            {
                if (_ExpiresOn != value)
                {
                    _ExpiresOn = value;
                    OnPropertyChanged("ExpiresOn");
                }
            }
        }
        private string _MatchesCount = "4 Matches";
        public string MatchesCount
        {
            get { return _MatchesCount; }
            set
            {
                if (_MatchesCount != value)
                {
                    _MatchesCount = value;
                    OnPropertyChanged("MatchesCount");
                }
            }
        }
        private string _BestRate = "500,000";
        public string BestRate
        {
            get { return _BestRate; }
            set
            {
                if (_BestRate != value)
                {
                    _BestRate = value;
                    OnPropertyChanged("BestRate");
                }
            }
        }
        private string _MinRate = "500,000";
        public string MinRate
        {
            get { return _MinRate; }
            set
            {
                if (_MinRate != value)
                {
                    _MinRate = value;
                    OnPropertyChanged("MinRate");
                }
            }
        }
        private string _RateHeader ;
        public string RateHeader
        {
            get { return _RateHeader; }
            set
            {
                if (_RateHeader != value)
                {
                    _RateHeader = value;
                    OnPropertyChanged("RateHeader");
                }
            }
        }
        
        #endregion

        #region Methods 

        /// <summary>
        /// TODO : To navigate Back...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnBackAsync(object obj)
        {
            await Navigation.PopModalAsync();
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
        public async Task GetCurrencyDetailsList()
        {
            if (Currency.buyorsell == "B")
                RateHeader = "Minimum Buy Rate";
            else
                RateHeader = "Maximum Sell Rate";

            CurrencyName = Currency.CurrencyName;
            CreatedOn = "Expires in " + Currency.expiryminutes + " minutes";
            string[] obj = Currency.bestrate.Split('.');
            BestRate = obj[0];
            string[] objj = Currency.rate.Split('.');
            MinRate = objj[0]; 
            MatchesCount = CurrencyMatchesList.Count.ToString() + " Matches";
        }

        /// <summary>
        /// To perform Delete, Close Action on Search...
        /// </summary>
        /// <returns></returns>
        public async Task PerformActionOnSearches(string action)
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Please Wait…", MaskType.Clear);
                if (CrossConnectivity.Current.IsConnected)
                {
                    await Task.Run(async () =>
                    {

                        if (_businessCode != null)
                        {
                            await _businessCode.SearchRespondApi(new SearchRespondRequestModel()
                            {
                                profiletoken = Helpers.LocalStorage.GeneralProfileToken,
                                requestnumber = Currency.requestnumber,
                                action = action,
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as ResendTokenResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        if (action == "C")
                                            UserDialog.Alert("Search closed successfully.", "", "Ok");
                                        else
                                            UserDialog.Alert("Search deleted successfully.", "", "Ok");
                                        await Navigation.PopModalAsync();
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
                    UserDialogs.Instance.Loading().Hide();
                    await UserDialogs.Instance.AlertAsync("No Network Connection found, Please try again!", "", "Okay");
                }
            }
            catch (Exception ex)
            {
                UserDialog.HideLoading();
            }

        }

        /// <summary>
        /// To Get The List Of Matches...
        /// </summary>
        /// <returns></returns>
        public async Task GetMatchesList()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Please Wait…", MaskType.Clear);
                if (CrossConnectivity.Current.IsConnected)
                {
                    await Task.Run(async () =>
                    {

                        if (_businessCode != null)
                        {
                            await _businessCode.MatchesApi(new MatchesRequestModel()
                            {
                                profiletoken = Helpers.LocalStorage.GeneralProfileToken,
                                requestnumber = Currency.requestnumber
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as MatchesResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        CurrencyMatchesList = new ObservableCollection<MatchesModel>(requestList.searches);
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
                    UserDialogs.Instance.Loading().Hide();
                    await UserDialogs.Instance.AlertAsync("No Network Connection found, Please try again!", "", "Okay");
                }
            }
            catch (Exception ex)
            {
                UserDialog.HideLoading();
            }

        }

        /// <summary>
        /// To perform Accept/Reject Action on Search...
        /// </summary>
        /// <returns></returns>
        public async Task PerformActionOnMatches(string action, string matchnum)
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Please Wait…", MaskType.Clear);
                if (CrossConnectivity.Current.IsConnected)
                {
                    await Task.Run(async () =>
                    {

                        if (_businessCode != null)
                        {
                            await _businessCode.MatchesRespondApi(new MatchesRespondRequestModel()
                            {
                                profiletoken = Helpers.LocalStorage.GeneralProfileToken,
                                requestnumber = Currency.requestnumber,
                                action = action,
                                matchnumber = matchnum.ToString(),
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as ResendTokenResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading(); 
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
                    UserDialogs.Instance.Loading().Hide();
                    await UserDialogs.Instance.AlertAsync("No Network Connection found, Please try again!", "", "Okay");
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

