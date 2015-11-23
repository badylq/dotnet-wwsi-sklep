using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklep.Kernel;

namespace sklep.Controllers
{
    public class CartController : Controller
    {
		// GET: Cart
		public ActionResult Index()
		{
			string userName = HttpContext.User.Identity.Name;
			var cart = Cache.Instance.Carts.FirstOrDefault(x => x.Key.Equals(userName));
			if (cart.Value != null)
				return View(cart);
			else
			{
				ViewBag.Msg = "Sesja wygasla";
				return View();
			}
		}
	}
}