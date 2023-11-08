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
    public partial class search_memo : Form
    {
        public search_memo()
        {
            InitializeComponent();
        }

        private void search_memo_Load(object sender, EventArgs e)
        {
            int ic;
            ic = diary_pro.Properties.Settings.Default.last_memo_id;

            
            for (int i = 1; i <= ic; i++)
            {
                this.listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.memo_form mf = new My_Forms.memo_form();
          
            mf.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fn;
            string fn_title;
            string fn_date;
            int l_id;
            int.TryParse(this.listBox1.Text, out l_id);
            fn = Application.StartupPath + "\\Data\\docs\\" + l_id.ToString() + ".rtf";
            fn_title = Application.StartupPath + "\\Data\\docs\\title_" + l_id.ToString() + ".txt";
            fn_date = Application.StartupPath + "\\Data\\docs\\date_" + l_id.ToString() + ".txt";
            //------------------------------------------------------
            this.richTextBox1.LoadFile(fn);
            this.mt_textBox1.Text = System.IO.File.ReadAllText(fn_title);
            this.md_textBox2.Text = System.IO.File.ReadAllText(fn_date);
            this.mi_textBox1.Text = l_id.ToString();
            //------------------------------------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
           i = this.listBox1.FindStringExact(this.textBox1.Text);
            this.listBox1.SelectedIndex = i;
        }
    }
}
