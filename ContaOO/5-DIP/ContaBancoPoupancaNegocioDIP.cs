using Conta.ContaOO._4_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    class ContaBancoPoupancaNegocioDIP
    {
        IContaPoupanca contaBancoPoupanca;

        public ContaBancoPoupancaNegocioDIP(IContaPoupanca contaPoupanca)
        {
            contaBancoPoupanca = contaPoupanca;
        }

        public void Sacar(double valor)
        {
            if (valor != 0)
            {
                contaBancoPoupanca.Sacar(valor);
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
