using NorthWind_WinForm.ProductServiceReference;
using System;
using System.Windows.Forms;

namespace NorthWind_WinForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceOf_ProductDTOClient client = new ServiceOf_ProductDTOClient();
            dataGridView1.DataSource = client.Paging();
            client.Close();
        }
    }
}
