using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjPorto.Models
{
	public class Context : DbContext
	{
		public DbSet<Conteiner> Conteiners { get; set; }
		public DbSet<Movimentacao> Movimentacoes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBPorto;Integrated Security=true");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Conteiner>()
				.Property(e => e.TipoConteiner)
				.HasConversion<string>();

			modelBuilder.Entity<Conteiner>()
				.Property(e => e.Status)
				.HasConversion<string>();

			modelBuilder.Entity<Conteiner>()
				.Property(e => e.Categoria)
				.HasConversion<string>();

			modelBuilder.Entity<Movimentacao>()
				.Property(e => e.TipoMovimentacao)
				.HasConversion<string>();
		}
	}
}
