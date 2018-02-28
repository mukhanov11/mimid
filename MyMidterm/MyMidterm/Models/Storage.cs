using System;
using System.Collections.Generic;

namespace MyMidterm.Models
{
    [Serializable]
    public class Storage
    {
        public static List<Customer> Customers;
        public static Dictionary<Pair<string, string>, int> Prices;

        public Storage()
        {
            Prices.Add(new Pair<string, string>("Kostanay", "Almaty"), 200);
            Prices.Add(new Pair<string, string>("Kostanay", "Ekibastuz"), 100);
            Prices.Add(new Pair<string, string>("Ekibastuz", "Almaty"), 150);
        }
    }
}
