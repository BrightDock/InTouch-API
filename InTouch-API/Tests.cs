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
    
    public partial class Tests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tests()
        {
            this.Passed_tests = new HashSet<Passed_tests>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public System.Guid Professor { get; set; }
        public System.Guid Subject { get; set; }
        public Nullable<System.Guid> Lection { get; set; }
        public int Questions_count { get; set; }
        public Nullable<int> Light_questions_count { get; set; }
        public Nullable<int> Medium_questions_count { get; set; }
        public Nullable<int> Hard_questions_count { get; set; }
        public Nullable<System.DateTime> Date_start { get; set; }
        public Nullable<System.DateTime> Date_end { get; set; }
    
        public virtual Posts Posts { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passed_tests> Passed_tests { get; set; }
    }
}
