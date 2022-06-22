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
    public partial class FrmMember : Form
    {
        ClubDBEntities database = new ClubDBEntities();
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String name = txtname.Text.Trim();
            String lastname = txtLastName.Text.Trim();
            String nationalcode = mskCode.Text.ToString();
            String phone = mskPhone.Text.ToString();
            String address = txtAddress.Text.Trim();
            database.CreatMember(@name ,@lastname ,@nationalcode ,@phone ,@address);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
