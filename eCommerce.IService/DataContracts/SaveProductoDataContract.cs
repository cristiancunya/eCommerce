using eCommerce.Entities;
using eCommerce.Service.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Service.DataContracts
{
    [DataContract]
    public class SaveProductoRequest : DataContractBaseRequest
    {
        [DataMember]
        public Producto Producto { get; set; }
    }

     [DataContract]
    public class SaveProductoResponse : DataContractBaseResponse
    {
    }
}
