namespace PZCheeseria.Domain.Entities;

public class Cheese
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal PricePerKilo { get; set; }
    public string ImageName { get; set; }
    public System.DateTime CreatedOn { get; set; }
    public CheeseColour Colour { get; set; }

}

public class CheeseColour
{
    public int Id { get; set; }
    public string Colour { get; set; }
}
