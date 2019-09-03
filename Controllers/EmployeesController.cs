using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {

            List<ListEmployeeViewModel> lst;
            using (NorthwindEntities db = new NorthwindEntities())
            {
                lst = (from d in db.Employees
                          select new ListEmployeeViewModel
                          {
                              EmployeeID = d.EmployeeID,
                              LastName = d.LastName,
                              FristName = d.FirstName,
                              Title = d.Title,
                              TitleOfCourtesy = d.TitleOfCourtesy,
                              Address = d.Address,
                              City = d.City,
                              Region = d.Region,
                              PostalCode = d.PostalCode,
                              Country = d.Country,
                              HomePhone = d.HomePhone,
                              Extension = d.Extension,
                              Notes = d.Notes,
                              PhotoPath = d.PhotoPath

                          }).ToList();
            }


            return View(lst);
        }
    }
}