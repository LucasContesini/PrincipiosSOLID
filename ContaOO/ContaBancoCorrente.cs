using Conta.ContaOO._4_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    class ContaBancoCorrente : ContaBanco, IContaCorrente
    {
        public void Sacar(double valor)
        {
            Saldo = Saldo - (valor + (valor * 0.10));   
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }
    }
}
