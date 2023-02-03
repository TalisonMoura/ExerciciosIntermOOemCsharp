namespace ExemploOO21_DictionanyESortedDictionay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["User"] = "Maria";
            cookies["Email"] = "maria@gmail.com";
            cookies["Phone"] = "99712234";
            cookies["Phone"] = "83737388";

            Console.WriteLine(cookies["Email"]);
            Console.WriteLine(cookies["Phone"]);

            cookies.Remove("Email");
            if (cookies.ContainsKey("Email"))
            {
                Console.WriteLine(cookies["Email"]);
            }
            else
            {
                Console.WriteLine("There isn't 'email' key");
            }

            Console.WriteLine($"Size: {cookies.Count}");

            Console.WriteLine("ALL COOKIES:");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}