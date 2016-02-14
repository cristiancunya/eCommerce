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
    public class GetProductosRequest : DataContractBaseRequest
    {       
        [DataMember]
        public string Nombre { get; set; }        
    }

    [DataContract]
    public class GetProductosResponse : DataContractBaseResponse
    {        
        [DataMember]
        public IEnumerable<Producto> Productos {get;set;}
    }
}
