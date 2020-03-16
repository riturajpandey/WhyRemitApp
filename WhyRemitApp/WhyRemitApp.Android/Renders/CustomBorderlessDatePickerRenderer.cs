using System;
using System.Collections.Generic;
using System.ComponentModel;
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

[assembly: ExportRenderer(typeof(CustomBorderlessDatePicker), typeof(CustomBorderlessDatePickerRenderer))]
namespace WhyRemitApp.Droid.Renders
{
    public class CustomBorderlessDatePickerRenderer : DatePickerRenderer
    {
        #region Constructor
        public CustomBorderlessDatePickerRenderer(Context context) : base(context)
        {

        }
        #endregion

        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);
            var customDatePicker = e.NewElement as CustomBorderlessDatePicker;

            if (customDatePicker != null)
            {
                this.SetValue(customDatePicker);
            }
            if (e.OldElement == null)
            {
                Control.Background = null;

                var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                layoutParams.SetMargins(0, 0, 0, 0);
                LayoutParameters = layoutParams;
                Control.LayoutParameters = layoutParams;
                Control.SetPadding(0, 0, 0, 0);
                SetPadding(0, 0, 0, 0);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (this.Control == null) return;

            var customDatePicker = this.Element as CustomBorderlessDatePicker;

            if (customDatePicker != null)
            {
                switch (e.PropertyName)
                {
                    case CustomBorderlessDatePicker.NullableDatePropertyName:
                        this.SetValue(customDatePicker);
                        break;
                    case CustomBorderlessDatePicker.NullTextPropertyName:
                        this.SetValue(customDatePicker);
                        break;
                }
            }
        }

        private void SetValue(CustomBorderlessDatePicker customDatePicker)
        {
            if (customDatePicker.NullableDate.HasValue)
            {
                this.Control.Text = customDatePicker.NullableDate.Value.ToString(customDatePicker.Format);
            }
            else
            {
                this.Control.Text = customDatePicker.NullText ?? string.Empty;
            }
        }
        #endregion
    }
}