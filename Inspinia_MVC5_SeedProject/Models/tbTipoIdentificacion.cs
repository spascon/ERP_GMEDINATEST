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
    
    public partial class tbTipoIdentificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTipoIdentificacion()
        {
            this.tbEmpleado = new HashSet<tbEmpleado>();
            this.tbIdentificacionCliente = new HashSet<tbIdentificacionCliente>();
            this.tbCliente = new HashSet<tbCliente>();
        }
    
        public byte tpi_Id { get; set; }
        public string tpi_Descripcion { get; set; }
        public int tpi_UsuarioCrea { get; set; }
        public System.DateTime tpi_FechaCrea { get; set; }
        public Nullable<int> tpi_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tpi_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleado> tbEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdentificacionCliente> tbIdentificacionCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCliente> tbCliente { get; set; }
    }
}
