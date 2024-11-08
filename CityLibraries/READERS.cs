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
    using System.Linq;
    
    public partial class READERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public READERS()
        {
            this.ISSUING_LITERATURE = new HashSet<ISSUING_LITERATURE>();
        }
    
        public int READER_ID { get; set; }
        public string READER_SURNAME { get; set; }
        public string READER_NAME { get; set; }
        public string READER_PATRONYMIC { get; set; }
        public string READER_CATEGORY { get; set; }
        public string READER_WORKING_PLACE { get; set; }
        public System.DateTime READER_BIRTHDAY { get; set; }
        public Nullable<int> READER_AGE { get; set; }
        public System.DateTime READER_REGISTRATION { get; set; }
        public string READER_PHOTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ISSUING_LITERATURE> ISSUING_LITERATURE { get; set; }


        public string IssuanceDate
        {
            get
            {
                // Проверяем, что коллекция не пустая, чтобы избежать ошибки
                var issuingLiterature = ISSUING_LITERATURE.FirstOrDefault();
                if (issuingLiterature != null && issuingLiterature.ISSUING_LITERATURE_ISSUANCE_DATE.HasValue)
                {
                    return issuingLiterature.ISSUING_LITERATURE_ISSUANCE_DATE.Value.ToString("dd.MM.yyyy");
                }
                return string.Empty;
            }
        }

    }
}