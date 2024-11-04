using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventWebApp.Models;

namespace EventWebApp.Controllers
{
    public class ParticipacaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Participacaos
        public ActionResult Index()
        {
            var participacoes = db.Participacoes.Include(p => p.Evento).Include(p => p.Usuario);
            return View(participacoes.ToList());
        }

        // GET: Participacaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participacao participacao = db.Participacoes.Find(id);
            if (participacao == null)
            {
                return HttpNotFound();
            }
            return View(participacao);
        }

        // GET: Participacaos/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.EventoId = new SelectList(db.Eventos, "EventoId", "Nome");
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome");
            return View();
        }

        // POST: Participacaos/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "ParticipacaoId,EventoId,UsuarioId,Confirmado")] Participacao participacao)
        {
            if (ModelState.IsValid)
            {
                db.Participacoes.Add(participacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventoId = new SelectList(db.Eventos, "EventoId", "Nome", participacao.EventoId);
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome", participacao.UsuarioId);
            return View(participacao);
        }

        // GET: Participacaos/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participacao participacao = db.Participacoes.Find(id);
            if (participacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventoId = new SelectList(db.Eventos, "EventoId", "Nome", participacao.EventoId);
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome", participacao.UsuarioId);
            return View(participacao);
        }

        // POST: Participacaos/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ParticipacaoId,EventoId,UsuarioId,Confirmado")] Participacao participacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(participacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventoId = new SelectList(db.Eventos, "EventoId", "Nome", participacao.EventoId);
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome", participacao.UsuarioId);
            return View(participacao);
        }

        // GET: Participacaos/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participacao participacao = db.Participacoes.Find(id);
            if (participacao == null)
            {
                return HttpNotFound();
            }
            return View(participacao);
        }

        // POST: Participacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Participacao participacao = db.Participacoes.Find(id);
            db.Participacoes.Remove(participacao);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
