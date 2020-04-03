using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyRemitApp.Model
{
    public class CountryPickerModel
    {
        public int Id { get; set; }
        public string CountryFlag { get; set; }
        public string CountryName { get; set; }
        public string CountryISDCode { get; set; }
        public string CountryCode { get; set; }
        public string CountryIS03Code { get; set; }
        public string Currency { get; set; }

        public static List<CountryPickerModel> CountryPickerData()
        {
            return new List<CountryPickerModel>
        {
          new CountryPickerModel ()
          {
            Id=3,
            CountryFlag="af.png",
            CountryName = "Afghanistan",
            CountryISDCode = "+93",
            CountryCode = "AF",
            CountryIS03Code = "AFG",
            Currency = "AFN" 
          },
         new CountryPickerModel ()
          {
            Id=4,
            CountryFlag="al.png",
            CountryName = "Albania",
            CountryISDCode = "+355",
            CountryCode = "AL",
            CountryIS03Code = "ALB",
            Currency = "ALL"
          },
         new CountryPickerModel ()
          {
            Id=5,
            CountryFlag="dz_flag.png",
            CountryName = "Algeria",
            CountryISDCode = "+213",
            CountryCode = "DZ",
            CountryIS03Code = "DZA",
            Currency = "DZD"
          },
         new CountryPickerModel ()
          {
            Id=6,
            CountryFlag="ad.png",
            CountryName = "Andorra",
            CountryISDCode = "+376",
            CountryCode = "AD",
            CountryIS03Code = "AND",
            Currency = "EUR"
          },
         new CountryPickerModel ()
          {
            Id=7,
            CountryFlag="ao.png",
            CountryName = "Angola",
            CountryISDCode = "+244",
            CountryCode = "AO",
            CountryIS03Code = "AGO",
             Currency = "AOA"
          },
         new CountryPickerModel ()
          {
            Id=8,
            CountryFlag="ag.png",
            CountryName = "Antigua and Barbuda",
            CountryISDCode = "+1-268",
            CountryCode = "AG",
            CountryIS03Code = "ATG",
            Currency = "XCD"
          },
         new CountryPickerModel ()
          {
            Id=9,
            CountryFlag="ar.png",
            CountryName = "Argentina",
            CountryISDCode = "+54",
            CountryCode = "AR",
            CountryIS03Code = "ARG",
            Currency = "ARS"
          },
         new CountryPickerModel ()
          {
            Id=10,
            CountryFlag="am.png",
            CountryName = "Armenia",
            CountryISDCode = "+374",
            CountryCode = "AM",
            CountryIS03Code = "ARM",
            Currency = "AMD"
          },
         new CountryPickerModel ()
          {
            Id=11,
            CountryFlag="au.png",
            CountryName = "Australia",
            CountryISDCode = "+61",
            CountryCode = "AU",
            CountryIS03Code = "AUS",
            Currency = "AUD"
          },
         new CountryPickerModel ()
          {
            Id=12,
            CountryFlag="at.png",
            CountryName = "Austria",
            CountryISDCode = "+43",
            CountryCode = "AT",
            CountryIS03Code = "AUT",
            Currency = "EUR"
          },
         new CountryPickerModel ()
          {
            Id=13,
            CountryFlag="az.png",
            CountryName = "Azerbaijan",
            CountryISDCode = "+994",
            CountryCode = "AZ",
            CountryIS03Code = "AZE",
            Currency = "AZN"
          },
         new CountryPickerModel ()
          {
            Id=14,
            CountryFlag="bs.png",
            CountryName = "Bahamas",
            CountryISDCode = "+1-242",
            CountryCode = "BS",
            CountryIS03Code = "BSD",
            Currency = "BSD"
          },
         new CountryPickerModel ()
          {
            Id=15,
            CountryFlag="bh.png",
            CountryName = "Bahrain",
            CountryISDCode = "+973",
            CountryCode = "BH",
            CountryIS03Code = "BHR",
             Currency = "BHD"
          },
         new CountryPickerModel ()
          {
            Id=16,
            CountryFlag="bd.png",
            CountryName = "Bangladesh",
            CountryISDCode = "+880",
            CountryIS03Code = "BGD",
             Currency = "BDT"
          },
         new CountryPickerModel ()
          {
            Id=17,
            CountryFlag="bb.png",
            CountryName = "Barbados",
            CountryISDCode = "+1-246",
            CountryCode = "BB",
            CountryIS03Code = "BRB",
            Currency = "BBD"
          },
         new CountryPickerModel ()
          {
            Id=18,
            CountryFlag="by.png",
            CountryName = "Belarus",
            CountryISDCode = "+375",
            CountryCode = "BY",
            CountryIS03Code = "BLR",
            Currency = "BYR"
          },
         new CountryPickerModel ()
          {
            Id=19,
            CountryFlag="be.png",
            CountryName = "Belgium",
            CountryISDCode = "+32",
            CountryCode = "BE",
            CountryIS03Code = "BEL",
            Currency = "EUR"
          },
         new CountryPickerModel ()
          {
            Id=20,
            CountryFlag="bz.png",
            CountryName = "Belize",
            CountryISDCode = "+501",
            CountryCode = "BZ",
            CountryIS03Code = "BLZ",
             Currency = "BZD"
          },
         new CountryPickerModel ()
          {
            Id=21,
            CountryFlag="bj.png",
            CountryName = "Benin",
            CountryISDCode = "+229",
            CountryCode = "BJ",
            CountryIS03Code = "BEN",
            Currency = "XOF"
          },
         new CountryPickerModel ()
          {
            Id=22,
            CountryFlag="bt.png",
            CountryName = "Bhutan",
            CountryISDCode = "+975",
            CountryCode = "BT",
            CountryIS03Code = "BTN",
            Currency = "BTN"
          },
         new CountryPickerModel ()
          {
            Id=23,
            CountryFlag="bo.png",
            CountryName = "Bolivia",
            CountryISDCode = "+591",
            CountryCode = "BO",
            CountryIS03Code = "BOL",
            Currency = "BOB"
          },
         new CountryPickerModel ()
          {
            Id=24,
            CountryFlag="ba.png",
            CountryName = "Bosnia and Herz.",
            CountryISDCode = "+387",
            CountryCode = "BA",
            CountryIS03Code = "BIH",
            Currency = "BAM"
          },
         new CountryPickerModel ()
          {
            Id=25,
            CountryFlag="bw.png",
            CountryName = "Botswana",
            CountryISDCode = "+267",
            CountryCode = "BW",
            CountryIS03Code = "BWA",
            Currency = "BWP"
         },
            new CountryPickerModel ()
          {
            Id=26,
            CountryFlag="br.png",
            CountryName = "Brazil",
            CountryISDCode = "+55",
            CountryCode = "BR",
            CountryIS03Code = "BRA",
            Currency = "BRL"
          },
            new CountryPickerModel ()
          {
            Id=27,
            CountryFlag="bn.png",
            CountryName = "Brunei",
            CountryISDCode = "+673",
            CountryCode = "BN",
            CountryIS03Code = "BRN",
             Currency = "BND"
          },
            new CountryPickerModel ()
          {
            Id=28,
            CountryFlag="bg_flag.png",
            CountryName = "Bulgaria",
            CountryISDCode = "+359",
            CountryCode = "BG",
            CountryIS03Code = "BGR",
            Currency = "BGN"
          },
            new CountryPickerModel ()
          {
            Id=29,
            CountryFlag="bf.png",
            CountryName = "Burkina Faso",
            CountryISDCode = "+226",
            CountryCode = "BF",
            CountryIS03Code = "BFA",
            Currency = "XOF"
          },
            new CountryPickerModel ()
          {
            Id=30,
            CountryFlag="bi.png",
            CountryName = "Burundi",
            CountryISDCode = "+257",
            CountryCode = "BI",
            CountryIS03Code = "BDI",
            Currency = "BIF"
          },
            new CountryPickerModel ()
          {
            Id=31,
            CountryFlag="kh.png",
            CountryName = "Cambodia",
            CountryISDCode = "+855",
            CountryCode = "KH",
            CountryIS03Code = "KHM",
            Currency = "KHR"
          },
            new CountryPickerModel ()
          {
            Id=32,
            CountryFlag="cm.png",
            CountryName = "Cameroon",
            CountryISDCode = "+237",
            CountryCode = "CM",
            CountryIS03Code = "CMR",
            Currency = "XAF"
          },
            new CountryPickerModel ()
          {
            Id=33,
            CountryFlag="ca.png",
            CountryName = "Canada",
            CountryISDCode = "+1",
            CountryCode = "CA",
            CountryIS03Code = "CAN",
            Currency = "CAD"
          },
            new CountryPickerModel ()
          {
            Id=34,
            CountryFlag="cv.png",
            CountryName = "Cape Verde",
            CountryISDCode = "+238",
            CountryCode = "CV",
            CountryIS03Code = "CPV",
             Currency = "CVE"
          },
            new CountryPickerModel ()
          {
            Id=35,
            CountryFlag="cf.png",
            CountryName = "Central African Rep.",
            CountryISDCode = "+236",
            CountryCode = "CF",
            CountryIS03Code = "CAF",
            Currency = "XAF"
          },
            new CountryPickerModel ()
          {
            Id=36,
            CountryFlag="td.png",
            CountryName = "Chad",
            CountryISDCode = "+235",
            CountryCode = "TD",
            CountryIS03Code = "TCD",
            Currency = "XAF"
          },
            new CountryPickerModel ()
          {
            Id=37,
            CountryFlag="cl.png",
            CountryName = "Chile",
            CountryISDCode = "+56",
            CountryCode = "CL",
            CountryIS03Code = "CHL",
            Currency = "CLP"
          },
            new CountryPickerModel ()
          {
            Id=38,
            CountryFlag="cn.png",
            CountryName = "China",
            CountryISDCode = "+86",
            CountryCode = "CN",
            CountryIS03Code = "CHN",
            Currency = "CNY"
          },
            new CountryPickerModel ()
          {
            Id=39,
            CountryFlag="co.png",
            CountryName = " Colombia",
            CountryISDCode = "+57",
            CountryCode = "CO",
            CountryIS03Code = "COL",
            Currency = "COP"
          },
        new CountryPickerModel ()
          {
            Id=40,
            CountryFlag="km.png",
            CountryName = "Comoros",
            CountryISDCode = "+269",
            CountryCode = "KM",
            CountryIS03Code = "COM",
            Currency = "KMF"
          },
         new CountryPickerModel ()
        {
            Id=41,
            CountryFlag="cd.png",
            CountryName = "Congo",
            CountryISDCode = "+242",
            CountryCode = "CD",
            CountryIS03Code = "COG",
            Currency = "CDF"
          },
        new CountryPickerModel ()
        {
            Id=42,
            CountryFlag="cr.png",
            CountryName = "Costa Rica",
            CountryISDCode = "+506",
            CountryCode = "CR",
            CountryIS03Code = "CRI",
            Currency = "CRC"
          },
        new CountryPickerModel ()
        {
            Id=43,
            CountryFlag="ci.png",
            CountryName = "Cote d Ivoire",
            CountryISDCode = "+225",
            CountryCode = "CI",
            CountryIS03Code = "CIV",
            Currency = "XOF"
          },

        new CountryPickerModel ()
        {
            Id=44,
            CountryFlag="hr.png",
            CountryName = "Croatia",
            CountryISDCode = "+385",
            CountryCode = "HR",
            CountryIS03Code = "HRV",
            Currency = "HRK"
          },
        new CountryPickerModel ()
        {
            Id=45,
            CountryFlag="cu.png",
            CountryName = "Cuba",
            CountryISDCode = "+53",
            CountryCode = "CU",
            CountryIS03Code = "CUB",
            Currency = "CUP"
          },
        new CountryPickerModel ()
        {
            Id=46,
            CountryFlag="cy.png",
            CountryName = "Cyprus",
            CountryISDCode = "+357",
            CountryCode = "CY",
            CountryIS03Code = "CYP",
            Currency = "EUR"
          },
        new CountryPickerModel ()
        {
            Id=47,
            CountryFlag="cz_flag.png",
            CountryName = "Czech Republic",
            CountryISDCode = "+420",
            CountryCode = "CZ",
            CountryIS03Code = "CZE",
            Currency = "CZK"
          },
        new CountryPickerModel ()
        {
            Id=48,
            CountryFlag="dk_flag.png",
            CountryName = "Denmark",
            CountryISDCode = "+45",
            CountryCode = "DK",
            CountryIS03Code = "DNK",
            Currency = "DKK"
          },
        new CountryPickerModel ()
        {
            Id=49,
            CountryFlag="dj_flag.png",
            CountryName = "Djibouti",
            CountryISDCode = "+253",
            CountryCode = "DJ",
            CountryIS03Code = "DJI",
            Currency = "DJF"
          },
        new CountryPickerModel ()
        {
            Id=50,
            CountryFlag="dm_flag.png",
            CountryName = "Dominica",
            CountryISDCode = "+1-767",
            CountryCode = "DM",
            CountryIS03Code = "DMA",
            Currency = "XCD"
          },
        new CountryPickerModel ()
         {
            Id=51,
            CountryFlag="do_flag.png",
            CountryName = "Dominican Republic",
            CountryISDCode = "+1-809",
            CountryCode = "DO",
            CountryIS03Code = "DOM",
            Currency = "DOP"
          },
        new CountryPickerModel ()
         {
            Id=52,
            CountryFlag="tp.png",
            CountryName = "East Timor",
            CountryISDCode = "+670",
            CountryCode = "TP",
            CountryIS03Code = "TLS",
            Currency = "USD"
          },
        new CountryPickerModel ()
          {
            Id=53,
            CountryFlag="ec.png",
            CountryName = "Ecuador",
            CountryISDCode = "+593",
            CountryCode = "EC",
            CountryIS03Code = "ECU",
            Currency = "USD"
          },
        new CountryPickerModel ()
          {
            Id=54,
            CountryFlag="eg.png",
            CountryName = "Egypt",
            CountryISDCode = "+20",
            CountryCode = "EG",
            CountryIS03Code = "EGY",
            Currency = "EGP"
          },
        new CountryPickerModel ()
          {
            Id=55,
            CountryFlag="sv.png",
            CountryName = "El Salvador",
            CountryISDCode = "+503",
            CountryCode = "SV",
            CountryIS03Code = "SLV",
            Currency = "SVC"
          },
        new CountryPickerModel ()
          {
            Id=56,
            CountryFlag="gq.png",
            CountryName = "Equatorial Guinea",
            CountryISDCode = "+240",
            CountryCode = "GQ",
            CountryIS03Code = "GNQ",
            Currency = "XAF"
          },
        new CountryPickerModel ()
          {
            Id=57,
            CountryFlag="er.png",
            CountryName = "Eritrea",
            CountryISDCode = "+291",
            CountryCode = "ER",
            CountryIS03Code = "ERI",
            Currency = "ERN"
          },
        new CountryPickerModel ()
          {
            Id=58,
            CountryFlag="ee.png",
            CountryName = "Estonia",
            CountryISDCode = "+372",
            CountryCode = "EE",
            CountryIS03Code = "EST",
            Currency = "EEK"
          },
        new CountryPickerModel ()
          {
            Id=59,
            CountryFlag="et.png",
            CountryName = "Ethiopia",
            CountryISDCode = "+251",
            CountryCode = "ET",
            CountryIS03Code = "ETH",
            Currency = "ETB"
          },
        new CountryPickerModel ()
          {
            Id=60,
            CountryFlag="fj.png",
            CountryName = "Fiji",
            CountryISDCode = "+679",
            CountryCode = "FJ",
            CountryIS03Code = "ETH",
            Currency = "FJD"
          },
            new CountryPickerModel ()
          {
            Id=61,
            CountryFlag="fi.png",
            CountryName = "Finland",
            CountryISDCode = "+358",
            CountryCode = "FI",
            CountryIS03Code = "FIN",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=62,
            CountryFlag="fr.png",
            CountryName = "France",
            CountryISDCode = "+33",
            CountryCode = "FR",
            CountryIS03Code = "FRA",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=63,
            CountryFlag="pf.png",
            CountryName = "French Polynesia",
            CountryISDCode = "+689",
            CountryCode = "PF",
            CountryIS03Code = "PYF",
            Currency = "XPF"
          },
            new CountryPickerModel ()
          {
            Id=64,
            CountryFlag="ga.png",
            CountryName = " Gabon",
            CountryISDCode = "+241",
            CountryCode = "GA",
            CountryIS03Code = "GAB",
            Currency = "XAF"
          },
           new CountryPickerModel ()
          {
            Id=65,
            CountryFlag="gm.png",
            CountryName = "Gambia",
            CountryISDCode = "+220",
            CountryCode = "GM",
            CountryIS03Code = "GMB",
            Currency = "GMD"
          },
         new CountryPickerModel ()
          {
            Id=66,
            CountryFlag="ge.png",
            CountryName = "Georgia",
            CountryISDCode = "+995",
            CountryCode = "GE",
            CountryIS03Code = "SGS",
            Currency = "GEL"
          },
         new CountryPickerModel ()
          {
            Id=67,
            CountryFlag="de_flag.png",
            CountryName = "Germany",
            CountryISDCode = "+49",
            CountryCode = "DE",
            CountryIS03Code = "DEU",
            Currency = "EUR"
          },
         new CountryPickerModel ()
          {
            Id=68,
            CountryFlag="gh.png",
            CountryName = "Ghana",
            CountryISDCode = "+233",
            CountryCode = "GH",
            CountryIS03Code = "GHA",
            Currency = "GHC"
          },
            new CountryPickerModel ()
          {
            Id=69,
            CountryFlag="gi.png",
            CountryName = "Gibraltar",
            CountryISDCode = "+350",
            CountryCode = "GI",
            CountryIS03Code = "GIB",
            Currency = "GIP"
          },
            new CountryPickerModel ()
          {
            Id=70,
            CountryFlag="gr.png",
            CountryName = "Greece",
            CountryISDCode = "+30",
            CountryCode = "GR",
            CountryIS03Code = "GRC",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=71,
            CountryFlag="gl.jpg",
            CountryName = "Greenland",
            CountryISDCode = "+299",
            CountryCode = "GL",
            CountryIS03Code = "GRL",
            Currency = "DKK"
          },
            new CountryPickerModel ()
          {
            Id=72,
            CountryFlag="gd.png",
            CountryName = "Grenada",
            CountryISDCode = "+1-473",
            CountryCode = "GD",
            CountryIS03Code = "GRD",
            Currency = "XCD"
          },
            new CountryPickerModel ()
          {
            Id=73,
            CountryFlag="gp.png",
            CountryName = "Guadeloupe",
            CountryISDCode = "+355",
            CountryCode = "GP",
            CountryIS03Code = "GLP",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=74,
            CountryFlag="gt.png",
            CountryName = "Guatemala",
            CountryISDCode = "+502",
            CountryCode = "GT",
            CountryIS03Code = "GTM",
            Currency = "GTQ"
          },
            new CountryPickerModel ()
          {
            Id=75,
            CountryFlag="gn.png",
            CountryName = "Guinea",
            CountryISDCode = "+224",
            CountryCode = "GN",
            CountryIS03Code = "GTM",
            Currency = "GNF"
          },
            new CountryPickerModel ()
          {
            Id=76,
            CountryFlag="gw.png",
            CountryName = "Guinea-Bissau",
            CountryISDCode = "+245",
            CountryCode = "GW",
            CountryIS03Code = "PNG",
            Currency = "XOF"
          },
            new CountryPickerModel ()
          {
            Id=77,
            CountryFlag="gy.png",
            CountryName = "Guyana",
            CountryISDCode = "+592",
            CountryCode = "GY",
            CountryIS03Code = "GUY",
            Currency = "GYD"
          },
            new CountryPickerModel ()
          {
            Id=78,
            CountryFlag="ht.png",
            CountryName = "Haiti",
            CountryISDCode = "+509",
            CountryCode = "HT",
            CountryIS03Code = "HTI",
            Currency = "HTG" 
          },
            new CountryPickerModel ()
          {
            Id=79,
            CountryFlag="hn.png",
            CountryName = "Honduras",
            CountryISDCode = "+504",
            CountryCode = "HN",
            CountryIS03Code = "HND",
            Currency = "HNL"
          },
            new CountryPickerModel ()
          {
            Id=80,
            CountryFlag="hk.png",
            CountryName = "Hong Kong",
            CountryISDCode = "+852",
            CountryCode = "HK",
            CountryIS03Code = "HKG",
            Currency = "HKD"
          },
            new CountryPickerModel ()
          {
            Id=81,
            CountryFlag="hu.png",
            CountryName = "Hungary",
            CountryISDCode = "+36",
            CountryCode = "HU",
            CountryIS03Code = "HUN",
            Currency = "HUF"
          },
            new CountryPickerModel ()
          {
            Id=82,
            CountryFlag="is.png",
            CountryName = "Iceland",
            CountryISDCode = "+354",
            CountryCode = "IS",
            CountryIS03Code = "ISL",
            Currency = "ISK"
          },
            new CountryPickerModel ()
          {
            Id=1,
            CountryFlag="in.png",
            CountryName = "India",
            CountryISDCode = "+91",
            CountryCode = "IN",
            CountryIS03Code = "IND",
            Currency = "INR"
          },
            new CountryPickerModel ()
          {
            Id=83,
            CountryFlag="id.png",
            CountryName = "Indonesia",
            CountryISDCode = "+62",
            CountryCode = "ID",
            CountryIS03Code = "IDN",
            Currency = "IDR"
          },
            new CountryPickerModel ()
          {
            Id=84,
            CountryFlag="ir.png",
            CountryName = "Iran",
            CountryISDCode = "+98",
            CountryCode = "IR",
            CountryIS03Code = "IRN",
            Currency = "IRR"
          },
            new CountryPickerModel ()
          {
            Id=85,
            CountryFlag="iq.png",
            CountryName = "Iraq",
            CountryISDCode = "+964",
            CountryCode = "IQ",
            CountryIS03Code = "IRQ",
            Currency = "IQD"
          },
            new CountryPickerModel ()
          {
            Id=86,
            CountryFlag="ie.png",
            CountryName = "Ireland",
            CountryISDCode = "+353",
            CountryCode = "IE",
            CountryIS03Code = "IRL",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=87,
            CountryFlag="il.png",
            CountryName = "Israel",
            CountryISDCode = "+972",
            CountryCode = "IL",
            CountryIS03Code = "ISR",
            Currency = "ILS"
          },
            new CountryPickerModel ()
          {
            Id=88,
            CountryFlag="it.png",
            CountryName = "Italy",
            CountryISDCode = "+39",
            CountryCode = "IT",
            CountryIS03Code = "ITA",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=89,
            CountryFlag="jm.png",
            CountryName = "Jamaica",
            CountryISDCode = "+1-876",
            CountryCode = "JM",
            CountryIS03Code = "JAM",
            Currency = "JMD"
          },
            new CountryPickerModel ()
          {
            Id=90,
            CountryFlag="jp.png",
            CountryName = "Japan",
            CountryISDCode = "+81",
            CountryCode = "JP",
            CountryIS03Code = "JPN",
            Currency = "JPY"
          },
            new CountryPickerModel ()
          {
            Id=91,
            CountryFlag="jo.png",
            CountryName = "Jordan",
            CountryISDCode = "+962",
            CountryCode = "JO",
            CountryIS03Code = "JOR",
            Currency = "JOD"
          },
            new CountryPickerModel ()
          {
            Id=92,
            CountryFlag="kz.png",
            CountryName = "Kazakhstan",
            CountryISDCode = "+7",
            CountryCode = "KZ",
            CountryIS03Code = "KAZ",
            Currency = "KZT"
          },
            new CountryPickerModel ()
          {
            Id=93,
            CountryFlag="ke.png",
            CountryName = "Kenya",
            CountryISDCode = "+254",
            CountryCode = "KE",
            CountryIS03Code = "KEN",
            Currency = "KES"
          },
            new CountryPickerModel ()
          {
            Id=94,
            CountryFlag="ki.png",
            CountryName = "Kiribati",
            CountryISDCode = "+686",
            CountryCode = "KI",
            CountryIS03Code = "KIR",
            Currency = "AUD"
          },
            new CountryPickerModel ()
          {
            Id=95,
            CountryFlag="kp.png",
            CountryName = "Korea, North",
            CountryISDCode = "+850",
            CountryCode = "KP",
            CountryIS03Code = "PRK",
            Currency = "KPW"
          },
             new CountryPickerModel ()
          {
            Id=96,
            CountryFlag="kr.png",
            CountryName = "Korea, South",
            CountryISDCode = "+82",
            CountryCode = "KR",
            CountryIS03Code = "PRK",
            Currency = "KRW"
          },
              new CountryPickerModel ()
          {
            Id=97,
            CountryFlag="kw.png",
            CountryName = "Kuwait",
            CountryISDCode = "+965",
            CountryCode = "KW",
            CountryIS03Code = "KWT",
            Currency = "KRW"
          },
              new CountryPickerModel ()
          {
            Id=98,
            CountryFlag="kg.png",
            CountryName = "Kyrgyzstan",
            CountryISDCode = "+996",
            CountryCode = "KG",
            CountryIS03Code = "KGZ",
            Currency = "KGS"
          },
              new CountryPickerModel ()
          {
            Id=99,
            CountryFlag="la.png",
            CountryName = "Laos",
            CountryISDCode = "+856",
            CountryCode = "LA",
            CountryIS03Code = "LAO",
            Currency = "LAK"
          },
            new CountryPickerModel ()
          {
            Id=100,
            CountryFlag="lv.png",
            CountryName = "Latvia",
            CountryISDCode = "+371",
            CountryCode = "LV",
            CountryIS03Code = "LVA",
            Currency = "LVL"
          },
            new CountryPickerModel ()
          {
            Id=101,
            CountryFlag="lb.png",
            CountryName = "Lebanon",
            CountryISDCode = "+961",
            CountryCode = "LB",
            CountryIS03Code = "LBN",
            Currency = "LBP"
          },
           new CountryPickerModel ()
          {
            Id=102,
            CountryFlag="lr.png",
            CountryName = "Liberia",
            CountryISDCode = "+231",
            CountryCode = "LR",
            CountryIS03Code = "LBR",
            Currency = "LRD"
          },
           new CountryPickerModel ()
          {
            Id=103,
            CountryFlag="ly.png",
            CountryName = "Libya",
            CountryISDCode = "+218",
            CountryCode = "LY",
            CountryIS03Code = "LBY",
            Currency = "LYD"
          },
           new CountryPickerModel ()
          {
            Id=104,
            CountryFlag="li.png",
            CountryName = "Liechtenstein",
            CountryISDCode = "+423",
            CountryCode = "LI",
            CountryIS03Code = "LIE",
            Currency = "CHF"
          },
           new CountryPickerModel ()
          {
            Id=105,
            CountryFlag="lt.png",
            CountryName = "Lithuania",
            CountryISDCode = "+370",
            CountryCode = "LT",
            CountryIS03Code = "LTU",
            Currency = "LTL"
          },
           new CountryPickerModel ()
          {
            Id=106,
            CountryFlag="lu.png",
            CountryName = "Luxembourg",
            CountryISDCode = "+352",
            CountryCode = "LU",
            CountryIS03Code = "LUX",
            Currency = "EUR"
          },
           new CountryPickerModel ()
          {
            Id=107,
            CountryFlag="mo.png",
            CountryName = "Macau SAR",
            CountryISDCode = "+853",
            CountryCode = "MO",
            CountryIS03Code = "MAC",
            Currency = "MOP"
          },
           new CountryPickerModel ()
          {
            Id=108,
            CountryFlag="mk.png",
            CountryName = "Macedonia",
            CountryISDCode = "+389",
            CountryCode = "MK",
            CountryIS03Code = "MKD",
            Currency = "MKD"
          },
           new CountryPickerModel ()
          {
            Id=109,
            CountryFlag="mg.png",
            CountryName = "Madagascar",
            CountryISDCode = "+261",
            CountryCode = "MG",
            CountryIS03Code = "MDG",
            Currency = "MGA"
          },
           new CountryPickerModel ()
          {
            Id=110,
            CountryFlag="mw.png",
            CountryName = "Malawi",
            CountryISDCode = "+265",
            CountryCode = "MW",
            CountryIS03Code = "MWI",
            Currency = "MWK"
          },
           new CountryPickerModel ()
          {
            Id=111,
            CountryFlag="my.png",
            CountryName = "Malaysia",
            CountryISDCode = "+60",
            CountryIS03Code = "MYS",
            Currency = "MYR"
          },
           new CountryPickerModel ()
          {
            Id=112,
            CountryFlag="mv.png",
            CountryName = "Maldives",
            CountryISDCode = "+960",
            CountryCode = "MV",
            CountryIS03Code = "MDV",
            Currency = "MVR"
          },
           new CountryPickerModel ()
          {
            Id=113,
            CountryFlag="ml.png",
            CountryName = "Mali",
            CountryISDCode = "+223",
            CountryCode = "ML",
            CountryIS03Code = "MLI",
            Currency = "XOF"
          },
           new CountryPickerModel ()
          {
            Id=114,
            CountryFlag="mt.png",
            CountryName = "Malta",
            CountryISDCode = "+356",
            CountryCode = "MT",
            CountryIS03Code = "MLT",
            Currency = "EUR"
          },
           new CountryPickerModel ()
          {
            Id=115,
            CountryFlag="mh.png",
            CountryName = "Marshall Islands",
            CountryISDCode = "+692",
            CountryCode = "MH",
            CountryIS03Code = "MHL",
            Currency = "USD"
          },
           new CountryPickerModel ()
          {
            Id=116,
            CountryFlag="mq.png",
            CountryName = "Martinique",
            CountryISDCode = "+596",
            CountryCode = "MQ",
            CountryIS03Code = "MTQ",
            Currency = "EUR"
          },
           new CountryPickerModel ()
          {
            Id=117,
            CountryFlag="mr.png",
            CountryName = "Mauritania",
            CountryISDCode = "+222",
            CountryCode = "MR",
            CountryIS03Code = "MRT",
            Currency = "MRU"
          },
           new CountryPickerModel ()
          {
            Id=118,
            CountryFlag="mu.png",
            CountryName = "Mauritius",
            CountryISDCode = "+230",
            CountryCode = "MU",
            CountryIS03Code = "MUS",
            Currency = "MUR"
          },
           new CountryPickerModel ()
          {
            Id=119,
            CountryFlag="mx.png",
            CountryName = "Mexico",
            CountryISDCode = "+52",
            CountryCode = "MX",
            CountryIS03Code = "MEX",
            Currency = "MXN"
          },
           new CountryPickerModel ()
          {
            Id=120,
            CountryFlag="fm.png",
            CountryName = "Micronesia",
            CountryISDCode = "+691",
            CountryCode = "FM",
            CountryIS03Code = "FSM",
            Currency = "USD"
          },
           new CountryPickerModel ()
          {
            Id=121,
            CountryFlag="md.png",
            CountryName = "Moldova",
            CountryISDCode = "+373",
            CountryCode = "MD",
            CountryIS03Code = "MDA",
            Currency = "MDL"
          },
           new CountryPickerModel ()
          {
            Id=122,
            CountryFlag="mc.png",
            CountryName = "Monaco",
            CountryISDCode = "+377",
            CountryCode = "MC",
            CountryIS03Code = "MCO",
            Currency = "EUR"
           },
            new CountryPickerModel ()
          {
            Id=123,
            CountryFlag="mn.png",
            CountryName = "Mongolia",
            CountryISDCode = "+976",
            CountryCode = "MN",
            CountryIS03Code = "MNG",
            Currency = "MNT"
            },
            new CountryPickerModel ()
          {
            Id=124,
            CountryFlag="me.png",
            CountryName = "Montenegro",
            CountryISDCode = "+382",
            CountryCode = "ME",
            CountryIS03Code = "MNE",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=125,
            CountryFlag="ma.png",
            CountryName = "Morocco",
            CountryISDCode = "+212",
            CountryCode = "MA",
            CountryIS03Code = "MAR",
            Currency = "MAD"
          },
            new CountryPickerModel ()
          {
            Id=126,
            CountryFlag="mz.png",
            CountryName = "Mozambique",
            CountryISDCode = "+258",
            CountryCode = "MZ",
            CountryIS03Code = "MOZ",
            Currency = "MZN"
          },
            new CountryPickerModel ()
          {
            Id=127,
            CountryFlag="mm.png",
            CountryName = "Myanmar",
            CountryISDCode = "+95",
            CountryCode = "MM",
            CountryIS03Code = "MMR",
            Currency = "MMK"
          },
            new CountryPickerModel ()
          {
            Id=128,
            CountryFlag="na.png",
            CountryName = "Namibia",
            CountryISDCode = "+264",
            CountryCode = "NA",
            CountryIS03Code = "NAM",
            Currency = "NAD"
          },
            new CountryPickerModel ()
          {
            Id=129,
            CountryFlag="nr.png",
            CountryName = "Nauru",
            CountryISDCode = "+674",
            CountryCode = "NR",
            CountryIS03Code = "NRU",
            Currency = "AUD"
          },
            new CountryPickerModel ()
          {
            Id=130,
            CountryFlag="np.png",
            CountryName = "Nepal",
            CountryISDCode = "+977",
            CountryCode = "NP",
            CountryIS03Code = "NPL",
            Currency = "NPR"
          },
            new CountryPickerModel ()
          {
            Id=131,
            CountryFlag="nl.png",
            CountryName = "Netherlands",
            CountryISDCode = "+31",
            CountryCode = "NL",
            CountryIS03Code = "NLD",
            Currency = "ANG"
          },
            new CountryPickerModel ()
          {
            Id=132,
            CountryFlag="nc.png",
            CountryName = "New Caledonia",
            CountryISDCode = "+687",
            CountryCode = "NC",
            CountryIS03Code = "NCL",
            Currency = "XPF"
          },
            new CountryPickerModel ()
          {
            Id=133,
            CountryFlag="nz.png",
            CountryName = "New Zealand",
            CountryISDCode = "+64",
            CountryCode = "NZ",
            CountryIS03Code = "NCL",
            Currency = "NZD"
          },
            new CountryPickerModel ()
          {
            Id=134,
            CountryFlag="ni.png",
            CountryName = "Nicaragua",
            CountryISDCode = "+505",
            CountryCode = "NZ",
            CountryIS03Code = "NIC",
            Currency = "NIO"
          },
            new CountryPickerModel ()
          {
            Id=135,
            CountryFlag="ne.png",
            CountryName = "Niger",
            CountryISDCode = "+227",
            CountryCode = "NE",
            CountryIS03Code = "NER",
            Currency = "XOF"
          },
            new CountryPickerModel ()
          {
            Id=136,
            CountryFlag="ng.png",
            CountryName = "Nigeria",
            CountryISDCode = "+234",
            CountryCode = "NG",
            CountryIS03Code = "NGA",
            Currency = "NGN"
          },
            new CountryPickerModel ()
          {
            Id=137,
            CountryFlag="mp.png",
            CountryName = "Northern Mariana Islands",
            CountryISDCode = "+1-670",
            CountryCode = "MP",
            CountryIS03Code = "MNP",
            Currency = "USD"
          },
            new CountryPickerModel ()
          {
            Id=138,
            CountryFlag="no.png",
            CountryName = "Norway",
            CountryISDCode = "+47",
            CountryCode = "NO",
            CountryIS03Code = "NOR",
            Currency = "NOK"
          },
            new CountryPickerModel ()
          {
            Id=139,
            CountryFlag="om.png",
            CountryName = "Oman",
            CountryISDCode = "+968",
            CountryCode = "OM",
            CountryIS03Code = "OMN",
            Currency = "OMR"
          },
            new CountryPickerModel ()
          {
            Id=140,
            CountryFlag="pk.png",
            CountryName = "Pakistan",
            CountryISDCode = "+92",
            CountryCode = "PK",
            CountryIS03Code = "PAK",
            Currency = "PKR"
          },
            new CountryPickerModel ()
          {
            Id=141,
            CountryFlag="pw.png",
            CountryName = "Palau",
            CountryISDCode = "+680",
            CountryCode = "PW",
            CountryIS03Code = "PLW",
            Currency = "USD"
          },
            new CountryPickerModel ()
          {
            Id=142,
            CountryFlag="ps.png",
            CountryName = "Palestinian",
            CountryISDCode = "+970",
            CountryCode = "PS",
            CountryIS03Code = "PSE",
            Currency = "ILS"
          },
            new CountryPickerModel ()
          {
            Id=143,
            CountryFlag="pa.png",
            CountryName = "Panama",
            CountryISDCode = "+507",
            CountryCode = "PA",
            CountryIS03Code = "PAN",
            Currency = "PAB"
          },
            new CountryPickerModel ()
          {
            Id=144,
            CountryFlag="pg.png",
            CountryName = "Papua New Guinea",
            CountryISDCode = "+675",
            CountryCode = "PG",
            CountryIS03Code = "PNG",
            Currency = "PGK"
          },
            new CountryPickerModel ()
          {
            Id=145,
            CountryFlag="py.png",
            CountryName = "Paraguay",
            CountryISDCode = "+595",
            CountryCode = "PY",
            CountryIS03Code = "PRY",
            Currency = "PYG"
          },
            new CountryPickerModel ()
          {
            Id=146,
            CountryFlag="pe.png",
            CountryName = "Peru",
            CountryISDCode = "+51",
            CountryCode = "PE",
            CountryIS03Code = "PER",
            Currency = "PEN"
          },
            new CountryPickerModel ()
          {
            Id=147,
            CountryFlag="ph.png",
            CountryName = "Philippines",
            CountryISDCode = "+63",
            CountryCode = "PH",
            CountryIS03Code = "PHL",
            Currency = "PHP"
          },
            new CountryPickerModel ()
          {
            Id=148,
            CountryFlag="pl.png",
            CountryName = "Poland",
            CountryISDCode = "+48",
            CountryCode = "PL",
            CountryIS03Code = "POL",
            Currency = "PLN"
          },
            new CountryPickerModel ()
          {
            Id=149,
            CountryFlag="pt.png",
            CountryName = "Portugal",
            CountryISDCode = "+351",
            CountryCode = "PT",
             CountryIS03Code = "PRT",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=150,
            CountryFlag="pr.jpg",
            CountryName = "Puerto Rico",
            CountryISDCode = "+1-787",
            CountryCode = "PR",
            CountryIS03Code = "PRI",
            Currency = "USD"
          },
            new CountryPickerModel ()
          {
            Id=151,
            CountryFlag="qa.png",
            CountryName = "Qatar",
            CountryISDCode = "+974",
            CountryCode = "QA",
            CountryIS03Code = "QAT",
            Currency = "QAR"
          },
            new CountryPickerModel ()
          {
            Id=152,
            CountryFlag="re.jpg",
            CountryName = "Réunion",
            CountryISDCode = "+262",
            CountryCode = "RE",
            CountryIS03Code = "REU",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=153,
            CountryFlag="ro.png",
            CountryName = "Romania",
            CountryISDCode = "+40",
            CountryCode = "RO",
            CountryIS03Code = "ROU",
            Currency = "RON"
          },
            new CountryPickerModel ()
          {
            Id=154,
            CountryFlag="ru.png",
            CountryName = "Russian Federation",
            CountryISDCode = "+7-73",
            CountryCode = "RU",
            CountryIS03Code = "RUS",
            Currency = "RUB"
          },
            new CountryPickerModel ()
          {
            Id=155,
            CountryFlag="rw.png",
            CountryName = "Rwanda",
            CountryISDCode = "+250",
            CountryCode = "RW",
            CountryIS03Code = "RWA",
            Currency = "RWF"
          },
            new CountryPickerModel ()
          {
            Id=156,
            CountryFlag="kn.png",
            CountryName = "Saint Kitts and Nevis",
            CountryISDCode = "+1-869",
            CountryCode = "KN",
            CountryIS03Code = "KNA",
            Currency = "XCD"
          },
            new CountryPickerModel ()
          {
            Id=157,
            CountryFlag="lc.png",
            CountryName = "Saint Lucia",
            CountryISDCode = "+1-758",
            CountryCode = "LC",
            CountryIS03Code = "LCA",
            Currency = "XCD"
          },
            new CountryPickerModel ()
          {
            Id=158,
            CountryFlag="ws.png",
            CountryName = "Samoa",
            CountryISDCode = "+685",
            CountryCode = "WS",
            CountryIS03Code = "WSM",
            Currency = "WST"
          },
            new CountryPickerModel ()
          {
            Id=159,
            CountryFlag="sm.png",
            CountryName = "San Marino",
            CountryISDCode = "+378",
            CountryCode = "SM",
            CountryIS03Code = "SMR",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=160,
            CountryFlag="st.png",
            CountryName = "Sao Tome and Princ",
            CountryISDCode = "+239",
            CountryCode = "ST",
            CountryIS03Code = "STP",
            Currency = "STN"
          },
            new CountryPickerModel ()
          {
            Id=161,
            CountryFlag="sa.png",
            CountryName = "Saudi Arabia",
            CountryISDCode = "+966",
            CountryCode = "SA",
            CountryIS03Code = "SAU",
            Currency = "SAR"
          },
            new CountryPickerModel ()
          {
            Id=162,
            CountryFlag="sn.png",
            CountryName = "Senegal",
            CountryISDCode = "+221",
            CountryCode = "SN",
            CountryIS03Code = "SEN",
            Currency = "XOF"
          },
            new CountryPickerModel ()
          {
            Id=163,
            CountryFlag="rs.png",
            CountryName = "Serbia",
            CountryISDCode = "+381",
            CountryCode = "RS",
            CountryIS03Code = "SRB",
            Currency = "RSD"
          },
            new CountryPickerModel ()
          {
            Id=164,
            CountryFlag="sc.png",
            CountryName = "Seychelles",
            CountryISDCode = "+248",
            CountryCode = "SC",
            CountryIS03Code = "SYC",
            Currency = "SCR"
          },
            new CountryPickerModel ()
          {
            Id=165,
            CountryFlag="sl.png",
            CountryName = "Sierra Leone",
            CountryISDCode = "+232",
            CountryCode = "SL",
            CountryIS03Code = "SLE",
            Currency = "SLL"
          },
            new CountryPickerModel ()
          {
            Id=166,
            CountryFlag="sg.png",
            CountryName = "Singapore",
            CountryISDCode = "+65",
            CountryCode = "SG",
            CountryIS03Code = "SGP",
            Currency = "SGD"
          },
            new CountryPickerModel ()
          {
            Id=167,
            CountryFlag="sk.png",
            CountryName = "Slovakia",
            CountryISDCode = "+421",
            CountryCode = "SK",
            CountryIS03Code = "SVK",
            Currency = "EUR"
          },
            new CountryPickerModel ()
          {
            Id=168,
            CountryFlag="sb.png",
            CountryName = "Solomon Islands",
            CountryISDCode = "+677",
            CountryCode = "SB",
            CountryIS03Code = "SLB",
            Currency = "SBD"
          },
             new CountryPickerModel ()
          {
            Id=169,
            CountryFlag="so.png",
            CountryName = "Somalia",
            CountryISDCode = "+252",
            CountryCode = "SO",
            CountryIS03Code = "SOM",
            Currency = "SOS"
          },
              new CountryPickerModel ()
          {
            Id=170,
            CountryFlag="za.png",
            CountryName = "South Africa",
            CountryISDCode = "+27",
            CountryCode = "ZA",
            CountryIS03Code = "ZAF",
            Currency = "ZAR"
          },
               new CountryPickerModel ()
          {
            Id=171,
            CountryFlag="es.png",
            CountryName = "Spain",
            CountryISDCode = "+34",
            CountryCode = "ES",
            CountryIS03Code = "ESP",
            Currency = "EUR"
          },
           new CountryPickerModel ()
          {
            Id=172,
            CountryFlag="lk.png",
            CountryName = "Sri Lanka",
            CountryISDCode = "+94",
            CountryCode = "LK",
            CountryIS03Code = "LKA",
            Currency = "LKR"
          },
           new CountryPickerModel ()
          {
            Id=173,
            CountryFlag="vc.png",
            CountryName = "St Vincent and Gren",
            CountryISDCode = "+1-784",
            CountryCode = "VC",
            CountryIS03Code = "VCT",
            Currency = "XCD"
          },
           new CountryPickerModel ()
          {
            Id=174,
            CountryFlag="sd.png",
            CountryName = "Sudan",
            CountryISDCode = "+249",
            CountryCode = "SD",
            CountryIS03Code = "SDN",
            Currency = "SDG"
          },
           new CountryPickerModel ()
          {
            Id=175,
            CountryFlag="sr.png",
            CountryName = "Suriname",
            CountryISDCode = "+597",
            CountryCode = "SR",
            CountryIS03Code = "SUR",
            Currency = "SRD"
          },
           new CountryPickerModel ()
          {
            Id=176,
            CountryFlag="sz.png",
            CountryName = "Swaziland",
            CountryISDCode = "+268",
            CountryCode = "SZ",
            CountryIS03Code = "SWZ",
            Currency = "SZL"
          },
           new CountryPickerModel ()
          {
            Id=177,
            CountryFlag="se.png",
            CountryName = "Sweden",
            CountryISDCode = "+46",
            CountryCode = "SE",
            CountryIS03Code = "SWE",
            Currency = "SEK"
          },
           new CountryPickerModel ()
          {
            Id=178,
            CountryFlag="ch.png",
            CountryName = "Switzerland",
            CountryISDCode = "+41",
            CountryCode = "CH",
            CountryIS03Code = "CHE",
            Currency = "CHF"
          },
           new CountryPickerModel ()
          {
            Id=179,
            CountryFlag="sy.png",
            CountryName = "Syria",
            CountryISDCode = "+963",
            CountryCode = "SY",
            CountryIS03Code = "SYR",
            Currency = "SYP"
          },
           new CountryPickerModel ()
          {
            Id=180,
            CountryFlag="tw.png",
            CountryName = "Taiwan",
            CountryISDCode = "+886",
            CountryCode = "TW",
            CountryIS03Code = "TWN",
            Currency = "TWD"
          },
           new CountryPickerModel ()
          {
            Id=181,
            CountryFlag="tj.png",
            CountryName = "Tajikistan",
            CountryISDCode = "+992",
            CountryCode = "TJ",
            CountryIS03Code = "TJK",
            Currency = "TJS"
          },
           new CountryPickerModel ()
          {
            Id=182,
            CountryFlag="tz.png",
            CountryName = "Tanzania",
            CountryISDCode = "+255",
            CountryCode = "TZ",
            CountryIS03Code = "TZA",
            Currency = "TZS"
          },
           new CountryPickerModel ()
          {
            Id=183,
            CountryFlag="th.png",
            CountryName = "Thailand",
            CountryISDCode = "+66",
            CountryCode = "TH",
            CountryIS03Code = "THA",
            Currency = "THB"
          },
           new CountryPickerModel ()
          {
            Id=184,
            CountryFlag="tg.png",
            CountryName = "Togo",
            CountryISDCode = "+228",
            CountryCode = "TG",
            CountryIS03Code = "TGO",
            Currency = "XOF"
          },
           new CountryPickerModel ()
          {
            Id=185,
            CountryFlag="to.png",
            CountryName = "Tonga",
            CountryISDCode = "+676",
            CountryCode = "TO",
            CountryIS03Code = "TON",
            Currency = "TOP"
          },
           new CountryPickerModel ()
          {
            Id=186,
            CountryFlag="tt.png",
            CountryName = "Trinidad and Tobago",
            CountryISDCode = "+1-868",
            CountryCode = "TT",
            CountryIS03Code = "TTO",
            Currency = "TTD"
          },
           new CountryPickerModel ()
          {
            Id=187,
            CountryFlag="tn.png",
            CountryName = "Tunisia",
            CountryISDCode = "+216",
            CountryCode = "TN",
            CountryIS03Code = "TUN",
            Currency = "TND"
          },
           new CountryPickerModel ()
          {
            Id=188,
            CountryFlag="tr.png",
            CountryName = "Turkey",
            CountryISDCode = "+90",
            CountryCode = "TR",
            CountryIS03Code = "TUR",
            Currency = "TRY"
          },
           new CountryPickerModel ()
          {
            Id=189,
            CountryFlag="tm.png",
            CountryName = "Turkmenistan",
            CountryISDCode = "+993",
            CountryCode = "TM",
            CountryIS03Code = "TKM",
            Currency = "TMT"
          },
           new CountryPickerModel ()
          {
            Id=190,
            CountryFlag="tv.png",
            CountryName = "Tuvalu",
            CountryISDCode = "+688",
            CountryCode = "TV",
            CountryIS03Code = "TUV",
            Currency = "AUD"
          },
           new CountryPickerModel ()
          {
            Id=191,
            CountryFlag="ug.png",
            CountryName = "Uganda",
            CountryISDCode = "+256",
            CountryCode = "UG",
            CountryIS03Code = "UGA",
            Currency = "UGX"
          },
           new CountryPickerModel ()
          {
            Id=192,
            CountryFlag="ua.png",
            CountryName = "Ukraine",
            CountryISDCode = "+380",
            CountryCode = "UA",
            CountryIS03Code = "UKR",
            Currency = "UAH"
          },
           new CountryPickerModel ()
          {
            Id=193,
            CountryFlag="ae.png",
            CountryName = "United Arab Emirates",
            CountryISDCode = "+971",
            CountryCode = "AE",
            CountryIS03Code = "ARE",
            Currency = "AED"
          },
           new CountryPickerModel ()
          {
            Id=194,
            CountryFlag="gb.png",
            CountryName = "United Kingdom",
            CountryISDCode = "+44",
            CountryCode = "GB",
            CountryIS03Code = "GBR",
            Currency = "GBP"
          },
           new CountryPickerModel ()
          {
            Id=2,
            CountryFlag="us.png",
            CountryName = "United States",
            CountryISDCode = "+1",
            CountryCode = "US",
            CountryIS03Code = "UMI",
            Currency = "USD"
          },
           new CountryPickerModel ()
          {
            Id=195,
            CountryFlag="uy.png",
            CountryName = "Uruguay",
            CountryISDCode = "+598",
            CountryCode = "UY",
            CountryIS03Code = "URY",
            Currency = "UYU"
          },
           new CountryPickerModel ()
          {
            Id=196,
            CountryFlag="uz.png",
            CountryName = "Uzbekistan",
            CountryISDCode = "+998",
            CountryCode = "UZ",
            CountryIS03Code = "UZB",
            Currency = "UZS"
          },
           new CountryPickerModel ()
          {
            Id=197,
            CountryFlag="vu.png",
            CountryName = "Vanuatu",
            CountryISDCode = "+678",
            CountryCode = "VU",
            CountryIS03Code = "VUT",
            Currency = "VUV"
          },
           new CountryPickerModel ()
          {
            Id=198,
            CountryFlag="va.png",
            CountryName = "Vatican City",
            CountryISDCode = "+379",
            CountryCode = "VA",
            CountryIS03Code = "VAT",
            Currency = "EUR"
          },
           new CountryPickerModel ()
          {
            Id=199,
            CountryFlag="ve.png",
            CountryName = "Venezuela",
            CountryISDCode = "+58",
            CountryCode = "VE",
            CountryIS03Code = "VEN",
            Currency = "VES"
          },
           new CountryPickerModel ()
          {
            Id=200,
            CountryFlag="vn.png",
            CountryName = "Vietnam",
            CountryISDCode = "+84",
            CountryCode = "VN",
            CountryIS03Code = "VNM",
            Currency = "VND"
          },
           new CountryPickerModel ()
          {
            Id=201,
            CountryFlag="vg.png",
            CountryName = "Virgin Islands, British",
            CountryISDCode = "+1-284",
            CountryCode = "VG",
            CountryIS03Code = "VGB",
            Currency = "USD"
          },
           new CountryPickerModel ()
          {
            Id=202,
            CountryFlag="vi.png",
            CountryName = "Virgin Islands, U.S.",
            CountryISDCode = "+1-340",
            CountryCode = "VI",
            CountryIS03Code = "VIR",
            Currency = "USD"
          },
           new CountryPickerModel ()
          {
            Id=203,
            CountryFlag="eh.png",
            CountryName = "Western Sahara",
            CountryISDCode = "+212",
            CountryCode = "EH",
            CountryIS03Code = "ESH",
            Currency = "MAD"
          },
           new CountryPickerModel ()
          {
            Id=204,
            CountryFlag="ye.png",
            CountryName = "Yemen",
            CountryISDCode = "+967",
            CountryCode = "YE",
            CountryIS03Code = "YEM",
            Currency = "YER"
          },
           new CountryPickerModel ()
          {
            Id=205,
            CountryFlag="zm.png",
            CountryName = "Zambia",
            CountryISDCode = "+260",
            CountryCode = "ZM",
            CountryIS03Code = "ZMB",
            Currency = "ZMW"
          },
           new CountryPickerModel ()
          {
            Id=206,
            CountryFlag="zw.png",
            CountryName = "Zimbabwe",
            CountryISDCode = "+263",
            CountryCode = "ZW",
            CountryIS03Code = "ZWE",
            Currency = "USD"
          },
           new CountryPickerModel ()
          {
            Id=207,
            CountryFlag="aruba.png",
            CountryName = "Aruba",
            CountryISDCode = "+297",
            CountryCode = "ABW",
            CountryIS03Code = "ABW",
            Currency = "AWG"
          },
           new CountryPickerModel ()
          {
            Id=208,
            CountryFlag="bermuda.png",
            CountryName = "Bermuda",
            CountryISDCode = "+1441",
            CountryCode = "BM",
            CountryIS03Code = "BMU",
            Currency = "BMD"
          },
            new CountryPickerModel ()
          {
            Id=209,
            CountryFlag="cayman.png",
            CountryName = "Cayman",
            CountryISDCode = "+1345",
            CountryCode = "CYM",
            CountryIS03Code = "CYM",
            Currency = "KYD"
          },
       };
        }
        public static List<CountryPickerModel> CurrencyPickerData()
        {
            return new List<CountryPickerModel>
        {
          new CountryPickerModel ()
          {
            Id=4,
            CountryFlag="al.png",
            CountryName = "Albania",
            CountryISDCode = "+355",
            CountryCode = "AL",
            CountryIS03Code = "ALB",
            Currency = "ALL"
          },
          new CountryPickerModel ()
          {
            Id=3,
            CountryFlag="af.png",
            CountryName = "Afghanistan",
            CountryISDCode = "+93",
            CountryCode = "AF",
            CountryIS03Code = "AFG",
            Currency = "AFN"
          },
        new CountryPickerModel ()
          {
            Id=9,
            CountryFlag="ar.png",
            CountryName = "Argentina",
            CountryISDCode = "+54",
            CountryCode = "AR",
            CountryIS03Code = "ARG",
            Currency = "ARS"
          },
         new CountryPickerModel ()
          {
            Id=207,
            CountryFlag="aruba.png",
            CountryName = "Aruba",
            CountryISDCode = "+297",
            CountryCode = "ABW",
            CountryIS03Code = "ABW",
            Currency = "AWG"
          },
         new CountryPickerModel ()
          {
            Id=190,
            CountryFlag="tv.png",
            CountryName = "Australia",
            CountryISDCode = "+688",
            CountryCode = "TV",
            CountryIS03Code = "TUV",
            Currency = "AUD"
          },
         new CountryPickerModel ()
          {
            Id=13,
            CountryFlag="az.png",
            CountryName = "Azerbaijan",
            CountryISDCode = "+994",
            CountryCode = "AZ",
            CountryIS03Code = "AZE",
            Currency = "AZN"
          },
         new CountryPickerModel ()
          {
            Id=14,
            CountryFlag="bs.png",
            CountryName = "Bahamas",
            CountryISDCode = "+1-242",
            CountryCode = "BS",
            CountryIS03Code = "BSD",
            Currency = "BSD"
          },
         new CountryPickerModel ()
          {
            Id=17,
            CountryFlag="bb.png",
            CountryName = "Barbados",
            CountryISDCode = "+1-246",
            CountryCode = "BB",
            CountryIS03Code = "BRB",
            Currency = "BBD"
          },
         new CountryPickerModel ()
          {
            Id=18,
            CountryFlag="by.png",
            CountryName = "Belarus",
            CountryISDCode = "+375",
            CountryCode = "BY",
            CountryIS03Code = "BLR",
            Currency = "BYR"
          },
         new CountryPickerModel ()
          {
            Id=20,
            CountryFlag="bz.png",
            CountryName = "Belize",
            CountryISDCode = "+501",
            CountryCode = "BZ",
            CountryIS03Code = "BLZ",
             Currency = "BZD"
          },
          new CountryPickerModel ()
          {
            Id=208,
            CountryFlag="bermuda.png",
            CountryName = "Bermuda",
            CountryISDCode = "+1441",
            CountryCode = "BMU",
            CountryIS03Code = "BMU",
            Currency = "BMD"
          },
           new CountryPickerModel ()
          {
            Id=23,
            CountryFlag="bo.png",
            CountryName = "Bolivia",
            CountryISDCode = "+591",
            CountryCode = "BO",
            CountryIS03Code = "BOL",
            Currency = "BOB"
          },
           new CountryPickerModel ()
          {
            Id=24,
            CountryFlag="ba.png",
            CountryName = "Bosnia and Herz.",
            CountryISDCode = "+387",
            CountryCode = "BA",
            CountryIS03Code = "BIH",
            Currency = "BAM"
          },
           new CountryPickerModel ()
          {
            Id=25,
            CountryFlag="bw.png",
            CountryName = "Botswana",
            CountryISDCode = "+267",
            CountryCode = "BW",
            CountryIS03Code = "BWA",
            Currency = "BWP"
         },
           new CountryPickerModel ()
          {
            Id=28,
            CountryFlag="bg_flag.png",
            CountryName = "Bulgaria",
            CountryISDCode = "+359",
            CountryCode = "BG",
            CountryIS03Code = "BGR",
            Currency = "BGN"
          },
            new CountryPickerModel ()
          {
            Id=26,
            CountryFlag="br.png",
            CountryName = "Brazil",
            CountryISDCode = "+55",
            CountryCode = "BR",
            CountryIS03Code = "BRA",
            Currency = "BRL"
          },
            new CountryPickerModel ()
          {
            Id=27,
            CountryFlag="bn.png",
            CountryName = "Brunei",
            CountryISDCode = "+673",
            CountryCode = "BN",
            CountryIS03Code = "BRN",
             Currency = "BND"
          },
            new CountryPickerModel ()
          {
            Id=31,
            CountryFlag="kh.png",
            CountryName = "Cambodia",
            CountryISDCode = "+855",
            CountryCode = "KH",
            CountryIS03Code = "KHM",
            Currency = "KHR"
          },
             new CountryPickerModel ()
          {
            Id=33,
            CountryFlag="ca.png",
            CountryName = "Canada",
            CountryISDCode = "+1",
            CountryCode = "CA",
            CountryIS03Code = "CAN",
            Currency = "CAD"
          },
              new CountryPickerModel ()
          {
            Id=209,
            CountryFlag="cayman.png",
            CountryName = "Cayman",
            CountryISDCode = "+1345",
            CountryCode = "CYM",
            CountryIS03Code = "CYM",
            Currency = "KYD"
          },
              new CountryPickerModel ()
          {
            Id=37,
            CountryFlag="cl.png",
            CountryName = "Chile",
            CountryISDCode = "+56",
            CountryCode = "CL",
            CountryIS03Code = "CHL",
            Currency = "CLP"
          },
          new CountryPickerModel ()
          {
            Id=38,
            CountryFlag="cn.png",
            CountryName = "China",
            CountryISDCode = "+86",
            CountryCode = "CN",
            CountryIS03Code = "CHN",
            Currency = "CNY"
          },
          new CountryPickerModel ()
          {
            Id=39,
            CountryFlag="co.png",
            CountryName = " Colombia",
            CountryISDCode = "+57",
            CountryCode = "CO",
            CountryIS03Code = "COL",
            Currency = "COP"
          },
          new CountryPickerModel ()
        {
            Id=42,
            CountryFlag="cr.png",
            CountryName = "Costa Rica",
            CountryISDCode = "+506",
            CountryCode = "CR",
            CountryIS03Code = "CRI",
            Currency = "CRC"
          },
          new CountryPickerModel ()
        {
            Id=44,
            CountryFlag="hr.png",
            CountryName = "Croatia",
            CountryISDCode = "+385",
            CountryCode = "HR",
            CountryIS03Code = "HRV",
            Currency = "HRK"
          },
          new CountryPickerModel ()
        {
            Id=45,
            CountryFlag="cu.png",
            CountryName = "Cuba",
            CountryISDCode = "+53",
            CountryCode = "CU",
            CountryIS03Code = "CUB",
            Currency = "CUP"
          },
          new CountryPickerModel ()
        {
            Id=47,
            CountryFlag="cz_flag.png",
            CountryName = "Czech Republic",
            CountryISDCode = "+420",
            CountryCode = "CZ",
            CountryIS03Code = "CZE",
            Currency = "CZK"
          },
           new CountryPickerModel ()
          {
            Id=71,
            CountryFlag="gl.jpg",
            CountryName = "Greenland",
            CountryISDCode = "+299",
            CountryCode = "GL",
            CountryIS03Code = "GRL",
            Currency = "DKK"
          },
           new CountryPickerModel ()
         {
            Id=51,
            CountryFlag="do_flag.png",
            CountryName = "Dominican Republic",
            CountryISDCode = "+1-809",
            CountryCode = "DO",
            CountryIS03Code = "DOM",
            Currency = "DOP"
          },
            new CountryPickerModel ()
          {
            Id=54,
            CountryFlag="eg.png",
            CountryName = "Egypt",
            CountryISDCode = "+20",
            CountryCode = "EG",
            CountryIS03Code = "EGY",
            Currency = "EGP"
          },
            new CountryPickerModel ()
          {
            Id=55,
            CountryFlag="sv.png",
            CountryName = "El Salvador",
            CountryISDCode = "+503",
            CountryCode = "SV",
            CountryIS03Code = "SLV",
            Currency = "SVC"
          },
            new CountryPickerModel ()
          {
            Id=58,
            CountryFlag="ee.png",
            CountryName = "Estonia",
            CountryISDCode = "+372",
            CountryCode = "EE",
            CountryIS03Code = "EST",
            Currency = "EEK"
          },
             new CountryPickerModel ()
          {
            Id=198,
            CountryFlag="euro.png",
            CountryName = "Euro Member",
            CountryISDCode = "+379",
            CountryCode = "EUR",
            CountryIS03Code = "EUR",
            Currency = "EUR"
          },
             new CountryPickerModel ()
          {
            Id=198,
            CountryFlag="falklandislands.png",
            CountryName = "Falkland Islands	",
            CountryISDCode = "+379",
            CountryCode = "FKP",
            CountryIS03Code = "FKP",
            Currency = "FKP"
          },
              new CountryPickerModel ()
          {
            Id=60,
            CountryFlag="fj.png",
            CountryName = "Fiji",
            CountryISDCode = "+679",
            CountryCode = "FJ",
            CountryIS03Code = "ETH",
            Currency = "FJD"
          },
               new CountryPickerModel ()
          {
            Id=66,
            CountryFlag="ge.png",
            CountryName = "Georgia",
            CountryISDCode = "+995",
            CountryCode = "GE",
            CountryIS03Code = "SGS",
            Currency = "GEL"
          },
                new CountryPickerModel ()
          {
            Id=68,
            CountryFlag="gh.png",
            CountryName = "Ghana",
            CountryISDCode = "+233",
            CountryCode = "GH",
            CountryIS03Code = "GHA",
            Currency = "GHC"
          },
                new CountryPickerModel ()
          {
            Id=69,
            CountryFlag="gi.png",
            CountryName = "Gibraltar",
            CountryISDCode = "+350",
            CountryCode = "GI",
            CountryIS03Code = "GIB",
            Currency = "GIP"
          },
            new CountryPickerModel ()
          {
            Id=74,
            CountryFlag="gt.png",
            CountryName = "Guatemala",
            CountryISDCode = "+502",
            CountryCode = "GT",
            CountryIS03Code = "GTM",
            Currency = "GTQ"
          }, 
            new CountryPickerModel ()
          {
            Id=74,
            CountryFlag="guernsey.png",
            CountryName = "Guernsey",
            CountryISDCode = "+502",
            CountryCode = "GGP",
            CountryIS03Code = "GGP",
            Currency = "GGP"
          },
            new CountryPickerModel ()
          {
            Id=77,
            CountryFlag="gy.png",
            CountryName = "Guyana",
            CountryISDCode = "+592",
            CountryCode = "GY",
            CountryIS03Code = "GUY",
            Currency = "GYD"
          },
             new CountryPickerModel ()
          {
            Id=79,
            CountryFlag="hn.png",
            CountryName = "Honduras",
            CountryISDCode = "+504",
            CountryCode = "HN",
            CountryIS03Code = "HND",
            Currency = "HNL"
          },
             new CountryPickerModel ()
          {
            Id=80,
            CountryFlag="hk.png",
            CountryName = "Hong Kong",
            CountryISDCode = "+852",
            CountryCode = "HK",
            CountryIS03Code = "HKG",
            Currency = "HKD"
          },
              new CountryPickerModel ()
          {
            Id=81,
            CountryFlag="hu.png",
            CountryName = "Hungary",
            CountryISDCode = "+36",
            CountryCode = "HU",
            CountryIS03Code = "HUN",
            Currency = "HUF"
          },
               new CountryPickerModel ()
          {
            Id=82,
            CountryFlag="is.png",
            CountryName = "Iceland",
            CountryISDCode = "+354",
            CountryCode = "IS",
            CountryIS03Code = "ISL",
            Currency = "ISK"
          },
                new CountryPickerModel ()
          {
            Id=1,
            CountryFlag="in.png",
            CountryName = "India",
            CountryISDCode = "+91",
            CountryCode = "IN",
            CountryIS03Code = "IND",
            Currency = "INR"
          },
                 new CountryPickerModel ()
          {
            Id=83,
            CountryFlag="id.png",
            CountryName = "Indonesia",
            CountryISDCode = "+62",
            CountryCode = "ID",
            CountryIS03Code = "IDN",
            Currency = "IDR"
          },
                 new CountryPickerModel ()
          {
            Id=84,
            CountryFlag="ir.png",
            CountryName = "Iran",
            CountryISDCode = "+98",
            CountryCode = "IR",
            CountryIS03Code = "IRN",
            Currency = "IRR"
          },
                 new CountryPickerModel ()
          {
            Id=84,
            CountryFlag="isleofman.png",
            CountryName = "Isle of Man",
            CountryISDCode = "+902",
            CountryCode = "IR",
            CountryIS03Code = "IRN",
            Currency = "IMP"
          },
           new CountryPickerModel ()
          {
            Id=87,
            CountryFlag="il.png",
            CountryName = "Israel",
            CountryISDCode = "+972",
            CountryCode = "IL",
            CountryIS03Code = "ISR",
            Currency = "ILS"
          },
            new CountryPickerModel ()
          {
            Id=89,
            CountryFlag="jm.png",
            CountryName = "Jamaica",
            CountryISDCode = "+1-876",
            CountryCode = "JM",
            CountryIS03Code = "JAM",
            Currency = "JMD"
          },
             new CountryPickerModel ()
          {
            Id=90,
            CountryFlag="jp.png",
            CountryName = "Japan",
            CountryISDCode = "+81",
            CountryCode = "JP",
            CountryIS03Code = "JPN",
            Currency = "JPY"
          },
             new CountryPickerModel ()
          {
            Id=302,
            CountryFlag="jersey.png",
            CountryName = "Jersey",
            CountryISDCode = "+81",
            CountryCode = "JEP",
            CountryIS03Code = "JEP",
            Currency = "JEP"
          },
              new CountryPickerModel ()
          {
            Id=92,
            CountryFlag="kz.png",
            CountryName = "Kazakhstan",
            CountryISDCode = "+7",
            CountryCode = "KZ",
            CountryIS03Code = "KAZ",
            Currency = "KZT"
          },
                new CountryPickerModel ()
          {
            Id=95,
            CountryFlag="kp.png",
            CountryName = "Korea, North",
            CountryISDCode = "+850",
            CountryCode = "KP",
            CountryIS03Code = "PRK",
            Currency = "KPW"
          },
             new CountryPickerModel ()
          {
            Id=96,
            CountryFlag="kr.png",
            CountryName = "Korea, South",
            CountryISDCode = "+82",
            CountryCode = "KR",
            CountryIS03Code = "PRK",
            Currency = "KRW"
          },
               new CountryPickerModel ()
          {
            Id=98,
            CountryFlag="kg.png",
            CountryName = "Kyrgyzstan",
            CountryISDCode = "+996",
            CountryCode = "KG",
            CountryIS03Code = "KGZ",
            Currency = "KGS"
          },
                 new CountryPickerModel ()
          {
            Id=99,
            CountryFlag="la.png",
            CountryName = "Laos",
            CountryISDCode = "+856",
            CountryCode = "LA",
            CountryIS03Code = "LAO",
            Currency = "LAK"
          },
          new CountryPickerModel ()
          {
            Id=100,
            CountryFlag="lv.png",
            CountryName = "Latvia",
            CountryISDCode = "+371",
            CountryCode = "LV",
            CountryIS03Code = "LVA",
            Currency = "LVL"
          },
          new CountryPickerModel ()
          {
            Id=101,
            CountryFlag="lb.png",
            CountryName = "Lebanon",
            CountryISDCode = "+961",
            CountryCode = "LB",
            CountryIS03Code = "LBN",
            Currency = "LBP"
          },
          new CountryPickerModel ()
          {
            Id=102,
            CountryFlag="lr.png",
            CountryName = "Liberia",
            CountryISDCode = "+231",
            CountryCode = "LR",
            CountryIS03Code = "LBR",
            Currency = "LRD"
          },
           new CountryPickerModel ()
          {
            Id=105,
            CountryFlag="lt.png",
            CountryName = "Lithuania",
            CountryISDCode = "+370",
            CountryCode = "LT",
            CountryIS03Code = "LTU",
            Currency = "LTL"
          },
            new CountryPickerModel ()
          {
            Id=108,
            CountryFlag="mk.png",
            CountryName = "Macedonia",
            CountryISDCode = "+389",
            CountryCode = "MK",
            CountryIS03Code = "MKD",
            Currency = "MKD"
          },
            new CountryPickerModel ()
          {
            Id=111,
            CountryFlag="my.png",
            CountryName = "Malaysia",
            CountryISDCode = "+60",
            CountryIS03Code = "MYS",
            Currency = "MYR"
          },
             new CountryPickerModel ()
          {
            Id=118,
            CountryFlag="mu.png",
            CountryName = "Mauritius",
            CountryISDCode = "+230",
            CountryCode = "MU",
            CountryIS03Code = "MUS",
            Currency = "MUR"
          },
               new CountryPickerModel ()
          {
            Id=119,
            CountryFlag="mx.png",
            CountryName = "Mexico",
            CountryISDCode = "+52",
            CountryCode = "MX",
            CountryIS03Code = "MEX",
            Currency = "MXN"
          },
                new CountryPickerModel ()
          {
            Id=123,
            CountryFlag="mn.png",
            CountryName = "Mongolia",
            CountryISDCode = "+976",
            CountryCode = "MN",
            CountryIS03Code = "MNG",
            Currency = "MNT"
            },
                new CountryPickerModel ()
          {
            Id=126,
            CountryFlag="mz.png",
            CountryName = "Mozambique",
            CountryISDCode = "+258",
            CountryCode = "MZ",
            CountryIS03Code = "MOZ",
            Currency = "MZN"
          },
                  new CountryPickerModel ()
          {
            Id=128,
            CountryFlag="na.png",
            CountryName = "Namibia",
            CountryISDCode = "+264",
            CountryCode = "NA",
            CountryIS03Code = "NAM",
            Currency = "NAD"
          },
                   new CountryPickerModel ()
          {
            Id=130,
            CountryFlag="np.png",
            CountryName = "Nepal",
            CountryISDCode = "+977",
            CountryCode = "NP",
            CountryIS03Code = "NPL",
            Currency = "NPR"
          },
                 new CountryPickerModel ()
          {
            Id=131,
            CountryFlag="nl.png",
            CountryName = "Netherlands",
            CountryISDCode = "+31",
            CountryCode = "NL",
            CountryIS03Code = "NLD",
            Currency = "ANG"
          },
                 new CountryPickerModel ()
          {
            Id=133,
            CountryFlag="nz.png",
            CountryName = "New Zealand",
            CountryISDCode = "+64",
            CountryCode = "NZ",
            CountryIS03Code = "NCL",
            Currency = "NZD"
          },
                  new CountryPickerModel ()
          {
            Id=134,
            CountryFlag="ni.png",
            CountryName = "Nicaragua",
            CountryISDCode = "+505",
            CountryCode = "NZ",
            CountryIS03Code = "NIC",
            Currency = "NIO"
          },
                    new CountryPickerModel ()
          {
            Id=136,
            CountryFlag="ng.png",
            CountryName = "Nigeria",
            CountryISDCode = "+234",
            CountryCode = "NG",
            CountryIS03Code = "NGA",
            Currency = "NGN"
          },
                     new CountryPickerModel ()
          {
            Id=138,
            CountryFlag="no.png",
            CountryName = "Norway",
            CountryISDCode = "+47",
            CountryCode = "NO",
            CountryIS03Code = "NOR",
            Currency = "NOK"
          },
                       new CountryPickerModel ()
          {
            Id=139,
            CountryFlag="om.png",
            CountryName = "Oman",
            CountryISDCode = "+968",
            CountryCode = "OM",
            CountryIS03Code = "OMN",
            Currency = "OMR"
          },
                        new CountryPickerModel ()
          {
            Id=140,
            CountryFlag="pk.png",
            CountryName = "Pakistan",
            CountryISDCode = "+92",
            CountryCode = "PK",
            CountryIS03Code = "PAK",
            Currency = "PKR"
          },
                         new CountryPickerModel ()
          {
            Id=143,
            CountryFlag="pa.png",
            CountryName = "Panama",
            CountryISDCode = "+507",
            CountryCode = "PA",
            CountryIS03Code = "PAN",
            Currency = "PAB"
          },
           new CountryPickerModel ()
          {
            Id=145,
            CountryFlag="py.png",
            CountryName = "Paraguay",
            CountryISDCode = "+595",
            CountryCode = "PY",
            CountryIS03Code = "PRY",
            Currency = "PYG"
          },
           new CountryPickerModel ()
          {
            Id=146,
            CountryFlag="pe.png",
            CountryName = "Peru",
            CountryISDCode = "+51",
            CountryCode = "PE",
            CountryIS03Code = "PER",
            Currency = "PEN"
          },
           new CountryPickerModel ()
          {
            Id=147,
            CountryFlag="ph.png",
            CountryName = "Philippines",
            CountryISDCode = "+63",
            CountryCode = "PH",
            CountryIS03Code = "PHL",
            Currency = "PHP"
          },
           new CountryPickerModel ()
          {
            Id=148,
            CountryFlag="pl.png",
            CountryName = "Poland",
            CountryISDCode = "+48",
            CountryCode = "PL",
            CountryIS03Code = "POL",
            Currency = "PLN"
          },
           new CountryPickerModel ()
          {
            Id=151,
            CountryFlag="qa.png",
            CountryName = "Qatar",
            CountryISDCode = "+974",
            CountryCode = "QA",
            CountryIS03Code = "QAT",
            Currency = "QAR"
          },
           new CountryPickerModel ()
          {
            Id=153,
            CountryFlag="ro.png",
            CountryName = "Romania",
            CountryISDCode = "+40",
            CountryCode = "RO",
            CountryIS03Code = "ROU",
            Currency = "RON"
          },
           new CountryPickerModel ()
          {
            Id=154,
            CountryFlag="ru.png",
            CountryName = "Russian Federation",
            CountryISDCode = "+7-73",
            CountryCode = "RU",
            CountryIS03Code = "RUS",
            Currency = "RUB"
          },
          new CountryPickerModel ()
          {
            Id=454,
            CountryFlag="falklandislands.png",
            CountryName = "Saint Helena",
            CountryISDCode = "+7-73",
            CountryCode = "RU",
            CountryIS03Code = "RUS",
            Currency = "SHP"
          },
          new CountryPickerModel ()
          {
            Id=161,
            CountryFlag="sa.png",
            CountryName = "Saudi Arabia",
            CountryISDCode = "+966",
            CountryCode = "SA",
            CountryIS03Code = "SAU",
            Currency = "SAR"
          },
           new CountryPickerModel ()
          {
            Id=163,
            CountryFlag="rs.png",
            CountryName = "Serbia",
            CountryISDCode = "+381",
            CountryCode = "RS",
            CountryIS03Code = "SRB",
            Currency = "RSD"
          },
            new CountryPickerModel ()
          {
            Id=164,
            CountryFlag="sc.png",
            CountryName = "Seychelles",
            CountryISDCode = "+248",
            CountryCode = "SC",
            CountryIS03Code = "SYC",
            Currency = "SCR"
          },
            new CountryPickerModel ()
          {
            Id=166,
            CountryFlag="sg.png",
            CountryName = "Singapore",
            CountryISDCode = "+65",
            CountryCode = "SG",
            CountryIS03Code = "SGP",
            Currency = "SGD"
          },
             new CountryPickerModel ()
          {
            Id=168,
            CountryFlag="sb.png",
            CountryName = "Solomon Islands",
            CountryISDCode = "+677",
            CountryCode = "SB",
            CountryIS03Code = "SLB",
            Currency = "SBD"
          },
             new CountryPickerModel ()
          {
            Id=169,
            CountryFlag="so.png",
            CountryName = "Somalia",
            CountryISDCode = "+252",
            CountryCode = "SO",
            CountryIS03Code = "SOM",
            Currency = "SOS"
          },
              new CountryPickerModel ()
          {
            Id=170,
            CountryFlag="za.png",
            CountryName = "South Africa",
            CountryISDCode = "+27",
            CountryCode = "ZA",
            CountryIS03Code = "ZAF",
            Currency = "ZAR"
          },
              new CountryPickerModel ()
          {
            Id=172,
            CountryFlag="lk.png",
            CountryName = "Sri Lanka",
            CountryISDCode = "+94",
            CountryCode = "LK",
            CountryIS03Code = "LKA",
            Currency = "LKR"
          },
               new CountryPickerModel ()
          {
            Id=177,
            CountryFlag="se.png",
            CountryName = "Sweden",
            CountryISDCode = "+46",
            CountryCode = "SE",
            CountryIS03Code = "SWE",
            Currency = "SEK"
          },
               new CountryPickerModel ()
          {
            Id=178,
            CountryFlag="ch.png",
            CountryName = "Switzerland",
            CountryISDCode = "+41",
            CountryCode = "CH",
            CountryIS03Code = "CHE",
            Currency = "CHF"
          },
                new CountryPickerModel ()
          {
            Id=175,
            CountryFlag="sr.png",
            CountryName = "Suriname",
            CountryISDCode = "+597",
            CountryCode = "SR",
            CountryIS03Code = "SUR",
            Currency = "SRD"
          },
                new CountryPickerModel ()
          {
            Id=179,
            CountryFlag="sy.png",
            CountryName = "Syria",
            CountryISDCode = "+963",
            CountryCode = "SY",
            CountryIS03Code = "SYR",
            Currency = "SYP"
          },
          new CountryPickerModel ()
          {
            Id=180,
            CountryFlag="tw.png",
            CountryName = "Taiwan",
            CountryISDCode = "+886",
            CountryCode = "TW",
            CountryIS03Code = "TWN",
            Currency = "TWD"
          },
          new CountryPickerModel ()
          {
            Id=183,
            CountryFlag="th.png",
            CountryName = "Thailand",
            CountryISDCode = "+66",
            CountryCode = "TH",
            CountryIS03Code = "THA",
            Currency = "THB"
          },
          new CountryPickerModel ()
          {
            Id=186,
            CountryFlag="tt.png",
            CountryName = "Trinidad and Tobago",
            CountryISDCode = "+1-868",
            CountryCode = "TT",
            CountryIS03Code = "TTO",
            Currency = "TTD"
          },
          new CountryPickerModel ()
          {
            Id=188,
            CountryFlag="tr.png",
            CountryName = "Turkey",
            CountryISDCode = "+90",
            CountryCode = "TR",
            CountryIS03Code = "TUR",
            Currency = "TRY"
          },
          new CountryPickerModel ()
          {
            Id=190,
            CountryFlag="tv.png",
            CountryName = "Tuvalu",
            CountryISDCode = "+688",
            CountryCode = "TV",
            CountryIS03Code = "TUV",
            Currency = "TVD"
          },
           new CountryPickerModel ()
          {
            Id=192,
            CountryFlag="ua.png",
            CountryName = "Ukraine",
            CountryISDCode = "+380",
            CountryCode = "UA",
            CountryIS03Code = "UKR",
            Currency = "UAH"
          },
           new CountryPickerModel ()
          {
            Id=194,
            CountryFlag="gb.png",
            CountryName = "United Kingdom",
            CountryISDCode = "+44",
            CountryCode = "GB",
            CountryIS03Code = "GBR",
            Currency = "GBP"
          },
           new CountryPickerModel ()
          {
            Id=2,
            CountryFlag="us.png",
            CountryName = "United States",
            CountryISDCode = "+1",
            CountryCode = "US",
            CountryIS03Code = "UMI",
            Currency = "USD"
          },
           new CountryPickerModel ()
          {
            Id=195,
            CountryFlag="uy.png",
            CountryName = "Uruguay",
            CountryISDCode = "+598",
            CountryCode = "UY",
            CountryIS03Code = "URY",
            Currency = "UYU"
          },
           new CountryPickerModel ()
          {
            Id=196,
            CountryFlag="uz.png",
            CountryName = "Uzbekistan",
            CountryISDCode = "+998",
            CountryCode = "UZ",
            CountryIS03Code = "UZB",
            Currency = "UZS"
          },
            new CountryPickerModel ()
          {
            Id=199,
            CountryFlag="ve.png",
            CountryName = "Venezuela",
            CountryISDCode = "+58",
            CountryCode = "VE",
            CountryIS03Code = "VEN",
            Currency = "VEF"
          },
            new CountryPickerModel ()
          {
            Id=200,
            CountryFlag="vn.png",
            CountryName = "Vietnam",
            CountryISDCode = "+84",
            CountryCode = "VN",
            CountryIS03Code = "VNM",
            Currency = "VND"
          },
             new CountryPickerModel ()
          {
            Id=204,
            CountryFlag="ye.png",
            CountryName = "Yemen",
            CountryISDCode = "+967",
            CountryCode = "YE",
            CountryIS03Code = "YEM",
            Currency = "YER"
          },
              new CountryPickerModel ()
          {
            Id=206,
            CountryFlag="zw.png",
            CountryName = "Zimbabwe",
            CountryISDCode = "+263",
            CountryCode = "ZW",
            CountryIS03Code = "ZWE",
            Currency = "ZWD"
          },
         };
        }
    }
}
