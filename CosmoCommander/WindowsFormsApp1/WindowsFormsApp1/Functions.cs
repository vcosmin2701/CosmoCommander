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
        public void getDrives(ComboBox obj)
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    obj.Items.Add(drive);
                    //obj.Text = Convert.ToString(drive);
                }
            }
        }
    }
}
