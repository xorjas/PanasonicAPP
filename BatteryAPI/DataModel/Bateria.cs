//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bateria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bateria()
        {
            this.Master_Table = new HashSet<Master_Table>();
        }
    
        public int ID_Bateria { get; set; }
        public string Detalle_Bateria { get; set; }
        public string Largo { get; set; }
        public string Ancho { get; set; }
        public string Alto { get; set; }
        public string Peso { get; set; }
        public string CCA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master_Table> Master_Table { get; set; }
    }
}
