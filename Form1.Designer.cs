namespace psm
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFile2Split = new System.Windows.Forms.TextBox();
            this.btnToSplit = new System.Windows.Forms.Button();
            this.tbSplitFiles = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSaveFileName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbFiles2Combine = new System.Windows.Forms.TextBox();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFile2Split);
            this.groupBox1.Controls.Add(this.btnToSplit);
            this.groupBox1.Controls.Add(this.tbSplitFiles);
            this.groupBox1.Controls.Add(this.btnSplit);
            this.groupBox1.Location = new System.Drawing.Point(13, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 154);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Splitter";
            // 
            // tbFile2Split
            // 
            this.tbFile2Split.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFile2Split.Location = new System.Drawing.Point(41, 32);
            this.tbFile2Split.Name = "tbFile2Split";
            this.tbFile2Split.Size = new System.Drawing.Size(500, 23);
            this.tbFile2Split.TabIndex = 15;
            this.tbFile2Split.Text = "File to split";
            // 
            // btnToSplit
            // 
            this.btnToSplit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToSplit.Location = new System.Drawing.Point(547, 32);
            this.btnToSplit.Name = "btnToSplit";
            this.btnToSplit.Size = new System.Drawing.Size(80, 23);
            this.btnToSplit.TabIndex = 14;
            this.btnToSplit.Text = "Open";
            this.btnToSplit.UseVisualStyleBackColor = true;
            this.btnToSplit.Click += new System.EventHandler(this.btnToSplit_Click);
            // 
            // tbSplitFiles
            // 
            this.tbSplitFiles.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSplitFiles.Location = new System.Drawing.Point(41, 61);
            this.tbSplitFiles.Multiline = true;
            this.tbSplitFiles.Name = "tbSplitFiles";
            this.tbSplitFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSplitFiles.Size = new System.Drawing.Size(500, 67);
            this.tbSplitFiles.TabIndex = 13;
            this.tbSplitFiles.Text = "Split file names";
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(547, 61);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(80, 67);
            this.btnSplit.TabIndex = 12;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSaveFileName);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.tbFiles2Combine);
            this.groupBox2.Controls.Add(this.btnOpen1);
            this.groupBox2.Location = new System.Drawing.Point(13, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 136);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combiner";
            // 
            // tbSaveFileName
            // 
            this.tbSaveFileName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaveFileName.Location = new System.Drawing.Point(39, 98);
            this.tbSaveFileName.Name = "tbSaveFileName";
            this.tbSaveFileName.Size = new System.Drawing.Size(500, 23);
            this.tbSaveFileName.TabIndex = 15;
            this.tbSaveFileName.Text = "New file name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(545, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Combine";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbFiles2Combine
            // 
            this.tbFiles2Combine.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiles2Combine.Location = new System.Drawing.Point(39, 20);
            this.tbFiles2Combine.Multiline = true;
            this.tbFiles2Combine.Name = "tbFiles2Combine";
            this.tbFiles2Combine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFiles2Combine.Size = new System.Drawing.Size(500, 67);
            this.tbFiles2Combine.TabIndex = 9;
            this.tbFiles2Combine.Text = "Files to be combined";
            // 
            // btnOpen1
            // 
            this.btnOpen1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen1.Location = new System.Drawing.Point(545, 20);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(80, 68);
            this.btnOpen1.TabIndex = 8;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "PDF Combiner / Splitter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFile2Split;
        private System.Windows.Forms.Button btnToSplit;
        private System.Windows.Forms.TextBox tbSplitFiles;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSaveFileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbFiles2Combine;
        private System.Windows.Forms.Button btnOpen1;
    }
}

