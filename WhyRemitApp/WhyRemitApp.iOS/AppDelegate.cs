using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Syncfusion.ListView.XForms.iOS;
using UIKit;

namespace WhyRemitApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            #region Initializing Packages 
            global::Xamarin.Forms.Forms.Init(); 
            Rg.Plugins.Popup.Popup.Init();  
            Plugin.InputKit.Platforms.iOS.Config.Init();
            SfListViewRenderer.Init();
            CarouselView.FormsPlugin.iOS.CarouselViewRenderer.Init();
            Syncfusion.XForms.iOS.TabView.SfTabViewRenderer.Init();
            //Popup Menu
            Xam.Plugin.iOS.PopupEffect.Init();
            XamEffects.iOS.Effects.Init();
            #endregion

            #region
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTMyNDlAMzEzNzJlMzEyZTMwWVAxejJTOFhSaUswQm1MUGJoWC93K3pyRWpkdkNVM0oyemhkK1ZzY0pNbz0=");
            #endregion

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
