namespace TransactionTracker;

public class Expense
{
    private static double Amount { get; set; }
    private bool IsIncome { get; set; }
    public bool IsRecurring { get; set; }
    private Catagory _catagory;
    private string? Name { get; set; }
    private DateTime Date { get; set; }
}