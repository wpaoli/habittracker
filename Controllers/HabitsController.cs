using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HabitTracker.Models;
using HabitTracker;

namespace HabitTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HabitsController : ControllerBase
{
    private readonly HabitTrackerDbContext _db;

    public HabitsController(HabitTrackerDbContext db)
    {
        _db = db;
    }

    [HttpPost]
    public async Task<IActionResult> CreateHabit([FromBody] Habit habit)
    {
        _db.Habits.Add(habit);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(CreateHabit), new { id = habit.Id }, habit);
    }

[HttpGet]
public async Task<IActionResult> GetHabits()
{
    var habits = await _db.Habits.ToListAsync();
    return Ok(habits);
}


}
