using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    interface IConta
    {
        void Sacar(double valor);

        void Depositar(double valor);
    }
}
