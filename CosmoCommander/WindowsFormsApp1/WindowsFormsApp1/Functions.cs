using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Functions
    {
        //private OpenFileDialog openFileDialog1;

        protected internal void getSystemDrives(ComboBox obj)
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                obj.Items.Add(drive);
            }
        }

        protected internal void getDriveInfo(ComboBox comboBox, ListBox list1)
        {
            try
            {
                DriveInfo drive = (DriveInfo)comboBox.SelectedItem;
                foreach(DirectoryInfo dirInfo in drive.RootDirectory.GetDirectories())
                {
                    list1.Items.Add(dirInfo);
                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
