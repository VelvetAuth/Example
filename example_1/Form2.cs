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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            emaillb.Text = Form1.VelvetAuth.user_data.email;
            usernamelb.Text = Form1.VelvetAuth.user_data.username;
            var exp = Form1.VelvetAuth.user_data.expires;
            expirylb.Text = exp.ToString();
            switch (Form1.VelvetAuth.user_data.rank)
            {
                case 1:
                    levellb.Text = "premium";
                    break;
            }
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            if(Form1.VelvetAuth.user_data.rank == 1)
            {
                vProtect.api.messagebox.Access_Denied();
            }else if(Form1.VelvetAuth.user_data.rank == 2)
            {
                vProtect.api.messagebox.Access_Granted();
            }else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
