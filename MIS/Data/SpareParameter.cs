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
    
    public partial class SpareParameter
    {
        public int SpareParameter_ID { get; set; }
        public int Spare_ID { get; set; }
        public string Parameter { get; set; }
        public string ParameterVakue { get; set; }
    
        public virtual Spare Spare { get; set; }
    }
}
