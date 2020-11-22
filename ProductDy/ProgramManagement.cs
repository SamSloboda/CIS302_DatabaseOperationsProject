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
    
    
 
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();
        }

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Insert modifyForm = new Insert();
            modifyForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update();
            updateForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Delete deleteForm = new Delete();
            deleteForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ProductDetails display = new ProductDetails();
            display.ShowDialog();

            //Display_Products disp = new Display_Products();
            //disp.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            
        }
    }


    public class DatabaseConnect
    {

        // Connection string: Double click on the database(mdf) file in the solution explorer , then look in the preperties section
        public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sam Sloboda\\source\\repos\\HW_ProductManagement\\ProductDB.mdf;Integrated Security=True";
        DatabaseConnect() { }
        // Connection string for database server
        //String constr = "Server=SBF2D1Z2;Database=PRODUCTDB;Integrated Security=True;";
    }
}
