using Exercicio_BankAccount.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EXERICIO CONTA BANCARIA

            Account account;

            Console.Write("Entre o número da conta: ");
            Int64 numero = Int64.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            String nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            String r = Console.ReadLine();
            if (r == "s" || r == "S")
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                Double saldoDepositado = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(numero, nome, saldoDepositado);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: " + account);

                Console.WriteLine();
                Console.Write("Entre um valor para deposito: ");
                Double saldoNovo = Double.Parse(Console.ReadLine());
                account.Deposito(saldoNovo);
                Console.WriteLine("Dados da conta atualizados: " + account);

                Console.Write("Entre um valor para saque: ");
                Double saque = Double.Parse(Console.ReadLine());
                account.Saque(saque);
                Console.WriteLine("Dados da conta atualizados: " + account);

            }
            else
            {
                account = new Account(numero, nome);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: " + account);

                Console.WriteLine();
                Console.Write("Entre um valor para deposito: ");
                Double saldoNovo = Double.Parse(Console.ReadLine());
                account.Deposito(saldoNovo);
                Console.WriteLine("Dados da conta atualizados: " + account);

                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                Double saque = Double.Parse(Console.ReadLine());
                account.Saque(saque);
                Console.WriteLine("Dados da conta atualizados: " + account);

            }
            #endregion 
        }
    }
}
