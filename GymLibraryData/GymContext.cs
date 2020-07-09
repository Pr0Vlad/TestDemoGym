using GymLibraryData.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymLibraryData
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Program> Programs { get; set; }

    }
}
