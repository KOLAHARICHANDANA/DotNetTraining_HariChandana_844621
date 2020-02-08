namespace SampleWindowsFormsApp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbadd2 = new System.Windows.Forms.RadioButton();
            this.rdbsubtract2 = new System.Windows.Forms.RadioButton();
            this.rdbmultiply2 = new System.Windows.Forms.RadioButton();
            this.rdbdivide2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(317, 73);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(100, 20);
            this.textFirst.TabIndex = 1;
            // 
            // textSecond
            // 
            this.textSecond.Location = new System.Drawing.Point(317, 145);
            this.textSecond.Name = "textSecond";
            this.textSecond.Size = new System.Drawing.Size(100, 20);
            this.textSecond.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter first Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdivide2);
            this.groupBox1.Controls.Add(this.rdbmultiply2);
            this.groupBox1.Controls.Add(this.rdbsubtract2);
            this.groupBox1.Controls.Add(this.rdbadd2);
            this.groupBox1.Location = new System.Drawing.Point(24, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbadd2
            // 
            this.rdbadd2.AutoSize = true;
            this.rdbadd2.Location = new System.Drawing.Point(6, 28);
            this.rdbadd2.Name = "rdbadd2";
            this.rdbadd2.Size = new System.Drawing.Size(44, 17);
            this.rdbadd2.TabIndex = 0;
            this.rdbadd2.TabStop = true;
            this.rdbadd2.Text = "Add";
            this.rdbadd2.UseVisualStyleBackColor = true;
            this.rdbadd2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbsubtract2
            // 
            this.rdbsubtract2.AutoSize = true;
            this.rdbsubtract2.Location = new System.Drawing.Point(6, 67);
            this.rdbsubtract2.Name = "rdbsubtract2";
            this.rdbsubtract2.Size = new System.Drawing.Size(65, 17);
            this.rdbsubtract2.TabIndex = 1;
            this.rdbsubtract2.TabStop = true;
            this.rdbsubtract2.Text = "Subtract";
            this.rdbsubtract2.UseVisualStyleBackColor = true;
            // 
            // rdbmultiply2
            // 
            this.rdbmultiply2.AutoSize = true;
            this.rdbmultiply2.Location = new System.Drawing.Point(6, 102);
            this.rdbmultiply2.Name = "rdbmultiply2";
            this.rdbmultiply2.Size = new System.Drawing.Size(60, 17);
            this.rdbmultiply2.TabIndex = 2;
            this.rdbmultiply2.TabStop = true;
            this.rdbmultiply2.Text = "Multiply";
            this.rdbmultiply2.UseVisualStyleBackColor = true;
            // 
            // rdbdivide2
            // 
            this.rdbdivide2.AutoSize = true;
            this.rdbdivide2.Location = new System.Drawing.Point(6, 141);
            this.rdbdivide2.Name = "rdbdivide2";
            this.rdbdivide2.Size = new System.Drawing.Size(55, 17);
            this.rdbdivide2.TabIndex = 3;
            this.rdbdivide2.TabStop = true;
            this.rdbdivide2.Text = "Divide";
            this.rdbdivide2.UseVisualStyleBackColor = true;
            this.rdbdivide2.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSecond);
            this.Controls.Add(this.textFirst);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbsubtract2;
        private System.Windows.Forms.RadioButton rdbadd2;
        private System.Windows.Forms.RadioButton rdbdivide2;
        private System.Windows.Forms.RadioButton rdbmultiply2;
    }
}

