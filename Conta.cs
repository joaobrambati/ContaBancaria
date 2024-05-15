using System;
using System.Globalization;

namespace ConsoleApp1 {
    public class Conta {

        public int Numero {  get; private set; }
        public string Nome {  get; private set; }
        public double Saldo {  get; private set; }
        public string Chave { get; private set; }
        public DateTime Comprovante { get; private set; }

        public Conta(int numero, string nome) {
            Numero = numero;
            Nome = nome;
            Chave = Guid.NewGuid().ToString().Substring(0, 8);
            Comprovante = DateTime.Now;
        }
        public Conta(int numero, string nome, double depositoInicial) 
        :this(numero, nome) {
            Saldo = depositoInicial;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }
        public void Saque(double saque) {
            Saldo -= saque+5.0;
        }

        public void AtualizarGuid() {
            Chave = Guid.NewGuid().ToString().Substring(0, 8);
        }
        public void AtualizarData() {
            Comprovante = DateTime.Now;
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
