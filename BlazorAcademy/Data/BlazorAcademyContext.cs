using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAcademy.Models;

namespace BlazorAcademy.Data
{
    public class BlazorAcademyContext : DbContext
    {
        public BlazorAcademyContext (DbContextOptions<BlazorAcademyContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAcademy.Models.Direction> Directions { get; set; } = default!;
        public DbSet<BlazorAcademy.Models.Group> Groups { get; set; } = default!;
    }
}
