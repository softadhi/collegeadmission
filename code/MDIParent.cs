using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace admission
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addcourse ab = new addcourse();
            ab.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editcourse ab = new Editcourse();
            ab.Show();
        }
    }
}
