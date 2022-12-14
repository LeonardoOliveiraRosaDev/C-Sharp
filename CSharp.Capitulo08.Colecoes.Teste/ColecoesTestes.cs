using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Capitulo08.Colecoes.Teste
{
    [TestClass]
    public class ColecoesTestes
    {
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void ListTeste()
        {
            
            var inteiros = new List<int>(/*1000*/) { 1, 8, 33, 16 };

            inteiros.Add(47);
            inteiros.Add(1);
            inteiros.Add(-8);
            inteiros.Add(0);

            inteiros[0] = 7;
            //inteiros[20] = 14;

            var maisInteiros = new List<int> { 16, 38, -7 };
            inteiros.AddRange(maisInteiros);
            inteiros.Insert(2, -86);
            inteiros.Remove(16);
            inteiros.RemoveAt(5);
            inteiros.Sort();
            inteiros.Reverse();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();
            var ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");
            }
        }
        [TestMethod]
        public void DictionaryTeste() // hash table tras a habilitadade para trazer o tipo do indice
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2022, 11, 15), "Proclamação");
            feriados.Add(new DateTime(2022, 12, 25), "Natal");
            feriados.Add(new DateTime(2023, 1, 1), "Ano Novo");

            var proclamacao = feriados[new DateTime(2022, 11, 15)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado:d}: {feriado.Value}");
            }
            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("11/11/2022")));
            Console.WriteLine(feriados.ContainsValue("Natal"));
        }
    }
}
