using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary_pro
{
    class comm_class
    {
        public static void err_msg(string err_text)
        {
            System.Windows.Forms.MessageBox.Show("Error:"+err_text);
        }
     
    }
}
