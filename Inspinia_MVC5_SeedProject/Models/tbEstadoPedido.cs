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
    
    public partial class tbEstadoPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEstadoPedido()
        {
            this.tbPedido = new HashSet<tbPedido>();
        }
    
        public byte esped_Id { get; set; }
        public string esped_Descripcion { get; set; }
        public int esped_UsuarioCrea { get; set; }
        public System.DateTime esped_FechaCrea { get; set; }
        public Nullable<int> esped_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> esped_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPedido> tbPedido { get; set; }
    }
}
