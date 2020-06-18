using Charity.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Context
{
    public class CharityContext : DbContext
    {
        public CharityContext(DbContextOptions<CharityContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Donation> Donations { get; set; }
    }
}
