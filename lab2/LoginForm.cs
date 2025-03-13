using System;
using System.Windows.Forms;

namespace FootballerManagementSystem
{
    public partial class LoginForm : Form
    {
        private CountriesDAL countriesDAL;
        private FootballersDAL footballersDAL;
        private string errMess;
        private int errNumber;
        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
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

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            int login;
            login = username == "Admin" ? 0 : 1;
            if (login == 0)
            {
                if (password != "admin")
                {
                    MessageBox.Show("Helytelen jelszo");
                }
                else
                {
                    Form form = new Form1(login, username, password);
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                string error = string.Empty;
                if (footballersDAL.existsUser(username, ref error))
                {
                    Form form = new Form1(login, username, password);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nem letezik a felhasznalo");
                }
            }

        }

        private void btLoginGuest_Click(object sender, EventArgs e)
        {
            int login = 2;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            try
            {
                Form form = new Form1(login, username, password);
                form.Show();
                this.Hide();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            Form form = new RegistrationForm();
            form.Show();
            this.Hide();
        }
    }
}
