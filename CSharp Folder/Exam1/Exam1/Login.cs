using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }


        private void Login_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = "Username";
            passwordLbl.Text = "Password";
            loginBtn.Text = "Login";

            usernameErrorLbl.Visible= false;
            passwordErrorLbl.Visible= false;
        }
    }
}
