using Demo.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Goal> Goals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Client>()
                .HasData(
                    new Client
                    {
                        Id = Guid.Parse("64de18e0-d1a7-47c2-b477-430d6e68d3bb"),
                        FirstName = "John",
                        LastName = "Doe",
                        DateCreated = DateTime.Now,
                    },
                    new Client
                    {
                        Id = Guid.Parse("cee1af96-d756-4a8e-b545-1973518e130a"),
                        FirstName = "Peter",
                        LastName = "Potty",
                        DateCreated = DateTime.Now,

                    },
                    new Client
                    {
                        Id = Guid.Parse("28e423e3-73af-4ca2-978d-188cdcff2a87"),
                        FirstName = "Tom",
                        LastName = "Hanks",
                        DateCreated = DateTime.Now,

                    }
                );

            modelBuilder.Entity<Goal>()
                .HasData(
                    new Goal
                    {
                        Id = Guid.NewGuid(),
                        ClientId = Guid.Parse("64de18e0-d1a7-47c2-b477-430d6e68d3bb"),
                        Title = "Win a Game",
                        Details = "Win any global game",
                        DateCreated = DateTime.Now,
                    },
                    new Goal
                    {
                        Id = Guid.NewGuid(),
                        ClientId = Guid.Parse("cee1af96-d756-4a8e-b545-1973518e130a"),
                        Title = "Get Rich",
                        Details = "Earn 1 million dollar",
                        DateCreated = DateTime.Now,

                    },
                    new Goal
                    {
                        Id = Guid.NewGuid(),
                        ClientId = Guid.Parse("cee1af96-d756-4a8e-b545-1973518e130a"),
                        Title = "Get a Bike",
                        Details = "Buy a good bike",
                        DateCreated = DateTime.Now,

                    },
                    new Goal
                    {
                        Id = Guid.NewGuid(),
                        ClientId = Guid.Parse("28e423e3-73af-4ca2-978d-188cdcff2a87"),
                        Title = "See the World",
                        Details = "Travel to 100 countrys",
                        DateCreated = DateTime.Now,
                    },
                    new Goal
                    {
                        Id = Guid.NewGuid(),
                        ClientId = Guid.Parse("28e423e3-73af-4ca2-978d-188cdcff2a87"),
                        Title = "Find a Country",
                        Details = "Find a dream country after see the world",
                        DateCreated = DateTime.Now,
                    }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
