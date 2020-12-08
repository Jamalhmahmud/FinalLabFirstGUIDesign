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
    public partial class Dashboard : Form
    {

        public Dashboard(User u)
        {
            InitializeComponent();
            string output = String.Format("Name : {0}" +
                "\nEmail : {1}" +
                    "\nProfession : {2}" +
                        "\nGender : {3}", u.Name, u.Email, u.Profession, u.Gender


                );
           richTextBox1.Text = output;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
