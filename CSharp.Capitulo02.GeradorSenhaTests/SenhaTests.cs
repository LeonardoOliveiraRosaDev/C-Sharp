using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Capitulo02.GeradorSenha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Capitulo02.GeradorSenha.Tests
{
    [TestClass()]
    public class SenhaTests
    {
        [TestMethod()]
        public void GerarTest()
        {
            Senha senha = new Senha();
            senha.Tamanho = 8;
            //var valorSenha = senha.Gerar();

            Console.WriteLine(senha.Gerar());
        }
        [TestMethod]
        public void ConstrutorSemParametroDeveRetornarSenhaMinima()
        {
            Senha senha = new Senha();

            Assert.AreEqual(senha.Valor.Length, Senha.TamanhoMinimo);
            Console.WriteLine(senha.Valor);
        }

        [TestMethod]
       
        public void ConstrutorParametrizadoDeveRetornarSenhaEspecifica()
        {
           var senha = new Senha(8);
            Console.WriteLine(senha.Valor);
        }
    }
}