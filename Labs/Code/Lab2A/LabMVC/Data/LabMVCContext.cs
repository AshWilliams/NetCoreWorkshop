using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LabMVC.Models;

namespace LabMVC.Models
{
    public class LabMVCContext : DbContext
    {
        public LabMVCContext (DbContextOptions<LabMVCContext> options)
            : base(options)
        {
        }

        public DbSet<LabMVC.Models.Person> Person { get; set; }

        public DbSet<LabMVC.Models.Product> Product { get; set; }
    }
}
