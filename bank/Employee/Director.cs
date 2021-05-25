using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Employee
{
    public class Director:EmployeeAuthentication
    {
        public Director(string cpf) : base(5000, cpf)
        {

        }
    }
}
