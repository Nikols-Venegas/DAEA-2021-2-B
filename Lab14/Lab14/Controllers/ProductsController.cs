using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Lab14.Models;
using System.Net;

namespace Lab14.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        private NORTHWNDEntities _contexto;
        public NORTHWNDEntities contexto
        {
            set
            {
                _contexto = value;
            }
            get
            {
                if (_contexto == null)
                    _contexto = new NORTHWNDEntities();
                return _contexto;
            }
        }
        public ActionResult Index()
        {
            return View(contexto.Products.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products nuevoProducto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Products.Add(nuevoProducto);
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoProducto);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //Buscar por categoria a editar
            Products ProductoEditar = contexto.Products.Find(id);

            //Si la entidad es NULO (categoria no existe)
            if (ProductoEditar == null)
                return HttpNotFound();

            return View(ProductoEditar);
        }

        [HttpPost]
        public ActionResult Edit(Products ProductoEditar)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Entry(ProductoEditar).State = EntityState.Modified;
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ProductoEditar);
            }
            catch (Exception e)
            {
                throw e;
                return View();
            }
        }

        //GET
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //Buscar por categoria a editar
            Products ProductoEliminar = contexto.Products.Find(id);

            //Si la entidad es NULO (categoria no existe)
            if (ProductoEliminar == null)
                return HttpNotFound();

            return View(ProductoEliminar);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Products Producto1)
        {
            try
            {
                Products ProductoEliminar = new Products();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    //busca categoria a eliminar
                    ProductoEliminar = contexto.Products.Find(id);

                    //Si no encuentra la categoria
                    if (ProductoEliminar == null)
                        return HttpNotFound();

                    //Elimina la categoria
                    contexto.Products.Remove(ProductoEliminar);
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ProductoEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}
