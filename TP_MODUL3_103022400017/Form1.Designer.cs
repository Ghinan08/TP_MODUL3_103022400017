namespace TP_MODUL3_103022400017
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOutput = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnTambah = new Button();
            btnNol = new Button();
            btnSamaDengan = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Location = new Point(38, 41);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(78, 17);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Label Output";
            // 
            // btn1
            // 
            btn1.Location = new Point(45, 66);
            btn1.Name = "btn1";
            btn1.Size = new Size(23, 22);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(66, 66);
            btn2.Name = "btn2";
            btn2.Size = new Size(23, 22);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(87, 66);
            btn3.Name = "btn3";
            btn3.Size = new Size(23, 22);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button1_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(45, 86);
            btn4.Name = "btn4";
            btn4.Size = new Size(23, 22);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(66, 86);
            btn5.Name = "btn5";
            btn5.Size = new Size(23, 22);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button1_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(87, 86);
            btn6.Name = "btn6";
            btn6.Size = new Size(23, 22);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button1_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(45, 106);
            btn7.Name = "btn7";
            btn7.Size = new Size(23, 22);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(66, 106);
            btn8.Name = "btn8";
            btn8.Size = new Size(23, 22);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button1_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(87, 106);
            btn9.Name = "btn9";
            btn9.Size = new Size(23, 22);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button1_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(46, 125);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(23, 22);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnNol
            // 
            btnNol.Location = new Point(67, 125);
            btnNol.Name = "btnNol";
            btnNol.Size = new Size(23, 22);
            btnNol.TabIndex = 1;
            btnNol.Text = "0";
            btnNol.UseVisualStyleBackColor = true;
            btnNol.Click += button1_Click;
            // 
            // btnSamaDengan
            // 
            btnSamaDengan.Location = new Point(88, 125);
            btnSamaDengan.Name = "btnSamaDengan";
            btnSamaDengan.Size = new Size(23, 22);
            btnSamaDengan.TabIndex = 1;
            btnSamaDengan.Text = "=";
            btnSamaDengan.UseVisualStyleBackColor = true;
            btnSamaDengan.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(174, 301);
            Controls.Add(btnSamaDengan);
            Controls.Add(btnNol);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btnTambah);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnTambah;
        private Button btnNol;
        private Button btnSamaDengan;
    }
}
