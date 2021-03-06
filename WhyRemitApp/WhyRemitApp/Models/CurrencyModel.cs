﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WhyRemitApp.Models
{
    public class CurrencyModel
    {
        public string CurrencyName { get; set; }
        public string CurrencyExpire { get; set; }
        public string CurrencyExpireColor { get; set; }
        public string BestRate { get; set; }
        public string BestRateValue { get; set; }
        public string Matches { get; set; }
        public string MatchesValue { get; set; }
        public static List<CurrencyModel> CurrencyList()
        {
            return new List<CurrencyModel>
        {
            new CurrencyModel{CurrencyName="GBN - NGN",CurrencyExpire="Expires in 15 hours",BestRate="Best Rate",BestRateValue="500,000",Matches="Matches",MatchesValue="15",CurrencyExpireColor="#B2ACAC E57B7C"},
            new CurrencyModel{CurrencyName="GBN - USD",CurrencyExpire="Expires in 15 hours",BestRate="Best Rate",BestRateValue="500,000",Matches="Matches",MatchesValue="15",CurrencyExpireColor="#B2ACAC E57B7C"},
            new CurrencyModel{CurrencyName="GBN - EUR",CurrencyExpire="CLOSED",BestRate="Best Rate",BestRateValue="1.25",Matches="Matches",MatchesValue="5",CurrencyExpireColor="#E57B7C"},
            new CurrencyModel{CurrencyName="GBN - YEN",CurrencyExpire="CLOSED",BestRate="Best Rate",BestRateValue="1.25",Matches="Matches",MatchesValue="5",CurrencyExpireColor="#E57B7C"},
        };
        }
    } 
    public class CurrencyMatchesModel
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string MatchImage { get; set; } 
        public string Amount { get; set; } 
        public static List<CurrencyMatchesModel> GetCurrencyMatchesList()
        {
            return new List<CurrencyMatchesModel>
        {
            new CurrencyMatchesModel{Name="Joe Blogges", Amount ="500,000",Status="Approved" },
            new CurrencyMatchesModel{Name="Bolo Blogges", Amount ="400,000",Status="New" },
            new CurrencyMatchesModel{Name="Free Blogges", Amount ="480,000",Status="Awaiting Approval" }, 
            new CurrencyMatchesModel{Name="Trevor Blogges", Amount ="450,000",Status="Awaiting Approval" }, 
         };
        }
    }
}
