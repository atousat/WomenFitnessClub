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
    public partial class FrmListClass : Form
    {
        public FrmListClass()
        {
            ClubDBEntities database = new ClubDBEntities();
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String code = txtCode.TextAlign.ToString();
            String coachname = txtCoachName.Text.Trim();

            List<GetSearchListClass_Result> result = database.GetSearchListClass(@code ,@coachname).ToList<GetSearchListClass_Result>();

            DtGrdSearchClass.DataSource = result;

            foreach (GetSearchListClass_Result item in result)
            {
                if (txtCode.Text.Equals(item.Code) && txtCoachName.Text.Equals(item.CoachName))

                    MessageBox.Show("جست و جو با موفقیت انجام شد.");
                else
                    MessageBox.Show("جست و جوی مورد نظر یافت نشد،دوباره امتحان کنید.");
            }

        }
    }
}
