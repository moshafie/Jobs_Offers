using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace taske_tracking.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("اسم الوظيفه")]
        public string JobTitel { get; set; }
        [DisplayName(" وصف الوظيفه")]
        public string JobContent { get; set; }
        [DisplayName(" صوره")]
        public string JobImage { get; set; }
        [DisplayName(" نوع الوظيفه")]
        public int CategoryId { get; set; }

        public category category { get; set; }
    }
}