namespace AgileMini.Data;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }
    public ProjectState State { get; set; }
    
}

public enum ProjectState
{
    New,
    Started,
    Closed,
    OnSupport
}