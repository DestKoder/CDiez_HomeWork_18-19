using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDiez_HomeWork_18_19.form
{
    public partial class RegisterForm : Form
    {
        public User User { get; private set; }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(name.Text)) return;

            this.User = new User(name.Text, login.Text, password.Text);

            DialogResult = DialogResult.OK;
        }
    }
}
