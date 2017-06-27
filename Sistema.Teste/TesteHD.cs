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
        public void Atualizar()
        {
            try
            {
                HD hd = servico.RetornarPorID(1);
                hd.Quantidade = 5;
                hd.Capacidade = "1TB";

                servico.Atualizar(hd);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Deletar()
        {
            try
            {
                HD hd = servico.RetornarPorID(1);

                servico.Deletar(hd);
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

                foreach (HD hd in hds)
                {
                    Assert.IsNotNull(hd.IDHD, "O campo IDHD está vazio");
                    Assert.IsNotNull(hd.Quantidade, "O campo Quantidade está vazio");
                    Assert.IsNotNull(hd.Capacidade, "O campo Capacidade está vazio");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void RetornarPorID()
        {
            try
            {
                HD hd = new HD();

                hd = servico.RetornarPorID(1);

                Assert.IsNotNull(hd.IDHD, "O campo IDHD está vazio");
                Assert.IsNotNull(hd.Quantidade, "O campo Quantidade está vazio");
                Assert.IsNotNull(hd.Capacidade, "O campo Capacidade está vazio");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
