namespace UniCatalog
{
    partial class gestionareGrupe
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 20);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Facultatea";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(37, 69);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(260, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Departamentul";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(37, 111);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(260, 23);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "Program de Studiu";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(497, 20);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 22);
            button1.TabIndex = 3;
            button1.Text = "Adaugă Grupă";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox4.Location = new Point(38, 152);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(259, 23);
            comboBox4.TabIndex = 4;
            comboBox4.Text = "An de studiu";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(39, 188);
            comboBox5.Margin = new Padding(3, 2, 3, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(257, 23);
            comboBox5.TabIndex = 5;
            comboBox5.Text = "Grupa";
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 224);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(444, 298);
            dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(661, 311);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(209, 29);
            button2.TabIndex = 7;
            button2.Text = "Adaugă Student în Grupă";
            button2.UseVisualStyleBackColor = true;
            
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(661, 360);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(209, 29);
            button3.TabIndex = 8;
            button3.Text = "Eliminare Student";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // gestionareGrupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 530);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "gestionareGrupe";
            Text = "gestionareGrupe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
    }
}