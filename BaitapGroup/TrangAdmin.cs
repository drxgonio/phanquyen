using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapGroup
{
    public partial class TrangAdmin : UserControl
    {
        public TrangAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem name = new ListViewItem(txtName.Text);
            ListViewItem.ListViewSubItem group = new ListViewItem.ListViewSubItem(name, checkBox1.Text);
            ListViewItem.ListViewSubItem role = new ListViewItem.ListViewSubItem(name, cmbRole.Text);
            name.SubItems.Add(role);
            name.SubItems.Add(group);
            listView1.Items.Add(name);
        }
    }
}
