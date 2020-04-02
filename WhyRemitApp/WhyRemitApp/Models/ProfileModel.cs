using System;
using System.Collections.Generic;
using System.Text;

namespace WhyRemitApp.Models
{
    public class ProfileModel
    {
    }
    public class RegisterProfileRequestModel
    {
        public string displayname { get; set; }
        public string countrycode { get; set; }
        public string mobilenumber { get; set; }
    }
    public class RegisterProfileResponseModel
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; }
        public string profiletoken { get; set; }
    }
    public class ProfileRequestModel
    {
        public string profiletoken { get; set; }
    }
    public class ResendTokenResponseModel
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; }
    }

    public class ProfileVerifyRequestModel
    {
        public string profiletoken { get; set; }
        public string validatetoken { get; set; }
    }
    public class ProfileVerifyResponseModel
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; }
        public string secretkey { get; set; }
    }

    public class ProfileDetailsResponseModel
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; }
        public string mobilenumber { get; set; }
        public string displayname { get; set; }
        public string emailaddress { get; set; }
        public string countrycode { get; set; }
        public string profilepic { get; set; }
    }
    public class UpdateProfileRequestModel
    {
        public string profiletoken { get; set; }
        public string displayname { get; set; }
        public string emailaddress { get; set; }
        public string profilepic { get; set; }
    }

    public class ResendCodeRequestModel
    {
        public string emailaddress { get; set; }
    }

}
