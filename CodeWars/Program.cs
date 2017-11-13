using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Kyu7.get_animals_count(34, 11, 6));
            Kyu7.Solve(new List<string> { "abode", "ABc", "xyzD" });
            Console.ReadKey();

            //string uri = "https://sports.betway.com/en/sports";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            //Console.WriteLine(reader.ReadToEnd());
            //Console.ReadLine();
        }
    }
}
