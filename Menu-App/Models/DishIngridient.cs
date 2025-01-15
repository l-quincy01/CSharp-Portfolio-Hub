namespace Menu.Models
{
    public class DishIngridient
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int IngridentId { get; set; }
        public Ingrident Ingrident { get; set; }
    }
}