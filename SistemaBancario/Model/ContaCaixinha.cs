using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Model
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(decimal saldo) : base(saldo)
        {
        }

        public ContaCaixinha(Cliente cliente) : base(cliente)
        {
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero.");
            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            Saldo -= (valor + 5); // Saldo = Saldo - valor;
        }
        public override void Depositar(decimal valor)
        {
            if (valor < 1)
                throw new ArgumentOutOfRangeException("O valor do depósito deve ser maior que 1,00.");
            Saldo += (valor + 1); // Saldo = Saldo + valor;
        }
    }
}
