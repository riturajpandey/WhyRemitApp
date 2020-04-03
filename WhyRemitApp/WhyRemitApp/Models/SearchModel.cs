using System;
using System.Collections.Generic;
using System.Text;

namespace WhyRemitApp.Models
{
    public class SearchModel
    {
        public string requestnumber { get; set; }
        public string datecreated { get; set; }
        public string matches { get; set; }
        public string statuscode { get; set; }
        public string statusname { get; set; }
        public string currencysell { get; set; }
        public string currencybuy { get; set; }
        public string rate { get; set; }
        public string buyorsell { get; set; }
        public string duration { get; set; }
        public string expiryminutes { get; set; }
        public string bestrate { get; set; }

        public string CurrencyName
        {
            get
            {
                string name = string.Empty;
                name = currencysell + " - " + currencybuy;
                return name;
            }
        }
        public string CurrencyExpire
        {
            get
            {
                string name = string.Empty;
                if (statuscode != "ACTIVE")
                {
                    name = "Closed";
                }
                else
                {
                    //name = "Expires in " + duration;
                    int minutes = Convert.ToInt32(expiryminutes);
                    if (minutes == 0)
                    {
                        name = "Expired";
                    }
                    else if (minutes == 60)
                    {
                        name = "Expires in " + "1 hour";
                    }
                    else if (minutes < 60)
                    {
                        name = "Expires in " + minutes.ToString() + " mins";
                    }
                    else if (minutes > 60)
                    {
                        var time = TimeSpan.FromMinutes(minutes);
                        string hour = string.Format("{0:00}", (int)time.TotalHours);
                        string min = string.Format("{0:00}", (int)time.Minutes);

                        int totalHours = Convert.ToInt32(hour);
                        int totalMinutes = Convert.ToInt32(min);

                        double days = minutes / 60 / 24;
                        double hours = (minutes - days * 24 * 60) / 60;

                        if (hour == "0" && min == "0" && days == 0)
                        {
                            name = "Expired";
                        } 
                        if (totalHours > 23) // 1500
                        {
                            name = "Expires in " + days.ToString() + " day(s)";
                        }
                        else if (totalHours <= 24)
                        {
                            name = "Expires in " + hour + " hour(s)";
                        }
                        else if (totalHours <= 1) // 790
                        {
                            name = "Expires in " + min + " minute(s)"; //hour + " hour(s) "; 
                        }
                      
                    }
                }
                return name;
            }
        }
        public string CurrencyExpireColor
        {
            get
            {
                string clr = string.Empty;
                if (statuscode == "ACTIVE")
                { clr = "#B2ACAC"; }
                else
                { clr = "#E57B7C"; }
                return clr;
            }
        }
        public string BestRateValue
        {
            get
            {
                string name = string.Empty;
                string[] obj = rate.Split('.');
                name = obj[0];
                return name;
            }
        }
    }
    public class SearchResponseModel
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; }
        public List<SearchModel> searches { get; set; }
    }

    public class SearchSaveRequestModel
    {
        public string profiletoken { get; set; }
        public string requestnumber { get; set; }
        public string sellcurrencycode { get; set; }
        public string buycurrencycode { get; set; }
        public string rate { get; set; }
        public string buyorsell { get; set; }
        public string duration { get; set; }
    }
    public class SearchSaveResponseModel
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; }
        public string requestnumber { get; set; }
    }

    public class SearchRespondRequestModel
    {
        public string profiletoken { get; set; }
        public string requestnumber { get; set; }
        public string action { get; set; }
    }
}
