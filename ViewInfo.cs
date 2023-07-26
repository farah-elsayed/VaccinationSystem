using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vacc
{
    public partial class ViewInfo : Form
    {
        User user;
        public ViewInfo()
        {
            InitializeComponent();
        }
        long NationalID;
        public void ValueFromForm1(string value)
        {
            nametxt.Text = value;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewInfo_Load(object sender, EventArgs e)
        {
            user = UserData.SearchUser(NationalID);


            nametxt.Text = user.name;
            id.Text = user.NationalID.ToString();
            email.Text = user.email;
            gender.Text = user.gender;
            age.Text = user.age.ToString();
            govCombo.Text = user.governorate;
            vac.Text = user.vaccinated.ToString();
            category.Text = user.category;
            dosagenum.Text = user.dosagesNum.ToString();
        }
        public void recieveData(long NID)
        {

            NationalID = NID;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //User user = Admin.SearchUser(NationalID);
            user.name = nametxt.Text;
            user.age = int.Parse(age.Text);
            user.governorate = govCombo.Text;
            user.email = email.Text;
            user.gender = gender.Text;
            govCombo.Text = user.governorate;
            User.updateUser(user);
            MessageBox.Show("User Updated Successfully");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            UserData.DeleteUser(NationalID);
            MessageBox.Show("User Deleted Successfully.");
            nametxt.Text = "";
            id.Text = "";
            email.Text = "";
            gender.Text = "";
            age.Text = "";
            govCombo.Text = "";
            vac.Text = "";
            category.Text = "";
            dosagenum.Text = "";
        }
    }
}
