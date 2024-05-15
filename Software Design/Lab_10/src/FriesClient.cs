namespace Lab_10.src
{
    public class FriesClient : IClient
    {
        public string Name { get; set; }

        public FriesClient(string name)
        {
            this.Name = name;
        }

        public void OrderFood(Cafe cafe)
        {
            cafe.MakeFries(this);
        }
    }
}