//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbUnidadesMedida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbUnidadesMedida()
        {
            this.tbInventarioFisicoDetalle = new HashSet<tbInventarioFisicoDetalle>();
            this.tbProducto = new HashSet<tbProducto>();
        }
    
        public int uni_Id { get; set; }
        public string uni_Descripcion { get; set; }
        public string uni_Abreviacion { get; set; }
        public string uni_UsuarioCrea { get; set; }
        public System.DateTime uni_FechaCrea { get; set; }
        public string uni_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> uni_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisicoDetalle> tbInventarioFisicoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProducto> tbProducto { get; set; }
    }
}