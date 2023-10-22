using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();  
            frm1.ShowDialog();
            this.Close();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
           if(Form1.VelvetAuth.RegisterResponse(usernametb.Text, emailtb.Text, passwordtb.Text, tokentb.Text)){

                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
                this.Close();

            }
        }
    }
}
