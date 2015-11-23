using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace sklep.Models
{
	public class KategoriaProduktu_Produkt
	{
		// temp data - nie kasuje sie pio przejsciu do nastepnego widoku, viewbag - kasuje sie po przejsciu do nastepnego widoku
		public List<Produkt> Produkt { get; set; }
		public List<KategoriaProduktu> Kategoria { get; set; }
	}
}
