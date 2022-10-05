namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; } //was previously Description
    public int Rating { get; set; } //new
    public int Cost { get; set; } //new
    public string Type { get; set; }//new
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}