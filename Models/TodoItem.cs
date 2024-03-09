namespace webapi_todo.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long AssigneeUserId { get; set; }
    public bool IsDone { get; set; } = false;
    public DateTime CreatedAt { get; set; }
}
