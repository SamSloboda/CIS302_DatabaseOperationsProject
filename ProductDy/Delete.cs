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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting

            String sel = "select * from Product";  // Create the SQL query to be executed
            SqlDataAdapter Da = new SqlDataAdapter(sel, con); // Create the tableAdapter/ dataAdapter
            DataSet ds = new DataSet();  // Need the Dataset to populate data from the table

            Da.Fill(ds, "QueryResult_products"); // Lead query result in the dataset- given a table name 'QueryResult_products', a dataset can have multiple such table/query resutl

            listBox1.DataSource = ds.Tables["QueryResult_products"];
            listBox1.DisplayMember = "Description";

            con.Close();
        }

        private void refreshListBox(SqlConnection con) 
        {
            String sel = "select * from Product";  // Create the SQL query to be executed
            SqlDataAdapter Da = new SqlDataAdapter(sel, con); // Create the tableAdapter/ dataAdapter
            DataSet ds = new DataSet();  // Need the Dataset to populate data from the table

            Da.Fill(ds, "QueryResult_products"); // Lead query result in the dataset- given a table name 'QueryResult_products', a dataset can have multiple such table/query resutl

            listBox1.DataSource = ds.Tables["QueryResult_products"];
            listBox1.DisplayMember = "Description";
        }

        private void bt_Click_delete(object sender, EventArgs e)
        {
            //MessageBox.Show(" Delete Method is not implemented");
            // WRITE YOUR CODE HERE TO DELETE THE SELCTED PRODUCT
            // Samle delete query:  delete from product where product_number = "123-34";
            // Query help from : https://www.w3schools.com/sql/sql_delete.asp

            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            String curItem = drv["Product_Number"].ToString();


            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand(); // Need to execute the query
            try
            {
                //form the SQL insert query using the given data
                string query = "delete from Product where Product_Number = '"+ curItem+"'";
                cmd.CommandText = query;
                con.Open(); // open the Database connection for insertion when done must close the connection to avoid issues
                Int32 returnFlag = (Int32)cmd.ExecuteNonQuery(); // execute the query, the function returns 0 if the insertion unsuccessful
                if (returnFlag > 0)
                    refreshListBox(con);
                else
                    MessageBox.Show("Something went wrong");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                con.Close();


            }

        }
    }
}
