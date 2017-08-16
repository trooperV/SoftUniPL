using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop") break;
                string email = Console.ReadLine();

                if (email.EndsWith("us", StringComparison.InvariantCultureIgnoreCase) ||
                    email.EndsWith("uk", StringComparison.InvariantCultureIgnoreCase)) continue;

                names[name] = email;
            }

            foreach (var item in names)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
