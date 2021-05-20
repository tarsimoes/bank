using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Sistemas
{
    class SystemInternal
    {
        public bool Login(IAuthentication employee, string password)
        {
            bool authenticationUser= employee.Authentication(password);
            if (authenticationUser) {
                Console.WriteLine("Successfully authenticated");
                return true;
            }
            else
            {
                Console.WriteLine("Not authenticated");
                return false;
            }
           
        }
    }
}
