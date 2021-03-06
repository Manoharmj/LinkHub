﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace LinkHubUI.Areas.Admin.Controllers
{
    public class ListCategoryController : Controller
    {

        private CategoryBs objBs;

        public ListCategoryController()
        {
            objBs = new CategoryBs();
        }
        
                
        // GET: Admin/ListCategory
        public ActionResult Index( string SortOrder, string SortBy, string Page)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            var categories = objBs.GetALL();

            switch (SortBy)
            {

                case "CategoryName":
                    switch (SortOrder)
                    {

                        case "Asc":
                            categories = categories.OrderBy(x => x.CategoryName).ToList();
                            break;
                        case "Desc":
                            categories = categories.OrderByDescending(x => x.CategoryName).ToList();
                            break;
                        default:
                            break;


                    }
                    break;
                case "CategoryDesc":
                    switch (SortOrder)
                    {
                        case "Asc":
                            categories = categories.OrderBy(x => x.CategoryDesc).ToList();
                            break;
                        case "Desc":
                            categories = categories.OrderByDescending(x => x.CategoryDesc).ToList();
                            break;
                        default:
                            break;


                    }
                    break;
                default:
                    categories = categories.OrderBy(x => x.CategoryName).ToList();
                    break;




            }

            ViewBag.TotalPages = Math.Ceiling(objBs.GetALL().Count() / 10.0);

            int page = int.Parse(Page == null ? "1" : Page);
            ViewBag.Page = page;
            categories = categories.Skip((page - 1) * 10).Take(10);


            return View(categories);
        }

        public ActionResult Delete(int id)
        {

            try
            {
                objBs.Delete(id);
                TempData["Msg"] = "Deleted Succesfully";
                return RedirectToAction("Index");
            }
            catch(Exception e1)
            {
                TempData["Msg"] = "Delete Failed:" + e1.Message;
                return RedirectToAction("Index");
            }
        }
    }
    
}