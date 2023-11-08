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
    public partial class about_us : Form
    {
        public about_us()
        {
            InitializeComponent();
        }

        private void co_label4_Click(object sender, EventArgs e)
        {

        }

        private void about_us_Load(object sender, EventArgs e)
        {
            this.co_label4.Text = Application.CompanyName;
            this.pro_label1.Text = "Product : " + Application.ProductName;
            ver_label2.Text = "Version : " + Application.ProductVersion;
            //-------------load from settings--------
            this.label1.Text = diary_pro.Properties.Settings.Default.programmer_name;
        }
    }
}
