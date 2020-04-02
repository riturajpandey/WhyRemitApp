using Acr.UserDialogs;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels.Registration
{
    public class ConfirmNumberPageVM : BaseViewModel
    {
        //TODO : To Declare Local Class Level Variables..
        private const string _Name = @"^[a-zA-Z]+$";

        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmNumberPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public ConfirmNumberPageVM(INavigation nav)
        {
            Navigation = nav;
            ConfirmCommand = new Command(SignUpAsync);
            ResendCodeCommand = new Command(ResendCodeAsync);
            Mobileno = Helpers.Constants.MobileNumber;
        }

        #endregion

        #region COMMAND 
        public Command ConfirmCommand { get; set; }
        public Command ResendCodeCommand { get; set; }
        #endregion

        #region PROPERTIES 

        private string _OTP;
        public string OTP
        {
            get { return _OTP; }
            set
            {
                if (_OTP != value)
                {
                    _OTP = value;
                    OnPropertyChanged("OTP");
                }
            }
        }
        private string _Mobileno ;
        public string Mobileno
        {
            get { return _Mobileno; }
            set
            {
                if (_Mobileno != value)
                {
                    _Mobileno = value;
                    OnPropertyChanged("Mobileno");
                }
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Go To User Sign Up Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void SignUpAsync(object obj)
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
                        if (_businessCode != null)
                        {
                            await _businessCode.ProfileVerifyApi(new ProfileVerifyRequestModel()
                            {
                                profiletoken = Helpers.Constants.Token,
                                validatetoken = OTP,
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as ProfileVerifyResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        Helpers.LocalStorage.GeneralSecretkey = requestList.secretkey;
                                        Helpers.LocalStorage.GeneralProfileToken = Helpers.Constants.Token;
                                        Helpers.LocalStorage.GeneralIsNotification = "true";
                                        Helpers.LocalStorage.GeneralIsSound = "true";
                                        Helpers.LocalStorage.GeneralIsVibrate = "true";
                                        //Navigate To Currency Page...
                                        App.Current.MainPage = new Views.Currencies.CurrencyPage(); 
                                    }
                                });
                            }, (objj) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objj as ProfileVerifyResponseModel);
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
        /// TODO : To Perform Resend Code Operation...
        /// </summary>
        /// <param name="obj"></param>
        private async void ResendCodeAsync(object obj)
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
                            await _businessCode.ProfileResendCodeApi(new ProfileRequestModel()
                            {
                                profiletoken = Helpers.Constants.Token
                            }, async (objs) =>
                            {
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    var requestList = (objs as ResendTokenResponseModel);
                                    if (requestList != null)
                                    {
                                        UserDialog.HideLoading();
                                        UserDialogs.Instance.Alert(requestList.responsemessage, "", "ok");
                                        Xamarin.Forms.MessagingCenter.Send<string>("", "StartCountDown");
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
        /// To Validate all User Input Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            if (string.IsNullOrEmpty(OTP))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter the 6 digit code sent to your mobile number.", "", "Ok");
                return false;
            }
            if (OTP.Length < 6)
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Invalid 6 digit code.", "", "Ok");
                return false;
            }
            return true;
        }
        #endregion
    }
}
