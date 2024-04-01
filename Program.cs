using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace ConsoleApp1 {
    internal class Program {
        static void Main (string[] args) {

            Conta conta;

            Console.WriteLine("***** Santander *****");
                string chave = Guid.NewGuid().ToString().Substring(0, 8);
                var comprovante = DateTime.Now;
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLower());
                if (resposta == 's') {
                    Console.Write("Valor do depósito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    conta = new Conta(numero, nome, chave, comprovante, depositoInicial);
                }
                else {
                    conta = new Conta(numero, nome, chave, comprovante);
                }

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine($"--- Dados da Conta ---\n{conta}");

            Console.WriteLine();
            Console.Write("Valor do depósito: R$ ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            chave = Guid.NewGuid().ToString().Substring(0, 8);
            conta.Guid(chave);
            comprovante = DateTime.Now;
            conta.Data(comprovante);

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine($"--- Dados da Conta ---\n{conta}");
            

            Console.WriteLine();
            Console.Write("Valor do saque: R$ ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            chave = Guid.NewGuid().ToString().Substring(0, 8);
            conta.Guid(chave);
            comprovante = DateTime.Now;
            conta.Data(comprovante);

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine($"--- Dados da Conta ---\n{conta}");

        }
    }
}
