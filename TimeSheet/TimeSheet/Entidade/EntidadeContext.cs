using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Entidade
{
    class EntidadeContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public object Cliente { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string StringConn = ConfigurationManager.ConnectionStrings["TimesheetConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(StringConn);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
