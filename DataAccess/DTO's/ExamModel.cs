using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.DTO_s
{
    public class ExamModel
    {
        public int ExamId { get; set; }
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }
    }
}
