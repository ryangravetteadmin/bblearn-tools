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
            this.lblNumberOfMultipleChoiceInPool = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnSavePool = new System.Windows.Forms.Button();
            this.lblShuffled = new System.Windows.Forms.Label();
            this.lblPartialCredit = new System.Windows.Forms.Label();
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
            this.panelPool.Controls.Add(this.lblPartialCredit);
            this.panelPool.Controls.Add(this.lblShuffled);
            this.panelPool.Controls.Add(this.btnSavePool);
            this.panelPool.Controls.Add(this.checkBox2);
            this.panelPool.Controls.Add(this.checkBox1);
            this.panelPool.Controls.Add(this.comboBox2);
            this.panelPool.Controls.Add(this.label4);
            this.panelPool.Controls.Add(this.comboBox1);
            this.panelPool.Controls.Add(this.label3);
            this.panelPool.Controls.Add(this.lblStatus);
            this.panelPool.Controls.Add(this.lblNumberOfMultipleChoiceInPool);
            this.panelPool.Location = new System.Drawing.Point(11, 58);
            this.panelPool.Name = "panelPool";
            this.panelPool.Size = new System.Drawing.Size(741, 285);
            this.panelPool.TabIndex = 2;
            this.panelPool.Visible = false;
            this.panelPool.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPool_Paint);
            // 
            // lblNumberOfMultipleChoiceInPool
            // 
            this.lblNumberOfMultipleChoiceInPool.AutoSize = true;
            this.lblNumberOfMultipleChoiceInPool.Location = new System.Drawing.Point(48, 57);
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
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 362);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(729, 121);
            this.listBox1.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(6, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(726, 32);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "label3";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numbering type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Answer orientation:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(51, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Randomize order of answers";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(51, 182);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Allow partial credit";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnSavePool
            // 
            this.btnSavePool.Location = new System.Drawing.Point(51, 218);
            this.btnSavePool.Name = "btnSavePool";
            this.btnSavePool.Size = new System.Drawing.Size(634, 46);
            this.btnSavePool.TabIndex = 10;
            this.btnSavePool.Text = "Change all question settings";
            this.btnSavePool.UseVisualStyleBackColor = true;
            // 
            // lblShuffled
            // 
            this.lblShuffled.AutoSize = true;
            this.lblShuffled.Location = new System.Drawing.Point(217, 153);
            this.lblShuffled.Name = "lblShuffled";
            this.lblShuffled.Size = new System.Drawing.Size(74, 13);
            this.lblShuffled.TabIndex = 11;
            this.lblShuffled.Text = "n of q shuffled";
            // 
            // lblPartialCredit
            // 
            this.lblPartialCredit.AutoSize = true;
            this.lblPartialCredit.Location = new System.Drawing.Point(218, 182);
            this.lblPartialCredit.Name = "lblPartialCredit";
            this.lblPartialCredit.Size = new System.Drawing.Size(121, 13);
            this.lblPartialCredit.TabIndex = 12;
            this.lblPartialCredit.Text = "n of q allow partial credit";
            // 
            // poolsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 495);
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
        private System.Windows.Forms.Label lblNumberOfMultipleChoiceInPool;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSavePool;
        private System.Windows.Forms.Label lblPartialCredit;
        private System.Windows.Forms.Label lblShuffled;
    }
}