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
    public class EditProductoRequest : DataContractBaseRequest
    {
        [DataMember]
        public Producto Producto { get; set; }
    }
    [DataContract]
    public class EditProductoResponse : DataContractBaseResponse 
    {
    }
}
