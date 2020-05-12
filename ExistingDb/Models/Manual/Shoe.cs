namespace ExistingDb.Models.Manual
{
    public class Shoe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public long ColorId { get; set; }
        public Style Color { get; set; }
    }
}
