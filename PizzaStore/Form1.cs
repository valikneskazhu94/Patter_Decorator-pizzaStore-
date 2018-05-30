using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public abstract class Pizza
        {

            public string description = "Unknown Pizza";

            public abstract double cost();
            public virtual string getDescription()
            {
                return description;
            }
        }
        public class BulgarianPizza : Pizza
        {
            public BulgarianPizza()
            {
                description = "Bulgarian Pizza";
            }
            public override double cost()
            {
                return 5.99;
            }
        }
        public class ItalianPizza : Pizza
        {
            public ItalianPizza ()
            {
                description = "Italian Pizza";
            }
            public override double cost ()
            {
                return 6.19;
            }
             

        }
        
        public abstract class ConditionDecorator : Pizza
        {

            protected Pizza pizza = null;
            public ConditionDecorator(Pizza pizza)
            {
                this.pizza = pizza;
            }

        }
        public class Cheese : ConditionDecorator
        {
            public Cheese(Pizza pizza) : base(pizza)
            {
            }

            public override double cost()
            {
                return .31 + pizza.cost();
            }

            public override string getDescription()
            {
                return pizza.getDescription() ;
            }
        }
        public class Pineapple : ConditionDecorator
        {
            public Pineapple(Pizza pizza) : base(pizza) { }

            public override double cost()
            {
                return .20 + pizza.cost();
            }

            public override string getDescription()
            {
                return pizza.getDescription();
            }
        }
        public class Olives : ConditionDecorator
        {
            public Olives(Pizza pizza) : base(pizza) { }

            public override double cost()
            {
                return .10 + pizza.cost();
            }

            public override string getDescription()
            {
                return pizza.getDescription() ;
            }
        }
        public class Mushrooms : ConditionDecorator
        {
            public Mushrooms(Pizza pizza) : base(pizza) { }

            public override double cost()
            {
                return .7 + pizza.cost();
            }

            public override string getDescription()
            {
                return pizza.getDescription();
            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Pizza italian  = new ItalianPizza();
            Pizza bulgarian = new BulgarianPizza();
           
            //Mocha mocha = new Mocha(bevarage);
            //Milk milk = new Milk();
            if (comboBox1.SelectedItem.ToString() ==italian.getDescription())
            {
                checkBox1.Enabled = true; 
                checkBox2.Enabled = true; 
                checkBox3.Enabled = true; 
                checkBox4.Enabled = true;
                label2.Text = italian.getDescription() + ": " + italian.cost();
            }
          if (comboBox1.SelectedItem.ToString() == bulgarian.getDescription())
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                label2.Text=bulgarian.getDescription() + ": " + bulgarian.cost();
                
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
