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
    public partial class AfterAuth : Form
    {
        public AfterAuth(String login, String password, String name)
        {
            InitializeComponent();

            this.login.Text = login;
            this.password.Text = password;
            this.name.Text = name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
