using eCommerce.Business;
using eCommerce.Entities;
using eCommerce.UI.MVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Data;

namespace eCommerce.UI.MVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: producto
        [LoggingFilter]
        public ActionResult Index()
        {


            var productLN = new ProductoBL(new ProductoDA());
            var productos = productLN.SelectAll();


            ViewBag.Title = String.Format("Listado de productos({0})", productos.Count());

            return View(productos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            var productLN = new ProductoBL(new ProductoDA());
            productLN.Insert(producto);

            return RedirectToAction("Index"); 
        }

        public ActionResult Details(int id)
        {
            var productLN = new ProductoBL(new ProductoDA());
            var producto = productLN.GetProducto(id);
            return View(producto);
        }

        public ActionResult Edit(int id)
        {

            var productLN = new ProductoBL(new ProductoDA());
            var producto = productLN.GetProducto(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            var productLN = new ProductoBL(new ProductoDA());
            productLN.Edit(producto);
            return RedirectToAction("Index");
        }
        
        //ccv ini 
        public ActionResult Delete(int id)
        {
            var serviceCliente = new eCommerceService.IeCommerceServiceClient();
            var productos = serviceCliente.GetProductos(new Service.DataContracts.GetProductosRequest()).Productos;
            if (serviceCliente.State == System.ServiceModel.CommunicationState.Opened)
            {
                serviceCliente.Close();
            }
            return View(productos);
        }

        [HttpPost]
        public ActionResult Delete(Producto producto)
        {
            var serviceCliente = new eCommerceService.IeCommerceServiceClient();
            serviceCliente.DeleteProducto(new Service.DataContracts.DeleteProductoRequest() { Producto = producto });
            if (serviceCliente.State == System.ServiceModel.CommunicationState.Opened)
            {
                serviceCliente.Close();
            }

            return RedirectToAction("Index");
        }



    }
}