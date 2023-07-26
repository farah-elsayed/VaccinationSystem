using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace vacc
{
    public partial class Form2 : Form
    {
        //Saved For efficiency
        Admin admin;

        public Form2()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String username = txtuser.Text;
            int pass = Convert.ToInt32(txtpass.Text);

            if (admin.login(username, pass))
            {
                MessageBox.Show("Welcome!");
                this.timer1.Start();
                button1.Hide();
                progressBar1.Show();
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();

            }
            else
            {
                MessageBox.Show("Wrong User Name or Pass sis ! ");


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                //this.Hide();
                
            
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            progressBar1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backToMainBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
