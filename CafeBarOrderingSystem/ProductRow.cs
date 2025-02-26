namespace CafeBarOrderingSystem
{
    public class ProductRow
    {
        public Product product;
        public int quantity;
        public string description;

        public ProductRow(Product product, int quantity, string description)
        {
            this.product = product;
            this.quantity = quantity;
            this.description = description;
        }
    }
}
