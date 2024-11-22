using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6351071005_LTWEB_K63.Models;

namespace _6351071005_LTWEB_K63.Controllers
{
    public class HomeController : Controller
    {
        QLBanXeGanMayEntities1 data = new QLBanXeGanMayEntities1();
		private List<XEGANMAY> LayXeMoi(int count)
		{
			return data.XEGANMAYs.OrderByDescending(a => a.Ngaycapnhat)
				.Take(count).ToList();
		}
		// GET: Home
		public ActionResult Index()
        {
			var xemoi = LayXeMoi(5);
            return View(xemoi);
        }

		public ActionResult LoaiXe()
		{
			var loaixe = from cd in data.LOAIXEs select cd;
			return PartialView(loaixe);
		}
		public ActionResult Nhaphanphoi()
		{
			var loaixe = from cd in data.NHAPHANPHOIs select cd;
			return PartialView(loaixe);
		}

		public ActionResult Details(int id)
		{
			var xe = from s in data.XEGANMAYs
					   where s.MaXe == id
					   select s;
			return View(xe.Single());
		}

		public ActionResult SPTheoloaixe(int id)
		{
			var xe = from s in data.XEGANMAYs where s.MaLX == id select s;
			return View(xe);
		}

		public ActionResult SPTheoNPP(int id)
		{
			var xe = from s in data.XEGANMAYs where s.MaNPP == id select s;
			return View(xe);
		}

		public ActionResult About()
		{
			return View();
		}
	}
}