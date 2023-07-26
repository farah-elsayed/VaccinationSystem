using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace vacc
{
    public partial class AdminForm : Form
    {
        List<User> users = new List<User>();
        PriorityQueue1<User> usersWaiting = new PriorityQueue1<User>();


        //Saved for efficiency
        int userIndex;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e){ }
        private void AdminForm_Load(object sender, EventArgs e)
        {

            
            users =UserData.getUserlist();
            usersWaiting = UserData.addtoWaiting();
            
            for (int i = 0; i < users.Count(); i++)
            {
                dataGridView1.Rows.Add(users[i].name, users[i].NationalID, users[i].email, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum, users[i].category, users[i].priorityDegree);
            }
            while (!usersWaiting.empty()) 
            { 
                waitingGridView.Rows.Add(usersWaiting.Peek().name, usersWaiting.Peek().NationalID,usersWaiting.Peek().email, usersWaiting.Peek().gender, usersWaiting.Peek().age, usersWaiting.Peek().governorate, usersWaiting.Peek().vaccinated, usersWaiting.Peek().dosagesNum, usersWaiting.Peek().category , usersWaiting.Peek().priorityDegree);
                usersWaiting.deque();
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
          
            /*User user = Admin.SearchUser(long.Parse(textBox1.Text));
            if (user != null)
            {
                textBox2.Text = user.name;
                textBox3.Text = user.gender;
                textBox4.Text = user.age.ToString();
                comboBox1.Text = user.vaccinated.ToString();
                comboBox2.Text = user.dosagesNum.ToString();

            }
            else
            {
                MessageBox.Show("User doesn't exist");
            }*/
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e){ }

        private void label3_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            
            bool deleteuser =  UserData.DeleteUser(long.Parse(textBox1.Text));
            if(deleteuser)
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("This User Doesn't Exist");
            }

        }

        
        private void waitingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //this functionality may not be always available because we are providing it with a real email and password that may change at any time
        public static void Email(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient stmp = new SmtpClient();
                message.From = new MailAddress("purplew37@gmail.com");
                message.To.Add(new MailAddress("salmalqersh@gmail.com"));
                message.Subject = "TEST";
                message.IsBodyHtml = true;
                message.Body = htmlString;
                stmp.Port = 587;
                stmp.Host = "smtp.gmail.com";
                stmp.EnableSsl = true;
                stmp.UseDefaultCredentials = false;
                stmp.Credentials = new NetworkCredential("purplew37@gmail.com", "forVaccination2021");
                //salma
            }
            catch (Exception) { }
        }
        private void sendEmailBtn_Click(object sender, EventArgs e)
        {

            string htmlString1 = "Hello,\nHope this email finds you well and healthy.\nFirst Vaccination Notice:\n Your first dose will be on: " + DateTime.Now + "\nand the second Vaccination will be 14 days apart: " + DateTime.Now.AddDays(14) + "\nYou may have 3 days after each vaccination date to attend to your destinated area, after the 3 days your vaccination application will be removed and you will have to register again for vaccination.";
            Email(htmlString1);
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //see this again-note

            User user = UserData.SearchUser(long.Parse(textBox5.Text));
            dataGridView1.RowCount = 1;
            if (user != null)
            {
                dataGridView1.Rows.Add(user.name, user.NationalID, user.gender, user.age, user.governorate, user.email, user.vaccinated, user.dosagesNum, user.category, user.priorityDegree);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
           
            bool deleteuser = UserData.DeleteUser(long.Parse(textBox5.Text));
            if (deleteuser)
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("This User Doesn't Exist");
            }
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
           
            dataGridView1.RowCount = 1;
            for (int i = 0; i < users.Count(); i++)
            {
                dataGridView1.Rows.Add(users[i].name, users[i].NationalID, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum, users[i].category, users[i].priorityDegree);

            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            waitingGridView.RowCount = 1;
            usersWaiting = UserData.addtoWaiting();

            while (!usersWaiting.empty())
            {
                waitingGridView.Rows.Add(usersWaiting.Peek().name, usersWaiting.Peek().NationalID, usersWaiting.Peek().gender, usersWaiting.Peek().age, usersWaiting.Peek().governorate, usersWaiting.Peek().email, usersWaiting.Peek().vaccinated, usersWaiting.Peek().dosagesNum, usersWaiting.Peek().category, usersWaiting.Peek().priorityDegree);
                usersWaiting.deque();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    if (UserData.ids.Contains(long.Parse(txt_national.Text)))
                    {
                        Admin.updateUserFromAdmin(userIndex, long.Parse(txt_national.Text), cmb_category.Text, int.Parse(txt_dosage.Text));
                        MessageBox.Show("Updated Successafully");
                    }
                    else
                    {
                        MessageBox.Show("This ID Already Exits");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void txt_national_Validating(object sender, CancelEventArgs e)
        {
            if (long.Parse(txt_national.Text) < 0 || txt_national.Text.Count() < 14)
            {
                e.Cancel = true;
                txt_national.Focus();
                errorProvider1.SetError(txt_national, "Please Enter a Valid National ID");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_national, null);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gpbox_update.Enabled = true;
                userIndex = e.RowIndex;

                DataGridViewRow currentRow = this.dataGridView1.Rows[e.RowIndex];

                txt_national.Text = currentRow.Cells["National_ID"].Value.ToString();
                int indexC = cmb_category.FindString(currentRow.Cells["Category"].Value.ToString());
                cmb_category.SelectedIndex = indexC;
                txt_dosage.Text = currentRow.Cells["Dosages"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.DataSource = UserData.allUsers;
            chart1.DataBind();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int All = UserData.allUsers.Count();
            int One = Admin.OneDosage();
            float result = (One / (float)All) * 100;
            one_txt.Text = result.ToString() + "%";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int All = UserData.allUsers.Count();
            int Full = Admin.FullDosage();
            float result = (Full / (float)All) * 100;
            full_txt.Text = result.ToString() + "%";
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {

            if (int.Parse(textBox6.Text) < 0 || int.Parse(textBox6.Text) > 2)
            {
                e.Cancel = true;
                txt_dosage.Focus();
                errorProvider2.SetError(textBox6, "Number of Dosages are between 1 and 2");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox6, null);
            }


        
    }

        private void unvac_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vacc_btn_Click(object sender, EventArgs e)
        {
            
            float result = (Admin.VaccinatedCairo() /(float)Admin.Cairo()) * 100;
            vac_txt.Text = result.ToString() + "%";
            int count = Admin.VaccinatedCairo();
            MessageBox.Show(count.ToString());
        }

        private void Unvacc_btn_Click(object sender, EventArgs e)
        {
           
            float result = (Admin.UnvaccinatedCairo() / (float)Admin.Cairo()) * 100;
            unvac_txt.Text = result.ToString() + "%";
            int count = Admin.UnvaccinatedCairo();
            MessageBox.Show(count.ToString());
        }

        private void eighteen_btn_Click(object sender, EventArgs e)
        {
            int All = UserData.allUsers.Count();
            float result = (Admin.Eighteen()/ (float )All) * 100;
            eighteen_txt.Text = result.ToString() + "%";
        }

        private void sixty_btn_Click(object sender, EventArgs e)
        {
            int All = UserData.allUsers.Count();
            float result = (Admin.AboveSixty() / (float)All) * 100;
            sixty_txt.Text = result.ToString() + "%";
        }
    }
}
