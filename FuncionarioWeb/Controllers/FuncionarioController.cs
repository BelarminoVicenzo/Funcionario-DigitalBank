using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Funcionario.DataAccess;
using Funcionario.Models;

namespace FuncionarioWeb.Controllers
{
    public class FuncionarioController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Funcionario
        public async Task<ActionResult> Index()
        {
            return View(await db.Funcionario.ToListAsync());
        }



        // GET: Funcionario/Create
        public ActionResult Create()
        {
            
            var estado = AdicionarSelecione();
            ViewBag.FK_Estado = new SelectList(estado, "PK_Estado", "Nome", "Selecione");
            return View(new Funcionario.Models.Funcionario { Salario = 0.0m });
        }

        private IEnumerable<Estado> AdicionarSelecione()
        {
            var estados = new List<Estado>() { new Estado { Nome = "Selecione" } };
            return estados.Concat(db.Estado);
        }

        // POST: Funcionario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PK_Funcionario,Nome,Email,DataNascimento,Salario,FK_Estado")] Funcionario.Models.Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Funcionario.Add(funcionario);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return View(funcionario);
        }

        // GET: Funcionario/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {

            

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario.Models.Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            var nomeEstado = db.Estado.First(n=>n.PK_Estado==funcionario.FK_Estado);
            ViewBag.FK_Estado = new SelectList(db.Estado, "PK_Estado","Nome", nomeEstado.Nome);
            return View(funcionario);
        }

        // POST: Funcionario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PK_Funcionario,Nome,Email,DataNascimento,Salario,FK_Estado")] Funcionario.Models.Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionario).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        // GET: Funcionario/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario.Models.Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");

        }

        // POST: Funcionario/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Funcionario.Models.Funcionario funcionario = await db.Funcionario.FindAsync(id);
            db.Funcionario.Remove(funcionario);
            await db.SaveChangesAsync();
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
