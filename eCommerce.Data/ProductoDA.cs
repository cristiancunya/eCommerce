using eCommerce.Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Data
{
    public interface IProductoDA
    {
        IEnumerable<Producto> SelectAll();
        Producto GetProducto(int n);
        int Insert(Producto producto);
        void Edit(Producto producto);
        void Delete(Producto producto);
    }

    public class ProductoDA : IProductoDA 
    {
        Database db;

        public ProductoDA()
        {
            db = new AppDbFactory().AppDatabase; 
        }

        public IEnumerable<Producto> SelectAll()
        {
            var p = db.ExecuteSprocAccessor<Producto>("GetProductos");
            return p; 
        }

        public Producto GetProducto(int ProductId)
        {
            var p = db.ExecuteSprocAccessor<Producto>("GetProducto", 
                        new object[] { ProductId }).FirstOrDefault();
            return p;
        }

        public int Insert(Producto producto)
        {
            var idProducto = db.ExecuteScalar("InsertProducto",
                    new object[]{producto.Nombre, producto.Precio} );
            return Int32.Parse(idProducto.ToString());
        }

        public void Edit(Producto producto)
        {
            var IdProducto = db.ExecuteNonQuery("UpdateProducto", 
                new object[] { producto.ProductId, producto.Nombre, producto.Precio });
        }

        public void Delete(Producto producto)
        {
            var IdProducto = db.ExecuteNonQuery("DeleteProducto", 
                new object[] { producto.ProductId });
        }
    }
}
