using System;
namespace MyMidterm.Models
{
    [Serializable]
    public class Route
    {
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public double Price { get; set; }
        public int DeliveryDays { get; set; }


        public override bool Equals(Object obj) 
        {

            if (obj == null || GetType() != obj.GetType())
                return false;

            Route temp = (Route)obj;
            return temp.FromCity == this.FromCity && temp.ToCity == this.ToCity;
               
        }

        public override int GetHashCode()
        {
            return (FromCity.Length + ToCity.Length) * 1000007;
        }
    }
}
