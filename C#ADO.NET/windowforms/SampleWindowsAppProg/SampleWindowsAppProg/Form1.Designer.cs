namespace SampleWindowsAppProg
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbadd1 = new System.Windows.Forms.RadioButton();
            this.rdbsubtract1 = new System.Windows.Forms.RadioButton();
            this.rdbmultiply1 = new System.Windows.Forms.RadioButton();
            this.rdbdivide1 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Get Solution";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter First Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Second Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbdivide1);
            this.groupBox2.Controls.Add(this.rdbmultiply1);
            this.groupBox2.Controls.Add(this.rdbsubtract1);
            this.groupBox2.Controls.Add(this.rdbadd1);
            this.groupBox2.Location = new System.Drawing.Point(288, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Your Choice";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbadd1
            // 
            this.rdbadd1.AutoSize = true;
            this.rdbadd1.Location = new System.Drawing.Point(62, 20);
            this.rdbadd1.Name = "rdbadd1";
            this.rdbadd1.Size = new System.Drawing.Size(44, 17);
            this.rdbadd1.TabIndex = 0;
            this.rdbadd1.TabStop = true;
            this.rdbadd1.Text = "Add";
            this.rdbadd1.UseVisualStyleBackColor = true;
            // 
            // rdbsubtract1
            // 
            this.rdbsubtract1.AutoSize = true;
            this.rdbsubtract1.Location = new System.Drawing.Point(62, 43);
            this.rdbsubtract1.Name = "rdbsubtract1";
            this.rdbsubtract1.Size = new System.Drawing.Size(65, 17);
            this.rdbsubtract1.TabIndex = 1;
            this.rdbsubtract1.TabStop = true;
            this.rdbsubtract1.Text = "Subtract";
            this.rdbsubtract1.UseVisualStyleBackColor = true;
            this.rdbsubtract1.CheckedChanged += new System.EventHandler(this.Subtract_CheckedChanged);
            // 
            // rdbmultiply1
            // 
            this.rdbmultiply1.AutoSize = true;
            this.rdbmultiply1.Location = new System.Drawing.Point(62, 67);
            this.rdbmultiply1.Name = "rdbmultiply1";
            this.rdbmultiply1.Size = new System.Drawing.Size(60, 17);
            this.rdbmultiply1.TabIndex = 2;
            this.rdbmultiply1.TabStop = true;
            this.rdbmultiply1.Text = "Multiply";
            this.rdbmultiply1.UseVisualStyleBackColor = true;
            // 
            // rdbdivide1
            // 
            this.rdbdivide1.AutoSize = true;
            this.rdbdivide1.Location = new System.Drawing.Point(62, 90);
            this.rdbdivide1.Name = "rdbdivide1";
            this.rdbdivide1.Size = new System.Drawing.Size(55, 17);
            this.rdbdivide1.TabIndex = 3;
            this.rdbdivide1.TabStop = true;
            this.rdbdivide1.Text = "Divide";
            this.rdbdivide1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDivide;
        private System.Windows.Forms.RadioButton rdbMultiply;
        private System.Windows.Forms.RadioButton rdbSubtract;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbdivide1;
        private System.Windows.Forms.RadioButton rdbmultiply1;
        private System.Windows.Forms.RadioButton rdbsubtract1;
        private System.Windows.Forms.RadioButton rdbadd1;
    }
}

