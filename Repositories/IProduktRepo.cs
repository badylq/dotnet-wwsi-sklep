using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
	public interface IProduktRepo
	{
		void DodajProdukt(Produkt produkt);
		void EdytujProdukt(Produkt produkt);
		void UsunProdukt(int idProduktu);
		IQueryable<Produkt> PobierzProdukt(); //Iqueryable tablica nie numerowana, nie mozemy sie po niej poruszac
		Produkt PobierzProduktPoId(int idProduktu);
	}
}
