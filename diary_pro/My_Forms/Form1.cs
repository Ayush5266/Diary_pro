using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diary_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //--------------------------
                diary_pro.My_Forms.login_form lf = new My_Forms.login_form();
                lf.ShowDialog();
                //--------------------------
                get_time();
                //--------------------
                get_cal();
                //--------------------
                this.label3.Text = Application.ProductVersion;
                //---------------------
                //--------------------
                int si;
                si = diary_pro.Properties.Settings.Default.selected_back_image_index;
                back_image_loader(si);
                //---------------------
                back_combo_loader();
                this.comboBox1.SelectedIndex = si;
                //---------------------
                music_combo_loader();
                //---------------------
                int sm;
                sm = diary_pro.Properties.Settings.Default.selected_music_index;
                this.music_comboBox2.SelectedIndex = sm;
                //-------------------------------
                user_info_load();
            }
            catch (Exception ex)
            {

                // MessageBox.Show("Error:"+ ex.ToString());
                //-----alternate method to create class for all forms and use with them----
                comm_class.err_msg(ex.ToString());
            }
           
        }
        public void user_info_load()
        {
            this.usern_label6.Text = diary_pro.Properties.Settings.Default.User_name;
            
            //-----------load user pic------------
            string df;
            df = Application.StartupPath + "\\Data\\user_pic\\1.jpg";
            this.user_pictureBox1.Load(df);
        }
        public void back_image_loader(int combo_index)
        {
            string fn;
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\Data\\Pics\\"+combo_index.ToString()+".jpg";
            this.BackgroundImage = Image.FromFile(fn);
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        public void back_combo_loader()
        {
            //---------used to add items in a combobox----------
            for (int i = 1; i <= 7; i++)
            {
                this.comboBox1.Items.Add("Image" + i.ToString());
            }
        }

        public void music_combo_loader()
        {
            //---------used to add items in a combobox----------
            for (int i = 1; i <= 2; i++)
            {
                this.music_comboBox2.Items.Add("Music" + i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            if (MessageBox.Show("Do you want to exit..?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            get_time();
        }
        public void get_time()
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void get_cal()
        {
            System.Globalization.GregorianCalendar g = new System.Globalization.GregorianCalendar();
            this.cy_label6.Text = g.GetYear(DateTime.Now).ToString();
            // this.m_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.cdate_label8.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.cday_label9.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            int m;
            int.TryParse(g.GetMonth(DateTime.Now).ToString(), out m);

            this.cm_label7.Text = month_no_TO_name(m);
        }
        public string month_no_TO_name(int month_num)
        {
            string mn;
            switch (month_num)
            {
                case 1:
                    mn = "January";
                    break;
                case 2:
                    mn = "Febuary";
                    break;
                case 3:
                    mn = "March";
                    break;
                case 4:
                    mn = "April";
                    break;
                case 5:
                    mn = "May";
                    break;
                case 6:
                    mn = "June";
                    break;
                case 7:
                    mn = "July";
                    break;
                case 8:
                    mn = "August";
                    break;
                case 9:
                    mn = "September";
                    break;
                case 10:
                    mn = "October";
                    break;
                case 11:
                    mn = "November";
                    break;
                case 12:
                    mn = "December";
                    break;


                default:
                    mn = "Unknown";
                    break;
            }
            return mn;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            back_image_loader(this.comboBox1.SelectedIndex);
            //---------save the selected image index-------------------
            diary_pro.Properties.Settings.Default.selected_back_image_index = this.comboBox1.SelectedIndex;
            diary_pro.Properties.Settings.Default.Save();

        }
        public void music_loader(int combo_index)
        {
            string fn;
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\Data\\music\\" + combo_index.ToString() + ".mp3";
            this.axWindowsMediaPlayer1.URL = fn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            music_loader(this.music_comboBox2.SelectedIndex);
            //-----------------------------
            diary_pro.Properties.Settings.Default.selected_music_index = this.music_comboBox2.SelectedIndex;
            diary_pro.Properties.Settings.Default.Save();
        }

        private void music_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.about_us ab = new My_Forms.about_us();
            ab.MdiParent = this;
            ab.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.users_mang um = new My_Forms.users_mang();
            um.MdiParent = this;
            um.Show();
        }

        private void lockScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--------------------------
            diary_pro.My_Forms.login_form lf = new My_Forms.login_form();
            lf.ShowDialog();
            //--------------------------
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.memo_form mf = new My_Forms.memo_form();
            mf.MdiParent = this;
            mf.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.search_memo smf = new My_Forms.search_memo();
            smf.MdiParent = this;
            smf.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton5_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                toolStripButton4_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                this.sett_toolStripButton3.ShowDropDown();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.tool_toolStripButton2.ShowDropDown();
            }
            else if (e.KeyCode == Keys.F6)
            {
                this.about_toolStripButton1.ShowDropDown();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button2_Click(sender, e);
            }
        }

   
    }
}
