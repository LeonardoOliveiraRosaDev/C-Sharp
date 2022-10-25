using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class ContaEspecial : ContaCorrente
    {
        public ContaEspecial(Agencia agencia, int numero, string digitoVerificador, decimal limite) : base(agencia, numero, digitoVerificador)
        {
            Limite = limite;
        }

        public decimal Limite { get; set; }


        //esse override e feito para subistituir o que vem da classe mae !
        public override void EfetuarOperacao(decimal valor, TipoOperacao TipoOperacao)
        {
            switch (TipoOperacao)
            {
                case TipoOperacao.Deposito:
                    Saldo += valor;
                    //Saldo = Saldo + valor;
                    break;
                case TipoOperacao.Saque:
                    if (Saldo + Limite >= valor)
                    {
                        Saldo -= valor;
                    }
                    //Saldo = Saldo - valor;
                    break;
                default:
                    break;
            }
        }
    }
}
