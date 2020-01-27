using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoTask.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Importance Importance { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; }
        public bool IsDone { get; set; }
        public virtual ApplicationUser User { get; set; }

    }

    public enum Importance 
    {
        Low, 
        Normal, 
        High
    }
}