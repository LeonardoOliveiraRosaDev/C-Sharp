using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Capitulo02.EstruturasControle.Testes
{
    [TestClass]
    public class DecisaoTeste
    {
        [TestMethod]
        public void AvaliacaoFinalReprovadoTeste()
        {
            var notaFinal = 2.2d;
            string resultadoFinal = string.Empty;

            if (notaFinal < 3)
            {
                resultadoFinal = "Reprovado";
            }
             else if (notaFinal is > 3 and < 5)
            {
                resultadoFinal = "Recuperação";
            }
            //if (notaFinal > 5)
            else
            {
                resultadoFinal = "Aprovado";
            }

            Assert.AreEqual(resultadoFinal, "Reprovado");
        }
        [TestMethod]
        public void AvaliacaoFinalRecuperacao3Teste()
        {
            var notaFinal = 3.1;
            var resultadoFinal = string.Empty;
            switch (notaFinal)
            {
                case    
                default:
                    break;
            }
        }
    }
}
