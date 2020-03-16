using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhyRemitApp.CustomControls;
using WhyRemitApp.iOS.Renders;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace WhyRemitApp.iOS.Renders
{
    public class CustomPickerRenderer : PickerRenderer
    {
        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            try
            {
                Control.Layer.BorderWidth = 0;
                Control.BorderStyle = UITextBorderStyle.None;
                Control.BackgroundColor = UIKit.UIColor.White;
            }
            catch (Exception ex)
            {
               
            }
        }
        #endregion
    }
}