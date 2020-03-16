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

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace WhyRemitApp.iOS.Renders
{
    public class CustomLabelRenderer : LabelRenderer
    {
        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var label = (UILabel)this.Control;// for example
                string Styleid = e.NewElement?.StyleId;
                if (Styleid == "PoppinsBlack")
                {
                    Element.FontFamily = "Poppins-Black.ttf";
                }
                if (Styleid == "PoppinsBlackItalic")
                {
                    Element.FontFamily = "Poppins-BlackItalic.ttf";
                }
                if (Styleid == "PoppinsBold")
                {
                    Element.FontFamily =  "Poppins-Bold.ttf";
                }
                if (Styleid == "PoppinsBoldItalic")
                {
                    Element.FontFamily = "Poppins-BoldItalic.ttf";
                }
                if (Styleid == "PoppinsExtraBold")
                {
                    Element.FontFamily = "Poppins-ExtraBold.ttf";
                }
                if (Styleid == "PoppinsExtraBoldItalic")
                {
                    Element.FontFamily = "Poppins-ExtraBoldItalic.ttf";
                }
                if (Styleid == "PoppinsExtraLight")
                {
                    Element.FontFamily = "Poppins-ExtraLight.ttf";
                }
                if (Styleid == "PoppinsExtraLightItalic")
                {
                    Element.FontFamily = "Poppins-ExtraLightItalic.ttf";
                }
                if (Styleid == "PoppinsItalic")
                {
                    Element.FontFamily = "Poppins-Italic.ttf";
                }
                if (Styleid == "PoppinsLight")
                {
                    Element.FontFamily = "Poppins-Light.ttf";
                }
                if (Styleid == "PoppinsLightItalic")
                {
                    Element.FontFamily = "Poppins-LightItalic.ttf";
                }
                if (Styleid == "PoppinsMedium")
                {
                    Element.FontFamily = "Poppins-Medium.ttf";
                }
                if (Styleid == "PoppinsMediumItalic")
                {
                    Element.FontFamily = "Poppins-MediumItalic.ttf";
                }
                if (Styleid == "PoppinsRegular")
                {
                    Element.FontFamily = "Poppins-Regular.ttf";
                }
                if (Styleid == "PoppinsSemiBold")
                {
                    Element.FontFamily = "Poppins-SemiBold.ttf";
                }
                if (Styleid == "PoppinsSemiBoldItalic")
                {
                    Element.FontFamily = "Poppins-SemiBoldItalic.ttf";
                }
                if (Styleid == "PoppinsThin")
                {
                    Element.FontFamily = "Poppins-Thin.ttf";
                }
                if (Styleid == "PoppinsThinItalic")
                {
                    Element.FontFamily = "Poppins-ThinItalic.ttf";
                }
            }
        }
        #endregion
    }
}