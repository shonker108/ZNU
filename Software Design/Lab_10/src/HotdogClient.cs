namespace Lab_10.src
{
    public class HotdogClient : IClient
    {
        public string Name { get; set; }

        public HotdogClient(string name)
        {
            this.Name = name;
        }

        public void OrderFood(Cafe cafe)
        {
            cafe.MakeHotdog(this);
        }
    }
}