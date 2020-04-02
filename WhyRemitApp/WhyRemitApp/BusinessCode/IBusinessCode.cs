using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;

namespace WhyRemitApp.BusinessCode
{
    public interface IBusinessCode
    {
        #region Accounts Apis 
        Task<RegisterProfileResponseModel> ProfileRegisterApi(RegisterProfileRequestModel request, Action<object> success, Action<object> failed);
        Task<ResendTokenResponseModel> ProfileResendCodeApi(ProfileRequestModel request, Action<object> success, Action<object> failed);
        Task<ProfileVerifyResponseModel> ProfileVerifyApi(ProfileVerifyRequestModel request, Action<object> success, Action<object> failed);
        Task<ProfileDetailsResponseModel> ProfileGetApi(ProfileRequestModel request, Action<object> success, Action<object> failed);
        Task<ResendTokenResponseModel> ProfileSaveApi(UpdateProfileRequestModel request, Action<object> success, Action<object> failed);
        //Task<ResendTokenResponseModel> AccessPasswordResendCodeApi(string request, Action<object> success, Action<object> failed);
        #endregion

        #region Search Apis 
        Task<SearchSaveResponseModel> SearchSaveApi(SearchSaveRequestModel request, Action<object> success, Action<object> failed);
        Task<SearchResponseModel> SearchesApi(ProfileRequestModel request, Action<object> success, Action<object> failed);
        Task<ResendTokenResponseModel> SearchRespondApi(SearchRespondRequestModel request, Action<object> success, Action<object> failed);

        #endregion

        #region Matches Apis 
        Task<MatchesResponseModel> MatchesApi(MatchesRequestModel request, Action<object> success, Action<object> failed);
        Task<ResendTokenResponseModel> MatchesRespondApi(MatchesRespondRequestModel request, Action<object> success, Action<object> failed);

        #endregion
    }
}
