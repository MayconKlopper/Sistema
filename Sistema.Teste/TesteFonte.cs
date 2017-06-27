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
    public class TesteFonte
    {
        private readonly IServicoFonte servico;

        public TesteFonte()
        {
            this.servico = new ServicoFonte(new RepositorioFonte());
        }

        [TestMethod]
        public void Inserir()
        {
            try
            {
                Fonte fonte = new Fonte();
                fonte.Marca = "Corsair";
                fonte.Modelo = "CX430 V2";

                servico.Inserir(fonte);
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
                Fonte fonte = servico.RetornarPorID(1);
                fonte.Marca = "Corsair";
                fonte.Modelo = "CX430 V2";

                servico.Atualizar(fonte);
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
                Fonte fonte = servico.RetornarPorID(1);

                servico.Deletar(fonte);
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
                List<Fonte> fontes = new List<Fonte>();

                fontes = servico.RetornarTodos();

                foreach (Fonte fonte in fontes)
                {
                    Assert.IsNotNull(fonte.IDFonte, "O campo IDFonte está vazio");
                    Assert.IsNotNull(fonte.Marca, "O campo Marca está vazio");
                    Assert.IsNotNull(fonte.Modelo, "O campo Modelo está vazio");
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
                Fonte fonte = new Fonte();

                fonte = servico.RetornarPorID(1);

                Assert.IsNotNull(fonte.IDFonte, "O campo IDFonte está vazio");
                Assert.IsNotNull(fonte.Marca, "O campo Marca está vazio");
                Assert.IsNotNull(fonte.Modelo, "O campo Modelo está vazio");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
