using System;
using System.ComponentModel.DataAnnotations;

namespace MyMidterm.Models
{
    [Serializable]
    public class Item
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        public Item()
        {
            Price = 50;
        }

        public void DefinePrice() 
        {
            switch(Category) 
            {
                case Category.A:
                    Price = Price * 1;
                    break;
                case Category.B:
                    Price = Price * 2;
                    break;
                case Category.C:
                    Price = Price * 3;
                    break;
                case Category.D:
                    Price = Price * 4;
                    break;
                case Category.E:
                    Price = Price * 5;
                    break;
            }
        }

        public Item(string Name) => this.Name = Name;
    }
}