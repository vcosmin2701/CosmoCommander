using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Functions func = new Functions();

        public Form1()
        {
            InitializeComponent();
        }


        private void driveB1_DropDown(object sender, EventArgs e)
        {
            func.getDrives(driveB1);
        }


        private void driveB2_DropDown(object sender, EventArgs e)
        {
            func.getDrives(driveB2);
        }

        private void driveB1_DropDownClosed(object sender, EventArgs e)
        {
            driveB1.Items.Clear();
        }

        private void driveB2_DropDownClosed(object sender, EventArgs e)
        {
            driveB2.Items.Clear();
        }
    }
}
