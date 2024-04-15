using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace practica4._2
{
    public partial class Form1 : Form
    {
        private List<Fruit> fruitsList = new List<Fruit>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) && !string.IsNullOrWhiteSpace(countryTextBox.Text) && !string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                Fruit newFruit = new Fruit(nameTextBox.Text, countryTextBox.Text, Convert.ToDecimal(priceTextBox.Text));
                fruitsList.Add(newFruit);
                UpdateFruitsDataGridView();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите данные для всех полей.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateFruitsDataGridView()
        {
            fruitsDataGridView.Rows.Clear();
            foreach (var fruit in fruitsList)
            {
                fruitsDataGridView.Rows.Add(fruit.Name, fruit.Country, fruit.Price);
            }
        }

        private void ClearInputFields()
        {
            nameTextBox.Clear();
            countryTextBox.Clear();
            priceTextBox.Clear();
        }

        private class Fruit
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public decimal Price { get; set; }

            public Fruit(string name, string country, decimal price)
            {
                Name = name;
                Country = country;
                Price = price;
            }
        }

        private void fruitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
