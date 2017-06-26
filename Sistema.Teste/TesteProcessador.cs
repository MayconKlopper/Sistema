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
    public class TesteProcessador
    {
        private readonly IServicoProcessador servico;

        public TesteProcessador()
        {
            this.servico = new ServicoProcessador(new RepositorioProcessador());
        }

        [TestMethod]
        public void Inserir()
        {
            try
            {
                Processador processador = new Processador();
                processador.Marca = "Radeon";
                processador.Modelo = "AMD A10";
                processador.Velocidade = "3.6GHz";

                servico.Inserir(processador);
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
                List<Processador> processadores = new List<Processador>();

                processadores = servico.RetornarTodos();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
