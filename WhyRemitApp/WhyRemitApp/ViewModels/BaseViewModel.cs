using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.BusinessCode;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels
{
    public class BaseViewModel : BindableObject
    {
        private INavigation _Navigation;
        protected readonly IBusinessCode _businessCode;
        public Command BackCommand { get; set; }
        public INavigation Navigation
        {
            get { return _Navigation; }
            set
            {
                if (_Navigation != value)
                {
                    _Navigation = value;
                    OnPropertyChanged("Navigation");
                }
            }
        }

        public bool IsInitialized { get; set; }

        public BaseViewModel(INavigation navigation = null)
        {
            try
            {
                Navigation = navigation;
                BackCommand = new Command(OnBacksAsync);
                _businessCode = SimpleIoc.Default.GetInstance<IBusinessCode>();
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// TODO : To Navigate To Back Page...
        /// </summary>
        public async void OnBacksAsync()
        {
            try
            {
                await PopModalAsync();
            }
            catch (Exception ex)
            {

            }
        }
        public Acr.UserDialogs.IUserDialogs UserDialog
        {
            get
            {
                return Acr.UserDialogs.UserDialogs.Instance;
            }
        }
        public async Task PushModalAsync(Page page)
        {
            if (Navigation != null)
                await Navigation.PushModalAsync(page);
        }

        public async Task PopModalAsync()
        {
            if (Navigation != null)
                await Navigation.PopModalAsync();
        }

        public async Task PushAsync(Page page)
        {
            if (Navigation != null)
                await Navigation.PushModalAsync(page);
        }

        public async Task PopAsync()
        {
            if (Navigation != null)
                await Navigation.PopModalAsync();
        }
    }
}
