using Communication.Enums;

namespace Communication.Responses;

public class ResponseShortTask
{
    public int Id { get; set; }

    public String Name { get; set; } = string.Empty;
    
    public TaskPriority Priority { get; set; }
}