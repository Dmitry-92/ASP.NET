namespace TODOlist;

public class TODO
{
    public string Description { get; set; }
    public bool DONE { get; set; }
    public override bool Equals(object? other)
    public DateTime CreatedAt { get; set; } =  DateTime.Now;
    {
        return this.Description.Equals((other as TODO ).Description);
    }
}