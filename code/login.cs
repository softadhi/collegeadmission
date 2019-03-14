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
    public partial class login : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-T05F7OC;Initial Catalog=project;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            cn.Open();
            cmd.CommandText = "select count(*)from project where Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "'";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read()) {

                c = Convert.ToInt32(dr[0].ToString());
            }
            cn.Close();
            if (c != 0)
            {
                MDIParent o = new MDIParent();
                o.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid password or username");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
