using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDiez_HomeWork_18_19.form;

namespace CDiez_HomeWork_18_19
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        private RegisterForm form;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text)) return;

            //new AfterAuth(login.Text, password.Text).ShowDialog();
        
            foreach(User user in users)
            {
                if(user.Login.Equals(login.Text) && user.Password.Equals(password.Text))
                {
                    new AfterAuth(user.Login, user.Password, user.Name).ShowDialog();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form = new RegisterForm();

            if(form.ShowDialog() == DialogResult.OK)
            {
                this.users.Add(form.User);
            }
        }
    }
}
