using Conta.ContaOO;
using Conta.ContaOO.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Explicação de Classe, Objeto e Encapsulamento
            ContaBanco contaBanco = new ContaBanco();

            contaBanco.Depositar(100);
            contaBanco.Depositar(100);
            Console.Write(contaBanco.Saldo);
            Console.ReadKey();
            #endregion
            */
            
            #region Explicação Herança, Classe Abstrata, Polimorfismo e Interface
            ContaBancoCorrente contaBancoCorrente = new ContaBancoCorrente();

            contaBancoCorrente.Depositar(200);
            contaBancoCorrente.Sacar(100);
            Console.WriteLine("Conta Corrente: " + contaBancoCorrente.Saldo);


            ContaBancoPoupanca contaBancoPoupanca = new ContaBancoPoupanca();

            contaBancoPoupanca.Depositar(200);
            contaBancoPoupanca.Sacar(100);
            Console.WriteLine("Conta Poupança: " + contaBancoPoupanca.Saldo);

            #endregion
            
            #region LSP
            ContaBancoCorrenteViolacaoLSP contaBancoCorrenteViolacaoLSP = new ContaBancoCorrenteViolacaoLSP();

            contaBancoCorrenteViolacaoLSP.Depositar(200);
            contaBancoCorrenteViolacaoLSP.Sacar(100);
            Console.WriteLine("Conta Corrente Violação LSP: " + contaBancoCorrenteViolacaoLSP.Saldo);

            ContaBancoPoupancaViolacaoLSP contaBancoPoupancaViolacaoLSP = new ContaBancoPoupancaViolacaoLSP();

            contaBancoPoupancaViolacaoLSP.Depositar(200);
            contaBancoPoupancaViolacaoLSP.Sacar(100);
            Console.WriteLine("Conta Poupança Violação LSP: " + contaBancoPoupancaViolacaoLSP.Saldo);
            Console.ReadKey();
            #endregion


        }
    }
}
