using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class2
    {
        // Method 1
        public static string GetUserRole(string userRole)
        {
            string userType;

            if (userRole == "admen")
            {
                userType = "Adminstreter";
            }else
            {
                userType ="Number";
            }
            return userType;
        }

        //Method 2
        public static string GetUserRole2(string userRole)
        {
            return (userRole == "admen") ? "Admenstreter" : "Number";
        }

        //Method 3
        public static string GetUserRole3(string userRole , bool isRegsterd = false)
        {
            string userType;

            if (userRole == "admen" && isRegsterd == true)
            {
                userType = "Adminstreter";

            }else if (userRole == "admen" && isRegsterd == true)
            {
                userType = "Number";
            }
            else
            {
                if (isRegsterd == true)
                {
                    userType = "No Role";
                }
                else
                {
                    userType = "Not Regesterd";
                }
                //or i can use this line bellow
               // userType = isRegsterd ? "No ROle" : "Not Regesterd";
            }
                return userType ;
            
        }


    }
}
