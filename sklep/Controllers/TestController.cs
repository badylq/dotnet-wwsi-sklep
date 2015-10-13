using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sklep.Models;
using Models;

namespace sklep.Controllers
{
    public class TestController : Controller
    {
		private DataContext context = new DataContext();
        public ActionResult Index()
        {
            return View();
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