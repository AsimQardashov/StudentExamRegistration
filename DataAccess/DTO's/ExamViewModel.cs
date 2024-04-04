namespace DataAccess.DTO_s
{
    public class ExamViewModel
    {
        public int ExamId { get; set; }
        public string? LessonCode { get; set; }
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }
        public string? LessonTitle { get; set; }
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }
    }
}
