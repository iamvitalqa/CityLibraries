//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CityLibraries
{
    using System;
    using System.Collections.Generic;
    
    public partial class LITERATURE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LITERATURE()
        {
            this.ISSUING_LITERATURE = new HashSet<ISSUING_LITERATURE>();
        }
    
        public int LITERATURE_ID { get; set; }
        public string LITERATURE_NAME { get; set; }
        public string LITERATURE_CATEGORY { get; set; }
        public string LITERATURE_AUTHOR { get; set; }
        public string LITERATURE_PUBLISHER { get; set; }
        public int LITERATURE_PUBLISHING_DATE { get; set; }
        public int LITERATURE_PAGES { get; set; }
        public Nullable<int> LITERATURE_READING_ROOM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ISSUING_LITERATURE> ISSUING_LITERATURE { get; set; }
        public virtual READING_ROOM READING_ROOM { get; set; }
    }
}