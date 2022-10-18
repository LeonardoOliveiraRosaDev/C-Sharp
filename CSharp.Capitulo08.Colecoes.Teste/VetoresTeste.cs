using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp.Capitulo08.Colecoes.Teste
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            //var inteiro = 89;
           int[] inteiros = new int[5];
            inteiros[0] = 14;
            inteiros[1] = 1;
            inteiros[2] = 7;
            inteiros[3] = 0;
            inteiros[4] = -14;

            // decimal meuDecimal =8;
            var decimais = new decimal[] { 0.4m, 0.9m, 4m, 7.8m };

            string[] nomes = { "Vitor", "Avelino" };

            var chars = new[] { 'a', 'b', 'c' };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} é {decimais.Length}.");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal [] { 0.4m, 0.9m, 4m, 7.8m };
            Array.Resize(ref decimais, 6);
            decimais[5] = -4.5m;
        }

        [TestMethod]
        public void OrdenacaoTeste() // usa o quicksort, não duplica o vetor;
        {
            var decimais = new decimal[] { 0.4m, 0.9m, -4m, 7.8m };

            Array.Sort(decimais);
            Assert.AreEqual(decimais[0], -4m);
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Leonardo";
            nome += " Oliveira Rosa";

            //String Builder
            Assert.AreEqual(nome[0], 'L');

            foreach (var @char in nome)
            {
                // write escreve tudo em uma unica linha , ja o WriteLine , escreve quebrando a linha !
                Console.Write(@char);
            }
        }
    }
}
