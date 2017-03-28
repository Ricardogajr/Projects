using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.DAO;

namespace UserApp.Entidade
{
    class EntidadeContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringconn = ConfigurationManager.ConnectionStrings["UsuariosConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringconn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
