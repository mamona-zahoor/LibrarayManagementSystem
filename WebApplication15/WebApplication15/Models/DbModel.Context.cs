﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication15.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryManagementSystemEntities : DbContext
    {
        public LibraryManagementSystemEntities()
            : base("name=LibraryManagementSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<All_Books> All_Books { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Issued_Books> Issued_Books { get; set; }
        public virtual DbSet<tbl_student> tbl_student { get; set; }
        public virtual DbSet<tbl_teacher> tbl_teacher { get; set; }
    }
}