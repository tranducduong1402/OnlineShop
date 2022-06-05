using MyClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult LoadData()
        {
            var listCategory = new List<Category>();
            listCategory.Add(new Category()
            {
                Id = 1,
                Name = "Tivi",
                Slug = "Tuvi",
                Desc = "Tivi",
                CreatedDate = DateTime.Now,
                Status = true,
            });
            listCategory.Add(new Category()
            {
                Id = 2,
                Name = "Tu lanh",
                Slug = "Tu lanh",
                Desc = "Tu lanh",
                CreatedDate = DateTime.Now,
                Status = true,
            });
            listCategory.Add(new Category()
            {
                Id = 3,
                Name = "May giat",
                Slug = "May giat",
                Desc = "May giat",
                CreatedDate = DateTime.Now,
                Status = true,
            });
            return Json(new
            {
                data = listCategory,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }
    }
}