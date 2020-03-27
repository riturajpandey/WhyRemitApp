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

        #region Notification Settings
        private const string IsNotification = "IsNotification";
        private static readonly string IsNotificationDefault = string.Empty;

        private const string IsSound = "IsSound";
        private static readonly string IsSoundDefault = string.Empty;

        private const string IsVibrate = "IsVibrate";
        private static readonly string IsVibrateDefault = string.Empty;

        public static string GeneralIsNotification
        {
            get
            {
                return AppSettings.GetValueOrDefault(IsNotification, IsNotificationDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(IsNotification, value);
            }
        }

        public static string GeneralIsSound
        {
            get
            {
                return AppSettings.GetValueOrDefault(IsSound, IsSoundDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(IsSound, value);
            }
        }

        public static string GeneralIsVibrate
        {
            get
            {
                return AppSettings.GetValueOrDefault(IsVibrate, IsVibrateDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(IsVibrate, value);
            }
        }
        #endregion

        #endregion
    }
}
