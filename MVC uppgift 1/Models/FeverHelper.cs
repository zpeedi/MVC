using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_uppgift_1.Models
{
    public class FeverHelper
    {
        public static string Diagnose(string temp)
        {
            float temperature = float.Parse(temp);

            if (temperature > 37.5)
            {
                return "Du har feber!";
            }
            else
            {
                return "Du är frisk!";
            }

        }
    }
}
