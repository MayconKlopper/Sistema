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
        public void InserirTodos()
        {
            try
            {
                Computador computador = new Computador();
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
