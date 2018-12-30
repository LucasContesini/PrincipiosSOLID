using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO.OCP
{
    class ContaBancoViolacaoOCP
    {
        public string Agencia { get; set; }

        public string NumeroConta { get; set; }

        public double Saldo { get; protected set; }

        public string TipoConta { get; set; }



        public void Debitar(string tipoConta)
        {
            if(TipoConta == "Conta Corrente")
            {
                //Debito de Conta Corrente
            }
            else if(TipoConta == "Conta Poupança")
            {
                //Debito de Conta Poupança
            }
            else if(TipoConta == "Conta Investimento")
            {

            }
        }

        public double TaxaJuros { get; set; }
    }
}
