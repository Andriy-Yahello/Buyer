using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyer
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection mycol = new NameValueCollection();
            mycol.Add("Ben", "ball");
            mycol.Add("Ben", "jersey");
            mycol.Add("Ben", "car");
            mycol.Add("Roy", "car");
            mycol.Add("Sam", "car");
            mycol.Add("Sam", "ball");
            mycol.Add("Kim", "wallet");
            mycol.Add("Rob", "tv");
            mycol.Add("Rob", "player");
            mycol.Add("Jeff", "player");
            mycol.Add("Jeff", "car");

            PrintKeyAndValues(mycol);

            Console.WriteLine(new string('-', 40));

            PrintKeyAndValues2(mycol, "Jeff");

            Console.WriteLine(new string('-', 40));

            PrintValuesAndKeys(mycol, "player");

            Console.ReadKey();
        }

        public static void PrintKeyAndValues(NameValueCollection mycol)
        {
            foreach (var item in mycol.AllKeys)
            {
                Console.WriteLine("{0} - {1}", item, mycol[item]);
            }
        }

        public static void PrintKeyAndValues2(NameValueCollection mycol, string value)
        {
            foreach (var item in mycol.AllKeys)
            {
                if(item == value)
                Console.WriteLine("{0} - {1}", item, mycol[item]);
            }
        }


        public static void PrintValuesAndKeys(NameValueCollection mycol, string value)
        {
            Console.Write("{0} - ", value);
            foreach (string item in mycol.AllKeys)
            {
                if (mycol[item].Contains( value))
                {
                    Console.Write("{0},", item);
                }
                
            }
        }
    }
}
