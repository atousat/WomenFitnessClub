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
    public partial class ListMember : Form
    {
        ClubDBEntities database = new ClubDBEntities();
        public ListMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String code = mskCode.Text.ToString();
            String lastname = txtLastName.Text.ToString();
            List<GetSearchListMember_Result> result = database.GetSearchListMember(@code , @lastname).ToList<GetSearchListMember_Result>();

            DtGrdSearchMember.DataSource = result;

            foreach (GetSearchListMember_Result item in result)
            {
                if (txtLastName.Text.Equals(item.LastName) && mskCode.Text.Equals(item.NationalCode))
                
                    MessageBox.Show("جست و جو با موفقیت انجام شد.");
                else
                    MessageBox.Show("جست و جوی مورد نظر یافت نشد،دوباره امتحان کنید.");
            }
        }
    }
}
