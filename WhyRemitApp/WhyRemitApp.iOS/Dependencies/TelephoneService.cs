using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit; 
using WhyRemitApp.Interfaces;
using PhoneNumbers;
using WhyRemitApp.iOS.Dependencies;

[assembly: Xamarin.Forms.Dependency(typeof(TelephoneService))] 
namespace WhyRemitApp.iOS.Dependencies
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
                //Teetra.Helpers.ConstantVar.PhoneNumError = e.Message;
                return false;
            }
            if (isValid == "Yes")
                return true;
            else
                return false;
        }
    }
}