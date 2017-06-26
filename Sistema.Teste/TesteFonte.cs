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
        public void RetornarTodos()
        {
            try
            {
                List<Fonte> fontes = new List<Fonte>();

                fontes = servico.RetornarTodos();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
