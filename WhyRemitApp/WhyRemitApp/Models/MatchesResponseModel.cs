using System;
using System.Collections.Generic;
using System.Text;

namespace WhyRemitApp.Models
{
    public class MatchesResponseModel
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; }
        public List<MatchesModel> matches { get; set; }
    }
    public class MatchesModel
    {
        public string matchnumber { get; set; }
        public string statuscode { get; set; }
        public string statusname { get; set; }
        public string profilenumber { get; set; }
        public string displayname { get; set; }
        public string rate { get; set; }
        public string profilepic { get; set; }
        public string datecreated { get; set; }
    }

    public class MatchesRequestModel
    {
        public string profiletoken { get; set; }
        public string requestnumber { get; set; }
    }
    public class MatchesRespondRequestModel
    {
        public string profiletoken { get; set; }
        public string requestnumber { get; set; }
        public string matchnumber { get; set; }
        public string action { get; set; }
    }
}
