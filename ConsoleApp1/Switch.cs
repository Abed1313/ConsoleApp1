using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Switch
    {
        public static string UserSwitch(string usreRole)
        {
            string userType;
            switch (usreRole) 
            {
                case "abmin":
                    userType = "Adminstretor";
                    break;
                case "user":
                    userType = "Member";
                    break;
                default:
                    userType = "No Role";
                    break;
            }
            return userType;
        }
    }
}
