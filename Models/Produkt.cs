using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
	public class Produkt
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(30)]
		public string Nazwa { get; set; }
		[Required]
		public decimal Cena { get; set; }
		public string Opis { get; set; }
		//[ForeignKey("KategoriaProduktu")]
		//public int idProduktu { get; set; }
		public virtual KategoriaProduktu Kategoria { get; private set; }
	}
}
