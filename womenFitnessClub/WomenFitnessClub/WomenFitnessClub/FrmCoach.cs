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
    public partial class FrmCoach : Form
        {
        ClubDBEntities database = new ClubDBEntities();
        public FrmCoach()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String code = txtCode.Text.ToString();
            String name = txtName.Text.Trim();
            String lastname = txtLastName.Text.Trim();
            String nationalcode = mskCode.Text.ToString();
            String phone = mskPhone.Text.ToString();
            database.CreatCoachAccount(@code ,@name ,@lastname ,@nationalcode ,@phone);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
