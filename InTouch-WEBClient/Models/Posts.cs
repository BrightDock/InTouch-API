//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InTouch_WEBClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Posts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Posts()
        {
            this.Tests = new HashSet<Tests>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid Author_ID { get; set; }
        public Nullable<System.Guid> Subject_ID { get; set; }
        public int Post_type { get; set; }
        public string Text { get; set; }
        public Nullable<short> Lection_number { get; set; }
    
        public virtual Post_types Post_types { get; set; }
        public virtual Subjects Subjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tests> Tests { get; set; }
        public virtual Users Users { get; set; }
    }
}
