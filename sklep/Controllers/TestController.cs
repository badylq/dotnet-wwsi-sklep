using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Sklep.Models;

namespace Sklep.Controllers
{
    public class TestController : Controller
    {
		private DataContext context = new DataContext();
        public ActionResult Index()
        {
			var kategorie = context.Kategorie.AsNoTracking();
			return View(kategorie);
        }
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(KategoriaProduktu kat)
		{
			if (!ModelState.IsValid)
				return View(kat);
			context.Kategorie.Add(kat);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
    }
}