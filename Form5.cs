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
    public partial class Form5 : Form
    {
        List<User> users = new List<User>();
        public Form5()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool flag = false;
            long ID = long.Parse(IDtxt.Text);
            ViewInfo viewForm = new ViewInfo();
            if (string.IsNullOrWhiteSpace(IDtxt.Text) && string.IsNullOrWhiteSpace(passtxt.Text))
            {
                MessageBox.Show("Missing Information !");

            }
            else
            {
                try
                {
                    users = UserData.getUserlist();
                    for (int i = 0; i < users.Count(); i++)
                    {

                        if (ID == users[i].NationalID && passtxt.Text == users[i].password)
                        {
                            //User.Active_user_ID = ID;
                            flag = true;
                            MessageBox.Show("Welcome");
                            viewForm.recieveData(ID);
                            this.Hide();
                            viewForm.Show();
                            break;

                        }

                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Error Occured");

                }

                if (!flag)
                {
                    MessageBox.Show("Incorrect username or password !");
                }
            }
            
            this.Hide();
            viewForm.Show();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
