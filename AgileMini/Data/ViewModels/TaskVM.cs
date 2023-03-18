using Shared.Dtos;

namespace AgileMini.Data;

public class TaskVM
{
    public int Id { get; set; }
    public string Summary { get; set; }
    public string Details { get; set; }
    public TaskState State { get; set; }
    public User? User { get; set; }
    public Project Project { get; set; }
}