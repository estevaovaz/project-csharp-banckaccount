using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BankAccount.Entity
{
    public class Account
    {
        public Int64 NumeroConta { get; private set; }
        public String NomeTitular { get; set; }
        public Double Saldo { get; private set; }


        public Account(Int64 numero, String nome)
        {
            NumeroConta = numero;
            NomeTitular = nome;
        }

        public Account(Int64 numero, String nome, Double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(Double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(Double quantia)
        {

            Saldo -= quantia + 5.0;


        }

        public override string ToString()
        {
            return "Conta: "
                + NumeroConta
                + ", "
                + "Titular: "
                + NomeTitular
                + ", "
                + "Saldo: "
                + " $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
