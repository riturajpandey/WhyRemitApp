using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhyRemitApp.Helpers
{
    public class LocalStorage
    {
        private static ISettings AppSettings => CrossSettings.Current; // ข้อมูล Setting

        #region Local Constants

        #region Profile Token 
        private const string Token = "Token";
        private static readonly string TokenDefault = string.Empty;

        private const string secretkey = "secretkey";
        private static readonly string secretkeyDfault = string.Empty;

        public static string GeneralProfileToken
        {
            get
            {
                return AppSettings.GetValueOrDefault(Token, TokenDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(Token, value);
            }
        } 
        public static string GeneralSecretkey
        {
            get
            {
                return AppSettings.GetValueOrDefault(secretkey, secretkeyDfault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(secretkey, value);
            }
        }
        #endregion

        #region MyRegion
        private const string Searches = "Searches";
        private static readonly string SearchesDefault = string.Empty;

        private const string Profile = "Profile";
        private static readonly string ProfileDefault = string.Empty;

        public static string GeneralSearches
        {
            get
            {
                return AppSettings.GetValueOrDefault(Searches, SearchesDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(Searches, value);
            }
        }

        public static string GeneralProfile 
        {
            get
            {
                return AppSettings.GetValueOrDefault(Profile, ProfileDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(Profile, value);
            }
        }
        #endregion

        #endregion
    }
}
