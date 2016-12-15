namespace mean_median_mode
{
    partial class main
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxSetInput = new System.Windows.Forms.TextBox();
            this.lblSets = new System.Windows.Forms.Label();
            this.radioQuant = new System.Windows.Forms.RadioButton();
            this.radioQual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblMedian = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSpace = new System.Windows.Forms.RadioButton();
            this.radioComma = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBoth = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(322, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 30);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear Set";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(322, 50);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 30);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Add To Set";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxSetInput
            // 
            this.txtBoxSetInput.Location = new System.Drawing.Point(12, 24);
            this.txtBoxSetInput.Name = "txtBoxSetInput";
            this.txtBoxSetInput.Size = new System.Drawing.Size(476, 20);
            this.txtBoxSetInput.TabIndex = 2;
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Location = new System.Drawing.Point(12, 8);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(304, 13);
            this.lblSets.TabIndex = 3;
            this.lblSets.Text = "Paste Set Here (list with spaces or commas between each unit)";
            // 
            // radioQuant
            // 
            this.radioQuant.AutoSize = true;
            this.radioQuant.Checked = true;
            this.radioQuant.Location = new System.Drawing.Point(15, 9);
            this.radioQuant.Name = "radioQuant";
            this.radioQuant.Size = new System.Drawing.Size(82, 17);
            this.radioQuant.TabIndex = 4;
            this.radioQuant.TabStop = true;
            this.radioQuant.Text = "Quantitative";
            this.radioQuant.UseVisualStyleBackColor = true;
            this.radioQuant.CheckedChanged += new System.EventHandler(this.radioQuant_CheckedChanged);
            // 
            // radioQual
            // 
            this.radioQual.AutoSize = true;
            this.radioQual.Location = new System.Drawing.Point(107, 9);
            this.radioQual.Name = "radioQual";
            this.radioQual.Size = new System.Drawing.Size(75, 17);
            this.radioQual.TabIndex = 5;
            this.radioQual.Text = "Qualitative";
            this.radioQual.UseVisualStyleBackColor = true;
            this.radioQual.CheckedChanged += new System.EventHandler(this.radioQual_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMode);
            this.groupBox1.Controls.Add(this.lblMedian);
            this.groupBox1.Controls.Add(this.lblMean);
            this.groupBox1.Location = new System.Drawing.Point(15, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(7, 67);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(34, 13);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Mode";
            // 
            // lblMedian
            // 
            this.lblMedian.AutoSize = true;
            this.lblMedian.Location = new System.Drawing.Point(6, 44);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(42, 13);
            this.lblMedian.TabIndex = 1;
            this.lblMedian.Text = "Median";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(7, 20);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(34, 13);
            this.lblMean.TabIndex = 0;
            this.lblMean.Text = "Mean";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioQual);
            this.groupBox2.Controls.Add(this.radioQuant);
            this.groupBox2.Location = new System.Drawing.Point(288, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 32);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // radioSpace
            // 
            this.radioSpace.AutoSize = true;
            this.radioSpace.Location = new System.Drawing.Point(107, 9);
            this.radioSpace.Name = "radioSpace";
            this.radioSpace.Size = new System.Drawing.Size(70, 17);
            this.radioSpace.TabIndex = 5;
            this.radioSpace.Text = "by Space";
            this.radioSpace.UseVisualStyleBackColor = true;
            // 
            // radioComma
            // 
            this.radioComma.AutoSize = true;
            this.radioComma.Checked = true;
            this.radioComma.Location = new System.Drawing.Point(15, 9);
            this.radioComma.Name = "radioComma";
            this.radioComma.Size = new System.Drawing.Size(74, 17);
            this.radioComma.TabIndex = 4;
            this.radioComma.TabStop = true;
            this.radioComma.Text = "by Comma";
            this.radioComma.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBoth);
            this.groupBox3.Controls.Add(this.radioSpace);
            this.groupBox3.Controls.Add(this.radioComma);
            this.groupBox3.Location = new System.Drawing.Point(15, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 32);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // radioBoth
            // 
            this.radioBoth.AutoSize = true;
            this.radioBoth.Location = new System.Drawing.Point(191, 9);
            this.radioBoth.Name = "radioBoth";
            this.radioBoth.Size = new System.Drawing.Size(61, 17);
            this.radioBoth.TabIndex = 6;
            this.radioBoth.Text = "by Both";
            this.radioBoth.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 69);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 9;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 296);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.txtBoxSetInput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Name = "main";
            this.Text = "Mean, Median, and Mode Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxSetInput;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.RadioButton radioQuant;
        private System.Windows.Forms.RadioButton radioQual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblMedian;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSpace;
        private System.Windows.Forms.RadioButton radioComma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBoth;
        private System.Windows.Forms.ListBox listBox1;
    }
}

