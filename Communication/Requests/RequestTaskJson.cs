using Communication.Enums;
using TaskStatus = System.Threading.Tasks.TaskStatus;

namespace Communication.Requests;

public class RequestTaskJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string TaskDescription { get; set; } = string.Empty;

    public TaskPriority Priority { get; set; }
    
    public TaskState Status { get; set; }
    
    public DateOnly Deadline { get; set; }



}