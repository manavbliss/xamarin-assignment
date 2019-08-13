using System;
namespace Foodatory1.Models
{
    public class Inventory

    {
        public string name { get; set; }
       

        public Inventory()
        {
        }

        public Inventory(string name)
        {
            this.name = name;
        }
    }
}
