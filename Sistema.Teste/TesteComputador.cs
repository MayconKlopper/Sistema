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
    public class TesteComputador
    {
        private readonly IServicoComputador servico;

        public TesteComputador()
        {
            this.servico = new ServicoComputador(new RepositorioComputador());
        }

        [TestMethod]
        public void Inserir()
        {
            try
            {
                Computador computador = new Computador();
                computador.IDFonte = 1;
                computador.IDHD = 1;
                computador.IDMemoriaRAM = 1;
                computador.IDPlacaMae = 1;
                computador.IDProcessador = 1;
                computador.IDUsuario = "35b889eb-513a-431f-a212-3b02acb8d3a6";

                servico.Inserir(computador);
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
                List<Computador> computadores = new List<Computador>();

                computadores = servico.RetornarTodos();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
