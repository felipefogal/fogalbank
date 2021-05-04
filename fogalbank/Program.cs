using System;

namespace fogalbank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.titularDaConta = "Tay";
            cc.numeroDaAgencia = 1234;
            cc.numeroDaConta = 567890;
            cc.saldoDaConta = 10;

            ContaCorrente cc2 = new ContaCorrente();
            cc2.titularDaConta = "Fogal";
            cc2.numeroDaAgencia = 1234;
            cc2.numeroDaConta = 123409;
            cc2.saldoDaConta = 20;

            Console.WriteLine("O nome do titular é " + cc.titularDaConta);
            Console.WriteLine("O nome do titular da segunda conta é " + cc2.titularDaConta);


        }
    }
}
