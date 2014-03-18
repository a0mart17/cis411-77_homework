﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetStore.Models
{
    public class Pet
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Breed { get; set; }
        public DateTime DateBorn { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }
        public byte[] Photo { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}