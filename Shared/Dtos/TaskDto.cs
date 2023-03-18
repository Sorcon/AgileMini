namespace Shared.Dtos;

public class TaskDto
{
    public int Id { get; set; }
    public string Summary { get; set; }
    public string Details { get; set; }
    public TaskState State { get; set; }
    public int? UserId { get; set; }
    public int ProjectId { get; set; }
}