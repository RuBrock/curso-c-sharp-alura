using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente cc1 = new ContaCorrente();

            cc1.titular = "Bruno";
            Console.WriteLine(cc1.saldo);
            cc1.Sacar(59);
            Console.WriteLine(cc1.saldo);
            cc1.Sacar(45);
            Console.WriteLine(cc1.saldo);
            Console.WriteLine();
            cc1.Depositar(45);
            Console.WriteLine(cc1.saldo);

        }
    }
}
