using Conta.ContaOO._4_ISP;
using Conta.ContaOO._5_DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    class ContaBancoCorrenteNegocioDIP : IContaCorrenteNegocio
    {
        IContaCorrente contaBancoCorrente;

        public ContaBancoCorrenteNegocioDIP(IContaCorrente contaCorrente)
        {
            contaBancoCorrente = contaCorrente;
        }

        public void Sacar(double valor)
        {
            if(valor != 0)
            {
                contaBancoCorrente.Sacar(valor);
            }
        }

        public void Depositar(double valor)
        {
            if(valor != 0)
            {
                contaBancoCorrente.Depositar(valor);
            }
        }
    }
}
