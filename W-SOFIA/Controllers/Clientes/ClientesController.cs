using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace W_SOFIA.Controllers.Clientes
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            List<Models.Clientes> Lista = new List<Models.Clientes>();
            ViewData["Title"] = "Clientes";
            using (var db = new Models.SOFIAContext()) {
              
                Lista = db.Clientes.ToList();
            }
            return View(Lista);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Nuevo()
        {
            using (var bd = new Models.SOFIAContext())
            {

                ViewData["Departamentos"] = bd.Departamentos.ToList();
                ViewData["Municipios"] = bd.Municipios.ToList();
                ViewData["Pais"] = bd.Pais.ToList();
                ViewData["Terminos"] = bd.TerminosPagos.ToList();

            //    //ViewBag.Departamentos = new List<Models.Listas2>().Add(new Models.Listas2 { Codigo = 1, Descripcion = "Nombre" });
            //    //ViewBag.Municipios = bd.Municipios.ToList();
            //    //ViewBag.Pais = bd.Pais.ToList();
            //    //ViewBag.Terminos = bd.TerminosPagos.ToList();

            }
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create(int Id)
        {
            Models.Clientes clientes = new Models.Clientes();
            using (var db = new Models.SOFIAContext())
            {
                ViewData["Departamentos"] = db.Departamentos.ToList();
                ViewData["Municipios"] = db.Municipios.ToList();
                ViewData["Pais"] = db.Pais.ToList();
                ViewData["Terminos"] = db.TerminosPagos.ToList();
                clientes = db.Clientes.Find(Id);
            }
                return View(clientes);
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Clientes Clientes,int codigoCliente)
        {
            try
            {


                if (ModelState.IsValid)
                {
                    using (var db = new Models.SOFIAContext())
                    {
                        if (codigoCliente == 0)
                        {
                            db.Add(Clientes);
                            db.SaveChanges();
                        }
                        else
                        {
                            db.Update<Models.Clientes>(Clientes);
                            db.SaveChanges();

                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                else {
                    using (var db = new Models.SOFIAContext())
                    {
                        ViewData["Departamentos"] = db.Departamentos.ToList();
                        ViewData["Municipios"] = db.Municipios.ToList();
                        ViewData["Pais"] = db.Pais.ToList();
                        ViewData["Terminos"] = db.TerminosPagos.ToList();
                    }
                    return View(Clientes);
                   // return RedirectToActionPreserveMethod(nameof(Create),null ,Clientes);
                }
               
                //Models.Clientes c = new Models.Clientes();
                //var type = c.GetType();
                //PropertyInfo[] properties = type.GetProperties();
                //c.CodigoCliente = int.Parse(collection["CodigoCliente"]);

                //foreach (var key in collection.Keys) {
                //    var value = key.ToString();
                //    foreach (var p in properties) {
                //        if (p.Name == value) {
                //            p.SetValue(c,collection["value"]);
                //        }
                //    }

                //}
                // TODO: Add insert logic here

                
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            using (var db = new Models.SOFIAContext()) {
                var cliente = db.Find<Models.Clientes>(id);
                db.Remove<Models.Clientes>(cliente);
                db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}