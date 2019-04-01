namespace burgerShack.Models
{
  abstract class Items
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }

    public Items(string name, string description, float price)
    {
      Name = name;
      Description = description;
      Price = price;
    }
  }
}