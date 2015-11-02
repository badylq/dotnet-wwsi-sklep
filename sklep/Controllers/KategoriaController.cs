using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Repositories;
using Ninject;
using Sklep.Kernel;

namespace Sklep.Controllers
{
    public class KategoriaController : Controller
    {
        // GET: Kategoria
		private IKernel kernel = new StandardKernel(new Kernel.Kernel());
	    private IKategoriaRepo repo;

	    public KategoriaController()
	    {
		    repo = kernel.Get<IKategoriaRepo>();
	    }

	    public ViewResult Index()
	    {
		    var kategorie = repo.PobierzKategorie();
		    return View(kategorie);
	    }

	    [HttpGet]
	    public ViewResult Create()
	    {
		    return View();
	    }

	    [HttpPost]
	    public ActionResult Create(KategoriaProduktu kat)
	    {
			if (!ModelState.IsValid)
				return View(kat);
			repo.DodajKategorie(kat);
		    return RedirectToAction("Index");
	    }

	    [HttpGet]
	    public ViewResult Edit(int id)
	    {
		    var kategoria = repo.PobierzKategoriePoId(id);
		    if (kategoria != null)
		    {
			    return View(kategoria);
		    }
		    else
		    {
			    ViewBag.ErrorMsg = "Kategoria nie istnieje";
			    return View();
		    }
	    }

	    [HttpPost]
	    public ActionResult Edit(KategoriaProduktu kat)
	    {
		    if (!ModelState.IsValid)
		    {
			    return View(kat);
		    }
		    else
		    {
			    repo.EdytujKategorie(kat);
				return RedirectToAction("Index");
		    }
	    }

	    //[HttpGet]
	    //public ViewResult Delete(int id)
	    //{
		   // var kategoria = repo.PobierzKategoriePoId(id);
	    //}

    }
}