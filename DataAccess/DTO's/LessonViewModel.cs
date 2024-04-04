using StudentExamRegistration.DataAccess.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.DTO_s
{
    public class LessonViewModel
    {
        public int LessonId { get; set; }
        public string? LessonCode { get; set; }
        public string? LessonTitle { get; set; }
        public int Class { get; set; }
        public string? TeacherName { get; set; }
        public string? TeacherSurname { get; set; }
    }
}
