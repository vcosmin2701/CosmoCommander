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

        private void Form1_Load(object sender, EventArgs e)
        {
            func.getSystemDrives(driveB1);
            func.getSystemDrives(driveB2);
            
        }


        /*------GROUP 1------*/

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            func.getDriveInfo(driveB1, listBox1);
        }
        
        private void driveB1_SelectedIndexChanged(object sender, EventArgs e)
        {

            func.getDriveInfo(driveB1, listBox1);
        }

        private void driveB1_SelectedValueChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
        }

        /*------GROUP 1------*/


        /*------GROUP 2------*/

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            func.getDriveInfo(driveB2, listBox2);

        }
        
        private void driveB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            func.getDriveInfo(driveB2, listBox2);
        }

        private void driveB2_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        /*------GROUP 2------*/
    }
}
