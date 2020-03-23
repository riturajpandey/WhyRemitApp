using Acr.UserDialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using WhyRemitApp.Providers;
using WhyRemitApp.Services;

namespace WhyRemitApp.BusinessCode
{
    public class BuisnessCode : IBusinessCode
    {
        IApiProvider _apiProvider;
        public BuisnessCode(IApiProvider apiProvider)
        {
            //To initialize service providers...
            _apiProvider = apiProvider;
            HttpClientHandler handler = new HttpClientHandler();
        }

        #region Web Services

        #region Accounts Api
        /// <summary>
        /// To Call PRofile Register Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<RegisterProfileResponseModel> ProfileRegisterApi(RegisterProfileRequestModel request, Action<object> success, Action<object> failed)
        {
            RegisterProfileResponseModel resmodel = new RegisterProfileResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/ProfileRegister", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.displayname + request.countrycode + request.mobilenumber);

                var result = await _apiProvider.Post<RegisterProfileResponseModel, RegisterProfileRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<RegisterProfileResponseModel>(response);
                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        /// <summary>
        /// To Call Resend Token Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<ResendTokenResponseModel> ProfileResendCodeApi(ProfileRequestModel request, Action<object> success, Action<object> failed)
        {
            ResendTokenResponseModel resmodel = new ResendTokenResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/ProfileResendCode", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken);

                var result = await _apiProvider.Post<ResendTokenResponseModel, ProfileRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<ResendTokenResponseModel>(response);
                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        /// <summary>
        /// To Call Verfiy Profile Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<ProfileVerifyResponseModel> ProfileVerifyApi(ProfileVerifyRequestModel request, Action<object> success, Action<object> failed)
        {
            ProfileVerifyResponseModel resmodel = new ProfileVerifyResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/ProfileVerify", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + request.validatetoken);

                var result = await _apiProvider.Post<ProfileVerifyResponseModel, ProfileVerifyRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<ProfileVerifyResponseModel>(response);

                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        /// <summary>
        /// To Call Get Profile Details Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<ProfileDetailsResponseModel> ProfileGetApi(ProfileRequestModel request, Action<object> success, Action<object> failed)
        {
            ProfileDetailsResponseModel resmodel = new ProfileDetailsResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/ProfileGet", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + Helpers.LocalStorage.GeneralSecretkey);

                var result = await _apiProvider.Post<ProfileDetailsResponseModel, ProfileRequestModel>(url, request, dic);
                var response = result.RawResult;
                Helpers.LocalStorage.GeneralProfile = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<ProfileDetailsResponseModel>(response);

                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        /// <summary>
        /// To Call Save Profile Details Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<ResendTokenResponseModel> ProfileSaveApi(UpdateProfileRequestModel request, Action<object> success, Action<object> failed)
        {
            ResendTokenResponseModel resmodel = new ResendTokenResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/ProfileSave", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + Helpers.LocalStorage.GeneralSecretkey
                    + request.displayname + request.emailaddress);

                var result = await _apiProvider.Post<ResendTokenResponseModel, UpdateProfileRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<ResendTokenResponseModel>(response);

                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        #endregion

        #region Search Apis
        /// <summary>
        /// To Call Search Save Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<SearchSaveResponseModel> SearchSaveApi(SearchSaveRequestModel request, Action<object> success, Action<object> failed)
        {
            SearchSaveResponseModel resmodel = new SearchSaveResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/SearchSave", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + Helpers.LocalStorage.GeneralSecretkey
                    + request.requestnumber + request.sellcurrencycode + request.buycurrencycode);

                var result = await _apiProvider.Post<SearchSaveResponseModel, SearchSaveRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<SearchSaveResponseModel>(response);
                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        /// <summary>
        /// To Call Get Searches Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<SearchResponseModel> SearchesApi(ProfileRequestModel request, Action<object> success, Action<object> failed)
        {
            SearchResponseModel resmodel = new SearchResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/Searches", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + Helpers.LocalStorage.GeneralSecretkey);

                var result = await _apiProvider.Post<SearchResponseModel, ProfileRequestModel>(url, request, dic);
                var response = result.RawResult;
                Helpers.LocalStorage.GeneralSearches = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<SearchResponseModel>(response);

                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        /// <summary>
        /// To Call Search Respond Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<ResendTokenResponseModel> SearchRespondApi(SearchRespondRequestModel request, Action<object> success, Action<object> failed)
        {
            ResendTokenResponseModel resmodel = new ResendTokenResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/SearchRespond", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + Helpers.LocalStorage.GeneralSecretkey
                    + request.requestnumber);

                var result = await _apiProvider.Post<ResendTokenResponseModel, SearchRespondRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<ResendTokenResponseModel>(response);

                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        #endregion

        #region Matches Api

        /// <summary>
        /// To Call Get Matcches List Detail..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<MatchesResponseModel> MatchesApi(MatchesRequestModel request, Action<object> success, Action<object> failed)
        {
            MatchesResponseModel resmodel = new MatchesResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/Matches", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + Helpers.LocalStorage.GeneralSecretkey + request.requestnumber);

                var result = await _apiProvider.Post<MatchesResponseModel, MatchesRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<MatchesResponseModel>(response);

                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        /// <summary>
        /// To Call Matches Respond Api..
        /// </summary>
        /// <param name="request"></param>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public async Task<ResendTokenResponseModel> MatchesRespondApi(MatchesRespondRequestModel request, Action<object> success, Action<object> failed)
        {
            ResendTokenResponseModel resmodel = new ResendTokenResponseModel();
            try
            {
                var url = string.Format("{0}/api/appconnect/MatchRespond", WebServiceDetails.BasUri);
                string randomGuid = Guid.NewGuid().ToString();
                var dic = new Dictionary<string, string>();
                dic.Add("randomguid", randomGuid);
                dic.Add("hash", randomGuid + WebServiceDetails.AppKey + request.profiletoken + Helpers.LocalStorage.GeneralSecretkey
                    + request.requestnumber + request.matchnumber);

                var result = await _apiProvider.Post<ResendTokenResponseModel, MatchesRespondRequestModel>(url, request, dic);
                var response = result.RawResult;
                resmodel = JsonConvert.DeserializeObject<ResendTokenResponseModel>(response);

                if (result.IsSuccessful == true)
                {
                    if (resmodel.responsecode == 100)
                        success.Invoke(resmodel);
                    else
                        failed.Invoke(resmodel);
                }
                else
                {
                    failed.Invoke(resmodel);
                }
            }
            catch (Exception exception)
            {
                UserDialogs.Instance.HideLoading();
            }
            return resmodel;
        }

        #endregion
        #endregion
    }
}
