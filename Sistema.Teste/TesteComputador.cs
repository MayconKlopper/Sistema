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
                computador.DataCriacao = DateTime.Now;
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
        public void InserirTodos()
        {
            try
            {
                Computador computador = new Computador();
                computador.DataCriacao = DateTime.Now;
                computador.IDUsuario = "35b889eb-513a-431f-a212-3b02acb8d3a6";

                Fonte fonte = new Fonte();
                fonte.Marca = "Corsair";
                fonte.Modelo = "AX1200i";

                HD hd = new HD();
                hd.Quantidade = 1;
                hd.Capacidade = "2TB";

                MemoriaRAM memoriaRAM = new MemoriaRAM();
                memoriaRAM.Quantidade = 2;
                memoriaRAM.Capacidade = "16GB";

                PlacaMae placaMae = new PlacaMae();
                placaMae.Marca = "GIGABYTE";
                placaMae.Modelo = "mATX GA-B250M-D3H";

                Processador processador = new Processador();
                processador.Marca = "AMD";
                processador.Modelo = "FX-8170";
                processador.Velocidade = "3.9GHz";

                computador.Fonte = fonte;
                computador.HD = hd;
                computador.MemoriaRAM = memoriaRAM;
                computador.PlacaMae = placaMae;
                computador.Processador = processador;

                servico.Inserir(computador);
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
                Computador computador = servico.RetornarPorID(5);

                servico.Deletar(computador);
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

                if (computadores.Count == 0)
                {
                    Assert.Fail("método não retornou nenhum objeto");
                }

                foreach (Computador computador in computadores)
                {
                    Assert.IsNotNull(computador.IDComputador, "O campo IDComputador está vazio");
                    Assert.IsNotNull(computador.IDFonte, "O campo IDFonte está vazio");
                    Assert.IsNotNull(computador.IDHD, "O campo IDHD está vazio");
                    Assert.IsNotNull(computador.IDMemoriaRAM, "O campo IDMemoriaRAM está vazio");
                    Assert.IsNotNull(computador.IDPlacaMae, "O campo IDPlacaMae está vazio");
                    Assert.IsNotNull(computador.IDProcessador, "O campo IDProcessador está vazio");
                    Assert.IsNotNull(computador.IDUsuario, "O campo IDUsuario está vazio");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void RetornarPorIDUsuario()
        {
            try
            {
                List<Computador> computadores = new List<Computador>();

                computadores = servico.RetornarPorIDUsuario("35b889eb-513a-431f-a212-3b02acb8d3a6");

                if (computadores.Count == 0)
                {
                    Assert.Fail("método não retornou nenhum objeto");
                }

                foreach (Computador computador in computadores)
                {
                    Assert.IsNotNull(computador.IDComputador, "O campo IDComputador está vazio");
                    Assert.IsNotNull(computador.IDFonte, "O campo IDFonte está vazio");
                    Assert.IsNotNull(computador.IDHD, "O campo IDHD está vazio");
                    Assert.IsNotNull(computador.IDMemoriaRAM, "O campo IDMemoriaRAM está vazio");
                    Assert.IsNotNull(computador.IDPlacaMae, "O campo IDPlacaMae está vazio");
                    Assert.IsNotNull(computador.IDProcessador, "O campo IDProcessador está vazio");
                    Assert.IsNotNull(computador.IDUsuario, "O campo IDUsuario está vazio");
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
                Computador computador = new Computador();

                computador = servico.RetornarPorID(4);

                Assert.IsNotNull(computador.IDComputador, "O campo IDComputador está vazio");
                Assert.IsNotNull(computador.IDFonte, "O campo IDFonte está vazio");
                Assert.IsNotNull(computador.IDHD, "O campo IDHD está vazio");
                Assert.IsNotNull(computador.IDMemoriaRAM, "O campo IDMemoriaRAM está vazio");
                Assert.IsNotNull(computador.IDPlacaMae, "O campo IDPlacaMae está vazio");
                Assert.IsNotNull(computador.IDProcessador, "O campo IDProcessador está vazio");
                Assert.IsNotNull(computador.IDUsuario, "O campo IDUsuario está vazio");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
