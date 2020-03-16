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
        private bool _IsBuyRate;
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

            UserDialog.Alert("Currency updated successfully.", "Alert", "Ok");
            await Navigation.PopModalAsync();
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

            if (IsBuyRate)
            {
                if (string.IsNullOrEmpty(BuyRate))
                {
                    UserDialog.HideLoading();
                    UserDialog.Alert("Please enter buy rate.", "Alert", "Ok");
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(SellRate))
                {
                    UserDialog.HideLoading();
                    UserDialog.Alert("Please enter sell rate.", "Alert", "Ok");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(ExpireTime))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter expire time.", "Alert", "Ok");
                return false;
            }
            UserDialog.HideLoading();
            return true;
        }

        #endregion 
    }
}
