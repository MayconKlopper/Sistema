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
        public void Atualizar()
        {
            try
            {
                Processador processador = servico.RetornarPorID(1);
                processador.Marca = "Radeon";
                processador.Modelo = "AMD A10";
                processador.Velocidade = "3.6GHz";

                servico.Atualizar(processador);
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
                Processador processador = servico.RetornarPorID(1);

                servico.Deletar(processador);
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

                foreach (Processador processador in processadores)
                {
                    Assert.IsNotNull(processador.IDProcessador, "O campo IDProcessador está vazio");
                    Assert.IsNotNull(processador.Marca, "O campo Marca está vazio");
                    Assert.IsNotNull(processador.Modelo, "O campo Modelo está vazio");
                    Assert.IsNotNull(processador.Velocidade, "O campo Velocidade está vazio");
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
                Processador processador = servico.RetornarPorID(1);

                Assert.IsNotNull(processador.IDProcessador, "O campo IDProcessador está vazio");
                Assert.IsNotNull(processador.Marca, "O campo Marca está vazio");
                Assert.IsNotNull(processador.Modelo, "O campo Modelo está vazio");
                Assert.IsNotNull(processador.Velocidade, "O campo Velocidade está vazio");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
