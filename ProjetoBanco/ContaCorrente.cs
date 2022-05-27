using ProjetoBanco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente, int numero, decimal saldo)
             : base(cliente, numero, saldo)
        { }

        public override bool Depositar(decimal valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                MensagemTransacoes = $"O valor do depósito é inválido!";
                return false;
            }

            Saldo += valorDeposito;
            MensagemTransacoes = "Deposito realizado com sucesso!";

            return true;
        }

        public override bool Sacar(decimal valorSaque)
        {
            if (Saldo <= 0)
            {
                MensagemTransacoes = $"O saldo é insuficiente para saque. Sua conta está com o valor atual de {Saldo}";
                return false;
            }

            if (Saldo < valorSaque)
            {
                MensagemTransacoes = $"Valor solicitado para o saque é {valorSaque} e o Saldo é {Saldo}";
                return false;
            }

            Saldo -= valorSaque;
            return true;
        }
    }
}
