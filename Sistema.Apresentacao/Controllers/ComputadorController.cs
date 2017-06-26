using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistema.Aplicacao.Contratos;
using Sistema.Apresentacao.Models;
using Sistema.Dominio.Entidades;
using AutoMapper;

namespace Sistema.Apresentacao.Controllers
{
    [Authorize]
    public class ComputadorController : Controller
    {
        private readonly IAplicacaoServicoComputador servicoComputador;
        private readonly IAplicacaoServicoFonte servicoFonte;
        private readonly IAplicacaoServicoHD servicoHD;
        private readonly IAplicacaoServicoMemoriaRAM servicoMemoriaRAM;
        private readonly IAplicacaoServicoPlacaMae servicoPlacaMae;
        private readonly IAplicacaoServicoProcessador servicoProcessador;

        public ComputadorController(
            IAplicacaoServicoComputador servicoComputador,
            IAplicacaoServicoFonte servicoFonte,
            IAplicacaoServicoHD servicoHD,
            IAplicacaoServicoMemoriaRAM servicoMemoriaRAM,
            IAplicacaoServicoPlacaMae servicoPlacaMae,
            IAplicacaoServicoProcessador servicoProcessador
            )
        {
            this.servicoComputador = servicoComputador;
            this.servicoFonte = servicoFonte;
            this.servicoHD = servicoHD;
            this.servicoMemoriaRAM = servicoMemoriaRAM;
            this.servicoPlacaMae = servicoPlacaMae;
            this.servicoProcessador = servicoProcessador;
        }

        #region Computador

        // GET: Computador
        public ActionResult Index()
        {
            List<Computador> computadores = servicoComputador.RetornaTodos();
            List<ComputadorViewModelLista> computadoresViewModelListar = new List<ComputadorViewModelLista>();

            foreach (Computador computador in computadores)
            {
                ComputadorViewModelLista computadorViewModelListar = Mapper.Map<ComputadorViewModelLista>(computador);

                computadoresViewModelListar.Add(computadorViewModelListar);
            }

            return View(computadoresViewModelListar);
        }

        // GET: Computador/CriarComputador
        public ActionResult CriarComputador()
        {
            return View();
        }

