﻿namespace WinFormsApp3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 15);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 73);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Wiek";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 102);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Stanowisko";
            // 
            // button1
            // 
            button1.Location = new Point(12, 140);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Zatwierdź";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 140);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 181);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}