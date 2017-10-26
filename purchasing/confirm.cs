using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purchasing
{
    public partial class confirm : Form
    {
        public confirm()
        {
            InitializeComponent();
        }

        private void confirm_Load(object sender, EventArgs e)
        {
            
        }

        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            checkedListBox1.Items.Add(frm1.listBoxItems);
        }

        
    }
}
