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
        string poolfile;
        string searchTerm;
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
            //try
            //{
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
                        string extractDir = System.IO.Path.GetDirectoryName(file) + "\\" + System.IO.Path.GetFileNameWithoutExtension(file) + "-gctool";
                        // Atempt to delete directory that question pool was extracted to
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
                                                    int questionsInFile = 0;
                                                    using (XmlReader questionReader = XmlReader.Create(extractDir + "\\" + filenameAttribute))
                                                    {
                                                        while (questionReader.Read())
                                                        {
                                                            // Look for start of XML elements.
                                                            switch (questionReader.Name)
                                                            {
                                                                case "flow":
                                                                    string flowClass = questionReader["class"];
                                                                    // Blackboard keeps each question inside an element that looks like <flow class="QUESTION_BLOCK"....
                                                                    if (string.Equals(flowClass, "question_block", StringComparison.CurrentCultureIgnoreCase))
                                                                    {
                                                                        questionsInFile++;
                                                                    }
                                                                    break;
                                                                default:
                                                                    // no special scenario going on
                                                                    break;
                                                            }
                                                        }
                                                    }
                                                    poolfile = extractDir + "\\" + filenameAttribute;
                                                    listBox1.Items.Add("Found and counted questions in pool file: " + extractDir + "\\" + filenameAttribute);
                                                    listBox1.Items.Add("     > Contains question pool '" + filecontentsTitle + "' (" + questionsInFile + ") questions.");
                                                    panelPool.Visible = true;
                                                    lblNumberOfMultipleChoiceInPool.Text = questionsInFile + " questions in pool '" + filecontentsTitle + "'. Change settings for all:";
                                                    lblStatus.Text = "Working with: " + poolfile;
                                                    // Use a new stream reader to read contents of a file into a string
                                                    StreamReader sr = new StreamReader(poolfile, Encoding.Default);
                                                    // read entire file
                                                    string strz = sr.ReadToEnd();
                                                    // close the stream
                                                    sr.Close();

                                                    // EXAMPLE : http://msdn.microsoft.com/en-us/library/bb546166.aspx
                                                    // (How to use a LINQ query to count # of occurrences of a word in a string)
                                                    //Convert the string (strz) into an array of words 
                                                    string[] source = strz.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                                                    searchTerm = "shuffle=\"YES\"";
                                                    // Create the query.  Use ToLowerInvariant to match "data" and "Data"  
                                                    var matchQuery = from word in source
                                                                     where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                                                                     select word;
                                                    // Count the matches, which executes the query. 
                                                    int wordCount = matchQuery.Count();
                                                    lblShuffled.Text = wordCount + " of " + questionsInFile + " set to shuffle.";

                                                    
                                                    searchTerm = "<bbmd_partialcredit>true</bbmd_partialcredit>";
                                                    // Create the query.  Use ToLowerInvariant to match "data" and "Data"  
                                                    matchQuery = from word in source
                                                                     where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                                                                     select word;
                                                    // Count the matches, which executes the query. 
                                                    wordCount = matchQuery.Count();
                                                    lblPartialCredit.Text = wordCount + " of " + questionsInFile + " allow partial credit.";
                                                    //
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
            //}
            //catch (Exception err) {
                // do nothing for right now. most errors will be related to wrong files dropped.
            //}
        }

        private void poolsettings_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelPool_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
