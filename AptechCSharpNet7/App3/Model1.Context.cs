﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ManageStudentEntities : DbContext
    {
        public ManageStudentEntities()
            : base("name=ManageStudentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblClass> tblClasses { get; set; }
        public virtual DbSet<tblCource> tblCources { get; set; }
        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblExam> tblExams { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
        public virtual DbSet<tblSubject> tblSubjects { get; set; }
        public virtual DbSet<tblTot> tblTots { get; set; }
    }
}
