using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc1 = new ContaCorrente();
            cc1.titular = "Gabriela";
            cc1.agencia = 133;
            cc1.numero = 60801;
            cc1.saldo = 689.78;

            Console.WriteLine(cc1.titular);
            Console.WriteLine("Agência " + cc1.titular);
            Console.WriteLine("Número " + cc1.numero);
            Console.WriteLine("Saldo " + cc1.saldo);
            Console.WriteLine();
            cc1.saldo += 350;
            Console.WriteLine("Saldo Atualizado " + cc1.saldo);

        }
    }
}
