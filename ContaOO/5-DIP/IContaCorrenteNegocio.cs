using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO._5_DIP
{
    interface IContaCorrenteNegocio
    {
        void Sacar(double valor);

        void Depositar(double valor);
    }
}
