using Lab_9.src;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Фасад
            Restraunt restraunt = new Restraunt();

            Client client = new Client();

            client.OrderFood(restraunt, "Паста");

            // Замісник
            App app = new App(new SecureLogger("qwerty"));

            app.LogIn("qwerty");

            app.LogIn("123");
            app.LogIn("password");
            app.LogIn("11111");

            app.LogIn("qwerty");
            app.LogIn("qwerty");
            app.LogIn("qwerty");
        }
    }
}
