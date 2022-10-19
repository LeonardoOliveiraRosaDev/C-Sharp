﻿

namespace Fintech.Dominio.Entidades
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int DigitoVerificador { get; set; }
        public decimal Saldo  { get; set; }
        public Agencia Agencia { get; set; }
        public Cliente Cliente { get; set; }

        public void EfetuarOperacao(decimal valor, TipoOperacao TipoOperacao)
        {
            switch (TipoOperacao)
            {
                case TipoOperacao.Deposito:
                    Saldo += valor;
                    //Saldo = Saldo + valor;
                    break;
                case TipoOperacao.Saque:
                    Saldo -= valor;
                    //Saldo = Saldo - valor;
                    break;
                default:
                    break;
            }
        }

    }
}