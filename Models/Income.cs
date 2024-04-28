namespace ToDo.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string? Source { get; set; } // This makes the property nullable

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
