using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels.Registration;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Register
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        RegistrationPageVM RegistrationVM;
        public RegistrationPage()
        {
            InitializeComponent();
            RegistrationVM = new RegistrationPageVM(this.Navigation);
            this.BindingContext = RegistrationVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region Event Handler

        /// <summary>
        /// TODO : To Defeine On Page Appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await RegistrationVM.GetCountriesList();
        }

        /// <summary>
        /// TODO : To Define Event Handler For T&C Toggled...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (RegistrationVM.IsAgreedToTC) 
                RegistrationVM.IsAgreedToTC = false; 
            else
                RegistrationVM.IsAgreedToTC = true;
        }
        #endregion 
    }
}