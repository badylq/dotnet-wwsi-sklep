using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories.Imp
{
	public class ProduktRepo : IProduktRepo
	{
		private DataContext context = new DataContext();
		public void DodajProdukt(Produkt produkt)
		{
			context.Produkty.Add(produkt);
			context.SaveChanges();
		}

		public void EdytujProdukt(Produkt produkt)
		{
			var produktFromDb = context.Produkty.FirstOrDefault(x => x.Id.Equals(produkt.Id));
			if (produktFromDb != null)
			{
				produktFromDb.Nazwa = produkt.Nazwa;
				produktFromDb.Opis = produkt.Opis;
				produktFromDb.Cena = produkt.Cena;
				//context.Entry(katFromDb).Property(x = > x.Nazwa ).IsModified = true;
				context.SaveChanges();
			}
		}

		public void UsunProdukt(int idProduktu)
		{
			var produktFromDb = context.Produkty.FirstOrDefault(x => x.Id.Equals(idProduktu));
			if (produktFromDb != null)
			{
				context.Produkty.Remove(produktFromDb);
				context.SaveChanges();
			}
		}

		public IQueryable<Produkt> PobierzProdukt()
		{
			return context.Produkty.AsNoTracking();
		}

		public Produkt PobierzProduktPoId(int idProduktu)
		{
			var produktFromDb = context.Produkty.FirstOrDefault(x => x.Id.Equals(idProduktu));
			return produktFromDb;
		}
	}
}
