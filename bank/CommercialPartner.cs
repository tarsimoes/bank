﻿using System;
using System.Collections.Generic;
using System.Text;
using bank.Sistemas;

namespace bank
{
    class CommercialPartner: IAuthentication 
    {
        public string password { get; set; }

        
        public bool Authentication(string password)
        {
            return this.password == password;
        }
    }
}
