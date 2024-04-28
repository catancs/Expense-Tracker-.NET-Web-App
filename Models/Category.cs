namespace ToDo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Marking Name as nullable

        // Other properties or navigation properties if necessary

    public List<Expense> Expenses { get; set; } = new List<Expense>();
    public List<Income> Incomes { get; set; } = new List<Income>();

    }
}
