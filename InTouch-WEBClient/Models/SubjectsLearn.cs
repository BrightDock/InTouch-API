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
    
    public partial class SubjectsLearn
    {
        public System.Guid Id { get; set; }
        public System.Guid Subject_ID { get; set; }
        public System.Guid User_ID { get; set; }
    
        public virtual Subjects Subjects { get; set; }
        public virtual Users Users { get; set; }
    }
}
