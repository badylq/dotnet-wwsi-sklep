using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Models;

namespace sklep.Models
{
	public class DataContext : DbContext
	{
		public DataContext()
			: base("DefaultConnection")
		{

		}
		public DbSet<Produkt> Produkty { get; set; }
		public DbSet<KategoriaProduktu> Kategorie { get; set; }
	}
}