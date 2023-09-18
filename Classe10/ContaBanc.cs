using System;
using System.Globalization;

class ContaBanc {
    public int Conta {get; private set;}
    public string Nome {get; set;}
    public double Saldo {get; private set;}

    public ContaBanc(int conta, string nome) {
        Conta = conta;
        Nome = nome;
    }
    public ContaBanc(int conta, string nome, double saldo) : this (conta, nome){
        Saldo = saldo;
    }

    public void Deposito (double deposito) {
        Saldo += deposito;
    }

    public void Saque (double saque) {
        Saldo -= saque + 5.0;
    }

    public override string ToString()
    {
        return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
    }
}