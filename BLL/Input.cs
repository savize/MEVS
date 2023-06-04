using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public static class Input
    {
        public static readonly Regex _regex = new Regex("[^0-9.-]+");
        public static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        public static bool EVRegCk(string vModel, string Bank, string Address)
        {
            bool ok = true;
            if (vModel == "" || Bank == "" || Address == "")
            {
                ok = false;
            }
            return ok;
        }

        public static bool SPRegCk(string CompName, string PTitle, string duration, string Price)
        {
            bool ck = true;
            if(CompName == "" || PTitle == "" || duration == "" || Price == "")
            {
                ck = false;
            }
            return ck;
        }

        public static bool PlanCk (string PT, string Dur, string Pri)
        {
            bool plnOk = true;
            if(PT == "" || Dur == "" || Pri == "")
            {
                plnOk = false;
            }
            return plnOk;
        }

        public static bool SPCheck(string StationId, string address, string CHName, string Amount)
        {
            bool SPOk = true;
            if(StationId == "" || address == "" || CHName == "" || Amount== "")
            {
                SPOk = false;
            }
            return SPOk;
        }

        public static bool ChargerCheck(string CHName, string Amount)
        {
            bool charOk = true;
            if (CHName == "" || Amount == "")
            {
                charOk = false;
            }
            return charOk;
        }
    }

}
