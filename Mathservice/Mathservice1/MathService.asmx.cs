
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mathservice1
{
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod(Description = "show simple message")]
        public string show()
        {
            return "Web sevice Application";
        }
        [WebMethod(Description = "show datetime")]
        public string showdate()
        {
            return DateTime.Now.ToLongDateString();
        }
        [WebMethod(Description = "addition of two int")]
        public double add(double a, double b)
        {

            return a + b;
        }

        [WebMethod(Description = "addition of n numbers")]
        public double addMoreThan2Numbers(string numbers)
        {

            string[] listNumbers = numbers.Split(' ');

            double result = 0;
            for (int i = 0; i < listNumbers.Length; i++)
            {
                result += Convert.ToDouble(listNumbers[i]);
            }
            return result;
        }


        [WebMethod(Description = "Substraction of two int")]
        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
