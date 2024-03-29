﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class KategoriaProduktu
	{
		public KategoriaProduktu()
		{
			Produkty = new HashSet<Produkt>();
		}
		[Key]
		public int Id { get; set; }
		[MaxLength(30)]
		[Required]
		public string Nazwa { get; set; }
		[MaxLength(150)]
		[Required]
		public string Opis { get; set; }
		public virtual ICollection<Produkt> Produkty { get; private set; }
	}
}
