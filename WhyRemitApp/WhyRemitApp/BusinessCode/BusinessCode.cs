using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using WhyRemitApp.Providers;

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

        #endregion
    }
}
