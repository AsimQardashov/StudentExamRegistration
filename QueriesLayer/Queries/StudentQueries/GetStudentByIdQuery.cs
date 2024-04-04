using MediatR;
using DataAccess.DTO_s;

namespace QueriesLayer.Queries.StudentQueries
{
    public class GetStudentByIdQuery : IRequest<StudentViewModel>
    {
        public int StudentId;

        public GetStudentByIdQuery(int studentId)
        {
            this.StudentId = studentId;
        }

    }
}
