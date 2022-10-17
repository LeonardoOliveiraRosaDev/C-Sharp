using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Capitulo08.Colecoes.Teste
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            //var inteiro = 89;
            var inteiros = new int[5];
            inteiros[0] = 14;
            inteiros[1] = 1;
            inteiros[2] = 7;
            inteiros[3] = 0;
            inteiros[4] = -14;
        }
    }
}
