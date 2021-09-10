using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaClassDemo
{
    public partial class Form1 : Form
    {
        Pizza p = new Pizza("small", "pepporoni", "pepperoni");
        public Form1()
        {
            InitializeComponent();
            //create 2 pizzas
            Pizza p2 = new Pizza("large", "hawaiian", "pineapple", "ham", "bacon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pizza p3 = new Pizza("small", "pepporoni", "pepperoni");
            MessageBox.Show(p3.PizzaCount.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.PizzaCount.ToString());

        }
    }
}
