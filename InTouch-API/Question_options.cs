//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InTouch_API
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question_options
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question_options()
        {
            this.Passed_tests = new HashSet<Passed_tests>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid Question_ID { get; set; }
        public string Option_text { get; set; }
        public bool Is_right { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passed_tests> Passed_tests { get; set; }
        public virtual Questions Questions { get; set; }
    }
}
