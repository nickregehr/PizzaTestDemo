using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaClassDemo
{

    //access modifier is private by default
    public class Pizza
    {
        public Pizza(string _size, string _name, params string[] toppings)
        {
            this._size = _size;
            this._name = _name;
            this._toppings.AddRange(toppings);

            pizzaCount++;
        }

        ~Pizza()
        {
            pizzaCount--;
            System.Windows.Forms.MessageBox.Show("Destructor called");
        }

        private static int pizzaCount = 0;

        //Fields
        private string _size;
        private string _name;
        private List<string> _toppings = new List<string>();

        //Properties
        public string Name
        {
            get { return _name; }
        }

        public string Size
        {
            get { return _size; }
        }

        public decimal Cost
        {
            get
            {
                decimal tmp = 0;
                //Assign cost based on size
                if (_size == "small")
                    tmp += 4.99m;
                if (_size == "medium")
                    tmp += 7.99m;
                if (_size == "large")
                    tmp += 9.99m;
                //Charge $1.50 per topping
                tmp += _toppings.Count * 1.5m;

                return tmp;
            }
        }

        public int PizzaCount
        {
            get { return pizzaCount; }
        }
    }
}
