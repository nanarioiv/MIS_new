//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MIS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Spare()
        {
            this.RequestWorks = new HashSet<RequestWork>();
            this.SpareParameters = new HashSet<SpareParameter>();
        }
    
        public int Spare_ID { get; set; }
        public int SpareType_ID { get; set; }
        public decimal Price { get; set; }
        public string SpareName { get; set; }
        public string Article { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestWork> RequestWorks { get; set; }

        public virtual SpareType SpareType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpareParameter> SpareParameters { get; set; }
    }
}
