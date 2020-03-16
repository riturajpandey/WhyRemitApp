using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        }

        /// <summary>
        /// TODO : To Perform Resend Code Operation...
        /// </summary>
        /// <param name="obj"></param>
        private async void ResendCodeAsync(object obj)
        { }

        /// <summary>
        /// To Validate all User Input Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            if (string.IsNullOrEmpty(OTP))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter the 4 digit code sent to your number.", "Alert", "Ok");
                return false;
            } 
            return true;
        }
        #endregion
    }
}
