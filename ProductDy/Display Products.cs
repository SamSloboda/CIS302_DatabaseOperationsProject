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
    public partial class Display_Products : Form
    {
        public Display_Products()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            

            
        }

        private void Display_Products_Load(object sender, EventArgs e)
        {

            // WRITE YOUR CODE HERE TO LOAD THE PRODUCT IDs IN THE GIVEN LIST BOX

            listView1.Columns.Add("Product Number", 100);
            listView1.Columns.Add("Description", 150);
            listView1.Columns.Add("Units on Hand", 70);
            listView1.Columns.Add("Price", 70);
            
            listView1.View = View.Details;

            
            

            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting

            String sel = "select * from Product";  // Create the SQL query to be executed
            SqlDataAdapter Da = new SqlDataAdapter(sel, con); // Create the tableAdapter/ dataAdapter
            DataSet ds = new DataSet();  // Need the Dataset to populate data from the table
            DataTable dt;

            Da.Fill(ds, "QueryResult_products"); // Lead query result in the dataset- given a table name 'QueryResult_products', a dataset can have multiple such table/query resutl


            dt = ds.Tables["QueryResult_products"];
            con.Close();
            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }
    }
}
