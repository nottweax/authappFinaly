namespace AuthApp
{
    partial class users
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
            label2 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            welcomLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(775, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 32);
            label2.TabIndex = 1;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(298, 390);
            button3.Name = "button3";
            button3.Size = new Size(120, 46);
            button3.TabIndex = 4;
            button3.Text = "Отсортировать по фаилии";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 392);
            button2.Name = "button2";
            button2.Size = new Size(120, 46);
            button2.TabIndex = 3;
            button2.Text = "Отсортировать по имени";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 392);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 2;
            button1.Text = "Отсортировать по основе обучения";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(682, 265);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(welcomLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // welcomLabel
            // 
            welcomLabel.Dock = DockStyle.Fill;
            welcomLabel.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            welcomLabel.ForeColor = SystemColors.Info;
            welcomLabel.Location = new Point(0, 0);
            welcomLabel.Name = "welcomLabel";
            welcomLabel.Size = new Size(800, 100);
            welcomLabel.TabIndex = 0;
            welcomLabel.Text = "Все пользователи";
            welcomLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "users";
            Text = "users";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label welcomLabel;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}