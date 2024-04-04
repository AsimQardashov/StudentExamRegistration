using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentExamRegistration.DataAccess.Entities
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        [Required]
        [Column(TypeName = "char(3)")]
        [MaxLength(3)]
        public string? LessonCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        [MaxLength(30)]
        public string? LessonTitle { get; set; }
        [Required]
        [Column(TypeName = "numeric(2,0)")]
        [Range(1, 11)]
        public int Class { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20)]
        public string? TeacherName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20)]
        public string? TeacherSurname { get; set; }
        public ICollection<Exam>? Exams { get; set; }
    }
}
