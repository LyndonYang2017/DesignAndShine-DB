﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJSExerciseMain_DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DSEntities : DbContext
    {
        public DSEntities()
            : base("name=DSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DiagnosisList> DiagnosisLists { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Signin> Signins { get; set; }
        public virtual DbSet<StationNames> StationNames { get; set; }
    }
}
