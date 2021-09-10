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
        //create 2 pizzas
        Pizza p = new Pizza("small", "pepporoni", "pepperoni");
        Pizza p2 = new Pizza("large", "hawaiian", "pineapple", "ham", "bacon");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pizza p3 = new Pizza("small", "pepporoni", "pepperoni");
            MessageBox.Show(p3.PizzaCount.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = null;
            System.Threading.Thread.Sleep(1000);
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            p = null;
            MessageBox.Show(p2.PizzaCount.ToString());

        }
    }
}
