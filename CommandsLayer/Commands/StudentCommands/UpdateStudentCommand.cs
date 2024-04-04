using DataAccess.DTO_s;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLayer.Commands.StudentCommands
{
    public class UpdateStudentCommand : IRequest<Unit>
    {
        public StudentViewModel UpdatedStudent { get; set; }
    }
}
