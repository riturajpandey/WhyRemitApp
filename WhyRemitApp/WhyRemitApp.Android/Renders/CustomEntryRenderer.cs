using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using WhyRemitApp.CustomControls;
using WhyRemitApp.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace WhyRemitApp.Droid.Renders
{
    public class CustomEntryRenderer : EntryRenderer
    {
        #region Constructor
        public CustomEntryRenderer(Context context) : base(context)
        {

        }
        #endregion

        #region Overrides Methods
           
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.SetSelectAllOnFocus(true); 
            string Styleid = Element.StyleId;
            if (Control != null)
            { 
                var entry = (EditText)Control;
                entry.Background = null;
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Element.BackgroundColor = Color.Transparent;

                if (string.IsNullOrEmpty(Helpers.LocalStorage.GeneralProfileToken))
                {
                    Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);

                    // set the cursor color the same as the entry TextColor
                    IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
                    IntPtr mCursorDrawableResProperty =
                    JNIEnv.GetFieldID(IntPtrtextViewClass, "mCursorDrawableRes", "I");
                    JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, 0);
                }
                if (Styleid == "CenterAllign")
                {
                    Control.Gravity = GravityFlags.CenterHorizontal;
                }
            }
        }
        #endregion
    }
}