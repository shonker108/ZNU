namespace MyStructs
{
    struct User
    {
        public string firstName;
        public string lastName;
        public string email;
    }
    struct Item
    {
        public string name;
        public int count;
        public float pricePerOne;
    }

    struct Order
    {
        public User user;
        public List<Item> items;

        public string shippingAddress;
    }
}