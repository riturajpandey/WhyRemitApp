using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Acr.UserDialogs;
using Plugin.CurrentActivity;
using CarouselView.FormsPlugin.Android;

namespace WhyRemitApp.Droid
{
    [Activity(Label = "WhyRemitApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            #region Initializing Packages   
            UserDialogs.Init(this); 
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            UserDialogs.Init(this);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            Plugin.InputKit.Platforms.Droid.Config.Init(this, savedInstanceState);
            CarouselViewRenderer.Init();
            Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity = this;
            #endregion

            #region Status Bar
            //To set Status Bar Color :
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#025FA5"));

            #endregion
            #region
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTMyNDlAMzEzNzJlMzEyZTMwWVAxejJTOFhSaUswQm1MUGJoWC93K3pyRWpkdkNVM0oyemhkK1ZzY0pNbz0=");
            #endregion

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}