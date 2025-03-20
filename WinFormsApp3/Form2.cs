using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        Form1 ParentForm;
        public Form2(Form1 form)
        {
            InitializeComponent();
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Doktorant");
            comboBox1.Items.Add("Profesor");
            ParentForm = form;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Proszę wybrać stanowisko.");
                return;
            }

            string[] valuesToAdd = [textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text];
            ParentForm.AddRowToDataGridView(valuesToAdd);

            this.Close();
        }
    }
}
