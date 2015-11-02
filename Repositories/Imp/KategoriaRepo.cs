using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories.Imp
{
	public class KategoriaRepo : IKategoriaRepo
	{
		private DataContext context = new DataContext();
		public void DodajKategorie(KategoriaProduktu kategoria)
		{
			context.Kategorie.Add(kategoria);
			context.SaveChanges();
		}

		public void EdytujKategorie(KategoriaProduktu kategoria)
		{
			var katFromDb = context.Kategorie.FirstOrDefault(x => x.Id.Equals(kategoria.Id));
			if (katFromDb != null)
			{
				katFromDb.Nazwa = kategoria.Nazwa;
				katFromDb.Opis = kategoria.Opis;
				//context.Entry(katFromDb).Property(x => x.Nazwa).IsModified = true;
				//context.Entry(katFromDb).Property(x => x.Opis).IsModified = true;
				context.SaveChanges();
			}
		}

		public void UsunKategorie(int idKategorii)
		{
			
		}

		public IQueryable<KategoriaProduktu> PobierzKategorie()
		{
			return context.Kategorie.AsNoTracking();
		}

		public KategoriaProduktu PobierzKategoriePoId(int idKategorii)
		{
			var katFromDb = context.Kategorie.FirstOrDefault(x => x.Id.Equals(idKategorii));
			return katFromDb;
		}
	}
}
