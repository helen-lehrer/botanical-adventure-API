namespace BotanicalAdventure.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Category { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Latin { get; set; }
    public string Description { get; set; }
    public string Habitat { get; set; }
    public string Smell { get; set; }
    public string Taste { get; set; }
    public bool Edible { get; set; }
    public string EdibleDesc { get; set; }
    public string Symbolism { get; set; }
    public string History { get; set; }
    public int Score { get; set; }
    public string Hint { get; set; }
    public string Difficulty { get; set; }
    public bool Found { get; set; }
    public string Picture { get; set; }
  }
}