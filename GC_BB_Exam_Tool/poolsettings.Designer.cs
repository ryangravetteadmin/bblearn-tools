namespace GC_BB_Exam_Tool
{
    partial class poolsettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poolsettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPool = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.QuestionText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numbering = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Orientation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartialCredit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RandomizeAnswers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNumberOfMultipleChoiceInPool = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelPool.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Information:";
            // 
            // panelPool
            // 
            this.panelPool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPool.Controls.Add(this.listView1);
            this.panelPool.Controls.Add(this.lblNumberOfMultipleChoiceInPool);
            this.panelPool.Location = new System.Drawing.Point(11, 58);
            this.panelPool.Name = "panelPool";
            this.panelPool.Size = new System.Drawing.Size(741, 237);
            this.panelPool.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QuestionText,
            this.Numbering,
            this.Orientation,
            this.PartialCredit,
            this.RandomizeAnswers});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(14, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 191);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // QuestionText
            // 
            this.QuestionText.Text = "Question";
            this.QuestionText.Width = 334;
            // 
            // Numbering
            // 
            this.Numbering.Text = "Numbering Style";
            this.Numbering.Width = 94;
            // 
            // Orientation
            // 
            this.Orientation.Text = "Orientation";
            this.Orientation.Width = 84;
            // 
            // PartialCredit
            // 
            this.PartialCredit.Text = "Partial Credit";
            this.PartialCredit.Width = 87;
            // 
            // RandomizeAnswers
            // 
            this.RandomizeAnswers.Text = "Randomize Answers";
            this.RandomizeAnswers.Width = 111;
            // 
            // lblNumberOfMultipleChoiceInPool
            // 
            this.lblNumberOfMultipleChoiceInPool.AutoSize = true;
            this.lblNumberOfMultipleChoiceInPool.Location = new System.Drawing.Point(17, 11);
            this.lblNumberOfMultipleChoiceInPool.Name = "lblNumberOfMultipleChoiceInPool";
            this.lblNumberOfMultipleChoiceInPool.Size = new System.Drawing.Size(173, 13);
            this.lblNumberOfMultipleChoiceInPool.TabIndex = 0;
            this.lblNumberOfMultipleChoiceInPool.Text = "n Multiple Choice Questions in Pool";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(728, 8);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(24, 35);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 301);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(729, 121);
            this.listBox1.TabIndex = 4;
            // 
            // poolsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 432);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panelPool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "poolsettings";
            this.Text = "Question Pool Settings - Multiple Choice";
            this.Load += new System.EventHandler(this.poolsettings_Load);
            this.panelPool.ResumeLayout(false);
            this.panelPool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPool;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader QuestionText;
        private System.Windows.Forms.ColumnHeader Numbering;
        private System.Windows.Forms.ColumnHeader Orientation;
        private System.Windows.Forms.ColumnHeader PartialCredit;
        private System.Windows.Forms.ColumnHeader RandomizeAnswers;
        private System.Windows.Forms.Label lblNumberOfMultipleChoiceInPool;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox listBox1;
    }
}