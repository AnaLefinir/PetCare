﻿using System;
using System.Collections.Generic;
using System.Text;
using PetCare.BusinessLogic.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace PetCare.BusinessLogic.DataAccess
{
    public class PetCareContext : DbContext
    {
        //The name of the connection string is paddes in to the connstructor
        public PetCareContext() : base("PetCareContext")
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<MedicalHistory> MedicalHistory { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
