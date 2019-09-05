using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models.ViewModels
{
    public class EmployeeViewModel
    {        
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        public string Address { get; set; }
                
    }
}