public class HabitLog
{
    public int Id { get; set; }
    public int HabitId { get; set; }
    public DateTime Date { get; set; }
    public bool IsCompleted { get; set; } = true;
}
