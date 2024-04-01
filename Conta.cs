using System;
using System.Globalization;

namespace ConsoleApp1 {
    internal class Conta {

        public int Numero {  get; private set; }
        public string Nome {  get; private set; }
        public double Saldo {  get; private set; }
        public string Chave { get; private set; }
        public DateTime Comprovante { get; private set; }

        public Conta(int numero, string nome, string chave, DateTime comprovante) {
            Numero = numero;
            Nome = nome;
            Chave = chave;
            Comprovante = comprovante;
        }
        public Conta(int numero, string nome, string chave, DateTime comprovante, double depositoInicial) 
        :this(numero, nome, chave, comprovante) {
            Saldo = depositoInicial;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }
        public void Saque(double saque) {
            Saldo -= saque+5.0;
        }

        public void Guid(string chave) {
            Chave = chave;
        }
        public void Data(DateTime comprovante) {
            Comprovante = comprovante;
        }

        public override string ToString() {
            return "Número: "
                   + Numero
                   + "\nTitular: "
                   + Nome
                   + "\nSaldo: "
                   + Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))
                   + "\nChave: "
                   + Chave
                   + "\n"
                   + Comprovante;                   
        }

    }
}
