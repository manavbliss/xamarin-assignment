using System;
namespace Foodatory1.Models
{

    public class Recipe
    {
        public string name { get; set; }
        public string procedure { get; set; }
        public string ingredients { get; set; }

        public Recipe()
        {
        }

        public Recipe(string name, string procedure, string ingredients)
        {
            this.name = name;
            this.procedure = procedure;
            this.ingredients = ingredients;
        }
    }
}
