using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fintech.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fintech.Dominio.Entidades;

namespace Fintech.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
        
        [TestMethod()]
        public void InserirTest()
        {
            MovimentoRepositorio movimentoRepositorio = new MovimentoRepositorio("Dados\\Movimento.txt");

            Agencia agencia = new Agencia { Numero = 123};

            Conta conta = new ContaCorrente(agencia, 456, "x");

            Movimento movimento = new Movimento(54, TipoOperacao.Deposito, conta);

            movimentoRepositorio.Inserir(movimento);
        }
    }
}