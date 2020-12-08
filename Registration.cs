using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th11
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = textBox1.Text;
            u.Email = textBox2.Text;
            u.Profession = comboBox1.SelectedItem.ToString();

            RadioButton rb = radioButton1.Controls.OfType<RadioButton>().FirstOrDefault();
            u.Gender = rb.Text;
               




            new Dashboard(u).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
