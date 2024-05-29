using System.ComponentModel;

namespace Assignment3._4
{
    public partial class Form1 : Form
    {
        BindingList<Coffee> coffees = new BindingList<Coffee>();
        

        public Form1()
        {
            InitializeComponent();
            CoffeeListBox.DataSource = coffees;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee(SizeBox.Text,TemperatureBox.Text, StrengthBox.Text);
            coffees.Add(coffee);
        }
    }
}
