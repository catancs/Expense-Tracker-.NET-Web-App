using Microsoft.EntityFrameworkCore;
using ToDo.Models; // Replace 'to_do' with the actual namespace of your application

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Income> Incomes { get; set; }

    // Add any additional configuration here
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // For example, to configure a one-to-many relationship between Category and Expense
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Expenses)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId);

        // Similar configuration for Income if necessary
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Incomes)
            .WithOne(i => i.Category)
            .HasForeignKey(i => i.CategoryId);
    }
}
