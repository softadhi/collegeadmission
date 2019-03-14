using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace admission
{
    public partial class addcourse : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-T05F7OC;Initial Catalog=admission;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public addcourse()
        {
            InitializeComponent();
        }
        void fillcombo()
        {
            cn.Open();
            string query = "select * from addcourse1";
            SqlDataAdapter sda = new SqlDataAdapter(query,cn);
            SqlDataReader myreader;
            try
            {
                cn.Open();
                myreader = 
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
            

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
