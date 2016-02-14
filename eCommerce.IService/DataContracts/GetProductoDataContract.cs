using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Service.DataContracts
{
    [DataContract]
    public class GetProductoRequest : DataContractBaseRequest
    {

        [DataMember]
        public int idProducto { get; set; }
    }

    [DataContract]
    public class GetProductoResponse : DataContractBaseResponse
    {
        [DataMember]
        public Producto Producto { get; set; }
    }
}
