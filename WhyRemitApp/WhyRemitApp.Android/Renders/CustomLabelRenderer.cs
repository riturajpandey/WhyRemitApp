using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WhyRemitApp.CustomControls;
using WhyRemitApp.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace WhyRemitApp.Droid.Renders
{
    public class CustomLabelRenderer : LabelRenderer
    {
        #region Constructor
        public CustomLabelRenderer(Context context) : base(context)
        {

        }
        #endregion

        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                string Styleid = e.NewElement?.StyleId;
                var label = (TextView)Control;
                if (Styleid == "PoppinsBlack")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-Black.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsBlackItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-BlackItalic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsBold")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-Bold.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsBoldItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-BoldItalic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsExtraBold")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-ExtraBold.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsExtraBoldItalic")    
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-ExtraBoldItalic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsExtraLight")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-ExtraLight.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsExtraLightItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-ExtraLightItalic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-Italic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsLight")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-Light.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsLightItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-LightItalic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsMedium")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-Medium.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsMediumItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-MediumItalic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsRegular")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-Regular.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsSemiBold")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-SemiBold.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsSemiBoldItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-SemiBoldItalic.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsThin")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-Thin.ttf");
                    label.Typeface = font;
                }
                if (Styleid == "PoppinsThinItalic")
                {
                    Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Poppins-ThinItalic.ttf");
                    label.Typeface = font;
                }
            }
        }
        #endregion
    }
}