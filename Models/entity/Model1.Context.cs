﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities1 : DbContext
    {
        public DbCvEntities1()
            : base("name=DbCvEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }
        public virtual DbSet<TblEğitimlerim> TblEğitimlerim { get; set; }
        public virtual DbSet<TblHakkında> TblHakkında { get; set; }
        public virtual DbSet<TblHobilerim> TblHobilerim { get; set; }
        public virtual DbSet<Tblİletisim> Tblİletisim { get; set; }
        public virtual DbSet<TblSeltifikalarım> TblSeltifikalarım { get; set; }
        public virtual DbSet<TblYeteneklerim> TblYeteneklerim { get; set; }
    }
}
