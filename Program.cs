using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace ConsoleApp1 {
    internal class Program {
        static void Main (string[] args) {

            Conta conta;

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLower());
                if (resposta == 's') {
                    Console.Write("Valor do depósito inicial: R$ ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    conta = new Conta(numero, nome, depositoInicial);
                }
                else {
                    conta = new Conta(numero, nome);
                }

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"---- Dados da Conta ----\n{conta}");

            Console.WriteLine();
            Console.Write("Valor do depósito: R$ ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            conta.AtualizarGuid();
            conta.AtualizarData();


            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"---- Dados da Conta ----\n{conta}");
            

            Console.WriteLine();
            Console.Write("Valor do saque: R$ ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            conta.AtualizarGuid();
            conta.AtualizarData();


            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"---- Dados da Conta ----\n{conta}");

        }
    }
}
