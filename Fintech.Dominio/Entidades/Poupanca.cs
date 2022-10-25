namespace Fintech.Dominio.Entidades
{
    // Conta Classe Mae uma herança
    public class Poupanca : Conta
    {
        public Poupanca(Agencia agencia, int numero, string digitoVerificador) : base(agencia, numero, digitoVerificador)
        {
            //Agencia = agencia;
            //Numero = numero;
            //DigitoVerificador = digitoVerificador;
        }

        // construtor ctor podendo ser usado assim ou como abaixo 
        //public Poupanca()
        //{
        //    TaxaRendimento = 0.5m;
        //}
        public decimal TaxaRendimento { get; set; } = 0.5m;
        public decimal TaxaCid { get; set; }
    }
}
