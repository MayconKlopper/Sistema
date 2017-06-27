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
        public void Atualizar()
        {
            try
            {
                PlacaMae placaMae = servico.RetornarPorID(1);
                placaMae.Marca = "GIgabyte";
                placaMae.Modelo = "GA-H61M-S1";

                servico.Atualizar(placaMae);
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
                PlacaMae placaMae = servico.RetornarPorID(1);

                servico.Deletar(placaMae);
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

                foreach (PlacaMae placaMae in placaMaes)
                {
                    Assert.IsNotNull(placaMae.IDPlacaMae, "O campo IDPlacaMae está vazio");
                    Assert.IsNotNull(placaMae.Marca, "O campo Marca está vazio");
                    Assert.IsNotNull(placaMae.Modelo, "O campo Modelo está vazio");
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
                PlacaMae placaMae = servico.RetornarPorID(1);

                Assert.IsNotNull(placaMae.IDPlacaMae, "O campo IDPlacaMae está vazio");
                Assert.IsNotNull(placaMae.Marca, "O campo Marca está vazio");
                Assert.IsNotNull(placaMae.Modelo, "O campo Modelo está vazio");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