        // POST: Computador/CriarComputador
        [HttpPost]
        public ActionResult CriarComputador(ComputadorViewModelCria computadorViewModelCria)
        {
            try
            {
                Computador computador = Mapper.Map<Computador>(computadorViewModelCria);
                computador.Fonte = Mapper.Map<Fonte>(computadorViewModelCria);
                computador.MemoriaRAM = Mapper.Map<MemoriaRAM>(computadorViewModelCria);
                computador.PlacaMae = Mapper.Map<PlacaMae>(computadorViewModelCria);
                computador.Processador = Mapper.Map<Processador>(computadorViewModelCria);

                servicoComputador.Inserir(computador);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Computador/DeletarComputador/5
        public ActionResult DeletarComputador(int id)
        {
            return View();
        }

        // POST: Computador/DeletarComputador/5
        [HttpPost]
        public ActionResult DeletarComputador(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Fonte

        // GET: Computador/ListarFonte/5
        public ActionResult ListarFonte(int id)
        {
            Fonte fonte = servicoFonte.RetornarPorID(id);

            FonteViewModelLista fonteViewModelLista = Mapper.Map<FonteViewModelLista>(fonte);

            return View(fonteViewModelLista);
        }

        // GET: Computador/EditarFonte/5
        public ActionResult EditarFonte(int id)
        {
            Fonte fonte = servicoFonte.RetornarPorID(id);

            FonteViewModelEdita fonteViewModelEdita = Mapper.Map<FonteViewModelEdita>(fonte);

            return View(fonteViewModelEdita);
        }

        // POST: Computador/EditarFonte/5
        [HttpPost]
        public ActionResult EditarFonte(FonteViewModelEdita fonteViewModelEdita)
        {
            try
            {
                Fonte fonte = Mapper.Map<Fonte>(fonteViewModelEdita);

                servicoFonte.Atualizar(fonte);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region HD

        // GET: Computador/ListarHD/5
        public ActionResult ListarHD(int id)
        {
            HD hd = servicoHD.RetornarPorID(id);
            HDViewModelLista hdViewModelLista = Mapper.Map<HDViewModelLista>(hd);

            return View(hdViewModelLista);
        }

        // GET: Computador/EditarrHD/5
        public ActionResult EditarHD(int id)
        {
            HD hd = servicoHD.RetornarPorID(id);
            HDViewModelEdita hdViewModelLista = Mapper.Map<HDViewModelEdita>(hd);

            return View(hdViewModelLista);
        }

        // POST: Computador/EditarrHD/5
        [HttpPost]
        public ActionResult EditarHD(HDViewModelEdita hdViewModelEdita)
        {
            try
            {
                HD hd = Mapper.Map<HD>(hdViewModelEdita);

                servicoHD.Atualizar(hd);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region MemóriaRAM

        // GET: Computador/ListarMemoriaRAM/5
        public ActionResult ListarMemoriaRAM(int id)
        {
            MemoriaRAM memoriaRAM = servicoMemoriaRAM.RetornarPorID(id);

            MemoriaRAMViewModelLista memoriaRAMViewModelLista = Mapper.Map<MemoriaRAMViewModelLista>(memoriaRAM);

            return View(memoriaRAMViewModelLista);
        }

        // GET: Computador/EditarMemoriaRAM/5
        public ActionResult EditarMemoriaRAM(int id)
        {
            MemoriaRAM memoriaRAM = servicoMemoriaRAM.RetornarPorID(id);

            MemoriaRAMViewModelEdita memoriaRAMViewModelEdita = Mapper.Map<MemoriaRAMViewModelEdita>(memoriaRAM);

            return View(memoriaRAMViewModelEdita);
        }

        // POST: Computador/EditarMemoriaRAM/5
        [HttpPost]
        public ActionResult EditarMemoriaRAM(MemoriaRAMViewModelEdita memoriaRAMViewModelEdita)
        {
            try
            {
                MemoriaRAM memoriaRAM = Mapper.Map<MemoriaRAM>(memoriaRAMViewModelEdita);

                servicoMemoriaRAM.Atualizar(memoriaRAM);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region PlacaMae

        // GET: Computador/ListarPlacaMae/5
        public ActionResult ListarPlacaMae(int id)
        {
            PlacaMae placaMae = servicoPlacaMae.RetornarPorID(id);

            PlacaMaeViewModelLista placaMaeViewModelLista = Mapper.Map<PlacaMaeViewModelLista>(placaMae);

            return View(placaMaeViewModelLista);
        }

        // GET: Computador/EditarPlacaMae/5
        public ActionResult EditarPlacaMae(int id)
        {
            PlacaMae placaMae = servicoPlacaMae.RetornarPorID(id);

            PlacaMaeViewModelEdita placaMaeViewModelEdita = Mapper.Map<PlacaMaeViewModelEdita>(placaMae);

            return View(placaMaeViewModelEdita);
        }

        // POST: Computador/EditarPlacaMae/5
        [HttpPost]
        public ActionResult EditarPlacaMae(PlacaMaeViewModelEdita placaMaeViewModelEdita)
        {
            try
            {
                PlacaMae placaMae = Mapper.Map<PlacaMae>(placaMaeViewModelEdita);

                servicoPlacaMae.Atualizar(placaMae);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Processador

        // GET: Computador/ListarProcessador/5
        public ActionResult ListarProcessador(int id)
        {
            Processador processador = servicoProcessador.RetornarPorID(id);

            ProcessadorViewModelLista processadorViewModelLista = Mapper.Map<ProcessadorViewModelLista>(processador);

            return View(processadorViewModelLista);
        }

        // GET: Computador/EditarProcessador/5
        public ActionResult EditarProcessador(int id)
        {
            Processador processador = servicoProcessador.RetornarPorID(id);

            ProcessadorViewModelEdita processadorViewModelEdita = Mapper.Map<ProcessadorViewModelEdita>(processador);

            return View(processadorViewModelEdita);
        }

        // POST: Computador/EditarProcessador/5
        [HttpPost]
        public ActionResult EditarProcessador(ProcessadorViewModelEdita processadorViewModelEdita)
        {
            try
            {
                Processador processador = Mapper.Map<Processador>(processadorViewModelEdita);

                servicoProcessador.Atualizar(processador);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion
    }
}
