using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace taske_tracking.Models
{
    public class category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("نوع الوظيفه")]
        public string CategoryName { get; set; }
        [Required]
        [DisplayName("وصف نوع الوظيفه")]
        public string CategoryDiscription { get; set; }

        public ICollection<Job>jobs { get; set; }
    }
}