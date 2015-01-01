using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC_BB_Exam_Tool
{
    public partial class poolsettings : Form
    {
        public poolsettings()
        {
            InitializeComponent();
            // Allow drag and dropping onto the pool settings form.
            this.AllowDrop = true;
            // Create event handlers for drag and drop events
            this.DragEnter += new DragEventHandler(poolsettings_DragEnter);
            this.DragDrop += new DragEventHandler(poolsettings_DragDrop);
        }

        void poolsettings_DragEnter(object sender, DragEventArgs e)
        {
            // The drag enter event....
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void poolsettings_DragDrop(object sender, DragEventArgs e)
        {
            // One or more files just got dropped anywhere within this window...
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                // each File is a zip file dropped on this window
                // Exctract each zip file:
                string extractDir = System.IO.Path.GetDirectoryName(file) + "\\" + System.IO.Path.GetFileNameWithoutExtension(file);
                System.IO.Directory.CreateDirectory(extractDir);
                ZipFile.ExtractToDirectory(file, extractDir);
            }
            
        }

        private void poolsettings_Load(object sender, EventArgs e)
        {

        }

    }
}
