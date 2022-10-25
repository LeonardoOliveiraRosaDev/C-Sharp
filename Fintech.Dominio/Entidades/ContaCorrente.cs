using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Agencia agencia, int numero, string digitoVerificador) : base(agencia, numero, digitoVerificador)
        {
            //Agencia = agencia;
            //Numero = numero;
            //DigitoVerificador = digitoVerificador;
        }

        public bool EmissaoChequeHabilitada { get; set; }
        public bool DebitoAutomaticoHabilitado { get; set; }
    }
}
