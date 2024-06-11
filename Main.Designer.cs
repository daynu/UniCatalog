namespace UniCatalog
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Niagara Solid", 110F);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(393, 228);
            label1.Name = "label1";
            label1.Size = new Size(401, 197);
            label1.TabIndex = 0;
            label1.Text = "Catalog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(99, 36);
            label2.Name = "label2";
            label2.Size = new Size(82, 35);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Haettenschweiler", 35F);
            button1.ForeColor = Color.Tan;
            button1.Location = new Point(456, 480);
            button1.Name = "button1";
            button1.Size = new Size(287, 92);
            button1.TabIndex = 2;
            button1.Text = "N O T E";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Haettenschweiler", 35F);
            button2.ForeColor = Color.Tan;
            button2.Location = new Point(456, 760);
            button2.Name = "button2";
            button2.Size = new Size(287, 92);
            button2.TabIndex = 3;
            button2.Text = "UTILIZATORI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Haettenschweiler", 35F);
            button3.ForeColor = Color.Tan;
            button3.Location = new Point(456, 623);
            button3.Name = "button3";
            button3.Size = new Size(287, 92);
            button3.TabIndex = 4;
            button3.Text = "G R U P E";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(14, 36);
            label3.Name = "label3";
            label3.Size = new Size(88, 35);
            label3.TabIndex = 5;
            label3.Text = "Nume:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Niagara Solid", 50F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(517, 907);
            label4.Name = "label4";
            label4.Size = new Size(135, 90);
            label4.TabIndex = 6;
            label4.Text = "2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Modern No. 20", 40F, FontStyle.Italic);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(426, 36);
            label5.Name = "label5";
            label5.Size = new Size(317, 69);
            label5.TabIndex = 7;
            label5.Text = "Bun venit!";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1113, 1015);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "UniCatalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}