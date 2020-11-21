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
    
    
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // In this function, the product data are loaded usign table adapter and the dataset
      
            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting


            String sel = "select * from Product";  // Create the SQL query to be executed
            SqlDataAdapter Da = new SqlDataAdapter(sel, con); // Create the tableAdapter/ dataAdapter
            DataSet ds = new DataSet();  // Need the Dataset to populate data from the table

            Da.Fill(ds, "QueryResult_products"); // Lead query result in the dataset- given a table name 'QueryResult_products', a dataset can have multiple such table/query resutl

            ListBox AllDescriptions = new ListBox(); // We want to show all description here in the list box

            AllDescriptions.DataSource = ds.Tables["QueryResult_products"];
            AllDescriptions.DisplayMember = "Description";
            AllDescriptions.Location = new Point(20, 30);
            Label P_description = new Label(); // Want to show the description about the label
            P_description.Text = "Description of the products";
            P_description.Location = new Point(20, 15); // place the label above the list of description
            P_description.AutoSize = true;


            this.Controls.Add(AllDescriptions);
            this.Controls.Add(P_description);

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Here instead of using Table adapter and the Dataset DataReader is used to directly run select queries.

            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom

            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand(); // Need to execute the query

            try  // if there is a problem in connection, it will  catch the exception
            {
                String sel = "select * from Product";  // Create the SQL query to be executed
                cmd.CommandText = sel;
                con.Open(); // open the connection, will throw exception if cannot connect to the server
                SqlDataReader reader = cmd.ExecuteReader(); // 
                DataTable dt = new DataTable();
                dt.Load(reader); // load the data in the Data table through the reader
                // Now bind the data table with the controls I have


                //ListBox Allids = new ListBox(); // We want to show all descriptions here in the list box
                ComboBox Allids = new ComboBox(); // We want to show all descriptions here in the list box

                Allids.DataSource = dt;
                Allids.DisplayMember = "Product_number";
                Allids.Location = new Point(210, 30);
                Label P_Ids = new Label(); // Want to show the description about the label
                P_Ids.Text = "IDs of the products";
                P_Ids.Location = new Point(210, 15); // place the label above the list of description
                P_Ids.AutoSize = true;


                this.Controls.Add(Allids);
                this.Controls.Add(P_Ids);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {

                cmd.Dispose(); // clean ups, all the related the memory allocations
                con.Close();

            }

        }
    }
}
