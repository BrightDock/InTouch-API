﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InTouch_DBEntities : DbContext
    {
        public InTouch_DBEntities()
            : base("name=InTouch_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Difficulty_of_questions> Difficulty_of_questions { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Passed_tests> Passed_tests { get; set; }
        public virtual DbSet<Post_types> Post_types { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Question_options> Question_options { get; set; }
        public virtual DbSet<Question_types> Question_types { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<SignalRConnections> SignalRConnections { get; set; }
        public virtual DbSet<Student_answers> Student_answers { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<SubjectsLearn> SubjectsLearn { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }
        public virtual DbSet<Tests_additions> Tests_additions { get; set; }
        public virtual DbSet<Universities> Universities { get; set; }
        public virtual DbSet<User_types> User_types { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Users_additions> Users_additions { get; set; }
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Subjecst_professors> Subjecst_professors { get; set; }
    }
}
