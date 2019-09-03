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
                              LastName = d.LastName,
                              FirstName = d.FirstName,
                              Title = d.Title,                             
                              Address = d.Address,                             
                             
                          }).ToList();
            }
            return View(lst);
        }
        public ActionResult Nuevo()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Nuevo(EmployeeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (NorthwindEntities db = new NorthwindEntities())
                    {
                        var oEmployee = new Employees();
                        
                        oEmployee.FirstName = model.FirstName;
                        oEmployee.LastName = model.LastName;
                        oEmployee.Title = model.Title;                        
                        oEmployee.Address = model.Address;                        

                        db.Employees.Add(oEmployee);
                        db.SaveChanges();
                    }

                    return Redirect("~/Employees/");
                }

                return View(model);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}