/* Alex Gann
 CPT-206-A01S
 Lab 1 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexGann_CPT_206_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // The following line allows us to use the LINQ to SQL generated data set
            ProductDBDataSet productDBDataSet = new ProductDBDataSet();
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
        }

        private void SearchProductNumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /* The following code empties the text boxes and sets one or the other to
             writable, based on which radio button is clicked. Since there are only two
             radio buttons, we can assume one or the other is checked, and therefore can
             cheat a bit by only 'checking' one of them. */
            if (SearchProductNumRadioButton.Checked)
            {
                SearchProductNumTextBox.Text = string.Empty;
                SearchProductNumTextBox.BackColor = Color.IndianRed;
                SearchProductNumTextBox.ReadOnly = false;
                SearchDescriptionTextBox.Text = string.Empty;
                SearchDescriptionTextBox.BackColor = Color.Brown;
                SearchDescriptionTextBox.ReadOnly = true;
                SearchProductNumTextBox.Focus();
            }
            else
            {
                SearchProductNumTextBox.Text = string.Empty;
                SearchProductNumTextBox.BackColor = Color.Brown;
                SearchProductNumTextBox.ReadOnly = true;
                SearchDescriptionTextBox.Text = string.Empty;
                SearchDescriptionTextBox.BackColor = Color.IndianRed;
                SearchDescriptionTextBox.ReadOnly = false;
                SearchDescriptionTextBox.Focus();
            }
        }

        private void QuantityMoreThanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // See the prior function's comment, this is comparable
            if (QuantityMoreThanRadioButton.Checked)
            {
                QuantityMoreThanTextBox.Text = string.Empty;
                QuantityMoreThanTextBox.BackColor = Color.IndianRed;
                QuantityMoreThanTextBox.ReadOnly = false;
                QuantityLessThanTextBox.Text = string.Empty;
                QuantityLessThanTextBox.BackColor = Color.Brown;
                QuantityLessThanTextBox.ReadOnly = true;
                QuantityMoreThanTextBox.Focus();
            }
            else
            {
                QuantityMoreThanTextBox.Text = string.Empty;
                QuantityMoreThanTextBox.BackColor = Color.Brown;
                QuantityMoreThanTextBox.ReadOnly = true;
                QuantityLessThanTextBox.Text = string.Empty;
                QuantityLessThanTextBox.BackColor = Color.IndianRed;
                QuantityLessThanTextBox.ReadOnly = false;
                QuantityLessThanTextBox.Focus();
            }
        }

        private void PriceMoreThanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // See the prior function's comment, this is comparable
            if (PriceMoreThanRadioButton.Checked)
            {
                PriceMoreThanTextBox.Text = string.Empty;
                PriceMoreThanTextBox.BackColor = Color.IndianRed;
                PriceMoreThanTextBox.ReadOnly = false;
                PriceLessThanTextBox.Text = string.Empty;
                PriceLessThanTextBox.BackColor = Color.Brown;
                PriceLessThanTextBox.ReadOnly = true;
                PriceMoreThanTextBox.Focus();
            }
            else
            {
                PriceMoreThanTextBox.Text = string.Empty;
                PriceMoreThanTextBox.BackColor = Color.Brown;
                PriceMoreThanTextBox.ReadOnly = true;
                PriceLessThanTextBox.Text = string.Empty;
                PriceLessThanTextBox.BackColor = Color.IndianRed;
                PriceLessThanTextBox.ReadOnly = false;
                PriceLessThanTextBox.Focus();
            }
        }

        private void SearchProductNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* The folloing if statement lets us do a limited form of input validation,
             by ensuring the users cannot enter any character that is not a digit or dash */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void MoreThanSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // See the prior function, but this only allows digits, no dashes
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void LessThanSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // See the prior function
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PriceMoreThanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The following code allows only digits and a single period/point
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (PriceMoreThanTextBox.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void PriceLessThanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The following code allows only digits and a single period/point
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (PriceLessThanTextBox.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void ItemSearchButton_Click(object sender, EventArgs e)
        {
            /* Similar to the comment in 'SearchProductNumRadioButton_CheckedChanged',
             this function checks if one of the two radio buttons is on or off, assuming
             the other will be checked if the one isn't, and activates a search function
             from there. */
            if (SearchProductNumRadioButton.Checked)
            {
                ProductNumSearch(SearchProductNumTextBox.Text);
            }
            else
            {
                ProductDescSearch(SearchDescriptionTextBox.Text);
            }
        }

        private void QuantitySearchButton_Click(object sender, EventArgs e)
        {
            // See the prior function's comment, this is comparable
            if (QuantityMoreThanRadioButton.Checked)
            {
                QuantityMoreThanSearch(QuantityMoreThanTextBox.Text);
            }
            else
            {
                QuantityLessThanSearch(QuantityLessThanTextBox.Text);
            }
        }

        private void PriceSearchButton_Click(object sender, EventArgs e)
        {
            // See the prior function's comment, this is comparable
            if (PriceMoreThanRadioButton.Checked)
            {
                PriceMoreThanSearch(PriceMoreThanTextBox.Text);
            }
            else
            {
                PriceLessThanSearch(PriceLessThanTextBox.Text);
            }
        }

        private void ProductNumSearch(string productNum)
        {
            // Create a LINQ query with productNum as a partial search string
            var results = from product in productDBDataSet.Product
                          where product.Product_Number.Contains(productNum)
                          select product;

            // Put the LINQ query in the DataGridView
            ProductDataGridView.DataSource = results.ToList();
        }

        private void ProductDescSearch(string productDesc)
        {
            // Create a LINQ query with productDesc as a partial search string
            var results = from product in productDBDataSet.Product
                          where product.Description.Contains(productDesc)
                          select product;

            // Put the LINQ query in the DataGridView
            ProductDataGridView.DataSource = results.ToList();
        }

        private void QuantityMoreThanSearch(string moreThan)
        {
            // First, we must convert the string into an int, or provide a zero
            int moreThanNum;
            bool success = int.TryParse(moreThan, out moreThanNum);
            if (!success) { moreThanNum = 0; }

            // Create a LINQ query seeing if Units_On_Hand is greater than the int
            var results = from product in productDBDataSet.Product
                          where product.Units_On_Hand > moreThanNum
                          orderby product.Units_On_Hand
                          select product;

            // Put the LINQ query in the DataGridView
            ProductDataGridView.DataSource = results.ToList();
        }

        private void QuantityLessThanSearch(string lessThan)
        {
            // First, we must convert the string into an int, or provide a zero
            int lessThanNum;
            bool success = int.TryParse(lessThan, out lessThanNum);
            if (!success) { lessThanNum = 0; }
            /* The UX brain in me wants to put an arbitrarily high number instead,
             so an empty bar results in getting the entire table, but I'm not sure
             how arbitrarily high the number should be and I'm also not sure if that's
             necessarily a better 'expected performance' in this case */

            // Create a LINQ query seeing if Units_On_Hand is lesser than the int
            var results = from product in productDBDataSet.Product
                          where product.Units_On_Hand < lessThanNum
                          orderby product.Units_On_Hand
                          select product;

            // Put the LINQ query in the DataGridView
            ProductDataGridView.DataSource = results.ToList();
        }

        private void PriceMoreThanSearch(string moreThan)
        {
            // First, we must convert the string into a double, or provide a zero
            decimal moreThanNum;
            bool success = decimal.TryParse(moreThan, out moreThanNum);
            if (!success) { moreThanNum = 0.0M; }

            // Create a LINQ query seeing if Units_On_Hand is greater than the int
            var results = from product in productDBDataSet.Product
                          where product.Price > moreThanNum
                          orderby product.Price
                          select product;

            // Put the LINQ query in the DataGridView
            ProductDataGridView.DataSource = results.ToList();
        }

        private void PriceLessThanSearch(string lessThan)
        {
            // First, we must convert the string into a decimal, or provide a zero
            decimal lessThanNum;
            bool success = decimal.TryParse(lessThan, out lessThanNum);
            if (!success) { lessThanNum = 0.0M; }
            // Same dilemma as the comment in QuantityLessThanSearch

            // Create a LINQ query seeing if Units_On_Hand is greater than the int
            var results = from product in productDBDataSet.Product
                          where product.Price < lessThanNum
                          orderby product.Price
                          select product;

            // Put the LINQ query in the DataGridView
            ProductDataGridView.DataSource = results.ToList();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
