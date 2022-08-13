using Agenda.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Context
{
    public class LocalDbContext : DbContext
    {

        public LocalDbContext (DbContextOptions<LocalDbContext> opt) : base(opt) { }

        public DbSet<Tarefa> tarefa { get; set; }
    }
}
