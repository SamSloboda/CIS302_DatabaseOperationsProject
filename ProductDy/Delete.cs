using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // WRITE YOUR CODE HERE TO LOAD THE PRODUCT IDs IN THE GIVEN LIST BOX
            MessageBox.Show(" Delete form load Method is not implemented");
        }

        private void bt_Click_delete(object sender, EventArgs e)
        {
            MessageBox.Show(" Delete Method is not implemented");
            // WRITE YOUR CODE HERE TO DELETE THE SELCTED PRODUCT
            // Samle delete query:  delete from product where product_number = "123-34";
            // Query help from : https://www.w3schools.com/sql/sql_delete.asp
        }
    }
}
