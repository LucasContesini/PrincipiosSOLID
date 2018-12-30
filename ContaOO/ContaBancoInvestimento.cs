using Conta.ContaOO._4_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    class ContaBancoInvestimento : ContaBanco, IContaInvestimento
    {
        public void ComprarAcao(string acao, double valor)
        {
            //Método que compra um ação
        }

        public void VenderAcao(string acao)
        {
            //Método que vende uma ação
        }
    }
}
