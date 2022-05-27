using ProjetoBanco.Classes;
using System;

namespace ProjetoBanco
{
    class Program
    {
        static void Main()
        {            
            try
            {
                var Ariane = Cliente.CreateCliente("Ariane", "Rua 9 de Julho 202", 16999222999, "999.999.999-99", new DateTime(2000, 02, 17));
                var Roger = Cliente.CreateCliente("Roger", "Rua João Pires de Camargo 1598", 1697775689, "125.125.125-9", new DateTime(1985, 05, 25));
               
                Console.WriteLine(Ariane.ToString());

                Conta contaPoupanca = new Poupanca(Ariane, 556895, 1000);
                Conta contaCorrente = new ContaCorrente(Roger, 785687, 0);

                contaPoupanca.Transferir(500, contaCorrente);

                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Depositar(1000);
                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Sacar(500);
                Console.WriteLine(contaPoupanca.Saldo);


                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Depositar(1000);
                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Sacar(500);
                Console.WriteLine(contaCorrente.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}