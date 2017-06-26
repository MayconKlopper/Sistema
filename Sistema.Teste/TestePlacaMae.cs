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
    public class TestePlacaMae
    {
        private readonly IServicoPlacaMae servico;

        public TestePlacaMae()
        {
            this.servico = new ServicoPlacaMae(new RepositorioPlacaMae());
        }

        [TestMethod]
        public void Inserir()
        {
            try
            {
                PlacaMae placaMae = new PlacaMae();
                placaMae.Marca = "GIgabyte";
                placaMae.Modelo = "GA-H61M-S1";

                servico.Inserir(placaMae);
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
                List<PlacaMae> placaMaes = new List<PlacaMae>();

                placaMaes = servico.RetornarTodos();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
