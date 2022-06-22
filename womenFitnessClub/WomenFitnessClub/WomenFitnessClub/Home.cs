using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WomenFitnessClub
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ثبتکلاسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmClass().ShowDialog();
        }

        private void ثبتعضوجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMember().ShowDialog();
        }

        private void ثبتمربیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCoach().ShowDialog();
        }

        private void لیستاعضاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void لیستکلاسهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmListClass().ShowDialog();
        }

        private void لیستاعضایباشگاهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListMember().ShowDialog();
        }
    }
}
