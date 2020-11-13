using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public  class Assignment:ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }
        public int? AppUserId { get; set; }   //Mapping içinde yapabiliriz 
        public AppUser AppUser { get; set; }
        public List<Report> Reports { get; set; }
    }
}
