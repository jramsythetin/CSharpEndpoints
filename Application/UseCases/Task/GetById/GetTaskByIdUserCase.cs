using System.Runtime.InteropServices.JavaScript;
using Communication.Enums;
using Communication.Responses;

namespace Application.UseCases.Task.GetById;

public class GetTaskByIdUserCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = 1,
            Name = "Cut hair",
            TaskDescription = "Cut hair for Lisa's party",
            Status = TaskState.Waiting,
            Priority = TaskPriority.High,
            Deadline = DateOnly.Parse("2025-09-20")
        };
    }
}