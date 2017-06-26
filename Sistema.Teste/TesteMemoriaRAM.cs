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
    public class TesteMemoriaRAM
    {
        private readonly IServicoMemoriaRAM servico;

        public TesteMemoriaRAM()
        {
            this.servico = new ServicoMemoriaRAM(new RepositorioMemoriaRAM());
        }

        [TestMethod]
        public void Inserir()
        {
            try
            {
                MemoriaRAM memoriaRAM = new MemoriaRAM();
                memoriaRAM.Quantidade = 2;
                memoriaRAM.Capacidade = "4GB";

                servico.Inserir(memoriaRAM);
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
                List<MemoriaRAM> memoriaRAMs = new List<MemoriaRAM>();

                memoriaRAMs = servico.RetornarTodos();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
