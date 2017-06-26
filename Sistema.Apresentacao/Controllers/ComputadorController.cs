using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistema.Aplicacao.Contratos;
using Sistema.Apresentacao.Models;

namespace Sistema.Apresentacao.Controllers
{
    public class ComputadorController : Controller
    {
        private readonly IAplicacaoServicoComputador servicoComputador;

        public ComputadorController(IAplicacaoServicoComputador servicoComputador)
        {
            this.servicoComputador = servicoComputador;
        }

        // GET: Computador
        public ActionResult Index()
        {
            return View();
        }

        // GET: Computador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Computador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Computador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Computador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Computador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Computador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Computador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
    }
}
