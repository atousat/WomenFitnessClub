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
    public partial class FrmClass : Form
    {
        ClubDBEntities database = new ClubDBEntities();

        public FrmClass()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String code = txtCode.Text.ToString();
            String days = cmbTime.Text.ToString();
            String time = cmbDays.Text.ToString();
            String coachname = txtCoachName.Text.Trim();
            database.CreatClass(@code ,@days ,@time ,@coachname);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            cmbTime.SelectedIndex = 0;
            cmbDays.SelectedIndex = 0;
        }
    }
}
