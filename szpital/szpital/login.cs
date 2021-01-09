using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace szpital
{
    public partial class login : Form
    {
        connection con = new connection();

        string acctype, username, password, id;
        public login()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz wyłączyć program?", "Wyłączanie programu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if(passwordBox.PasswordChar == '*')
            {
                passwordBox.PasswordChar = '\0';
                showPassword.Text = "Ukryj hasło";
            }
            else
            {
                passwordBox.PasswordChar = '*';
                showPassword.Text = "Pokaż hasło";
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (loginBox.Text != "" && passwordBox.Text != "")
                {
                    con.Open();
                    string query = "select id,login,password,acctype from users WHERE login ='" + loginBox.Text + "' AND password ='" + passwordBox.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            username = row["login"].ToString();
                            password = row["password"].ToString();
                            acctype = row["acctype"].ToString();
                        }

                        if (acctype == "admin")
                        {
                            var add = new admin();
                            this.Hide();
                            add.Show();
                            con.Close();
                        }

                        if (acctype == "user")
                        {
                            var add = new userpanel();
                            this.Hide();
                            add.Show();
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Błędny login lub hasło", "BŁĄD");
                    }
                }
                else
                {
                    MessageBox.Show("Musisz wpisać login i hasło", "BŁĄD");
                }
            }
            catch
            {
                MessageBox.Show("Błąd połączenia", "BŁĄD");
            }
        }  
    }
}
