using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Job")]
    public class Job {
        public int Id { get; set; } 
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}