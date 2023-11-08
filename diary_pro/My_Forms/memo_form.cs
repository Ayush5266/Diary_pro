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
    public partial class memo_form : Form
    {
        public memo_form()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = this.fontDialog1.Font;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionColor = this.colorDialog1.Color;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionBackColor = this.colorDialog1.Color;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            int i;
            i = this.richTextBox1.SelectionIndent;
            i = i - 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            int i;
            i = this.richTextBox1.SelectionIndent;
            i = i - 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void newm_button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.newm_button1.Enabled = false;
            this.savem_button2.Enabled = true;
            //----------------------------------
            int i;
            i = diary_pro.Properties.Settings.Default.last_memo_id + 1;
            this.mi_textBox1.Text =i.ToString();
            //---------------------------------
            this.mt_textBox1.ResetText();
            this.md_textBox2.ResetText();
            this.richTextBox1.ResetText();

        }

        private void savem_button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.groupBox1.Enabled = false;
                this.savem_button2.Enabled = false;
                this.newm_button1.Enabled = true;
                //-------------------------------------
                int l_id;
                l_id = diary_pro.Properties.Settings.Default.last_memo_id;
                l_id = l_id + 1;
                //------------------------------------
                diary_pro.Properties.Settings.Default.last_memo_id = l_id;
                diary_pro.Properties.Settings.Default.Save();
                //------------------------------------
                string fn;
                string fn_title;
                string fn_date;
                fn = Application.StartupPath + "\\Data\\docs\\" + l_id.ToString() + ".rtf";
                fn_title = Application.StartupPath + "\\Data\\docs\\title_" + l_id.ToString() + ".txt";
                fn_date = Application.StartupPath + "\\Data\\docs\\date_" + l_id.ToString() + ".txt";
                //-------------------------------------------------
                System.IO.File.WriteAllText(fn_title, this.mt_textBox1.Text);
                System.IO.File.WriteAllText(fn_date, this.md_textBox2.Text);
                //-------------------------------------------------
                this.richTextBox1.SaveFile(fn);
                MessageBox.Show("File Saved!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.ToString());
            }



        }

        private void memo_form_Load(object sender, EventArgs e)
        {
            this.savem_button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diary_pro.Properties.Settings.Default.last_memo_id = 0;
            diary_pro.Properties.Settings.Default.Save();
        }

        private void memo_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                newm_button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                savem_button2_Click(sender, e);
            }
        }
    }
}
