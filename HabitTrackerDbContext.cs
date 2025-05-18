using Microsoft.EntityFrameworkCore;
using HabitTracker.Models;

namespace HabitTracker;

public class HabitTrackerDbContext : DbContext
{
    public HabitTrackerDbContext(DbContextOptions<HabitTrackerDbContext> options)
        : base(options) { }

    public DbSet<Habit> Habits { get; set; }
}
