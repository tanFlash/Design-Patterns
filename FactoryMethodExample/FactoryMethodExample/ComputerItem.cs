using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    public class ComputerItem
    {
        string name;
        string character;
        string description;
        double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Character
        {
            get { return character; }
            set { character = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new System.Exception("The price cannot be lower than 0");
                price = value;
            }
        }

        public ComputerItem()
        {
            Name = "unknown";
            Character = "unknown";
            Description = "unknown";
            Price = 0.0;
        }

        public ComputerItem(string name, string character, string description, double price)
        {
            Name = name;
            Character = character;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return Name + " " + Character + " " + Description + " " + Price + " grn";
        }
    }
}
