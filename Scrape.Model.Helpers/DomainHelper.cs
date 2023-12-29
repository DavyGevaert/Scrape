using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrape.Model.Helpers
{
    public class DomainHelper
    {
        public string DomainNumber(string domain)
        {
            string url = "&jobdomein=";

            switch (domain)
            {
                case "Aankoop":
                    url = url + "JOBCAT01";
                    break;
                case "Administratie":
                    url = url + "JOBCAT02";
                    break;
                case "Bouw":
                    url = url + "JOBCAT03";
                    break;
                case "Communicatie":
                    url = url + "JOBCAT04";
                    break;
                case "Creatief":
                    url = url + "JOBCAT05";
                    break;
                case "Dienstverlening":
                    url = url + "JOBCAT14";
                    break;
                case "Financieel":
                    url = url + "JOBCAT06";
                    break;
                case "Gezondheid":
                    url = url + "JOBCAT07";
                    break;
                case "Horeca en toerisme":
                    url = url + "JOBCAT08";
                    break;
                case "Human resources":
                    url = url + "JOBCAT09";
                    break;
                case "ICT":
                    url = url + "JOBCAT10";
                    break;
                case "Juridisch":
                    url = url + "JOBCAT11";
                    break;
                case "Land- en tuinbouw":
                    url = url + "JOBCAT12";
                    break;
                case "Logistiek en transport":
                    url = url + "JOBCAT13";
                    break;
                case "Management":
                    url = url + "JOBCAT15";
                    break;
                case "Marketing":
                    url = url + "JOBCAT16";
                    break;
                case "Onderhoud":
                    url = url + "JOBCAT17";
                    break;
                case "Onderwijs":
                    url = url + "JOBCAT18";
                    break;
                case "Overheid":
                    url = url + "JOBCAT19";
                    break;
                case "Onderzoek en ontwikkeling":
                    url = url + "JOBCAT20";
                    break;
                case "Productie":
                    url = url + "JOBCAT21";
                    break;
                case "Techniek":
                    url = url + "JOBCAT22";
                    break;
                case "Verkoop":
                    url = url + "JOBCAT23";
                    break;
                case "Andere":
                    url = url + "JOBCAT24";
                    break;
            }

            return url;
        }
    }
}
