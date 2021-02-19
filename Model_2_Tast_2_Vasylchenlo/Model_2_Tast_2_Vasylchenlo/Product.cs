namespace Model_2_Tast_2_Vasylchenlo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public TypeCurrency Currency { get; set; }
        public string ImagePath { get; set; }
    }
}
