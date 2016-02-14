using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using eCommerce.Service.DataContracts;
using eCommerce.Business; 

namespace eCommerce.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class eCommerceService : IeCommerceService
    {
        public GetProductosResponse GetProductos(GetProductosRequest request)
        {
            var response = new GetProductosResponse();
         
            try
            {
                var productLN = new ProductoBL(new ProductoDA());
                response.Productos = productLN.SelectAll();

                response.ErrorCode = 0; 
            }
            catch(Exception e)
            {
                response.ErrorCode = 100;
                response.ErrorMessage = e.Message; 
            }
            
            return response;
 
        }


        public SaveProductoResponse AddProducto(SaveProductoRequest request)
        {
            var response = new SaveProductoResponse();

            try
            {
                var productLN = new ProductoBL();
                productLN.Insert(request.Producto);

                response.ErrorCode = 0;
            }
            catch (Exception e)
            {
                response.ErrorCode = 100;
                response.ErrorMessage = e.Message;
            }

            return response;
        }


        public DeleteProductoResponse DeleteProducto(DeleteProductoRequest request)
        {
            var response = new DeleteProductoResponse();

            try
            {
                var productLN = new ProductoBL();
                productLN.Delete(request.Producto);

                response.ErrorCode = 0;
            }
            catch (Exception e)
            {
                response.ErrorCode = 100;
                response.ErrorMessage = e.Message;
            }

            return response;
        }


        public EditProductoResponse EditProducto(EditProductoRequest request)
        {
            var response = new EditProductoResponse();

            try
            {
                var productLN = new ProductoBL();
                productLN.Edit(request.Producto);

                response.ErrorCode = 0;
            }
            catch (Exception e)
            {
                response.ErrorCode = 100;
                response.ErrorMessage = e.Message;
            }

            return response;
        }



        public GetProductoResponse GetProducto(GetProductoRequest request)
        {
            var response = new GetProductoResponse();

            try
            {
                var productLN = new ProductoBL();
                response.Producto = productLN.GetProducto(request.idProducto);

                response.ErrorCode = 0;
            }
            catch (Exception e)
            {
                response.ErrorCode = 100;
                response.ErrorMessage = e.Message;
            }

            return response;
        }
    }
}
