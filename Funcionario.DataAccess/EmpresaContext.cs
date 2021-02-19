using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Funcionario.Models;

namespace Funcionario.DataAccess
{
    public class EmpresaContext : DbContext
    {


        public EmpresaContext() : base("name=Empresa")
        {
            //prevent creating a new db
            Database.SetInitializer<EmpresaContext>(null);
        }

        public DbSet<Models.Funcionario> Funcionario { get; set; }
        public DbSet<Estado> Estado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // EF is search for plural names, this will prevent
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
 

    }

}
