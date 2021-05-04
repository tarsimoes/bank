using System;

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
            
        }
    }
}
