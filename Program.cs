using ConsoleApp1;
using Npgsql;
using System;
namespace CosoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTransferencia = 500.00;
            double valorSaque = 2000.00;

            var conta1 = new Conta(000, "Pedro", 2000.00);
            var conta2 = new Conta(001, "Wellinton", 2000.00);

            Console.WriteLine("{0}, {1}, {2}", conta1.NumeroDaConta, conta1.Nome, conta1.Saldo);
            Console.WriteLine("{0}, {1}, {2}", conta2.NumeroDaConta, conta2.Nome, conta2.Saldo);

            var saque = new Saque(conta1, valorSaque);

            saque.Sacar();

            //Transferir(valorTransferencia, conta1, conta2);
            
            Console.Read();
        }

        static void Transferir(double valorASerTransferido, Conta contaSaida, Conta contaDestino)
        {

            if (valorASerTransferido > contaSaida.Saldo)
            {
                Console.WriteLine("Saldo insuficiente seu pobre!");
            }

            else
            {
                contaSaida.Saldo -= valorASerTransferido;
                contaDestino.Saldo += valorASerTransferido;
                Console.WriteLine("Sucesso ao transferir");
                Console.WriteLine("Novo saldo da sua conta: {0}.", contaSaida.Saldo);
            }
        }
    }



}


