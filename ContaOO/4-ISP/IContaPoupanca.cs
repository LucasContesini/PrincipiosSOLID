using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO._4_ISP
{
    interface IContaPoupanca
    {
        void Sacar(double valor);

        void Depositar(double valor);

        void AplicarJuros(double juros);
    }
}
