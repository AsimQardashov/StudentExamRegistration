using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentExamRegistration.DataAccess.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [Column(TypeName = "numeric(5,0)")]
        //[Range(10000, 99999)]
        public decimal StudentNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        [MaxLength(30)]
        public string StudentName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string StudentSurname { get; set; }
        [Required]
        [Column(TypeName = "numeric(2,0)")]
        [Range(1, 12)]
        public int Class { get; set; }
        public ICollection<Exam>? Exams { get; set; }
    }
}
//dotnet ef migrations add InitialCreate --project DataAccess --startup-project Presentation
//dotnet ef database update --project DataAccess --startup-project Presentation