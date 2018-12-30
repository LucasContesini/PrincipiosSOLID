using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    class ContaBancoPoupancaNegocio
    {
        ContaBancoPoupanca contaBancoPoupanca = new ContaBancoPoupanca();

        public void Sacar(double valor)
        {
            if (valor != 0)
            {
                if (contaBancoPoupanca.Saldo >= valor)
                {
                    contaBancoPoupanca.Sacar(valor);
                }
            }
        }

        public void Depositar(double valor)
        {
            if (valor != 0)
            {
                contaBancoPoupanca.Depositar(valor);
            }
        }
    }
}
