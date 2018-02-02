using Quiron.LojaVirtual.V2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.V2.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        /// <summary>
        /// Representa a entidade Produto do banco
        /// </summary>
        public DbSet<Produtos> Produtos { get; set; }

        /// <summary>
        /// Trabalha com pluralização
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Produto no banco é Produtos
            modelBuilder.Entity<Produtos>().ToTable("Produtos");
        }

    }
}
