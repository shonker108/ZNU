namespace Lab_10.src
{
    public class CoffeeClient : IClient
    {
        public string Name { get; set; }

        public CoffeeClient(string name)
        {
            this.Name = name;
        }

        public void OrderFood(Cafe cafe)
        {
            cafe.MakeCoffee(this);
        }
    }
}