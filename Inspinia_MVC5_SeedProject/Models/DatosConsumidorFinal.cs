//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatosConsumidorFinal
    {
        public int confi_Id { get; set; }
        public long fact_Id { get; set; }
        public string confi_Nombres { get; set; }
        public string confi_Telefono { get; set; }
        public string confi_Correo { get; set; }
    
        public virtual tbFactura tbFactura { get; set; }
    }
}
