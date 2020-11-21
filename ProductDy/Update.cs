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

            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting

            refreshListBox(con, "Product_Number");

            con.Close();
        }

        private void refreshListBox(SqlConnection con, String dispMemb)
        {
            String sel = "select * from Product";  // Create the SQL query to be executed
            SqlDataAdapter Da = new SqlDataAdapter(sel, con); // Create the tableAdapter/ dataAdapter
            DataSet ds = new DataSet();  // Need the Dataset to populate data from the table

            Da.Fill(ds, "QueryResult_products"); // Lead query result in the dataset- given a table name 'QueryResult_products', a dataset can have multiple such table/query resutl

            listBox1.DataSource = ds.Tables["QueryResult_products"];
            listBox1.DisplayMember = dispMemb;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

            /*
             * As mouse clicked on the ListBox- this methods is invoked
             * Take the selected text from the listBox1 as using listBox1.GetItemText(listBox1.SelectedItem)
             * use it in select query to get the corresponding row from the product table, show the row ( Product_Number, description, numberonHand and price)
             * and display them on text boxs
             */

            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            txtProductNo.Text = drv["Product_Number"].ToString();
            txtProductDes.Text = drv["Description"].ToString();
            txtProductOH.Text = drv["Units_On_Hand"].ToString();
            txtProductPrice.Text = drv["Price"].ToString();
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
