using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    [DataContract]
    public class Producto
    {
        [DataMember]
        public int ProductId { get; set; }
        //[Required(ErrorMessage="El nombre es requerido.")]
        [Required(ErrorMessageResourceType=typeof(eCommerce.Resource.Resource),
                    ErrorMessageResourceName = "ProductoNameRequerido")]
        [Display(Name="Producto")]
        [DataMember]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El precio es requerido.")]
        [DataMember]
        public decimal Precio { get; set; }
    }
}

