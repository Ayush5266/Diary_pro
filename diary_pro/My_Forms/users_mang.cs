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
    public partial class users_mang : Form
    {
        public users_mang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            this.pictureBox1.Load(fn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //------------------------------
            if (this.un_textBox1.Text == "")
            {
                MessageBox.Show("Username is empty!!!");
                return;
            }
            //------------------------------
            if (this.pass_textBox2.Text != this.pc_textBox1.Text)
            {
                MessageBox.Show("Must enter same password!!!");
                return;
            }
            //------------------------------
            diary_pro.Properties.Settings.Default.User_name = this.un_textBox1.Text;
            diary_pro.Properties.Settings.Default.User_pass = this.pass_textBox2.Text;
            diary_pro.Properties.Settings.Default.Save();
            //--------save user image------------
            if (this.openFileDialog1.FileName != "openFileDialog")
            {
                string fn;
                fn = this.openFileDialog1.FileName;

                string df;
                df = Application.StartupPath + "\\Data\\user_pic\\1.jpg";
                System.IO.File.Copy(fn, df, true);
            }
           
            //-----------------------------------
            MessageBox.Show("Done!");
        }

        private void users_mang_Load(object sender, EventArgs e)
        {
            user_info_load();
        }
        public void user_info_load()
        {
            this.un_textBox1.Text = diary_pro.Properties.Settings.Default.User_name;
            this.pass_textBox2.Text = diary_pro.Properties.Settings.Default.User_pass;
            //-----------load user pic------------
            string df;
            df = Application.StartupPath + "\\Data\\user_pic\\1.jpg";
            this.pictureBox1.Load(df);
        }
    }
}
