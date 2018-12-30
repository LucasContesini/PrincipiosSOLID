using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO._4_ISP
{
    interface IContaCorrente
    {
        void Sacar(double valor);

        void Depositar(double valor);
    }
}
