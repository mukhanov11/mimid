using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMidterm.Models
{
    public enum Status
    {
        Done, Cancelled, OnTheWay, Late
    }

    [Serializable]
    public class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        //public Route Route { get; set; }
        public double Price { get; set; }

        public Order() { }

        public Order(int Id) => this.Id = Id;

    }
}
