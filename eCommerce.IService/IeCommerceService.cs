using eCommerce.Service.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eCommerce.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IeCommerceService
    {
        [OperationContract]
        GetProductosResponse GetProductos(GetProductosRequest request);

        [OperationContract]
        SaveProductoResponse AddProducto(SaveProductoRequest request);

        [OperationContract]
        DeleteProductoResponse DeleteProducto(DeleteProductoRequest request);

        [OperationContract]
        EditProductoResponse EditProducto(EditProductoRequest request);

        [OperationContract]
        GetProductoResponse  GetProducto(GetProductoRequest request);


    }
   
}
