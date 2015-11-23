using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositories;
using Models;
using Ninject;

namespace sklep.Controllers
{
    public class ProduktController : Controller
    {
		private IKernel kernel = new StandardKernel(new Sklep.Kernel.Kernel());
		private IProduktRepo repo;
		public ProduktController()
		{
			repo = kernel.Get<IProduktRepo>();
		}
		// GET: Produkt
		public ViewResult Index() // View result tylko pokazujemy widok, action result np jak przekierowujemy do innej akcji
		{
			var produkt = repo.PobierzProdukt();
			return View(produkt);
		}
		[HttpGet]
		public ViewResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(Produkt produkt)
		{
			if (!ModelState.IsValid)
				return View(produkt);
			repo.DodajProdukt(produkt);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ViewResult Edit(int id)
		{
			var produkt = repo.PobierzProduktPoId(id);
			if (produkt != null)
			{
				return View();
			}
			else
			{
				ViewBag.ErrorMsg = "Produkt nie istenieje"; //viewbag obiekt dynamiczny, wyrzuca cos na widok
				return View();
			}
		}
		[HttpPost]
		public ActionResult Edit(Produkt produkt)
		{
			if (!ModelState.IsValid)
			{
				return View(produkt);
			}
			else
			{
				repo.EdytujProdukt(produkt);
				return RedirectToAction("Index");

			}
		}
		[HttpGet]
		public ActionResult Delete(int id)
		{
			repo.UsunProdukt(id);
			return RedirectToAction("Index");

		}
	}
}