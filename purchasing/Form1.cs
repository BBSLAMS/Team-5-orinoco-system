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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Add(comboBoxItems.SelectedItem);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Remove(listBoxItems.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRequestNewItem_Click(object sender, EventArgs e)
        {
            textBoxNewItemRequest.Visible = true;
            textBoxReasonforRequest.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            /* string departmentName = "IT";
             confirm frm2 = new confirm();
            frm2.checkedListBox1.Items = listBoxItems.Items;
             frm2.Show();
             this.Hide();*/
            confirm frm2 = new confirm();
            frm2.checkedListBox1.Items.AddRange(listBoxItems.Items);


            frm2.Show();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
