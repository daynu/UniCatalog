namespace UniCatalog
{
    partial class EditareNote
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(106, 119);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nume";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(106, 158);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Prenume";
            textBox2.Size = new Size(279, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(106, 240);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Disciplina";
            textBox3.Size = new Size(279, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(227, 295);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Notă";
            textBox4.Size = new Size(111, 23);
            textBox4.TabIndex = 4;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 290);
            label2.Name = "label2";
            label2.Size = new Size(61, 26);
            label2.TabIndex = 6;
            label2.Text = "Notă:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(185, 389);
            button1.Name = "button1";
            button1.Size = new Size(107, 37);
            button1.TabIndex = 8;
            button1.Text = "Modifică";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 328);
            label3.Name = "label3";
            label3.Size = new Size(60, 26);
            label3.TabIndex = 9;
            label3.Text = "Data:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(106, 200);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Grupa";
            textBox6.Size = new Size(279, 23);
            textBox6.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(227, 331);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Niagara Solid", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 39);
            label1.Name = "label1";
            label1.Size = new Size(175, 56);
            label1.TabIndex = 18;
            label1.Text = "Editare Note";
            // 
            // EditareNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(516, 462);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EditareNote";
            Text = "Editare Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}