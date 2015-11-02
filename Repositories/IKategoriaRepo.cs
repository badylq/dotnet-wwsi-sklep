using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
	public interface IKategoriaRepo
	{
		void DodajKategorie(KategoriaProduktu kategoria);
		void EdytujKategorie(KategoriaProduktu kategoria);
		void UsunKategorie(int idKategorii);
		IQueryable<KategoriaProduktu> PobierzKategorie();
		KategoriaProduktu PobierzKategoriePoId(int idKategorii);
	}
}
