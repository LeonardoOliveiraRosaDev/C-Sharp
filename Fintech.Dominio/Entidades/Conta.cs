

using System.Collections.Generic;
using System.Linq;

namespace Fintech.Dominio.Entidades
{
    // base class - Classe Base Conta - Super Classe
    // abstract quer dizer que esse tipo de classe nao pode ser instanciada !
    public abstract class Conta
    {
        public Conta(Agencia agencia, int numero, string digitoVerificador)
        {
            Agencia = agencia;
            Numero = numero;
            DigitoVerificador = digitoVerificador;
        }

        public int Id { get; set; }
        public int Numero { get; set; }
        public string DigitoVerificador { get; set; }
        public decimal Saldo  
        {
            get => TotalDeposito - TotalSaque;
            private set { }
        }
        public Agencia Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public List<Movimento> Movimentos { get; set; } = new List<Movimento>();
        public decimal TotalDeposito 
        {
            get //obter
            { // instruções
                return Movimentos.Where(m => m.TipoOperacao == TipoOperacao.Deposito).Sum(m => m.Valor);
            }
            //set;
        }
        public decimal TotalSaque => Movimentos.Where(m => m.TipoOperacao == TipoOperacao.Saque).Sum(m => m.Valor);




        //Pode ser que as classes derivadas possam sobrescrever esse metodo , porem nao é nescessario  !
        // E esse virtual serve para isso apenas na classe mae !
        public virtual Movimento EfetuarOperacao(decimal valor, TipoOperacao TipoOperacao, decimal limite = 0)
        {
           // var sucesso = true;
            
            Movimento movimento = null;

            switch (TipoOperacao)
            {
                case TipoOperacao.Deposito:
                    Saldo += valor;
                    //Saldo = Saldo + valor;
                    break;
                case TipoOperacao.Saque:
                    if (Saldo + limite >= valor)
                    {
                        Saldo -= valor; 
                    }
                    else
                    {
                        throw new SaldoInsuficienteException();
                    }
                    break;
            }

            
                movimento = new Movimento(valor, TipoOperacao, this);
                Movimentos.Add(movimento); 
           
            return movimento;
        }

    }
}
