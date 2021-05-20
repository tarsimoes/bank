using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Sistemas
{
    interface IAuthentication
    {
        bool Authentication(string password);
    }
}
