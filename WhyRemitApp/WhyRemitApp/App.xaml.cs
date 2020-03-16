using System;
using WhyRemitApp.BusinessCode;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp
{
    public partial class App : Application
    {
        //TODO : To Define Global Varialbes Here....
        private static Autofac.IContainer _container;

        public App()
        {
            InitializeComponent();
            //To initialize Containers..
            AppSetup appSetup = new AppSetup();
            _container = appSetup.CreateContainer();

            MainPage = new Views.Currencies.EditCurrencyPage();

            #region
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTMyNDlAMzEzNzJlMzEyZTMwWVAxejJTOFhSaUswQm1MUGJoWC93K3pyRWpkdkNVM0oyemhkK1ZzY0pNbz0=");
            #endregion
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
