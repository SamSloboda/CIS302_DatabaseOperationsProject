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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // IN this function, a new product information is inserted in the product table using inertion query of SQL

            // Get the data provided by the user, you should validate is a certiain field is empty, say productID must be given
            string productNo = txtProductNo.Text;
            string description = txtProductDes.Text;
            int NOHands = int.Parse(txtProductOH.Text);
            decimal price = decimal.Parse(txtProductPrice.Text);

            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand(); // Need to execute the query
            try
            {
                //form the SQL insert query using the given data
                string query = "insert into Product values('" + productNo + "','" + description + "'," + NOHands + "," + price + ")";
                cmd.CommandText = query;
                con.Open(); // open the Database connection for insertion when done must close the connection to avoid issues
                Int32 returnFlag = (Int32)cmd.ExecuteNonQuery(); // execute the query, the function returns 0 if the insertion unsuccessful
                if (returnFlag > 0)
                    MessageBox.Show("Inserted Successfully");
                else
                    MessageBox.Show("Something went wrong");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                con.Close();


            }


        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductOH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
