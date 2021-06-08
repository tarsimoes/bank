using System;
using bank.Sistemas;
using bank.Employee;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titularConta = "Fogal";
            contaCorrente.numeroAgencia = 1234;
            contaCorrente.numeroConta = 123456;
            contaCorrente.saldoConta = 1234.00;

            ContaCorrente contaCorrente2 = new ContaCorrente();
            contaCorrente2.titularConta = "Tay";
            contaCorrente2.numeroAgencia = 2233;
            contaCorrente2.numeroConta = 332255;
            contaCorrente2.saldoConta = 20.00;

            Console.WriteLine($"O nome do titular da é {contaCorrente.titularConta}");
            Console.WriteLine($"O nome do segundo titular é {contaCorrente2.titularConta}");

            SystemInternal();
        }
        public static void SystemInternal()
        {
            SystemInternal systemInternal = new SystemInternal();

            Director director = new Director("123.456.789-01");
            director.name = "Taynara";
            director.password = "123654";

            AccountManager accountManager = new AccountManager("12343212354");
            accountManager.name = "Gustavo";
            accountManager.password = "123abc";


            systemInternal.Login(director, "123654");
        }
    
    }
}
