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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poolsettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPool = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPartialCredit = new System.Windows.Forms.Label();
            this.lblShuffled = new System.Windows.Forms.Label();
            this.btnSavePool = new System.Windows.Forms.Button();
            this.chkAllowPartialCredit = new System.Windows.Forms.CheckBox();
            this.chkRandomizeAnswerOrder = new System.Windows.Forms.CheckBox();
            this.cmbAnswerOrientation = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNumType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNumberOfMultipleChoiceInPool = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPool.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panelPool.Controls.Add(this.label6);
            this.panelPool.Controls.Add(this.label5);
            this.panelPool.Controls.Add(this.lblPartialCredit);
            this.panelPool.Controls.Add(this.lblShuffled);
            this.panelPool.Controls.Add(this.btnSavePool);
            this.panelPool.Controls.Add(this.chkAllowPartialCredit);
            this.panelPool.Controls.Add(this.chkRandomizeAnswerOrder);
            this.panelPool.Controls.Add(this.cmbAnswerOrientation);
            this.panelPool.Controls.Add(this.label4);
            this.panelPool.Controls.Add(this.cmbNumType);
            this.panelPool.Controls.Add(this.label3);
            this.panelPool.Controls.Add(this.lblStatus);
            this.panelPool.Controls.Add(this.lblNumberOfMultipleChoiceInPool);
            this.panelPool.Location = new System.Drawing.Point(11, 58);
            this.panelPool.Name = "panelPool";
            this.panelPool.Size = new System.Drawing.Size(741, 344);
            this.panelPool.TabIndex = 2;
            this.panelPool.Visible = false;
            this.panelPool.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPool_Paint);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(628, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "The standard or most usual question settings for your institution are pre-picked." +
    "";
            // 
            // lblPartialCredit
            // 
            this.lblPartialCredit.AutoSize = true;
            this.lblPartialCredit.Location = new System.Drawing.Point(62, 105);
            this.lblPartialCredit.Name = "lblPartialCredit";
            this.lblPartialCredit.Size = new System.Drawing.Size(121, 13);
            this.lblPartialCredit.TabIndex = 12;
            this.lblPartialCredit.Text = "n of q allow partial credit";
            // 
            // lblShuffled
            // 
            this.lblShuffled.AutoSize = true;
            this.lblShuffled.Location = new System.Drawing.Point(62, 81);
            this.lblShuffled.Name = "lblShuffled";
            this.lblShuffled.Size = new System.Drawing.Size(74, 13);
            this.lblShuffled.TabIndex = 11;
            this.lblShuffled.Text = "n of q shuffled";
            // 
            // btnSavePool
            // 
            this.btnSavePool.Location = new System.Drawing.Point(51, 291);
            this.btnSavePool.Name = "btnSavePool";
            this.btnSavePool.Size = new System.Drawing.Size(634, 46);
            this.btnSavePool.TabIndex = 10;
            this.btnSavePool.Text = "Save changes to all questions";
            this.btnSavePool.UseVisualStyleBackColor = true;
            this.btnSavePool.Click += new System.EventHandler(this.btnSavePool_Click);
            // 
            // chkAllowPartialCredit
            // 
            this.chkAllowPartialCredit.AutoSize = true;
            this.chkAllowPartialCredit.Location = new System.Drawing.Point(102, 254);
            this.chkAllowPartialCredit.Name = "chkAllowPartialCredit";
            this.chkAllowPartialCredit.Size = new System.Drawing.Size(111, 17);
            this.chkAllowPartialCredit.TabIndex = 9;
            this.chkAllowPartialCredit.Text = "Allow partial credit";
            this.chkAllowPartialCredit.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeAnswerOrder
            // 
            this.chkRandomizeAnswerOrder.AutoSize = true;
            this.chkRandomizeAnswerOrder.Location = new System.Drawing.Point(102, 224);
            this.chkRandomizeAnswerOrder.Name = "chkRandomizeAnswerOrder";
            this.chkRandomizeAnswerOrder.Size = new System.Drawing.Size(160, 17);
            this.chkRandomizeAnswerOrder.TabIndex = 8;
            this.chkRandomizeAnswerOrder.Text = "Randomize order of answers";
            this.chkRandomizeAnswerOrder.UseVisualStyleBackColor = true;
            // 
            // cmbAnswerOrientation
            // 
            this.cmbAnswerOrientation.ContextMenuStrip = this.contextMenuStrip1;
            this.cmbAnswerOrientation.FormattingEnabled = true;
            this.cmbAnswerOrientation.Items.AddRange(new object[] {
            "Vertical (one answer option per line)",
            "Horizontal (answer options will be on one line)"});
            this.cmbAnswerOrientation.Location = new System.Drawing.Point(198, 190);
            this.cmbAnswerOrientation.Name = "cmbAnswerOrientation";
            this.cmbAnswerOrientation.Size = new System.Drawing.Size(263, 21);
            this.cmbAnswerOrientation.TabIndex = 5;
            this.cmbAnswerOrientation.Text = "Vertical (one answer option per line)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Tag = "dummy menu strip assigned to answer orientation and numbering type boxes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Answer orientation:";
            // 
            // cmbNumType
            // 
            this.cmbNumType.ContextMenuStrip = this.contextMenuStrip1;
            this.cmbNumType.FormattingEnabled = true;
            this.cmbNumType.Items.AddRange(new object[] {
            "Uppercase Letters (A...B...C...)",
            "Lowercase Letters (a...b...c...)",
            "Arabic Numerals (1...2...3...)",
            "Roman Numerals (I...II...III...)",
            "none (no labels for answers)"});
            this.cmbNumType.Location = new System.Drawing.Point(198, 159);
            this.cmbNumType.Name = "cmbNumType";
            this.cmbNumType.Size = new System.Drawing.Size(263, 21);
            this.cmbNumType.TabIndex = 3;
            this.cmbNumType.Text = "Uppercase Letters (A...B...C...)";
            this.cmbNumType.SelectedIndexChanged += new System.EventHandler(this.cmbNumType_SelectedIndexChanged);
            this.cmbNumType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNumType_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numbering type:";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(6, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(726, 51);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "label3";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberOfMultipleChoiceInPool
            // 
            this.lblNumberOfMultipleChoiceInPool.AutoSize = true;
            this.lblNumberOfMultipleChoiceInPool.Location = new System.Drawing.Point(62, 55);
            this.lblNumberOfMultipleChoiceInPool.Name = "lblNumberOfMultipleChoiceInPool";
            this.lblNumberOfMultipleChoiceInPool.Size = new System.Drawing.Size(98, 13);
            this.lblNumberOfMultipleChoiceInPool.TabIndex = 0;
            this.lblNumberOfMultipleChoiceInPool.Text = "n Questions in Pool";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(728, 8);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(24, 35);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 422);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(729, 121);
            this.listBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(3, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(726, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Set new options below:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // poolsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 412);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panelPool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "poolsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblNumberOfMultipleChoiceInPool;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkAllowPartialCredit;
        private System.Windows.Forms.CheckBox chkRandomizeAnswerOrder;
        private System.Windows.Forms.ComboBox cmbAnswerOrientation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNumType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSavePool;
        private System.Windows.Forms.Label lblPartialCredit;
        private System.Windows.Forms.Label lblShuffled;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
    }
}