using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballerManagementSystem
{
    public partial class Form1 : Form
    {
        private CountriesDAL countriesDAL;
        private FootballersDAL footballersDAL;
        private string errMess;
        private int errNumber;
        private int login;

        public Form1(int login, string username = "", string password = "")
        {
            InitializeComponent();
            this.login = login;
            string error = string.Empty;
            footballersDAL = new FootballersDAL(login, ref error, username, password);
            if (error != "OK")
            {
                errNumber = 1;
                errMess = "Error" + errNumber + Environment.NewLine +
                          error;
            }
            else
            {
                errMess = "OK";
                countriesDAL = new CountriesDAL();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (errMess == "OK")
            {
                FillCbCountries();
                FillDgvFootballers(-1, null);
                keresésToolStripMenuItem_Click(null, EventArgs.Empty);
                keresésToolStripMenuItem.Visible = true;
                if (login == 0)
                {
                    lbRole.Text = "Admin";
                }
                else if (login == 1)
                {
                    lbRole.Text = "Felhasznalo";
                    törlésToolStripMenuItem.Visible = false;
                }
                else
                {
                    lbRole.Text = "Vendeg";
                    törlésToolStripMenuItem.Visible = false;
                    // módosításToolStripMenuItem.Visible = false;
                }
            }
        }

        private void FillCbCountries()
        {
            string error = string.Empty;
            List<Country> countryList = countriesDAL.GetCountryList(ref error);

            if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK")
                {
                    errMess = string.Empty;
                }

                errMess = errMess + Environment.NewLine + "Error" + errNumber + Environment.NewLine + "" +
                          "Hiba a ComboBox feltoltesenel." + error;
            }
            else
            {
                cbCountries.DataSource = countryList;
                cbCountries.DisplayMember = "CountryName";
                cbCountries.ValueMember = "CountryID";
            }
        }

        private void FillDgvFootballers(int countryID, string name)
        {
            string error = string.Empty;
            dgvFootballers.Rows.Clear();
            List<Footballer> footballerList = footballersDAL.GetFootballerListDataSet(countryID, name, ref error);

            if (footballerList.Count != 0 && error == "OK")
            {
                foreach (Footballer item in footballerList)
                {
                    try
                    {
                        dgvFootballers.Rows.Add(item.FootballerID,
                            item.FootballerName,
                            item.Country.CountryID,
                            item.Country.CountryName,
                            item.Goals,
                            item.Assists,
                            item.Age,
                            item.CurrentValue);
                    }
                    catch (Exception ex)
                    {
                        errNumber++;
                        if (errMess == "OK")
                        {
                            errMess = string.Empty;
                        }

                        errMess = errMess + Environment.NewLine + "Error" +
                                  errNumber + Environment.NewLine + "Invalid data " + ex.Message;
                    }
                }
            }
            else if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK")
                {
                    errMess = string.Empty;
                }

                errMess = errMess + Environment.NewLine +
                          "Error" + errNumber + Environment.NewLine + "Hiba a DataGridView feltoltesenel." + error;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (errMess != "OK")
            {
                ErrorForm errorForm = new ErrorForm(errMess);
                errorForm.Show();
                errorForm.Focus();
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            FillDgvFootballers(Convert.ToInt32(cbCountries.SelectedValue), tbNames.Text);
            if (errMess != "OK")
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvFootballers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_filter.Visible = true;
            bt_delete.Visible = false;
            bt_modosit.Visible = false;

            lbName.Visible = true;
            lbCountry.Visible = true;
            tbNames.Visible = true;
            cbCountries.Visible = true;

            lbGoals.Visible = false;
            tbGoals.Visible = false;

            gbUpdate.Visible = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvFootballers.SelectedRows.Count > 0)
            {
                DialogResult confirmResult =
                    MessageBox.Show(
                        "Ki szeretned torolni a kijelolt sort?\n A torles tobb tablaban is vegre fog hajtodni",
                        "Torles", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int footballerID = Convert.ToInt32(dgvFootballers.SelectedRows[0].Cells["footballerID"].Value);
                    footballersDAL.DeleteFootballer(footballerID, ref errMess);
                    if (errMess != "OK")
                    {
                        errMess += "for user ";
                        errMess += lbRole.Text;
                        ErrorForm errorForm = new ErrorForm(errMess);
                        errorForm.Show();
                        errorForm.Focus();
                    }

                    MessageBox.Show("A torles sikeres volt!");
                    FillDgvFootballers(-1, null);
                }
            }
            else
            {
                MessageBox.Show("Valassz ki egy sort a torleshez!");
            }
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_filter.Visible = false;
            bt_delete.Visible = true;
            bt_modosit.Visible = false;

            lbName.Visible = false;
            lbCountry.Visible = false;
            tbNames.Visible = false;
            cbCountries.Visible = false;

            lbGoals.Visible = false;
            tbGoals.Visible = false;

            gbUpdate.Visible = false;
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_filter.Visible = false;
            bt_delete.Visible = false;
            bt_modosit.Visible = true;

            lbName.Visible = false;
            lbCountry.Visible = false;
            tbNames.Visible = false;
            cbCountries.Visible = false;


            lbGoals.Visible = true;
            tbGoals.Visible = true;

            gbUpdate.Visible = false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dgvFootballers.SelectedRows.Count > 0)
            {
                if (tbGoals.Text != "")
                {
                    int footballerID = Convert.ToInt32(dgvFootballers.SelectedRows[0].Cells["footballerID"].Value);
                    int old = Convert.ToInt32(dgvFootballers.SelectedRows[0].Cells["Goals"].Value);
                    int actual = footballersDAL.GetGoals(footballerID, ref errMess);
                    try
                    {
                        int newv = Convert.ToInt32(tbGoals.Text.Trim());
                        if (newv >= 0)
                        {
                            if (gbUpdate.Visible)
                            {
                                old = Convert.ToInt32(rbOld.Text);
                                actual = Convert.ToInt32(rbActual.Text);
                            }
                            if (old != actual)
                            {
                                if (!rbOld.Checked && !rbActual.Checked && !rbNew.Checked)
                                {
                                    MessageBox.Show("Konkurencia problema lepett fel!");
                                    rbOld.Text = old.ToString();
                                    rbActual.Text = actual.ToString();
                                    rbNew.Text = newv.ToString();
                                    gbUpdate.Visible = true;
                                }
                                else
                                {
                                    if (rbOld.Checked)
                                    {
                                        footballersDAL.UpdateFootballerGoals(footballerID, old, ref errMess);
                                        if (errMess != "OK")
                                        {
                                            errMess += "for user ";
                                            errMess += lbRole.Text;
                                            ErrorForm errorForm = new ErrorForm(errMess);
                                            errorForm.Show();
                                            errorForm.Focus();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sikeres modositas!");
                                        }
                                        rbOld.Checked = false;
                                    }
                                    else if (rbActual.Checked)
                                    {
                                        footballersDAL.UpdateFootballerGoals(footballerID, actual, ref errMess);
                                        if (errMess != "OK")
                                        {
                                            errMess += "for user ";
                                            errMess += lbRole.Text;
                                            ErrorForm errorForm = new ErrorForm(errMess);
                                            errorForm.Show();
                                            errorForm.Focus();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sikeres modositas!");
                                        }

                                        rbActual.Checked = false;
                                    }
                                    else if (rbNew.Checked)
                                    {
                                        footballersDAL.UpdateFootballerGoals(footballerID, newv, ref errMess);
                                        if (errMess != "OK")
                                        {
                                            errMess += "for user ";
                                            errMess += lbRole.Text;
                                            ErrorForm errorForm = new ErrorForm(errMess);
                                            errorForm.Show();
                                            errorForm.Focus();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sikeres modositas!");
                                        }

                                        rbNew.Checked = false;
                                    }

                                    gbUpdate.Visible = false;
                                }
                            }
                            else
                            {
                                footballersDAL.UpdateFootballerGoals(footballerID, newv, ref errMess);
                                if (errMess != "OK")
                                {
                                    errMess += "for user ";
                                    errMess += lbRole.Text;
                                    ErrorForm errorForm = new ErrorForm(errMess);
                                    errorForm.Show();
                                    errorForm.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Sikeres modositas!");
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Adj meg egy termeszetes szamot");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Adj meg egy termeszetes szamot");
                    }
                }
                else
                {
                    MessageBox.Show("Valassz ki egy sort!");
                }
            }

            FillDgvFootballers(-1, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Close();
        }
    }
}