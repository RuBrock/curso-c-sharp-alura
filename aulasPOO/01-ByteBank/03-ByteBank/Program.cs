using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 864;
            contaGabriela.numero = 84946;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 864;
            contaGabrielaCosta.numero = 84946;

            Console.WriteLine("Igualdade do tipo de Referencia: " + (contaGabriela == contaGabrielaCosta));
            Console.WriteLine("Igualdade do tipo de Valor: " + (contaGabriela.agencia == contaGabrielaCosta.agencia));

            contaGabriela = contaGabrielaCosta;

            Console.WriteLine();
            Console.WriteLine(contaGabriela == contaGabrielaCosta);

            contaGabriela.saldo = 300;
            Console.WriteLine();
            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

            contaGabrielaCosta.saldo = 500;
            Console.WriteLine();
            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

        }
    }
}
