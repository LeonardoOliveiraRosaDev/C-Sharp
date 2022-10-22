using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class ContaCorrente : Conta
    {
        public bool EmissaoChequeHabilitada { get; set; }
        public bool DebitoAutomaticoHabilitado { get; set; }
    }
}
