using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Employees em = new Employees();
            em.Show();
            this.Hide();
            Home ho = new Home();
            ho.Hide();
        }

        private void achievmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Achievment ach = new Achievment();
            ach.Show();
            this.Hide();
            Home h = new Home();
            h.Hide();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Transfer tr = new Transfer();
            tr.Show();
            this.Hide();
            Home h = new Home();
            h.Hide();
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Promotion pr = new Promotion();
            pr.Show();
            this.Hide();
            Home h = new Home();
            h.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            ChartForm ch = new ChartForm();
            ch.Show();
            this.Hide();
            Home h = new Home();
            h.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
