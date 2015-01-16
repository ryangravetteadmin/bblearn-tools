namespace GC_BB_Exam_Tool
{
    partial class question_authoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSetCorrectAnswer = new System.Windows.Forms.Button();
            this.btn_Make_MC = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFileOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuAddQuestions = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.essayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSaveTest = new System.Windows.Forms.SaveFileDialog();
            this.btnPaste = new System.Windows.Forms.Button();
            this.pnlOptions.SuspendLayout();
            this.mnuAddQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(711, 208);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(12, 363);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 161);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Question Type";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Question Text";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Correct Answer";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Possible Answers";
            this.columnHeader4.Width = 246;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author your exam in a Word processor, copy all the questions and click the paste " +
    "button to the right.";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(12, 325);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(712, 35);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Select new question to create above.";
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.btnDone);
            this.pnlOptions.Controls.Add(this.btnSetCorrectAnswer);
            this.pnlOptions.Controls.Add(this.btn_Make_MC);
            this.pnlOptions.Controls.Add(this.btnCancel);
            this.pnlOptions.Location = new System.Drawing.Point(12, 266);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(711, 49);
            this.pnlOptions.TabIndex = 6;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Silver;
            this.btnDone.Location = new System.Drawing.Point(548, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(162, 38);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done (D)";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSetCorrectAnswer
            // 
            this.btnSetCorrectAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetCorrectAnswer.Location = new System.Drawing.Point(171, 3);
            this.btnSetCorrectAnswer.Name = "btnSetCorrectAnswer";
            this.btnSetCorrectAnswer.Size = new System.Drawing.Size(162, 38);
            this.btnSetCorrectAnswer.TabIndex = 6;
            this.btnSetCorrectAnswer.Text = "Set Correct Answer (A)";
            this.btnSetCorrectAnswer.UseVisualStyleBackColor = false;
            this.btnSetCorrectAnswer.Visible = false;
            this.btnSetCorrectAnswer.Click += new System.EventHandler(this.btnSetCorrectAnswer_Click);
            // 
            // btn_Make_MC
            // 
            this.btn_Make_MC.BackColor = System.Drawing.Color.Silver;
            this.btn_Make_MC.Location = new System.Drawing.Point(3, 3);
            this.btn_Make_MC.Name = "btn_Make_MC";
            this.btn_Make_MC.Size = new System.Drawing.Size(162, 38);
            this.btn_Make_MC.TabIndex = 5;
            this.btn_Make_MC.Text = "New Multiple Choice (Q)";
            this.btn_Make_MC.UseVisualStyleBackColor = false;
            this.btn_Make_MC.Click += new System.EventHandler(this.btn_Make_MC_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(339, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 38);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel Question (C)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFileOutput
            // 
            this.txtFileOutput.Location = new System.Drawing.Point(742, 27);
            this.txtFileOutput.Multiline = true;
            this.txtFileOutput.Name = "txtFileOutput";
            this.txtFileOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFileOutput.Size = new System.Drawing.Size(435, 523);
            this.txtFileOutput.TabIndex = 7;
            this.txtFileOutput.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File output preview:";
            // 
            // mnuAddQuestions
            // 
            this.mnuAddQuestions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addQuestionsToolStripMenuItem});
            this.mnuAddQuestions.Location = new System.Drawing.Point(0, 0);
            this.mnuAddQuestions.Name = "mnuAddQuestions";
            this.mnuAddQuestions.Size = new System.Drawing.Size(1033, 24);
            this.mnuAddQuestions.TabIndex = 9;
            this.mnuAddQuestions.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTestToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTestToolStripMenuItem
            // 
            this.saveTestToolStripMenuItem.Name = "saveTestToolStripMenuItem";
            this.saveTestToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveTestToolStripMenuItem.Text = "&Save Test";
            this.saveTestToolStripMenuItem.Click += new System.EventHandler(this.saveTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "E&xit (no saving)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addQuestionsToolStripMenuItem
            // 
            this.addQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multipleChoiceToolStripMenuItem,
            this.essayToolStripMenuItem});
            this.addQuestionsToolStripMenuItem.Name = "addQuestionsToolStripMenuItem";
            this.addQuestionsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.addQuestionsToolStripMenuItem.Text = "&Add Questions";
            // 
            // multipleChoiceToolStripMenuItem
            // 
            this.multipleChoiceToolStripMenuItem.Name = "multipleChoiceToolStripMenuItem";
            this.multipleChoiceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.multipleChoiceToolStripMenuItem.Text = "Multiple &Choice";
            this.multipleChoiceToolStripMenuItem.Click += new System.EventHandler(this.multipleChoiceToolStripMenuItem_Click);
            // 
            // essayToolStripMenuItem
            // 
            this.essayToolStripMenuItem.Name = "essayToolStripMenuItem";
            this.essayToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.essayToolStripMenuItem.Text = "&Essay";
            this.essayToolStripMenuItem.Click += new System.EventHandler(this.essayToolStripMenuItem_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(579, 22);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(143, 28);
            this.btnPaste.TabIndex = 10;
            this.btnPaste.TabStop = false;
            this.btnPaste.Text = "Paste (overwrite)";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // question_authoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 532);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileOutput);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.mnuAddQuestions);
            this.KeyPreview = true;
            this.Name = "question_authoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Authoring";
            this.Load += new System.EventHandler(this.question_authoring_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.question_authoring_KeyDown);
            this.pnlOptions.ResumeLayout(false);
            this.mnuAddQuestions.ResumeLayout(false);
            this.mnuAddQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnSetCorrectAnswer;
        private System.Windows.Forms.Button btn_Make_MC;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtFileOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip mnuAddQuestions;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleChoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem essayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog dlgSaveTest;
        private System.Windows.Forms.Button btnPaste;
    }
}