using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Adults")]
    public class Adult : Person
    {
        public Job JobTitle { get; set; }
    }
}