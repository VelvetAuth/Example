using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelvetAuth;

namespace example_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            VelvetAuth.ServerResponse();
           

        }
 
        
        public static api VelvetAuth = new api("", 
            "", 
            "", 
            show_messages: true);


        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register regfrm = new register();   
            regfrm.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if(VelvetAuth.LoginResponse(usernametb.Text, passwordtb.Text))
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
                this.Close();
            }
        }
    }
}
