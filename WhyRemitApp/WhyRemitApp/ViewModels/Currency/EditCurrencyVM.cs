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
    public class EditCurrencyVM : BaseViewModel
    {
        //TO Define Local Variables...
        public SearchModel Currency;

        #region CONSTRUCTOR 
        /// <summary>
        /// Initializes a new instance of the <see cref="EditCurrencyVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public EditCurrencyVM(INavigation nav)
        {
            Navigation = nav;
            BackCommand = new Command(OnBackAsync);
            UpdateCommand = new Command(OnUpdateAsync);
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command BackCommand { get; set; }
        public Command UpdateCommand { get; set; }
        #endregion

        #region PROPERTIES 
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
        private string _ExpireTime = "24H";
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
        /// TODO : To Call Update Currecny Api...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnUpdateAsync(object obj)
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
                            //string time = ExpireTime;
                            //if (ExpireTime == "1 Hour")
                            //    time = "1H";
                            //else if (ExpireTime == "12 Hours")
                            //    time = "12H";
                            //else if (ExpireTime == "24 Hours")
                            //    time = "24H";
                            //else if (ExpireTime == "3 Days")
                            //    time = "3D";
                            //else if (ExpireTime == "7 Days")
                            //    time = "7D";

                            await _businessCode.SearchSaveApi(new SearchSaveRequestModel()
                            {
                                profiletoken = Helpers.LocalStorage.GeneralProfileToken,
                                buycurrencycode = Currency.currencybuy,
                                sellcurrencycode = Currency.currencysell,
                                buyorsell = buyORell,
                                duration = ExpireTime,
                                rate = rate,
                                requestnumber = Currency.requestnumber
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as SearchSaveResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        //Navigate To Currency Page...
                                        var alertConfig = new AlertConfig
                                        {
                                            Title = "Alert",
                                            Message = "The search has updated. We will continue to update you of matches before the expiry time.",
                                            OkText = "OK",
                                            OnAction = async () =>
                                            {
                                                await Navigation.PopModalAsync();
                                            }
                                        };
                                        UserDialogs.Instance.Alert(alertConfig);

                                        //UserDialogs.Instance.Alert(requestList.responsemessage, "", "Ok");
                                        //await Navigation.PopModalAsync();
                                    }
                                });
                            }, (objj) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (obj as SearchSaveResponseModel);
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
            CurrencyName = Currency.CurrencyName;
            CreatedOn = Currency.datecreated; 
            string[] rate = Currency.rate.Split('.'); 

            if (IsBuyRate)
                BuyRate = rate[0];
            else
                SellRate = rate[0];
        }

        /// <summary>
        /// To Validate all User Input Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            UserDialog.ShowLoading();

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
