using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class KategoriaProduktu
	{
		public int Id { get; set; }
		public string Nazwa { get; set; }
		public string Opis { get; set; }
		public virtual ICollection<Produkt> Produkty { get; set; }
	}
}
