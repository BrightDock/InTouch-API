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
    
    public partial class Student_answers
    {
        public System.Guid Id { get; set; }
        public System.Guid Question_ID { get; set; }
        public System.Guid Student_ID { get; set; }
    
        public virtual Questions Questions { get; set; }
        public virtual Users Users { get; set; }
    }
}
