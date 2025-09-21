using Communication.Enums;
using Communication.Requests;
using Communication.Responses;

namespace Application.UseCases.Task.Register;

public class RegisterTaskUserCase
{
    public ResponseTaskJson Execute(RequestTaskJson request)
    
    {
        return new ResponseTaskJson()
        {
            Name = "Learning english",
            TaskDescription = "Learning english for a test ",
            Deadline = DateOnly.Parse("2025-09-20"),
            Priority = TaskPriority.High,
            Status = TaskState.InProgress


        };
    }
}