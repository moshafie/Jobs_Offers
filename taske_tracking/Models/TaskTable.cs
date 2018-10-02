using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace taske_tracking.Models
{
    public class TaskTable
    {
        public int Id { get; set; }
       
        [Required]
        [Display(Name = "Task title")]
        public string title { get; set; }
        [Required]
        [Display(Name = "Task Details")]
        public string details { get; set; }
        [Required]
        [Display(Name = "Assing Name")]
        public string assingname { get; set; }
        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date) ]
        public DateTime? date { get; set; }
        
    }
}