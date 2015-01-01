using System;
using System.Xml;
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
                // at this point we could Exctract each zip file and do things with them, but by enclosing
                // the code in the below if...statement, only the first file will be processed:
                if (files.First() == file)
                {
                    // Read from single zip file
                    string extractDir = System.IO.Path.GetDirectoryName(file) + "\\" + System.IO.Path.GetFileNameWithoutExtension(file);
                    System.IO.Directory.CreateDirectory(extractDir);
                    ZipFile.ExtractToDirectory(file, extractDir);
                    // Create an XML reader for the blackboard manifest file (
                    using (XmlReader xreader = XmlReader.Create(extractDir + "\\imsmanifest.xml"))
                    {
                        while (xreader.Read())
                        {
                            // Look for start of XML elements.
                            switch (xreader.Name)
                            {
                            // ----------------------------------------------------------------
                                case "resource":
                                    //MessageBox.Show("Start of <resource> element.");
                                    string filenameAttribute = xreader["bb:file"]; // File
                                    string filetypeAttribute = xreader["type"];
                                    string filecontentsTitle = xreader["bb:title"];
                                    if (filenameAttribute != null)
                                    {
                                        switch (filetypeAttribute)
                                        {
                                            case "assessment/x-bb-qti-pool":
                                            int questionsInFile;
                                            using (XmlReader questionReader = XmlReader.Create(extractDir + "\\imsmanifest.xml"))
                                            {
                                                while (questionReader.Read())
                                                {
                                                    // Look for start of XML elements.
                                                    switch (questionReader.Name)
                                                    {
                                                        case "presentation":
                                                            int questionsInFile = questionsInFile+1;
                                                            break;
                                                    }
                                                }
                                            }
                                            listBox1.Items.Add("Found and counted questions in pool file: " + extractDir + "\\" + filenameAttribute);
                                            listBox1.Items.Add("     > Contains question pool '" + filecontentsTitle + "' (" + questionsInFile + ") questions.");
                                            break;
                                        }
                                    }
                                    break;
                            // ----------------------------------------------------------------
                            }
                            listBox1.TopIndex = listBox1.Items.Count - 1;
                        }
                    }
                }
            }
        }

        private void poolsettings_Load(object sender, EventArgs e)
        {

        }

    }
}
