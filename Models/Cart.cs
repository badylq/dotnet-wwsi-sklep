using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Cart
	{
		public Guid Id { get; set; }
		public int ClientId { get; set; }
		public ICollection<Produkt> Products { get; set; }
		/// <summary>
		/// <paramref name="nasz wlasny opis"/>
		/// </summary>
		/// <param name="produkt"></param>
		public void AddToCard(Produkt produkt)
		{
			Products.Add(produkt);
		}
		public void RemoveFromCard(Produkt produkt)
		{
			Products.Remove(produkt);
		}
	}
}
