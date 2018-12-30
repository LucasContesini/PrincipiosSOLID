using Conta.ContaOO._4_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    class ContaBancoPoupanca : ContaBanco, IContaPoupanca
    {
        public void Sacar(double valor)
        {
            Saldo = Saldo - (valor + (valor * 0.05));
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void AplicarJuros(double juros)
        {
            Saldo = Saldo + (Saldo * juros / 100);
        }
    }
}
