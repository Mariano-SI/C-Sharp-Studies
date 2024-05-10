using Entities;
using System.Globalization;

namespace Cap15_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Mariano";
            cookies["email"] = "Mariano.silva@ufvjm.edu.br";
            cookies["phone"] = "988539207";
            cookies["phone"] = "35313870";


            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no email key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All Cookies:");
            foreach (KeyValuePair<string, string> cookie in cookies)
            {
                Console.WriteLine(cookie.Key + ": " + cookie.Value);
            }

        }
    }
}
