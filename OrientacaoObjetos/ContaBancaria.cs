using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OrientacaoObjetos {
    class ContaBancaria {
        
        private double _tarifa = 5.00;
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double deposito) : this(numeroConta, nome)
        {
            Deposito(deposito);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + _tarifa);
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", "
                + "Titular: "
                + Nome
                + ", "
                + "Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
