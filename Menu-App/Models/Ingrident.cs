namespace Menu.Models
{
    public class Ingrident
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<DishIngridient>? DishIngridient { get; set; }
    }
}