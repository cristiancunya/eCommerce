using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Service.DataContracts
{
    [DataContract]
    public class DataContractBaseRequest     
    {
        [DataMember]
        public string UserId { get; set; }
    }

    [DataContract]
    public class DataContractBaseResponse
    {
        [DataMember]
        public int ErrorCode { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
