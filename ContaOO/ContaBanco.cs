using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ContaOO
{
    abstract class ContaBanco
    {
        public string Agencia { get; set; }

        public string NumeroConta { get; set; }

        public double Saldo { get; protected set; }
    }
}
