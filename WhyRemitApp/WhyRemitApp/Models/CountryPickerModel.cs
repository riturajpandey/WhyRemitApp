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
          },
         new CountryPickerModel ()
          {
            Id=4,
            CountryFlag="al.png",
            CountryName = "Albania",
            CountryISDCode = "+355",
            CountryCode = "AL",
          },
         new CountryPickerModel ()
          {
            Id=5,
            CountryFlag="dz_flag.png",
            CountryName = "Algeria",
            CountryISDCode = "+213",
            CountryCode = "DZ",
          },
         new CountryPickerModel ()
          {
            Id=6,
            CountryFlag="ad.png",
            CountryName = "Andorra",
            CountryISDCode = "+376",
            CountryCode = "AD",
          },
         new CountryPickerModel ()
          {
            Id=7,
            CountryFlag="ao.png",
            CountryName = "Angola",
            CountryISDCode = "+244",
            CountryCode = "AO",
          },
         new CountryPickerModel ()
          {
            Id=8,
            CountryFlag="ag.png",
            CountryName = "Antigua and Barbuda",
            CountryISDCode = "+1-268",
            CountryCode = "AG",
          },
         new CountryPickerModel ()
          {
            Id=9,
            CountryFlag="ar.png",
            CountryName = "Argentina",
            CountryISDCode = "+54",
            CountryCode = "AR",
          },
         new CountryPickerModel ()
          {
            Id=10,
            CountryFlag="am.png",
            CountryName = "Armenia",
            CountryISDCode = "+374",
            CountryCode = "AM",
          },
         new CountryPickerModel ()
          {
            Id=11,
            CountryFlag="au.png",
            CountryName = "Australia",
            CountryISDCode = "+61",
            CountryCode = "AU",
          },
         new CountryPickerModel ()
          {
            Id=12,
            CountryFlag="at.png",
            CountryName = "Austria",
            CountryISDCode = "+43",
            CountryCode = "AT",
          },
         new CountryPickerModel ()
          {
            Id=13,
            CountryFlag="az.png",
            CountryName = "Azerbaijan",
            CountryISDCode = "+994",
            CountryCode = "AZ",
          },
         new CountryPickerModel ()
          {
            Id=14,
            CountryFlag="bs.png",
            CountryName = "Bahamas",
            CountryISDCode = "+1-242",
            CountryCode = "BS",
          },
         new CountryPickerModel ()
          {
            Id=15,
            CountryFlag="bh.png",
            CountryName = "Bahrain",
            CountryISDCode = "+973",
            CountryCode = "BH",
          },
         new CountryPickerModel ()
          {
            Id=16,
            CountryFlag="bd.png",
            CountryName = "Bangladesh",
            CountryISDCode = "+880",
          },
         new CountryPickerModel ()
          {
            Id=17,
            CountryFlag="bb.png",
            CountryName = "Barbados",
            CountryISDCode = "+1-246",
            CountryCode = "BB",
          },
         new CountryPickerModel ()
          {
            Id=18,
            CountryFlag="by.png",
            CountryName = "Belarus",
            CountryISDCode = "+375",
            CountryCode = "BY",
          },
         new CountryPickerModel ()
          {
            Id=19,
            CountryFlag="be.png",
            CountryName = "Belgium",
            CountryISDCode = "+32",
            CountryCode = "BE",
          },
         new CountryPickerModel ()
          {
            Id=20,
            CountryFlag="bz.png",
            CountryName = "Belize",
            CountryISDCode = "+501",
            CountryCode = "BZ",
          },
         new CountryPickerModel ()
          {
            Id=21,
            CountryFlag="bj.png",
            CountryName = "Benin",
            CountryISDCode = "+229",
            CountryCode = "BJ",
          },
         new CountryPickerModel ()
          {
            Id=22,
            CountryFlag="bt.png",
            CountryName = "Bhutan",
            CountryISDCode = "+975",
            CountryCode = "BT",
          },
         new CountryPickerModel ()
          {
            Id=23,
            CountryFlag="bo.png",
            CountryName = "Bolivia",
            CountryISDCode = "+591",
            CountryCode = "BO",
          },
         new CountryPickerModel ()
          {
            Id=24,
            CountryFlag="ba.png",
            CountryName = "Bosnia and Herz.",
            CountryISDCode = "+387",
            CountryCode = "BA",
          },
         new CountryPickerModel ()
          {
            Id=25,
            CountryFlag="bw.png",
            CountryName = "Botswana",
            CountryISDCode = "+267",
            CountryCode = "BW",
         },
            new CountryPickerModel ()
          {
            Id=26,
            CountryFlag="br.png",
            CountryName = "Brazil",
            CountryISDCode = "+55",
            CountryCode = "BR",
          },
            new CountryPickerModel ()
          {
            Id=27,
            CountryFlag="bn.png",
            CountryName = "Brunei",
            CountryISDCode = "+673",
            CountryCode = "BN",
          },
            new CountryPickerModel ()
          {
            Id=28,
            CountryFlag="bg_flag.png",
            CountryName = "Bulgaria",
            CountryISDCode = "+359",
            CountryCode = "BG",
          },
            new CountryPickerModel ()
          {
            Id=29,
            CountryFlag="bf.png",
            CountryName = "Burkina Faso",
            CountryISDCode = "+226",
            CountryCode = "BF",
          },
            new CountryPickerModel ()
          {
            Id=30,
            CountryFlag="bi.png",
            CountryName = "Burundi",
            CountryISDCode = "+257",
            CountryCode = "BI",
          },
            new CountryPickerModel ()
          {
            Id=31,
            CountryFlag="kh.png",
            CountryName = "Cambodia",
            CountryISDCode = "+855",
            CountryCode = "KH",
          },
            new CountryPickerModel ()
          {
            Id=32,
            CountryFlag="cm.png",
            CountryName = "Cameroon",
            CountryISDCode = "+237",
            CountryCode = "CM",
          },
            new CountryPickerModel ()
          {
            Id=33,
            CountryFlag="ca.png",
            CountryName = "Canada",
            CountryISDCode = "+1",
            CountryCode = "CA",
          },
            new CountryPickerModel ()
          {
            Id=34,
            CountryFlag="cv.png",
            CountryName = "Cape Verde",
            CountryISDCode = "+238",
            CountryCode = "CV",
          },
            new CountryPickerModel ()
          {
            Id=35,
            CountryFlag="cf.png",
            CountryName = "Central African Rep.",
            CountryISDCode = "+236",
            CountryCode = "CF",
          },
            new CountryPickerModel ()
          {
            Id=36,
            CountryFlag="td.png",
            CountryName = "Chad",
            CountryISDCode = "+235",
            CountryCode = "TD",
          },
            new CountryPickerModel ()
          {
            Id=37,
            CountryFlag="cl.png",
            CountryName = "Chile",
            CountryISDCode = "+56",
            CountryCode = "CL",
          },
            new CountryPickerModel ()
          {
            Id=38,
            CountryFlag="cn.png",
            CountryName = "China",
            CountryISDCode = "+86",
            CountryCode = "CN",
          },
            new CountryPickerModel ()
          {
            Id=39,
            CountryFlag="co.png",
            CountryName = " Colombia",
            CountryISDCode = "+57",
            CountryCode = "CO",
          },
        new CountryPickerModel ()
          {
            Id=40,
            CountryFlag="km.png",
            CountryName = "Comoros",
            CountryISDCode = "+269",
            CountryCode = "KM",
          },
         new CountryPickerModel ()
        {
            Id=41,
            CountryFlag="cd.png",
            CountryName = "Congo",
            CountryISDCode = "+242",
            CountryCode = "CD",
          },
        new CountryPickerModel ()
        {
            Id=42,
            CountryFlag="cr.png",
            CountryName = "Costa Rica",
            CountryISDCode = "+506",
            CountryCode = "CR",
          },
        new CountryPickerModel ()
        {
            Id=43,
            CountryFlag="ci.png",
            CountryName = "Cote d Ivoire",
            CountryISDCode = "+225",
            CountryCode = "CI",
          },

        new CountryPickerModel ()
        {
            Id=44,
            CountryFlag="hr.png",
            CountryName = "Croatia",
            CountryISDCode = "+385",
            CountryCode = "HR",
          },
        new CountryPickerModel ()
        {
            Id=45,
            CountryFlag="cu.png",
            CountryName = "Cuba",
            CountryISDCode = "+53",
            CountryCode = "CU",
          },
        new CountryPickerModel ()
        {
            Id=46,
            CountryFlag="cy.png",
            CountryName = "Cyprus",
            CountryISDCode = "+357",
            CountryCode = "CY",
          },
        new CountryPickerModel ()
        {
            Id=47,
            CountryFlag="cz_flag.png",
            CountryName = "Czech Republic",
            CountryISDCode = "+420",
            CountryCode = "CZ",
          },
        new CountryPickerModel ()
        {
            Id=48,
            CountryFlag="dk_flag.png",
            CountryName = "Denmark",
            CountryISDCode = "+45",
            CountryCode = "DK",
          },
        new CountryPickerModel ()
        {
            Id=49,
            CountryFlag="dj_flag.png",
            CountryName = "Djibouti",
            CountryISDCode = "+253",
            CountryCode = "DJ",
          },
        new CountryPickerModel ()
        {
            Id=50,
            CountryFlag="dm_flag.png",
            CountryName = "Dominica",
            CountryISDCode = "+1-767",
            CountryCode = "DM",
          },
        new CountryPickerModel ()
         {
            Id=51,
            CountryFlag="do_flag.png",
            CountryName = "Dominican Republic",
            CountryISDCode = "+1-809",
            CountryCode = "DO",
          },
        new CountryPickerModel ()
         {
            Id=52,
            CountryFlag="tp.png",
            CountryName = "East Timor",
            CountryISDCode = "+670",
            CountryCode = "TP",
          },
        new CountryPickerModel ()
          {
            Id=53,
            CountryFlag="ec.png",
            CountryName = "Ecuador",
            CountryISDCode = "+593",
            CountryCode = "EC",
          },
        new CountryPickerModel ()
          {
            Id=54,
            CountryFlag="eg.png",
            CountryName = "Egypt",
            CountryISDCode = "+20",
            CountryCode = "EG",
          },
        new CountryPickerModel ()
          {
            Id=55,
            CountryFlag="sv.png",
            CountryName = "El Salvador",
            CountryISDCode = "+503",
            CountryCode = "SV",
          },
        new CountryPickerModel ()
          {
            Id=56,
            CountryFlag="gq.png",
            CountryName = "Equatorial Guinea",
            CountryISDCode = "+240",
            CountryCode = "GQ",
          },
        new CountryPickerModel ()
          {
            Id=57,
            CountryFlag="er.png",
            CountryName = "Eritrea",
            CountryISDCode = "+291",
            CountryCode = "ER",
          },
        new CountryPickerModel ()
          {
            Id=58,
            CountryFlag="ee.png",
            CountryName = "Estonia",
            CountryISDCode = "+372",
            CountryCode = "EE",
          },
        new CountryPickerModel ()
          {
            Id=59,
            CountryFlag="et.png",
            CountryName = "Ethiopia",
            CountryISDCode = "+251",
            CountryCode = "ET",
          },
        new CountryPickerModel ()
          {
            Id=60,
            CountryFlag="fj.png",
            CountryName = "Fiji",
            CountryISDCode = "+679",
            CountryCode = "FJ",
          },
            new CountryPickerModel ()
          {
            Id=61,
            CountryFlag="fi.png",
            CountryName = "Finland",
            CountryISDCode = "+358",
            CountryCode = "FI",
          },
            new CountryPickerModel ()
          {
            Id=62,
            CountryFlag="fr.png",
            CountryName = "France",
            CountryISDCode = "+33",
            CountryCode = "FR",
          },
            new CountryPickerModel ()
          {
            Id=63,
            CountryFlag="pf.png",
            CountryName = "French Polynesia",
            CountryISDCode = "+689",
            CountryCode = "PF",
          },
            new CountryPickerModel ()
          {
            Id=64,
            CountryFlag="ga.png",
            CountryName = " Gabon",
            CountryISDCode = "+241",
            CountryCode = "GA",
          },
           new CountryPickerModel ()
          {
            Id=65,
            CountryFlag="gm.png",
            CountryName = "Gambia",
            CountryISDCode = "+220",
            CountryCode = "GM",
          },
         new CountryPickerModel ()
          {
            Id=66,
            CountryFlag="ge.png",
            CountryName = "Georgia",
            CountryISDCode = "+995",
            CountryCode = "GE",
          },
         new CountryPickerModel ()
          {
            Id=67,
            CountryFlag="de_flag.png",
            CountryName = "Germany",
            CountryISDCode = "+49",
            CountryCode = "DE",
          },
         new CountryPickerModel ()
          {
            Id=68,
            CountryFlag="gh.png",
            CountryName = "Ghana",
            CountryISDCode = "+233",
            CountryCode = "GH",
          },
            new CountryPickerModel ()
          {
            Id=69,
            CountryFlag="gi.png",
            CountryName = "Gibraltar",
            CountryISDCode = "+350",
            CountryCode = "GI",
          },
            new CountryPickerModel ()
          {
            Id=70,
            CountryFlag="gr.png",
            CountryName = "Greece",
            CountryISDCode = "+30",
            CountryCode = "GR",
          },
            new CountryPickerModel ()
          {
            Id=71,
            CountryFlag="gl.jpg",
            CountryName = "Greenland",
            CountryISDCode = "+299",
            CountryCode = "GL",
          },
            new CountryPickerModel ()
          {
            Id=72,
            CountryFlag="gd.png",
            CountryName = "Grenada",
            CountryISDCode = "+1-473",
            CountryCode = "GD",
          },
            new CountryPickerModel ()
          {
            Id=73,
            CountryFlag="gp.png",
            CountryName = "Guadeloupe",
            CountryISDCode = "+355",
            CountryCode = "GP",
          },
            new CountryPickerModel ()
          {
            Id=74,
            CountryFlag="gt.png",
            CountryName = "Guatemala",
            CountryISDCode = "+502",
            CountryCode = "GT",
          },
            new CountryPickerModel ()
          {
            Id=75,
            CountryFlag="gn.png",
            CountryName = "Guinea",
            CountryISDCode = "+224",
            CountryCode = "GN",
          },
            new CountryPickerModel ()
          {
            Id=76,
            CountryFlag="gw.png",
            CountryName = "Guinea-Bissau",
            CountryISDCode = "+245",
            CountryCode = "GW",
          },
            new CountryPickerModel ()
          {
            Id=77,
            CountryFlag="gy.png",
            CountryName = "Guyana",
            CountryISDCode = "+592",
            CountryCode = "GY",
          },
            new CountryPickerModel ()
          {
            Id=78,
            CountryFlag="ht.png",
            CountryName = "Haiti",
            CountryISDCode = "+509",
            CountryCode = "HT",
          },
            new CountryPickerModel ()
          {
            Id=79,
            CountryFlag="hn.png",
            CountryName = "Honduras",
            CountryISDCode = "+504",
            CountryCode = "HN",
          },
            new CountryPickerModel ()
          {
            Id=80,
            CountryFlag="hk.png",
            CountryName = "Hong Kong",
            CountryISDCode = "+852",
            CountryCode = "HK",
          },
            new CountryPickerModel ()
          {
            Id=81,
            CountryFlag="hu.png",
            CountryName = "Hungary",
            CountryISDCode = "+36",
            CountryCode = "HU",
          },
            new CountryPickerModel ()
          {
            Id=82,
            CountryFlag="is.png",
            CountryName = "Iceland",
            CountryISDCode = "+354",
            CountryCode = "IS",
          },
            new CountryPickerModel ()
          {
            Id=1,
            CountryFlag="in.png",
            CountryName = "India",
            CountryISDCode = "+91",
            CountryCode = "IN",
          },
            new CountryPickerModel ()
          {
            Id=83,
            CountryFlag="id.png",
            CountryName = "Indonesia",
            CountryISDCode = "+62",
            CountryCode = "ID",
          },
            new CountryPickerModel ()
          {
            Id=84,
            CountryFlag="ir.png",
            CountryName = "Iran",
            CountryISDCode = "+98",
            CountryCode = "IR",
          },
            new CountryPickerModel ()
          {
            Id=85,
            CountryFlag="iq.png",
            CountryName = "Iraq",
            CountryISDCode = "+964",
            CountryCode = "IQ",
          },
            new CountryPickerModel ()
          {
            Id=86,
            CountryFlag="ie.png",
            CountryName = "Ireland",
            CountryISDCode = "+353",
            CountryCode = "IE",
          },
            new CountryPickerModel ()
          {
            Id=87,
            CountryFlag="il.png",
            CountryName = "Israel",
            CountryISDCode = "+972",
            CountryCode = "IL",
          },
            new CountryPickerModel ()
          {
            Id=88,
            CountryFlag="it.png",
            CountryName = "Italy",
            CountryISDCode = "+39",
            CountryCode = "IT",
          },
            new CountryPickerModel ()
          {
            Id=89,
            CountryFlag="jm.png",
            CountryName = "Jamaica",
            CountryISDCode = "+1-876",
            CountryCode = "JM",
          },
            new CountryPickerModel ()
          {
            Id=90,
            CountryFlag="jp.png",
            CountryName = "Japan",
            CountryISDCode = "+81",
            CountryCode = "JP",
          },
            new CountryPickerModel ()
          {
            Id=91,
            CountryFlag="jo.png",
            CountryName = "Jordan",
            CountryISDCode = "+962",
            CountryCode = "JO",
          },
            new CountryPickerModel ()
          {
            Id=92,
            CountryFlag="kz.png",
            CountryName = "Kazakhstan",
            CountryISDCode = "+7",
            CountryCode = "KZ",
          },
            new CountryPickerModel ()
          {
            Id=93,
            CountryFlag="ke.png",
            CountryName = "Kenya",
            CountryISDCode = "+254",
            CountryCode = "KE",
          },
            new CountryPickerModel ()
          {
            Id=94,
            CountryFlag="ki.png",
            CountryName = "Kiribati",
            CountryISDCode = "+686",
            CountryCode = "KI",
          },
            new CountryPickerModel ()
          {
            Id=95,
            CountryFlag="kp.png",
            CountryName = "Korea, North",
            CountryISDCode = "+850",
            CountryCode = "KP",
          },
             new CountryPickerModel ()
          {
            Id=96,
            CountryFlag="kr.png",
            CountryName = "Korea, South",
            CountryISDCode = "+82",
            CountryCode = "KR",
          },
              new CountryPickerModel ()
          {
            Id=97,
            CountryFlag="kw.png",
            CountryName = "Kuwait",
            CountryISDCode = "+965",
            CountryCode = "KW",
          },
              new CountryPickerModel ()
          {
            Id=98,
            CountryFlag="kg.png",
            CountryName = "Kyrgyzstan",
            CountryISDCode = "+996",
            CountryCode = "KG",
          },
              new CountryPickerModel ()
          {
            Id=99,
            CountryFlag="la.png",
            CountryName = "Laos",
            CountryISDCode = "+856",
            CountryCode = "LA",
          },
            new CountryPickerModel ()
          {
            Id=100,
            CountryFlag="lv.png",
            CountryName = "Latvia",
            CountryISDCode = "+371",
            CountryCode = "LV",
          },
            new CountryPickerModel ()
          {
            Id=101,
            CountryFlag="lb.png",
            CountryName = "Lebanon",
            CountryISDCode = "+961",
            CountryCode = "LB",
          },
           new CountryPickerModel ()
          {
            Id=102,
            CountryFlag="lr.png",
            CountryName = "Liberia",
            CountryISDCode = "+231",
            CountryCode = "LR",
          },
           new CountryPickerModel ()
          {
            Id=103,
            CountryFlag="ly.png",
            CountryName = "Libya",
            CountryISDCode = "+218",
            CountryCode = "LY",
          },
           new CountryPickerModel ()
          {
            Id=104,
            CountryFlag="li.png",
            CountryName = "Liechtenstein",
            CountryISDCode = "+423",
            CountryCode = "LI",
          },
           new CountryPickerModel ()
          {
            Id=105,
            CountryFlag="lt.png",
            CountryName = "Lithuania",
            CountryISDCode = "+370",
            CountryCode = "LT",
          },
           new CountryPickerModel ()
          {
            Id=106,
            CountryFlag="lu.png",
            CountryName = "Luxembourg",
            CountryISDCode = "+352",
            CountryCode = "LU",
          },
           new CountryPickerModel ()
          {
            Id=107,
            CountryFlag="mo.png",
            CountryName = "Macau SAR",
            CountryISDCode = "+853",
            CountryCode = "MO",
          },
           new CountryPickerModel ()
          {
            Id=108,
            CountryFlag="mk.png",
            CountryName = "Macedonia",
            CountryISDCode = "+389",
            CountryCode = "MK",
          },
           new CountryPickerModel ()
          {
            Id=109,
            CountryFlag="mg.png",
            CountryName = "Madagascar",
            CountryISDCode = "+261",
            CountryCode = "MG",
          },
           new CountryPickerModel ()
          {
            Id=110,
            CountryFlag="mw.png",
            CountryName = "Malawi",
            CountryISDCode = "+265",
            CountryCode = "MW",
          },
           new CountryPickerModel ()
          {
            Id=111,
            CountryFlag="my.png",
            CountryName = "Malaysia",
            CountryISDCode = "+60",
          },
           new CountryPickerModel ()
          {
            Id=112,
            CountryFlag="mv.png",
            CountryName = "Maldives",
            CountryISDCode = "+960",
            CountryCode = "MV",
          },
           new CountryPickerModel ()
          {
            Id=113,
            CountryFlag="ml.png",
            CountryName = "Mali",
            CountryISDCode = "+223",
            CountryCode = "ML",
          },
           new CountryPickerModel ()
          {
            Id=114,
            CountryFlag="mt.png",
            CountryName = "Malta",
            CountryISDCode = "+356",
            CountryCode = "MT",
          },
           new CountryPickerModel ()
          {
            Id=115,
            CountryFlag="mh.png",
            CountryName = "Marshall Islands",
            CountryISDCode = "+692",
            CountryCode = "MH",
          },
           new CountryPickerModel ()
          {
            Id=116,
            CountryFlag="mq.png",
            CountryName = "Martinique",
            CountryISDCode = "+596",
            CountryCode = "MQ",
          },
           new CountryPickerModel ()
          {
            Id=117,
            CountryFlag="mr.png",
            CountryName = "Mauritania",
            CountryISDCode = "+222",
            CountryCode = "MR",
          },
           new CountryPickerModel ()
          {
            Id=118,
            CountryFlag="mu.png",
            CountryName = "Mauritius",
            CountryISDCode = "+230",
            CountryCode = "MU",
          },
           new CountryPickerModel ()
          {
            Id=119,
            CountryFlag="mx.png",
            CountryName = "Mexico",
            CountryISDCode = "+52",
            CountryCode = "MX",
          },
           new CountryPickerModel ()
          {
            Id=120,
            CountryFlag="fm.png",
            CountryName = "Micronesia",
            CountryISDCode = "+691",
            CountryCode = "FM",
          },
           new CountryPickerModel ()
          {
            Id=121,
            CountryFlag="md.png",
            CountryName = " Moldova",
            CountryISDCode = "+373",
            CountryCode = "MD",
          },
           new CountryPickerModel ()
          {
            Id=122,
            CountryFlag="mc.png",
            CountryName = "Monaco",
            CountryISDCode = "+377",
            CountryCode = "MC",
           },
            new CountryPickerModel ()
          {
            Id=123,
            CountryFlag="mn.png",
            CountryName = "Mongolia",
            CountryISDCode = "+976",
            CountryCode = "MN",
            },
            new CountryPickerModel ()
          {
            Id=124,
            CountryFlag="me.png",
            CountryName = "Montenegro",
            CountryISDCode = "+382",
            CountryCode = "ME",
          },
            new CountryPickerModel ()
          {
            Id=125,
            CountryFlag="ma.png",
            CountryName = "Morocco",
            CountryISDCode = "+212",
            CountryCode = "MA",
          },
            new CountryPickerModel ()
          {
            Id=126,
            CountryFlag="mz.png",
            CountryName = "Mozambique",
            CountryISDCode = "+258",
            CountryCode = "MZ",
          },
            new CountryPickerModel ()
          {
            Id=127,
            CountryFlag="mm.png",
            CountryName = "Myanmar",
            CountryISDCode = "+95",
            CountryCode = "MM",
          },
            new CountryPickerModel ()
          {
            Id=128,
            CountryFlag="na.png",
            CountryName = "Namibia",
            CountryISDCode = "+264",
            CountryCode = "NA",
          },
            new CountryPickerModel ()
          {
            Id=129,
            CountryFlag="nr.png",
            CountryName = "Nauru",
            CountryISDCode = "+674",
            CountryCode = "NR",
          },
            new CountryPickerModel ()
          {
            Id=130,
            CountryFlag="np.png",
            CountryName = "Nepal",
            CountryISDCode = "+977",
            CountryCode = "NP",
          },
            new CountryPickerModel ()
          {
            Id=131,
            CountryFlag="nl.png",
            CountryName = "Netherlands",
            CountryISDCode = "+31",
            CountryCode = "NL",
          },
            new CountryPickerModel ()
          {
            Id=132,
            CountryFlag="nc.png",
            CountryName = "New Caledonia",
            CountryISDCode = "+687",
            CountryCode = "NC",
          },
            new CountryPickerModel ()
          {
            Id=133,
            CountryFlag="nz.png",
            CountryName = "New Zealand",
            CountryISDCode = "+64",
            CountryCode = "NZ",
          },
            new CountryPickerModel ()
          {
            Id=134,
            CountryFlag="ni.png",
            CountryName = "Nicaragua",
            CountryISDCode = "+505",
          },
            new CountryPickerModel ()
          {
            Id=135,
            CountryFlag="ne.png",
            CountryName = "Niger",
            CountryISDCode = "+227",
            CountryCode = "NE",
          },
            new CountryPickerModel ()
          {
            Id=136,
            CountryFlag="ng.png",
            CountryName = "Nigeria",
            CountryISDCode = "+234",
            CountryCode = "NG",
          },
            new CountryPickerModel ()
          {
            Id=137,
            CountryFlag="mp.png",
            CountryName = "Northern Mariana Islands",
            CountryISDCode = "+1-670",
            CountryCode = "MP",
          },
            new CountryPickerModel ()
          {
            Id=138,
            CountryFlag="no.png",
            CountryName = "Norway",
            CountryISDCode = "+47",
            CountryCode = "NO",
          },
            new CountryPickerModel ()
          {
            Id=139,
            CountryFlag="om.png",
            CountryName = "Oman",
            CountryISDCode = "+968",
            CountryCode = "OM",
          },
            new CountryPickerModel ()
          {
            Id=140,
            CountryFlag="pk.png",
            CountryName = "Pakistan",
            CountryISDCode = "+92",
            CountryCode = "PK",
          },
            new CountryPickerModel ()
          {
            Id=141,
            CountryFlag="pw.png",
            CountryName = "Palau",
            CountryISDCode = "+680",
            CountryCode = "PW",
          },
            new CountryPickerModel ()
          {
            Id=142,
            CountryFlag="ps.png",
            CountryName = "Palestinian",
            CountryISDCode = "+970",
            CountryCode = "PS",
          },
            new CountryPickerModel ()
          {
            Id=143,
            CountryFlag="pa.png",
            CountryName = "Panama",
            CountryISDCode = "+507",
            CountryCode = "PA",
          },
            new CountryPickerModel ()
          {
            Id=144,
            CountryFlag="pg.png",
            CountryName = "Papua New Guinea",
            CountryISDCode = "+675",
            CountryCode = "PG",
          },
            new CountryPickerModel ()
          {
            Id=145,
            CountryFlag="py.png",
            CountryName = "Paraguay",
            CountryISDCode = "+595",
            CountryCode = "PY",
          },
            new CountryPickerModel ()
          {
            Id=146,
            CountryFlag="pe.png",
            CountryName = "Peru",
            CountryISDCode = "+51",
            CountryCode = "PE",
          },
            new CountryPickerModel ()
          {
            Id=147,
            CountryFlag="ph.png",
            CountryName = "Philippines",
            CountryISDCode = "+63",
            CountryCode = "PH",
          },
            new CountryPickerModel ()
          {
            Id=148,
            CountryFlag="pl.png",
            CountryName = "Poland",
            CountryISDCode = "+48",
            CountryCode = "PL",
          },
            new CountryPickerModel ()
          {
            Id=149,
            CountryFlag="pt.png",
            CountryName = "Portugal",
            CountryISDCode = "+351",
            CountryCode = "PT",
          },
            new CountryPickerModel ()
          {
            Id=150,
            CountryFlag="pr.jpg",
            CountryName = "Puerto Rico",
            CountryISDCode = "+1-787",
            CountryCode = "PR",
          },
            new CountryPickerModel ()
          {
            Id=151,
            CountryFlag="qa.png",
            CountryName = "Qatar",
            CountryISDCode = "+974",
            CountryCode = "QA",
          },
            new CountryPickerModel ()
          {
            Id=152,
            CountryFlag="re.jpg",
            CountryName = "Réunion",
            CountryISDCode = "+262",
            CountryCode = "RE",
          },
            new CountryPickerModel ()
          {
            Id=153,
            CountryFlag="ro.png",
            CountryName = "Romania",
            CountryISDCode = "+40",
            CountryCode = "RO",
          },
            new CountryPickerModel ()
          {
            Id=154,
            CountryFlag="ru.png",
            CountryName = "Russian Federation",
            CountryISDCode = "+7-73",
            CountryCode = "RU",
          },
            new CountryPickerModel ()
          {
            Id=155,
            CountryFlag="rw.png",
            CountryName = "Rwanda",
            CountryISDCode = "+250",
            CountryCode = "RW",
          },
            new CountryPickerModel ()
          {
            Id=156,
            CountryFlag="kn.png",
            CountryName = "Saint Kitts and Nevis",
            CountryISDCode = "+1-869",
            CountryCode = "KN",
          },
            new CountryPickerModel ()
          {
            Id=157,
            CountryFlag="lc.png",
            CountryName = "Saint Lucia",
            CountryISDCode = "+1-758",
            CountryCode = "LC",
          },
            new CountryPickerModel ()
          {
            Id=158,
            CountryFlag="ws.png",
            CountryName = "Samoa",
            CountryISDCode = "+685",
            CountryCode = "WS",
          },
            new CountryPickerModel ()
          {
            Id=159,
            CountryFlag="sm.png",
            CountryName = "San Marino",
            CountryISDCode = "+378",
            CountryCode = "SM",
          },
            new CountryPickerModel ()
          {
            Id=160,
            CountryFlag="st.png",
            CountryName = "Sao Tome and Princ",
            CountryISDCode = "+239",
            CountryCode = "ST",
          },
            new CountryPickerModel ()
          {
            Id=161,
            CountryFlag="sa.png",
            CountryName = "Saudi Arabia",
            CountryISDCode = "+966",
            CountryCode = "SA",
          },
            new CountryPickerModel ()
          {
            Id=162,
            CountryFlag="sn.png",
            CountryName = "Senegal",
            CountryISDCode = "+221",
            CountryCode = "SN",
          },
            new CountryPickerModel ()
          {
            Id=163,
            CountryFlag="rs.png",
            CountryName = "Serbia",
            CountryISDCode = "+381",
            CountryCode = "RS",
          },
            new CountryPickerModel ()
          {
            Id=164,
            CountryFlag="sc.png",
            CountryName = "Seychelles",
            CountryISDCode = "+248",
            CountryCode = "SC",
          },
            new CountryPickerModel ()
          {
            Id=165,
            CountryFlag="sl.png",
            CountryName = "Sierra Leone",
            CountryISDCode = "+232",
            CountryCode = "SL",
          },
            new CountryPickerModel ()
          {
            Id=166,
            CountryFlag="sg.png",
            CountryName = "Singapore",
            CountryISDCode = "+65",
            CountryCode = "SG",
          },
            new CountryPickerModel ()
          {
            Id=167,
            CountryFlag="sk.png",
            CountryName = "Slovakia",
            CountryISDCode = "+421",
            CountryCode = "SK",
          },
            new CountryPickerModel ()
          {
            Id=168,
            CountryFlag="sb.png",
            CountryName = "Solomon Islands",
            CountryISDCode = "+677",
            CountryCode = "SB",
          },
             new CountryPickerModel ()
          {
            Id=169,
            CountryFlag="so.png",
            CountryName = "Somalia",
            CountryISDCode = "+252",
            CountryCode = "SO",
          },
              new CountryPickerModel ()
          {
            Id=170,
            CountryFlag="za.png",
            CountryName = "South Africa",
            CountryISDCode = "+27",
            CountryCode = "ZA",
          },
               new CountryPickerModel ()
          {
            Id=171,
            CountryFlag="es.png",
            CountryName = "Spain",
            CountryISDCode = "+34",
            CountryCode = "ES",
          },
           new CountryPickerModel ()
          {
            Id=172,
            CountryFlag="lk.png",
            CountryName = "Sri Lanka",
            CountryISDCode = "+94",
            CountryCode = "LK",
          },
           new CountryPickerModel ()
          {
            Id=173,
            CountryFlag="vc.png",
            CountryName = "St Vincent and Gren",
            CountryISDCode = "+1-784",
            CountryCode = "VC",
          },
           new CountryPickerModel ()
          {
            Id=174,
            CountryFlag="sd.png",
            CountryName = "Sudan",
            CountryISDCode = "+249",
            CountryCode = "SD",
          },
           new CountryPickerModel ()
          {
            Id=175,
            CountryFlag="sr.png",
            CountryName = "Suriname",
            CountryISDCode = "+597",
            CountryCode = "SR",
          },
           new CountryPickerModel ()
          {
            Id=176,
            CountryFlag="sz.png",
            CountryName = "Swaziland",
            CountryISDCode = "+268",
            CountryCode = "SZ",
          },
           new CountryPickerModel ()
          {
            Id=177,
            CountryFlag="se.png",
            CountryName = "Sweden",
            CountryISDCode = "+46",
            CountryCode = "SE",
          },
           new CountryPickerModel ()
          {
            Id=178,
            CountryFlag="ch.png",
            CountryName = "Switzerland",
            CountryISDCode = "+41",
            CountryCode = "CH",
          },
           new CountryPickerModel ()
          {
            Id=179,
            CountryFlag="sy.png",
            CountryName = "Syria",
            CountryISDCode = "+963",
            CountryCode = "SY",
          },
           new CountryPickerModel ()
          {
            Id=180,
            CountryFlag="tw.png",
            CountryName = "Taiwan",
            CountryISDCode = "+886",
            CountryCode = "TW",
          },
           new CountryPickerModel ()
          {
            Id=181,
            CountryFlag="tj.png",
            CountryName = "Tajikistan",
            CountryISDCode = "+992",
            CountryCode = "TJ",
          },
           new CountryPickerModel ()
          {
            Id=182,
            CountryFlag="tz.png",
            CountryName = "Tanzania",
            CountryISDCode = "+255",
            CountryCode = "TZ",
          },
           new CountryPickerModel ()
          {
            Id=183,
            CountryFlag="th.png",
            CountryName = "Thailand",
            CountryISDCode = "+66",
            CountryCode = "TH",
          },
           new CountryPickerModel ()
          {
            Id=184,
            CountryFlag="tg.png",
            CountryName = "Togo",
            CountryISDCode = "+228",
            CountryCode = "TG",
          },
           new CountryPickerModel ()
          {
            Id=185,
            CountryFlag="to.png",
            CountryName = "Tonga",
            CountryISDCode = "+676",
            CountryCode = "TO",
          },
           new CountryPickerModel ()
          {
            Id=186,
            CountryFlag="tt.png",
            CountryName = "Trinidad and Tobago",
            CountryISDCode = "+1-868",
            CountryCode = "TT",
          },
           new CountryPickerModel ()
          {
            Id=187,
            CountryFlag="tn.png",
            CountryName = "Tunisia",
            CountryISDCode = "+216",
            CountryCode = "TN",
          },
           new CountryPickerModel ()
          {
            Id=188,
            CountryFlag="tr.png",
            CountryName = "Turkey",
            CountryISDCode = "+90",
            CountryCode = "TR",
          },
           new CountryPickerModel ()
          {
            Id=189,
            CountryFlag="tm.png",
            CountryName = "Turkmenistan",
            CountryISDCode = "+993",
            CountryCode = "TM",
          },
           new CountryPickerModel ()
          {
            Id=190,
            CountryFlag="tv.png",
            CountryName = "Tuvalu",
            CountryISDCode = "+688",
            CountryCode = "TV",
          },
           new CountryPickerModel ()
          {
            Id=191,
            CountryFlag="ug.png",
            CountryName = "Uganda",
            CountryISDCode = "+256",
            CountryCode = "UG",
          },
           new CountryPickerModel ()
          {
            Id=192,
            CountryFlag="ua.png",
            CountryName = "Ukraine",
            CountryISDCode = "+380",
            CountryCode = "UA",
          },
           new CountryPickerModel ()
          {
            Id=193,
            CountryFlag="ae.png",
            CountryName = "United Arab Emirates",
            CountryISDCode = "+971",
            CountryCode = "AE",
          },
           new CountryPickerModel ()
          {
            Id=194,
            CountryFlag="gb.png",
            CountryName = "United Kingdom",
            CountryISDCode = "+44",
            CountryCode = "GB",
          },
           new CountryPickerModel ()
          {
            Id=2,
            CountryFlag="us.png",
            CountryName = "United States",
            CountryISDCode = "+1",
            CountryCode = "US",
          },
           new CountryPickerModel ()
          {
            Id=195,
            CountryFlag="uy.png",
            CountryName = "Uruguay",
            CountryISDCode = "+598",
            CountryCode = "UY",
          },
           new CountryPickerModel ()
          {
            Id=196,
            CountryFlag="uz.png",
            CountryName = "Uzbekistan",
            CountryISDCode = "+998",
            CountryCode = "UZ",
          },
           new CountryPickerModel ()
          {
            Id=197,
            CountryFlag="vu.png",
            CountryName = "Vanuatu",
            CountryISDCode = "+678",
            CountryCode = "VU",
          },
           new CountryPickerModel ()
          {
            Id=198,
            CountryFlag="va.png",
            CountryName = "Vatican City",
            CountryISDCode = "+379",
            CountryCode = "VA",
          },
           new CountryPickerModel ()
          {
            Id=199,
            CountryFlag="ve.png",
            CountryName = "Venezuela",
            CountryISDCode = "+58",
            CountryCode = "VE",
          },
           new CountryPickerModel ()
          {
            Id=200,
            CountryFlag="vn.png",
            CountryName = "Vietnam",
            CountryISDCode = "+84",
            CountryCode = "VN",
          },
           new CountryPickerModel ()
          {
            Id=201,
            CountryFlag="vg.png",
            CountryName = "Virgin Islands, British",
            CountryISDCode = "+1-284",
            CountryCode = "VG",
          },
           new CountryPickerModel ()
          {
            Id=202,
            CountryFlag="vi.png",
            CountryName = "Virgin Islands, U.S.",
            CountryISDCode = "+1-340",
            CountryCode = "VI",
          },
           new CountryPickerModel ()
          {
            Id=203,
            CountryFlag="eh.png",
            CountryName = "Western Sahara",
            CountryISDCode = "+212",
            CountryCode = "EH",
          },
           new CountryPickerModel ()
          {
            Id=204,
            CountryFlag="ye.png",
            CountryName = "Yemen",
            CountryISDCode = "+967",
            CountryCode = "YE",
          },
           new CountryPickerModel ()
          {
            Id=205,
            CountryFlag="zm.png",
            CountryName = "Zambia",
            CountryISDCode = "+260",
            CountryCode = "ZM",
          },
           new CountryPickerModel ()
          {
            Id=206,
            CountryFlag="zw.png",
            CountryName = "Zimbabwe",
            CountryISDCode = "+263",
            CountryCode = "ZW",
          },
       };
        }

    }
}
