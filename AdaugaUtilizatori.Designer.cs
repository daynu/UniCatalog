﻿namespace UniCatalog
{
    partial class AdaugaUtilizatori
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(269, 275);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(123, 39);
            button1.TabIndex = 0;
            button1.Text = "Adaugă";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 118);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nume";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 155);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Prenume";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 189);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Parola";
            textBox3.Size = new Size(271, 23);
            textBox3.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrator", "Cadru didactic", "Secretar" });
            comboBox1.Location = new Point(196, 227);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Rol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Niagara Solid", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 31);
            label1.Name = "label1";
            label1.Size = new Size(239, 56);
            label1.TabIndex = 17;
            label1.Text = "Adauga Utilizatori";
            // 
            // AdaugaUtilizatori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdaugaUtilizatori";
            Text = "AdaugaUtilizatori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label1;
    }
}