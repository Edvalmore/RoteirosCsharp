   using System.Globalization;
   class ContaBancaria
    {
        public int Numero { get; private set;}
        public string Nome { get; set;}
        public double Saldo { get; private set;}

        public ContaBancaria(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }
        public ContaBancaria(int numero, string nome, double deposito) : this(numero, nome){
            Saldo = deposito;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    