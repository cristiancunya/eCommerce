using eCommerce.Data;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Business
{
 
    public class ProductoBL 
    {
        private IProductoDA Repositorio;
        public ProductoBL(IProductoDA Repositorio)
        {
            this.Repositorio = Repositorio;   
        }

        public IEnumerable<Producto> SelectAll()
        {

            //IEnumerable<Producto > items = new Producto [] { new T("msg") };
            //IEnumerable<Producto> items = new Producto[] { new Producto { ProductId = 1, Nombre = "Celular LG", Precio = 10.5m },
            //                                               new Producto{ ProductId = 2, Nombre = "impresora", Precio = 20.5m } };
       
            //var da = new ProductoDA();
            //return da.SelectAll(); 
            //return items;
            

             return this.Repositorio.SelectAll();

            
        }

        public Producto GetProducto(int ProductId)
        {
            //var da = new ProductoDA();
            //return da.GetProducto(ProductId);

            //var pro = new Producto();
            //pro.ProductId = 10;
            //pro.Nombre="Mororola";
            //pro.Precio= 500.50m;

            //return pro;

                return this.Repositorio.GetProducto(ProductId);

        }

        public int Insert(Producto producto)
        {
            //var da = new ProductoDA();
            //return da.Insert(producto);
            //return 0;


             return this.Repositorio.Insert(producto);
        }

        public void Edit(Producto producto)
        {
            //var da = new ProductoDA();
            //da.Edit(producto);


             this.Repositorio.Edit(producto);
        }

        public void Delete(Producto producto)
        {
            //var da = new ProductoDA();
            //da.Delete(producto);


            this.Repositorio.Delete(producto);
        }
    }
}
