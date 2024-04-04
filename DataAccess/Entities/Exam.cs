using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentExamRegistration.DataAccess.Entities
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        [ForeignKey("Lesson")]
        public int LessonId { get; set; }   
        public Lesson? Lesson { get; set; }
        [Required]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        [Required]
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }
        [Required]
        [Column(TypeName = "numeric(1,0)")]
        [Range(0, 9)]
        public int Score { get; set; }
    }
}
