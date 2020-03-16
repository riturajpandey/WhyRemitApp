using Acr.UserDialogs;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WhyRemitApp.Helpers;
using WhyRemitApp.Interfaces;
using WhyRemitApp.Models;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels
{
    public class ProfilePageVM : BaseViewModel
    {
        //TODO : To Declare Local Class Level Variables..
        private const string _Name = @"^[a-zA-Z]+$"; 
        private const string _emailRegex = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";

        #region CONSTRUCTOR 
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public ProfilePageVM(INavigation nav)
        {
            Navigation = nav;
            CurrencyCommand = new Command(OnCurrencyAsync);
            SettingCommand = new Command(OnSettingAsync);
            SaveCommand = new Command(OnSaveAsync);
            CameraCommand = new Command(OnCameraAsync);
            GalleryCommand = new Command(OnGalleryAsync);
            MediaCommand = new Command(OnMediaAsync);
            MediaCommand = new Command(OnCloseMediaAsync);
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command CurrencyCommand { get; set; }
        public Command SettingCommand { get; set; }
        public Command SaveCommand { get; set; }
        public Command CameraCommand { get; set; }
        public Command GalleryCommand { get; set; }
        public Command MediaCommand { get; set; }
        public Command CloseMediaCommand { get; set; }
        #endregion

        #region PROPERTIES 
        private string _UserProfileBase64;
        public string UserProfileBase64
        {
            get { return _UserProfileBase64; }
            set
            {
                if (_UserProfileBase64 != value)
                {
                    _UserProfileBase64 = value;
                    OnPropertyChanged("UserProfileBase64");
                }
            }
        }

        private ObservableCollection<IndicatorModel> _IndicatorList;
        public ObservableCollection<IndicatorModel> IndicatorList
        {
            get { return _IndicatorList; }
            set
            {
                if (_IndicatorList != value)
                {
                    _IndicatorList = value;
                    OnPropertyChanged("IndicatorList");
                }
            }
        }

        private bool _IsCamera;
        public bool IsCamera
        {
            get { return _IsCamera; }
            set
            {
                if (_IsCamera != value)
                {
                    _IsCamera = value;
                    OnPropertyChanged("IsCamera");
                }
            }
        } 
        private string _DisplayName;
        public string DisplayName
        {
            get { return _DisplayName; }
            set
            {
                if (_DisplayName != value)
                {
                    _DisplayName = value;
                    OnPropertyChanged("DisplayName");
                }
            }
        }
        private string _EmailAddress;
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set
            {
                if (_EmailAddress != value)
                {
                    _EmailAddress = value;
                    OnPropertyChanged("EmailAddress");
                }
            }
        }
        private string _Mobileno = "+44789789789798";
        public string Mobileno
        {
            get { return _Mobileno; }
            set
            {
                if (_Mobileno != value)
                {
                    _Mobileno = value;
                    OnPropertyChanged("Mobileno");
                }
            }
        }
        #endregion

        #region Methods 

        /// <summary>
        /// TODO : To navigate To Currency Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnCurrencyAsync(object obj)
        {
            App.Current.MainPage = new Views.Currencies.CurrencyPage();
        }

        /// <summary>
        /// TODO : To navigate To Setting Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnSettingAsync(object obj)
        {
            App.Current.MainPage = new Views.Settings.SettingsPage();
        }

        /// <summary>
        /// TODO : To Get Profile Details List...
        /// </summary>
        public async Task GetProfileData()
        { }

        /// <summary>
        /// TODO : To Save Profile ...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnSaveAsync(object obj)
        {
            //Apply Validations..
            if (!await Validate()) return;

            UserDialog.Alert("Profile updated successfully.", "Alert", "Ok");
        }

        /// <summary>
        /// TODO : To Camera Action ...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnCameraAsync(object obj)
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync
                                             (Plugin.Permissions.Abstractions.Permission.Camera);

                if (status != Plugin.Permissions.Abstractions.PermissionStatus.Granted)
                {
                    var result = await CrossPermissions.Current.RequestPermissionsAsync(new[] {
                                                                                  Plugin.Permissions.Abstractions.Permission.Camera });
                    status = result[Plugin.Permissions.Abstractions.Permission.Camera];
                }

                if (status == Plugin.Permissions.Abstractions.PermissionStatus.Granted)
                {
                    UserProfileBase64 = string.Empty;
                    if (!CrossMedia.Current.IsCameraAvailable)
                    {
                        UserDialogs.Instance.HideLoading();
                        UserDialogs.Instance.Alert("No camera avaialble.", null, "OK");
                        return;
                    }
                    if (Device.OS == TargetPlatform.Android)
                        UserDialogs.Instance.ShowLoading("Loading...");
                    var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        Directory = "Sample",
                        Name = "test.png",
                    });
                    if (file == null)
                    {
                        UserDialogs.Instance.HideLoading();
                        return;
                    }
                    Constants.ImgFilePath = file.Path;
                    string filepath = file.Path;
                    var ImageByteData = await DependencyService.Get<IMediaService>().ResizeImage(await DependencyService.Get<IMediaService>().GetMediaInBytes(file.Path), 120, 120);
                    UserProfileBase64 = Convert.ToBase64String(ImageByteData);

                    //await UpdateProfilePictureApi();
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        UserDialogs.Instance.HideLoading();
                        MessagingCenter.Send<string>("", "LoadImage");
                    });
                }
                else
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        UserDialogs.Instance.Alert("Camera permission denied. Make sure you have given us camera permission, go to settings and enable camera permission for us.", "Alert", "Ok");
                        UserDialogs.Instance.HideLoading();
                    });
                }

                UserDialogs.Instance.HideLoading();
            }
            catch (Exception ex)
            { UserDialogs.Instance.HideLoading(); }  
        }

        /// <summary>
        /// TODO : To Gallery Action ...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnGalleryAsync(object obj)
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync
                                             (Plugin.Permissions.Abstractions.Permission.Photos);

                if (status != Plugin.Permissions.Abstractions.PermissionStatus.Granted)
                {
                    var result = await CrossPermissions.Current.RequestPermissionsAsync(new[] {
                                                                                  Plugin.Permissions.Abstractions.Permission.Photos });
                    status = result[Plugin.Permissions.Abstractions.Permission.Photos];
                }

                if (status == Plugin.Permissions.Abstractions.PermissionStatus.Granted)
                {

                    UserProfileBase64 = string.Empty;
                    if (!CrossMedia.Current.IsPickPhotoSupported)
                    {
                        return;
                    }

                    if (Device.RuntimePlatform.Equals("Android"))
                        UserDialogs.Instance.ShowLoading("Loading...");

                    var file = await CrossMedia.Current.PickPhotoAsync();
                    if (file == null)
                    {
                        UserDialogs.Instance.HideLoading();
                        return;
                    }
                    Helpers.Constants.ImgFilePath = file.Path;
                    string filepath = file.Path;
                    Helpers.Constants.UserProfilePic = filepath;

                    var ImageByteData = await DependencyService.Get<IMediaService>().ResizeImage(await DependencyService.Get<IMediaService>().GetMediaInBytes(file.Path), 120, 120);
                    //var ImageByteData = await DependencyService.Get<IMediaService>().GetMediaInBytes(file.Path);
                    UserProfileBase64 = Convert.ToBase64String(ImageByteData);

                    //await UpdateProfilePictureApi();
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        UserDialogs.Instance.HideLoading();

                        MessagingCenter.Send<string>("", "LoadImage");
                    });
                }
                UserDialogs.Instance.HideLoading(); 
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
            } 
        }

        /// <summary>
        /// TODO : To Open Media Popup Async ...
        /// </summary>
        /// <param name="obj"></param>
        public async void OnMediaAsync()
        {
            IsCamera = true; 
        }

        /// <summary>
        /// TODO : To Open Media Popup Async ...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnCloseMediaAsync(object obj)
        {
            IsCamera = false;
        }

        /// <summary>
        /// To Validate all User Input Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            UserDialog.ShowLoading();
            if (string.IsNullOrEmpty(DisplayName))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter your display name.", "Alert", "Ok");
                return false;
            }
            bool isValid1 = (Regex.IsMatch(DisplayName, _Name, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            if (!isValid1)
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Display name is not valid");
                return false;
            } 
            if (string.IsNullOrEmpty(EmailAddress))
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Please enter your email Address.", "Alert", "Ok");
                return false;
            }
            bool isValid2 = (Regex.IsMatch(EmailAddress, _emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            if (!isValid2)
            {
                UserDialog.HideLoading();
                UserDialog.Alert("Email Address is not valid");
                return false;
            } 
            UserDialog.HideLoading();
            return true;
        }

        #endregion 
    }
}
