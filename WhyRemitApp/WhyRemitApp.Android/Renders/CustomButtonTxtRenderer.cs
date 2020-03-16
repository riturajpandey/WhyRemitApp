using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WhyRemitApp.CustomControls;
using WhyRemitApp.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButtonTxt), typeof(CustomButtonTxtRenderer))]
namespace WhyRemitApp.Droid.Renders
{
    public class CustomButtonTxtRenderer : ButtonRenderer
    {
        #region Constructor
        public CustomButtonTxtRenderer(Context context) : base(context)
        {

        }
        #endregion

        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var button = this.Control;
            button.SetAllCaps(false);
        }
        #endregion
    }
}