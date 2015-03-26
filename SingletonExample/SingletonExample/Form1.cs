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

namespace SingletonExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text;
            string password = txbPassword.Text;
            DateTime date = DateTime.Now;
            if (!LoggerSingleton.IsAuthorized())
            {
                LoggerSingleton.Signin(login, password, date);
                MessageBox.Show("You have logged in");
            }
            else
                MessageBox.Show("Is already authorized");
          //  MessageBox.Show(LoggerSingleton.GetInstance.Login);
           
            
            //LoggerSingleton.Signout();
        }
    }
}
