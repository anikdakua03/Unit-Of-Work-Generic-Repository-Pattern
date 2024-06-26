﻿using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Context
{
    public class MovieManagementDbContext : DbContext
    {
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options) : base(options)
        {
            
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Biography> Biographies { get; set; }

        // for using default 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FirstName = "Tom", LastName = "Thomas" },
                new Actor { Id = 2, FirstName = "Jerry", LastName = "Ring" },
                new Actor { Id = 3, FirstName = "Spike", LastName = "Sen" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie {Id = 1, Name = "Tom and Jerry Tales", Description = "Famous", ActorId = 1 },
                new Movie { Id = 2, Name = "Tom and Jerry Tales", Description = "Famous", ActorId = 2 },
               new Movie { Id = 3, Name = "Tom and Jerry Newwwwwww", Description = "New", ActorId = 1 },
               new Movie { Id = 4, Name = "Tom and Jerry Very Old", Description = "Old", ActorId = 1 }
                );
        }
    }
}
