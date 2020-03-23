using Acr.UserDialogs;
using Newtonsoft.Json;
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
    public class CurrencyPageVM : BaseViewModel
    {
        public List<string> ContextMenu = new List<string>();

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
            ContextMenu.Add("Show");
            ContextMenu.Add("Hide");
            ContextMenu.Add("Closed");
            ContextMenu.Add("Order By Currency I Have");
            ContextMenu.Add("Order By Currency I Want");
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command ProfileCommand { get; set; }
        public Command SettingCommand { get; set; }
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
            if (!string.IsNullOrEmpty(Helpers.LocalStorage.GeneralSearches))
            {
                var a = Helpers.LocalStorage.GeneralSearches;
                var searchDetail = JsonConvert.DeserializeObject<SearchResponseModel>(a);
                if (searchDetail.searches != null)
                    CurrencyModelList = new ObservableCollection<SearchModel>(searchDetail.searches);
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
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        CurrencyModelList = new ObservableCollection<SearchModel>(requestList.searches);
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
        /// TODO : To Get Profile Details List...
        /// </summary>
        public async Task GetProfileData()
        {
            try
            {
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
