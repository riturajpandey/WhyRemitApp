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
using PhoneNumbers;
using WhyRemitApp.Interfaces;
using WhyRemitApp.Droid.Dependencies;

[assembly: Xamarin.Forms.Dependency(typeof(TelephoneService))]
namespace WhyRemitApp.Droid.Dependencies
{
    public class TelephoneService : ITelephoneService
    {
        public string isValid = "";
        public TelephoneService()
        { }

        public bool GetISDCode(string PhoneNum)
        {

            // string number = "+919769321013";
            PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
            try
            {
                PhoneNumber numberProto = phoneUtil.Parse(PhoneNum, "");
                // System.out.println("Number is of region - "
                string region = phoneUtil.GetRegionCodeForNumber(numberProto);
                isValid = (phoneUtil.IsValidNumber(numberProto) == true ? "Yes" : "No");

            }
            catch (NumberParseException e)
            {
                string error = "NumberParseException was thrown: "
                          + e.ToString();
                //App.PhoneNumError = e.Message;
                return false;
            }
            if (isValid == "Yes")
                return true;
            else
                return false;
        }
    }
}