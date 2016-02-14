using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Entities;
using eCommerce.Business;
using eCommerce.Data;
using NUnit.Framework;

namespace eCommerce.UnitTest 
{

    public class ReviewRepositorioMock : IProductoDA
    {
        public ReviewRepositorioMock()
        {
        }

        public IEnumerable<Producto> item = new Producto[0];
        public Producto pro = new Producto();


        public IEnumerable<Producto> SelectAll()
        {
            return item;
        }

        public Producto GetProducto(int n)
        {
            return pro;
        }

        public int Insert(Producto producto)
        {
            return 1;
        }

        public void Edit(Producto producto)
        {      
        }

        public void Delete(Producto producto)
        { 
        }
    }

    [TestFixture]
    public class Class1
    {

        [Test]
        public void SelectAllTest()
        { 
            var service = new ProductoBL(new ReviewRepositorioMock());
       
            service.SelectAll();
        }

         [Test]
        public void Insert()
        {

            var repo = new ReviewRepositorioMock();
             var pro = new Producto();
            pro.ProductId = 10;
            pro.Nombre = "Mororola";
            pro.Precio = 500.50m;

            var service = new ProductoBL(repo);
            service.Insert(pro);
            //var n = bl.Insert(pro);
            //if (n != 0)
            //{
            //    Assert.Fail("No se pudo insertar el producto");
            //}
        }

       //[Test]
       // public void TestSelectAll() 
       // {
       //     ProductoBL bl = new ProductoBL();

       //     IEnumerable<Producto> items = bl.SelectAll();
       // }


       //[Test]
       //public void GetProducto()
       //{
       //    ProductoBL bl = new ProductoBL();

       //    var pro = bl.GetProducto(10);

       //    if (pro.ProductId == 0)
       //    {
       //        Assert.Fail("No Se abrio el producto");
       //    }

       //}
      
              

    }
}
