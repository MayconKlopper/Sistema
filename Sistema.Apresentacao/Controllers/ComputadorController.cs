using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;
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
        //public ActionResult Index()
        //{
        //    List<Computador> computadores = servicoComputador.RetornarPorIDUsuario(User.Identity.GetUserId());
        //    List<ComputadorViewModelLista> computadoresViewModelListar = new List<ComputadorViewModelLista>();

        //    foreach (Computador computador in computadores)
        //    {
        //        ComputadorViewModelLista computadorViewModelListar = Mapper.Map<ComputadorViewModelLista>(computador);

        //        computadoresViewModelListar.Add(computadorViewModelListar);
        //    }

        //    return View(computadoresViewModelListar);
        //}

        public ViewResult Index(string ordem, string busca)
        {
            List<Computador> computadores = servicoComputador.RetornarPorIDUsuario(User.Identity.GetUserId());
            List<ComputadorViewModelLista> computadoresViewModelListar = new List<ComputadorViewModelLista>();

            foreach (Computador computador in computadores)
            {
                ComputadorViewModelLista computadorViewModelListar = Mapper.Map<ComputadorViewModelLista>(computador);

                computadoresViewModelListar.Add(computadorViewModelListar);
            }

            if (! String.IsNullOrEmpty(busca))
            {
                computadoresViewModelListar = computadoresViewModelListar.Where(c => c.DataCriacao.Equals(busca)).ToList();
            }

            ViewBag.DataCricao = "DataCriacao";
            ViewBag.IDComputador = "IDComputador";

            switch (ordem)
            {
                case "DataCriacao":
                    computadoresViewModelListar = computadoresViewModelListar.OrderBy(c => c.DataCriacao).ToList();
                    break;

                case "IDComputador":
                    computadoresViewModelListar = computadoresViewModelListar.OrderByDescending(c => c.IDComputador).ToList();
                    break;

                default:
                    break;

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
                Computador computador = new Computador();
                computador.IDUsuario = User.Identity.GetUserId();
                //computador.DataCriacao = DateTime.Now;

                computador.Fonte = Mapper.Map<Fonte>(computadorViewModelCria);
                computador.HD = Mapper.Map<HD>(computadorViewModelCria);
                computador.MemoriaRAM = Mapper.Map<MemoriaRAM>(computadorViewModelCria);
                computador.PlacaMae = Mapper.Map<PlacaMae>(computadorViewModelCria);
                computador.Processador = Mapper.Map<Processador>(computadorViewModelCria);

                servicoComputador.Inserir(computador);

                TempData["MensagemSucesso"] = "Computador cadastrado com sucesso!";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou entre em contato com nosso suporte. Detalhe do erro: " + ex.Message;

                return View();
            }
        }

        // GET: Computador/DeletarComputador/5
        public ActionResult DeletarComputador(int id)
        {
            Computador computador = servicoComputador.RetornarPorID(id);

            ComputadorViewModelExclui computadorViewModeExclui = Mapper.Map<ComputadorViewModelExclui>(computador);

            return View(computadorViewModeExclui);
        }

        // POST: Computador/DeletarComputador/5
        [HttpPost]
        public ActionResult DeletarComputador(ComputadorViewModelExclui computadorViewModelExclui)
        {
            try
            {
                Computador computador = Mapper.Map<Computador>(computadorViewModelExclui);

                Fonte fonte = Mapper.Map<Fonte>(computadorViewModelExclui);
                HD hd = Mapper.Map<HD>(computadorViewModelExclui);
                MemoriaRAM memoriaRAM = Mapper.Map<MemoriaRAM>(computadorViewModelExclui);
                PlacaMae placaMae = Mapper.Map<PlacaMae>(computadorViewModelExclui);
                Processador processador = Mapper.Map<Processador>(computadorViewModelExclui);

                servicoComputador.Deletar(computador);
                servicoFonte.Deletar(fonte);
                servicoHD.Deletar(hd);
                servicoMemoriaRAM.Deletar(memoriaRAM);
                servicoPlacaMae.Deletar(placaMae);
                servicoProcessador.Deletar(processador);

                TempData["MensagemSucesso"] = "Computador deletado com sucesso!";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou entre em contato com nosso suporte. Detalhe do erro: " + ex.Message;

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
            fonteViewModelLista.IDComputador = fonte.Computadores[0].IDComputador;

            return View(fonteViewModelLista);
        }

        // GET: Computador/EditarFonte/5
        public ActionResult EditarFonte(int id)
        {
            Fonte fonte = servicoFonte.RetornarPorID(id);

            FonteViewModelEdita fonteViewModelEdita = Mapper.Map<FonteViewModelEdita>(fonte);
            fonteViewModelEdita.IDComputador = fonte.Computadores[0].IDComputador;

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

                TempData["MensagemSucesso"] = "Fonte editada com sucesso!";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou entre em contato com nosso suporte. Detalhe do erro: " + ex.Message;


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
            hdViewModelLista.IDComputador = hd.Computadores[0].IDComputador;

            return View(hdViewModelLista);
        }

        // GET: Computador/EditarrHD/5
        public ActionResult EditarHD(int id)
        {
            HD hd = servicoHD.RetornarPorID(id);

            HDViewModelEdita hdViewModelEdita = Mapper.Map<HDViewModelEdita>(hd);
            hdViewModelEdita.IDComputador = hd.Computadores[0].IDComputador;

            return View(hdViewModelEdita);
        }

        // POST: Computador/EditarrHD/5
        [HttpPost]
        public ActionResult EditarHD(HDViewModelEdita hdViewModelEdita)
        {
            try
            {
                HD hd = Mapper.Map<HD>(hdViewModelEdita);

                servicoHD.Atualizar(hd);

                TempData["MensagemSucesso"] = "HD editado com sucesso!";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou entre em contato com nosso suporte. Detalhe do erro: " + ex.Message;

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
            memoriaRAMViewModelLista.IDComputador = memoriaRAM.Computadores[0].IDComputador;

            return View(memoriaRAMViewModelLista);
        }

        // GET: Computador/EditarMemoriaRAM/5
        public ActionResult EditarMemoriaRAM(int id)
        {
            MemoriaRAM memoriaRAM = servicoMemoriaRAM.RetornarPorID(id);

            MemoriaRAMViewModelEdita memoriaRAMViewModelEdita = Mapper.Map<MemoriaRAMViewModelEdita>(memoriaRAM);
            memoriaRAMViewModelEdita.IDComputador = memoriaRAM.Computadores[0].IDComputador;

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

                TempData["MensagemSucesso"] = "Memória RAM editada com sucesso!";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou entre em contato com nosso suporte. Detalhe do erro: " + ex.Message;

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
            placaMaeViewModelLista.IDComputador = placaMae.Computadores[0].IDComputador;

            return View(placaMaeViewModelLista);
        }

        // GET: Computador/EditarPlacaMae/5
        public ActionResult EditarPlacaMae(int id)
        {
            PlacaMae placaMae = servicoPlacaMae.RetornarPorID(id);

            PlacaMaeViewModelEdita placaMaeViewModelEdita = Mapper.Map<PlacaMaeViewModelEdita>(placaMae);
            placaMaeViewModelEdita.IDComputador = placaMae.Computadores[0].IDComputador;

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

                TempData["MensagemSucesso"] = "Placa mãe editada com sucesso!";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou entre em contato com nosso suporte. Detalhe do erro: " + ex.Message;

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
            processadorViewModelLista.IDComputador = processador.Computadores[0].IDComputador;

            return View(processadorViewModelLista);
        }

        // GET: Computador/EditarProcessador/5
        public ActionResult EditarProcessador(int id)
        {
            Processador processador = servicoProcessador.RetornarPorID(id);

            ProcessadorViewModelEdita processadorViewModelEdita = Mapper.Map<ProcessadorViewModelEdita>(processador);
            processadorViewModelEdita.IDComputador = processador.Computadores[0].IDComputador;

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

                TempData["MensagemSucesso"] = "Processador editado com sucesso!";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou entre em contato com nosso suporte. Detalhe do erro: " + ex.Message;

                return View();
            }
        }

        #endregion
    }
}
