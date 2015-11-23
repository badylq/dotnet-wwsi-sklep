using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Models
{
	public class DataContext : DbContext
	{
		public DataContext()
			: base("DefaultConnection")
		{
		}

		public DbSet<Produkt> Produkty { get; set; }
		public DbSet<KategoriaProduktu> Kategorie { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<KategoriaProduktu>()
				.HasMany(x => x.Produkty)
				.WithRequired(x => x.Kategoria);
		}
	}
}