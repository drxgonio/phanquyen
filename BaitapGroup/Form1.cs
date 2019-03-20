using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaitapGroup.Conn;

namespace BaitapGroup
{
    public partial class Form1 : Form
    {
        
        TrangAdmin admin = new TrangAdmin();
        Role1 role1 = new Role1();
        Role2 role2 = new Role2();
        Role3 role3 = new Role3();
        Role4 role4 = new Role4();
        Role5 role5 = new Role5();
        AddUser addUser = new AddUser();
        User user = new User();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(admin);
          
        }

        private void quyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(role1);
        }

        private void role2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(role2);
        }

        private void role3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(role3);
        }

        private void role3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(role4);
        }

        private void role4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(role5);
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(addUser);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(user);
        }
    }
    
}
