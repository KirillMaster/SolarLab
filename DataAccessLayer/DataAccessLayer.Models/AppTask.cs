using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class AppTask : BaseEntity<long>
    {
        public string Title { get; set; }
        public string  Description { get; set;}
        public DateTime DeadLine { get; set; }
        public List<File> Files { get; set; }
    }
}
