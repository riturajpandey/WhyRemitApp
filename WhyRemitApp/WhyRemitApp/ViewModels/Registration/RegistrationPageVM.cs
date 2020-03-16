using Acr.UserDialogs;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WhyRemitApp.Interfaces;
using WhyRemitApp.Model;
using WhyRemitApp.Views;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels.Registration
{ 
    public class RegistrationPageVM : BaseViewModel
    {
        //TODO : To Declare Local Class Level Variables..
        private const string _Name = @"^[a-zA-Z]+$";
        private const string _Phone = @"^[0-9]*$";
        public CountryPickerPopup CountryPickerPopupVM;

        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public RegistrationPageVM(INavigation nav)
        {
            Navigation = nav;
            ContinueCommand = new Command(SignUpAsync); 
            OpenCountryPickerCommand = new Command(CountryPickerAsync); 
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command ContinueCommand { get; set; }
        public Command OpenCountryPickerCommand { get; set; }
        #endregion

        #region PROPERTIES 
        private ObservableCollection<CountryPickerModel> _CountryPickerListItem;
        public ObservableCollection<CountryPickerModel> TempCountryPickerListItem
        {
            get { return _CountryPickerListItem; }
            set
            {
                _CountryPickerListItem = value;
                OnPropertyChanged("TempCountryPickerListItem");
            }
        } 
        private string _DisplayName;
        public string DisplayName
        {
            get { return _DisplayName; }
            set
            {
                if (_DisplayName != value)
                {
                    _DisplayName = value;
                    OnPropertyChanged("DisplayName");
                }
            }
        }
        private string _CountryISDCode = "+44";
        public string CountryISDCode
        {
            get { return _CountryISDCode; }
            set
            {
                if (_CountryISDCode != value)
                {
                    _CountryISDCode = value;
                    OnPropertyChanged("CountryISDCode");
                }
            }
        }

        private int _CountryId;
        public int CountryId
        {
            get { return _CountryId; }
            set
            {
                if (_CountryId != value)
                {
                    _CountryId = value;
                    OnPropertyChanged("CountryId");
                }
            }
        }
        private string _Mobileno;
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
        private string _CountryFlag = "gb.png";
        public string CountryFlag
        {
            get { return _CountryFlag; }
            set
            {
                if (_CountryFlag != value)
                {
                    _CountryFlag = value;
                    OnPropertyChanged("CountryFlag");
                }
            }
        }
        private string _CountryOfResidency = "United Kingdom";
        public string CountryOfResidency
        {
            get { return _CountryOfResidency; }
            set
            {
                if (_CountryOfResidency != value)
                {
                    _CountryOfResidency = value;
                    OnPropertyChanged("CountryOfResidency");
                }
            }
        }
        private bool _IsAgreedToTC = false;
        public bool IsAgreedToTC
        {
            get { return _IsAgreedToTC; }
            set
            {
                if (_IsAgreedToTC != value)
                {
                    _IsAgreedToTC = value;
                    OnPropertyChanged("IsAgreedToTC");
                }
            }
        }
        #endregion

        #region Methods

        public async Task GetCountriesList()
        {
            TempCountryPickerListItem = new ObservableCollection<CountryPickerModel>(CountryPickerModel.CountryPickerData());
        }

        /// <summary>
        /// TODO : To Go To User Sign Up Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void SignUpAsync(object obj)
        {
            //Apply Validations..
            if (!await Validate()) return;

            Helpers.Constants.MobileNumber = CountryISDCode + Mobileno;

            //Navigate To Confirm Phone Number Page...
            await Navigation.PushModalAsync(new Views.Register.ConfirmNumberPage());
        }

        /// <summary>
        /// TODO : To Go To Country Picker Popup...
        /// </summary>
        /// <param name="obj"></param>
        private async void CountryPickerAsync(object obj)
        {
            CountryPickerPopupVM = new CountryPickerPopup(this);
            await Navigation.PushPopupAsync(CountryPickerPopupVM, true);
        }

        /// <summary>
        /// To Validate all User Input Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            UserDialog.ShowLoading();
            if (string.IsNullOrEmpty(DisplayName))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter your display name.", "Alert", "Ok");
                return false;
            }
            bool isValid1 = (Regex.IsMatch(DisplayName, _Name, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            if (!isValid1)
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Display name is not valid");
                return false;
            }
            if (string.IsNullOrEmpty(CountryOfResidency))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please select your country of resident.", "Alert", "Ok");
                return false;
            }
            if (string.IsNullOrEmpty(Mobileno))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter your mobile number.", "Alert", "Ok");
                return false;
            }
            bool isValid2 = (Regex.IsMatch(Mobileno, _Phone, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            if (!isValid2)
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Mobile number is not valid");
                return false;
            }
            bool valphone = await CheckPhoneNumber();
            if (valphone == false)
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Invalid Phone Number.");
                return false;
            }
            if (IsAgreedToTC==false)
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please agree to our Terms ande Conditions and Privacy Policy.", "Alert", "Ok");
                return false;
            }
            UserDialog.HideLoading();
            return true;
        }

        /// <summary>
        /// TODO : To Define Event To Validate Phone Number...
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CheckPhoneNumber()
        {
            bool isValid = false;
            await Task.Run(async () =>
            {
                var mobileNum = CountryISDCode + Mobileno;
                isValid = DependencyService.Get<ITelephoneService>().GetISDCode(mobileNum);

            }).ConfigureAwait(false);
            return isValid;
        }
        /// <summary>
        /// To Bind Flag Image On To The Register Screen
        /// To Bind Get Set Prop For ISD Code And Country ID On Register View Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="imgSource"></param>
        /// <param name="isdcode"></param>
        /// <param name="countryId"></param>
        /// /// <param name="countryname"></param>
        public void CallSubmitMethodForCollaborate(string imgSource, string isdcode, int countryId, string countryname)
        {
            CountryFlag = imgSource;
            CountryISDCode = isdcode;
            CountryId = countryId;
            CountryOfResidency = countryname;
        }
        #endregion 
    }
}
