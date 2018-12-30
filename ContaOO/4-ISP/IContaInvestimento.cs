using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO._4_ISP
{
    interface IContaInvestimento
    {
        void ComprarAcao(string acao, double valor);

        void VenderAcao(string acao);
    }
}
