using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FootballerManagementSystem
{
    public partial class RegistrationForm : Form
    {
        private CountriesDAL countriesDAL;
        private FootballersDAL footballersDAL;
        private string errMess;
        private int errNumber;
        public RegistrationForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbPasswordAgain.PasswordChar = '*';

            string error = string.Empty;
            footballersDAL = new FootballersDAL(-1, ref error);
            if (error != "OK")
            {
                errNumber = 1;
                errMess = "Error" + errNumber + Environment.NewLine + "Footballers objektumot nem tudtam letrehozni. " +
                          error;
            }
            else
            {
                errMess = "OK";
                countriesDAL = new CountriesDAL();
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbPasswordAgain.Text)
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                footballersDAL.CreateUser(username, password, ref errMess);
                if (errMess == "OK")
                {
                    MessageBox.Show("Sikeres regisztracio!");
                }
                else
                {
                    ErrorForm errorForm = new ErrorForm(errMess);
                    errorForm.Show();
                    errorForm.Focus();
                }
            }
            else
            {
                MessageBox.Show("A ket jelszo nem egyezik meg!");
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Close();
        }
    }
}
