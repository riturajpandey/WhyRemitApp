using Acr.UserDialogs;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Model;
using WhyRemitApp.Models;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels.Currency
{
    public class AddNewCurrencyVM : BaseViewModel
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewCurrencyVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public AddNewCurrencyVM(INavigation nav)
        {
            Navigation = nav;
            BackCommand = new Command(OnBackAsync);
            SearchCommand = new Command(OnSearchAsync);
            CurrencyList = new ObservableCollection<CountryPickerModel>(CountryPickerModel.CurrencyPickerData());
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command BackCommand { get; set; }
        public Command SearchCommand { get; set; }
        #endregion

        #region PROPERTIES 
        private string _Header = "Minimum rate you are willing to buy";
        public string Header
        {
            get { return _Header; }
            set
            {
                if (_Header != value)
                {
                    _Header = value;
                    OnPropertyChanged("Header");
                }
            }
        }
        private string _HaveCurrency;
        public string HaveCurrency
        {
            get { return _HaveCurrency; }
            set
            {
                if (_HaveCurrency != value)
                {
                    _HaveCurrency = value;
                    OnPropertyChanged("HaveCurrency");
                }
            }
        }
        private string _NeedCurrency;
        public string NeedCurrency
        {
            get { return _NeedCurrency; }
            set
            {
                if (_NeedCurrency != value)
                {
                    _NeedCurrency = value;
                    OnPropertyChanged("NeedCurrency");
                }
            }
        }
        public string NeedCurrencyCode;
        public string HaveCurrencyCode;

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
        private string _CreatedOn = "17 Dec 2018, at 10:00 AM";
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
        private string _BuyRate;
        public string BuyRate
        {
            get { return _BuyRate; }
            set
            {
                if (_BuyRate != value)
                {
                    _BuyRate = value;
                    OnPropertyChanged("BuyRate");
                }
            }
        }
        private string _SellRate;
        public string SellRate
        {
            get { return _SellRate; }
            set
            {
                if (_SellRate != value)
                {
                    _SellRate = value;
                    OnPropertyChanged("SellRate");
                }
            }
        }
        private string _RateImage = "bty01.png";
        public string RateImage
        {
            get { return _RateImage; }
            set
            {
                if (_RateImage != value)
                {
                    _RateImage = value;
                    OnPropertyChanged("RateImage");
                }
            }
        }
        private bool _IsBuyRate = true;
        public bool IsBuyRate
        {
            get { return _IsBuyRate; }
            set
            {
                if (_IsBuyRate != value)
                {
                    _IsBuyRate = value;
                    OnPropertyChanged("IsBuyRate");
                }
            }
        }
        private bool _IsSellRate;
        public bool IsSellRate
        {
            get { return _IsSellRate; }
            set
            {
                if (_IsSellRate != value)
                {
                    _IsSellRate = value;
                    OnPropertyChanged("IsSellRate");
                }
            }
        }
        private string _ExpireTime;
        public string ExpireTime
        {
            get { return _ExpireTime; }
            set
            {
                if (_ExpireTime != value)
                {
                    _ExpireTime = value;
                    OnPropertyChanged("ExpireTime");
                }
            }
        }
        private ObservableCollection<CountryPickerModel> _CountryList;
        public ObservableCollection<CountryPickerModel> CurrencyList
        {
            get { return _CountryList; }
            set
            {
                if (_CountryList != value)
                {
                    _CountryList = value;
                    OnPropertyChanged("CurrencyList");
                }
            }
        }
        #endregion

        #region Methods 

        public void HaveCurrencySelected(string currency)
        {
            if (!string.IsNullOrEmpty(NeedCurrency))
            {
                if (NeedCurrency == currency)
                {
                    UserDialog.HideLoading();
                    UserDialog.Alert("Currency can not be same.", "", "Ok");
                    return;
                }
            }
            HaveCurrency = currency;
        }


        public void NeedCurrencySelected(string currency)
        {
            if (!string.IsNullOrEmpty(currency))
            {
                if (HaveCurrency == currency)
                {
                    UserDialog.HideLoading();
                    UserDialog.Alert("Currency can not be same.", "", "Ok");
                    return;
                }
            }
            NeedCurrency = currency;
        }

        /// <summary>
        /// TODO : To navigate Back...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnBackAsync(object obj)
        {
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// TODO : To Call Search Currecny Api...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnSearchAsync(object obj)
        {
            //Apply Validations..
            if (!await Validate()) return;

            try
            {
                UserDialogs.Instance.ShowLoading("Please Wait…", MaskType.Clear);
                if (CrossConnectivity.Current.IsConnected)
                {
                    await Task.Run(async () =>
                    {
                        string buyORell = string.Empty;
                        string rate = string.Empty;
                        if (IsBuyRate)
                        {
                            buyORell = "B";
                            rate = BuyRate;
                        }
                        else
                        {
                            buyORell = "S";
                            rate = SellRate;
                        }
                        if (_businessCode != null)
                        {
                            string time = ExpireTime;
                            if (ExpireTime == "1 Hour")
                                time = "1H";
                            else if (ExpireTime == "12 Hours")
                                time = "12H";
                            else if (ExpireTime == "24 Hours")
                                time = "24H";
                            else if (ExpireTime == "3 Days")
                                time = "3D";
                            else if (ExpireTime == "7 Days")
                                time = "7D";

                            await _businessCode.SearchSaveApi(new SearchSaveRequestModel()
                            {
                                profiletoken = Helpers.LocalStorage.GeneralProfileToken,
                                buycurrencycode = NeedCurrency,
                                sellcurrencycode = HaveCurrency,
                                buyorsell = buyORell,
                                duration = time,
                                rate = rate,
                                requestnumber = string.Empty
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as SearchSaveResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        //Navigate To Currency Page...
                                        UserDialogs.Instance.Alert(requestList.responsemessage, "", "Ok");
                                        await Navigation.PopModalAsync();
                                    }
                                });
                            }, (objj) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (obj as ResendTokenResponseModel);
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
        /// TODO : To Get Currency Details List...
        /// </summary>
        public async Task GetCurrencyInfo()
        {
        }

        /// <summary>
        /// To Validate all User Input Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            UserDialog.ShowLoading();
            if (string.IsNullOrEmpty(HaveCurrency))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please select currency you have.", "", "Ok");
                return false;
            }
            if (string.IsNullOrEmpty(NeedCurrency))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please select currency you need.", "", "Ok");
                return false;
            }
            if (IsBuyRate)
            {
                if (string.IsNullOrEmpty(BuyRate))
                {
                    UserDialog.HideLoading();
                    UserDialog.Alert("Please enter buy rate.", "", "Ok");
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(SellRate))
                {
                    UserDialog.HideLoading();
                    UserDialog.Alert("Please enter sell rate.", "", "Ok");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(ExpireTime))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter expire time.", "", "Ok");
                return false;
            }
            UserDialog.HideLoading();
            return true;
        }
        #endregion
    }
}
