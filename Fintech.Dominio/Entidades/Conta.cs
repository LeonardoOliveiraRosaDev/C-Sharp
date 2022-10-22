

namespace Fintech.Dominio.Entidades
{
    // base class - Classe Base Conta - Super Classe
    // abstract quer dizer que esse tipo de classe nao pode ser instanciada !
    public abstract class Conta
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int DigitoVerificador { get; set; }
        public decimal Saldo  { get; set; }
        public Agencia Agencia { get; set; }
        public Cliente Cliente { get; set; }


        //Pode ser que as classes derivadas possam sobrescrever esse metodo , porem nao é nescessario  !
        // E esse virtual serve para isso apenas na classe mae !
        public virtual void EfetuarOperacao(decimal valor, TipoOperacao TipoOperacao)
        {
            switch (TipoOperacao)
            {
                case TipoOperacao.Deposito:
                    Saldo += valor;
                    //Saldo = Saldo + valor;
                    break;
                case TipoOperacao.Saque:
                    if (Saldo >= valor)
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
