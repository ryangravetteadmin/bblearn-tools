using System;
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

    public partial class question_authoring : Form
    {
        public string qAuthorState;
        public string mc_Question;
        public string essay_Question;
        public Boolean choosing_correctanswer;
        static List<string> mc_Answers = new List<string>();
        public int mc_correctAnswer;

        public question_authoring()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void question_authoring_Load(object sender, EventArgs e)
        {

        }

        private void btn_Make_MC_Click(object sender, EventArgs e)
        {
            // short-circuit evaluation
            if ((qAuthorState == "answers_multichoice") && (mc_correctAnswer > 0))
            {
                MessageBox.Show("You did not pick a correct answer. Select an answer for your current question before working on a new one.");
            }
            if (qAuthorState == "answers_multichoice") {
                btnDone_Click(sender, e);
            }
            btnCancel.Visible = true;
            btnSetCorrectAnswer.Visible = true;
            qAuthorState = "start_multichoice";
            lblStatus.Text = "Select new multiple choice question text above.";
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                switch (qAuthorState)
                {
                    case "start_multichoice":
                        // start authoring a multiple choice question by selecting a question
                        mc_Question = richTextBox1.SelectedText;
                        lblStatus.Text = "Select first multiple choice answer using left mouse button. click set correct answer to set the correct answer for the question.";
                        qAuthorState = "answers_multichoice";
                        richTextBox1.DeselectAll();
                        break;
                    case "answers_multichoice":
                        mc_Answers.Add(richTextBox1.SelectedText.Trim());
                        lblStatus.Text = "Select another multiple choice answer using left mouse button. (" + mc_Answers.Count() + " answers so far.)";
                        qAuthorState = "answers_multichoice";
                        richTextBox1.DeselectAll();
                        if (choosing_correctanswer == true)
                        {
                            choosing_correctanswer = false;
                            mc_correctAnswer = mc_Answers.Count();
                            //MessageBox.Show("Correct answer: #" + mc_correctAnswer + " is " + mc_Answers[mc_correctAnswer-1]);
                        }
                        break;
                    case "new_essay":
                        // start authoring a multiple choice question by selecting a question
                        essay_Question = richTextBox1.SelectedText;
                        lblStatus.Text = "Essay question created";
                        qAuthorState = "essay_created";
                        richTextBox1.DeselectAll();
                        break;
                        // qAuthorState variable is set to a string we are unprepared for
                    default:
                        break;

                }
            }
        }

        private void btnSetCorrectAnswer_Click(object sender, EventArgs e)
        {
            if (qAuthorState == "answers_multichoice")
            {
                choosing_correctanswer = true;
                lblStatus.Text = "The next answer you select will be marked as correct";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mc_Answers.Clear();
            qAuthorState = "";
            choosing_correctanswer = false;
            btnCancel.Visible = false;
            btnSetCorrectAnswer.Visible = false;
            lblStatus.Text = "Cancelled. Select new question to create above.";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // perform a short circuit evaluation (&&) - decide if
            // the user was working on a multiple choice question,
            // and if it had a valid answer. If not, alert the user.
            if ((qAuthorState == "answers_multichoice") && (mc_correctAnswer > 0))
            {
                string allanswers = "";
                // Currently authoring a multiple choice question, save it.

                ListViewItem addq = new ListViewItem("Multiple Choice");
                addq.SubItems.Add(mc_Question);
                addq.SubItems.Add(mc_Answers[mc_correctAnswer - 1]);
                // add all possible answers to listview
                foreach (string mcq in mc_Answers)
                {
                    allanswers = allanswers + mcq + ",";
                }
                addq.SubItems.Add(allanswers);
                listView1.Items.Add(addq);

                //
                mc_correctAnswer = -1;
                mc_Answers.Clear();
                btnCancel.Visible = false;
                btnSetCorrectAnswer.Visible = false;
                lblStatus.Text = "";
                qAuthorState = "";
            }
            else
            {
                MessageBox.Show("You did not select an answer for the question you are authoring.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void essayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qAuthorState = "new_essay";
            lblStatus.Text = "Select new essay question.";

        }

        private void question_authoring_KeyDown(object sender, KeyEventArgs e)
        {
            // trigger new multiple choice question
            if (e.KeyCode == Keys.Q) {
                btn_Make_MC_Click(sender, e);
            }
            if (e.KeyCode == Keys.A)
            {
                btnSetCorrectAnswer_Click(sender, e);
            }
            if (e.KeyCode == Keys.D)
            {
                btnDone_Click(sender, e);
            }
            if (e.KeyCode == Keys.C)
            {
                btnCancel_Click(sender, e);
            }

        }

        private void multipleChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Make_MC_Click(sender, e);
        }

        private void saveTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSaveTest.ShowDialog();
            MessageBox.Show(dlgSaveTest.FileName);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            // Get the format for the object type.
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Rtf);
            richTextBox1.Paste(myFormat);
            richTextBox1.ReadOnly = true;
        }

    }
}
