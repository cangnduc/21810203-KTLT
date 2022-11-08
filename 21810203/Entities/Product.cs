namespace _21810203.Entities
{
    public struct product
    {
        public int id;
        public string name;
        public double price;
        public int quantity;
        public DateOnly Expiration;
        public bool isDeleted;
    }
    public struct Products
    {
        public string name;
        public List<product> dsach;
    }
}
