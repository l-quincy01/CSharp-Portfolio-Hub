namespace Menu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int Price { get; set; }


        public List<DishIngridient>? DishIngridient { get; set; }


    }
}