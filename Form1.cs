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
        public Form1()
        {
            InitializeComponent();
            Pizza p = new Pizza("small", "pepporoni", "pepperoni");
            MessageBox.Show(p.Cost.ToString());

            Pizza p2 = new Pizza("large", "hawaiian", "pineapple", "ham", "bacon");
            MessageBox.Show(p2.Cost.ToString());
        }

    }
}
