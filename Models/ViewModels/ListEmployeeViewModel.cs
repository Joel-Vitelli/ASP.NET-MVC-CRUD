using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVC.Models.ViewModels
{
    public class ListEmployeeViewModel
    {               
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }              
        public string Address { get; set; }        
    }
}