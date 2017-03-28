using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entidade
{
    public class EntidadeContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringconn = ConfigurationManager.ConnectionStrings["EstudoConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringconn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
