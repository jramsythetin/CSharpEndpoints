using Communication.Enums;
using Communication.Responses;

namespace Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
         
            Tasks = new List<ResponseShortTask>
            {
                new ResponseShortTask()
                {
                    Id = 1,
                    Name = "Trip",
                    Priority = TaskPriority.High
                    
                }
            }

        };
    }
}