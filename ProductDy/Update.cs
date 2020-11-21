using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProductDy
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // WRITE YOUR CODE HERE TO LOAD THE PRODUCT IDs IN THE GIVEN LIST BOX

            MessageBox.Show(" Update form lead Method is not implemented");
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

            /*
             * As mouse clicked on the ListBox- this methods is invoked
             * Take the selected text from the listBox1 as using listBox1.GetItemText(listBox1.SelectedItem)
             * use it in select query to get the corresponding row from the product table, show the row ( Product_Number, description, numberonHand and price)
             * and display them on text boxs
             
             */

            MessageBox.Show(" Mouse Clicked Method is not implemented");


        }


        private void bt_click_update(object sender, EventArgs e)
        {
            //WRITE CODE HERE TO UPDATE information ABOUT a SELECTED PRODUCT.
            /*
             * Get the values from the four textboxs ( as the user updates here)
             * and use update command to set the updated values by the user
             * example update query: update produc set price = 20 where Product_Number= '2343-43';
             * More Update queries at: https://www.w3schools.com/sql/sql_update.asp
             */
            MessageBox.Show(" Update Method is not implemented");

        }
    }
}
