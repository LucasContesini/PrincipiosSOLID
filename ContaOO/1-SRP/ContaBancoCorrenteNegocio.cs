using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    class ContaBancoCorrenteNegocio
    {
        ContaBancoCorrente contaBancoCorrente = new ContaBancoCorrente();

        public void Sacar(double valor)
        {
            if(valor != 0)
            {
                if(contaBancoCorrente.Saldo >= valor)
                {
                    contaBancoCorrente.Sacar(valor);
                }
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
