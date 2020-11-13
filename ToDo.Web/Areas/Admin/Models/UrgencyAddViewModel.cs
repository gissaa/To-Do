using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Web.Areas.Admin.Models
{
    public class UrgencyAddViewModel
    {
        [Display(Name = "Definition")]
        [Required(ErrorMessage="Tanım alanı boş geçilmez")]
        public string Definition { get; set; }
    }
}
