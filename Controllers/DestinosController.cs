using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Destinos.Models;
using Destinos.Models.ViewsModels;

namespace Destinos.Controllers
{
    public class DestinosController : Controller
    {
        // GET: Destinos
        public ActionResult Index()
        {
            List<TablaViewModel> lst;
            using (DestinosEntities db = new DestinosEntities())
            {
                lst = (from d in db.Destinos
                       select new TablaViewModel
                       {
                           Name = d.Name,
                           Photo = d.Photo,
                           Description = d.Description,
                           Price = (int)d.Price
                       }).ToList();
            }
            return View(lst);
        }
    }
}