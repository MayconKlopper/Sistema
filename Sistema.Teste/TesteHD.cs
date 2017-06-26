using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

using Sistema.Dominio.Entidades;
using Sistema.Dominio.Contratos.Servicos;
using Sistema.Dominio.Servicos;
using Sistema.InfraEstrutura.Repositorios;

namespace Sistema.Teste
{
    [TestClass]
    public class TesteHD
    {
        private readonly IServicoHD servico;

        public TesteHD()
        {
            this.servico = new ServicoHD(new RepositorioHD());
        }

        [TestMethod]
        public void Inserir()
        {
            try
            {
                HD hd = new HD();
                hd.Quantidade = 5;
                hd.Capacidade = "1TB";

                servico.Inserir(hd);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void RetornarTodos()
        {
            try
            {
                List<HD> hds = new List<HD>();

                hds = servico.RetornarTodos();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
