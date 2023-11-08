using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diary_pro.My_Forms
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void user_pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void user_info_load()
        {
            this.usern_label6.Text = diary_pro.Properties.Settings.Default.User_name;

            //-----------load user pic------------
            string df;
            df = Application.StartupPath + "\\Data\\user_pic\\1.jpg";
            this.user_pictureBox1.Load(df);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            user_info_load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.pass_textBox2.Text == "")
            {
                MessageBox.Show("Password is empty!!!");
                return;
            }
            if (this.pass_textBox2.Text == diary_pro.Properties.Settings.Default.User_pass)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Your password is not correct, try again..!!!");
            }
        }
    }
}
