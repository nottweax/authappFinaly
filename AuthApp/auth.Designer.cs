namespace AuthApp
{
    partial class auth
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
            panel1 = new Panel();
            toreg = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(toreg);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 516);
            panel1.TabIndex = 0;
            // 
            // toreg
            // 
            toreg.AutoSize = true;
            toreg.Cursor = Cursors.Hand;
            toreg.Font = new Font("Segoe UI", 15F);
            toreg.Location = new Point(196, 479);
            toreg.Name = "toreg";
            toreg.Size = new Size(198, 28);
            toreg.TabIndex = 6;
            toreg.Text = "Зарегистрироваться";
            toreg.Click += toreg_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(272, 355);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 5;
            button1.Text = "Войти\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.Location = new Point(189, 279);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 50);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(189, 203);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 47);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26F);
            label4.Location = new Point(3, 279);
            label4.Name = "label4";
            label4.Size = new Size(157, 47);
            label4.TabIndex = 2;
            label4.Text = "PASSWD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F);
            label3.Location = new Point(40, 203);
            label3.Name = "label3";
            label3.Size = new Size(120, 47);
            label3.TabIndex = 1;
            label3.Text = "LOGIN";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 100);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(530, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 32);
            label2.TabIndex = 1;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(555, 100);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 516);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "auth";
            Text = "auth";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label toreg;
    }
}