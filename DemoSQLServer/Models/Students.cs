using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DemoSQLServer.Models
{
    public class Students
    {
        [Key]
        public int id { get; set; }


        [Column(TypeName ="nvarchar(250)")]
        [Required]
        public string fullName  { get; set; } = string.Empty;

        [Required]
        public int age { get; set; }


        [Required]
        public string contactNumber { get; set; }
    }
}
