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
    public partial class adminAddPanel : Form
    {
        string id;
        connection con = new connection();
        public adminAddPanel()
        {
            InitializeComponent();
            Size = new Size(938, 115);
        }

        private void adminAcc_Click(object sender, EventArgs e)
        {
            if (adminLogin.Visible == false )
            {
                Size = new Size(938, 165);
                adminPass.Visible = true;
                adminPassBox.Visible = true;
                adminLogin.Visible = true;
                adminLoginBox.Visible = true;
                adminAddBtn.Visible = true;

                userPass.Visible = false;
                userPassBox.Visible = false;
                userLogin.Visible = false;
                userLoginBox.Visible = false;

                name.Visible = false;
                nameBox.Visible = false;
                surname.Visible = false;
                surnameBox.Visible = false;
                pesel.Visible = false;
                peselBox.Visible = false;
                zawod.Visible = false;
                zawodBox.Visible = false;
                pwz.Visible = false;
                pwzBox.Visible = false;
                spec.Visible = false;
                specBox.Visible = false;
                userAddBtn.Visible = false;
            }
            else
            {
                Size = new Size(938, 115);
                adminPass.Visible = false;
                adminPassBox.Visible = false;
                adminLogin.Visible = false;
                adminLoginBox.Visible = false;
                adminAddBtn.Visible = false;

                userPass.Visible = false;
                userPassBox.Visible = false;
                userLogin.Visible = false;
                userLoginBox.Visible = false;

                name.Visible = false;
                nameBox.Visible = false;
                surname.Visible = false;
                surnameBox.Visible = false;
                pesel.Visible = false;
                peselBox.Visible = false;
                zawod.Visible = false;
                zawodBox.Visible = false;
                pwz.Visible = false;
                pwzBox.Visible = false;
                spec.Visible = false;
                specBox.Visible = false;
                userAddBtn.Visible = false;
            }

        }

        private void userAcc_Click(object sender, EventArgs e)
        {
            if (userLogin.Visible == false )
            {
                Size = new Size(938, 328);

                adminPass.Visible = false;
                adminPassBox.Visible = false;
                adminLogin.Visible = false;
                adminLoginBox.Visible = false;
                adminAddBtn.Visible = false;

                userPass.Visible = true;
                userPassBox.Visible = true;
                userLogin.Visible = true;
                userLoginBox.Visible = true;

                name.Visible = true;
                nameBox.Visible = true;
                surname.Visible = true;
                surnameBox.Visible = true;
                pesel.Visible = true;
                peselBox.Visible = true;
                zawod.Visible = true;
                zawodBox.Visible = true;
                userAddBtn.Visible = true;

            }
            else
            {
                Size = new Size(938, 115);

                adminPass.Visible = false;
                adminPassBox.Visible = false;
                adminLogin.Visible = false;
                adminLoginBox.Visible = false;
                adminAddBtn.Visible = false;

                userPass.Visible = false;
                userPassBox.Visible = false;
                userLogin.Visible = false;
                userLoginBox.Visible = false;

                name.Visible = false;
                nameBox.Visible = false;
                surname.Visible = false;
                surnameBox.Visible = false;
                pesel.Visible = false;
                peselBox.Visible = false;
                zawod.Visible = false;
                zawodBox.Visible = false;
                pwz.Visible = false;
                pwzBox.Visible = false;
                spec.Visible = false;
                specBox.Visible = false;
                userAddBtn.Visible = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz wyłączyć program?", "Wyłączanie programu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void backToAdmin_Click(object sender, EventArgs e)
        {
            var add = new admin();
            this.Hide();
            add.Show();
        }

        private void adminAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (adminLoginBox.Text != "" && adminPassBox.Text != "")
                {
                    string query = "INSERT INTO users(id, login, password, acctype) VALUES('', '" + adminLoginBox.Text + "', '" + adminPassBox.Text + "', 'admin');";

                    con.Open();
                    con.ExecuteNonQuery(query);
                    MessageBox.Show("Dodano użytkownika", "Sukces");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nie uzupełniłeś wszystkich danych", "BŁĄD");
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika", "BŁĄD");
            }
        }

        public void lastid()
        {
            con.Open();
            string query = "select id from users order BY id DESC limit 1";
            MySqlDataReader row;
            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    id = row["id"].ToString();
                }
            }

            con.Close();
        }

        private void zawodBox_TextChanged(object sender, EventArgs e)
        {
            if(zawodBox.Text=="Lekarz" || zawodBox.Text == "lekarz")
            {
                pwz.Visible = true;
                pwzBox.Visible = true;
                spec.Visible = true;
                specBox.Visible = true;
            }
            else
            {
                pwz.Visible = false;
                pwzBox.Visible = false;
                spec.Visible = false;
                specBox.Visible = false;
            }
        }

        private void userAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userLoginBox.Text != "" && userPassBox.Text != "" && nameBox.Text != "" && surnameBox.Text != "" && peselBox.Text != "" && zawodBox.Text != "")
                {
                    //if (zawodBox.Text != "lekarz" || zawodBox.Text != "Lekarz" || zawodBox.Text!= "Pielegniarz" || zawodBox.Text != "pielegniarz" || zawodBox.Text != "Pielegniarka" || zawodBox.Text != "pielegniarka")
                    //{
                    //    MessageBox.Show("Podałeś zawód który jest nie prawidłowy", "BŁĄD");
                    //}

                    if (zawodBox.Text == "lekarz" || zawodBox.Text == "Lekarz")
                    {
                        if(specBox.Text != "" && pwzBox.Text != "")
                        {
                            string query = "INSERT INTO users(id, login, password, acctype) VALUES('', '" + userLoginBox.Text + "', '" + userPassBox.Text + "', 'user');";

                            con.Open();
                            con.ExecuteNonQuery(query);
                            con.Close();

                            lastid();

                            query = "INSERT INTO usersData(id, user_id, name, surname, pesel, profession) VALUES('', '" + id + "', '" + nameBox.Text + "', '" + surnameBox.Text + "','" + peselBox.Text + "','" + zawodBox.Text + "');";
                            con.Open();
                            con.ExecuteNonQuery(query);
                            con.Close();

                            query = "INSERT INTO specialization(id, user_id, specialization, pwz) VALUES('', '" + id + "', '" + specBox.Text + "', '" + pwzBox.Text + "');";

                            con.Open();
                            con.ExecuteNonQuery(query);
                            con.Close();

                            MessageBox.Show("Dodano użytkownika", "Sukces");
                        }
                        else
                        {
                            MessageBox.Show("Musisz uzupełnić każde pole", "BŁĄD");
                        }
                        
                    }
                    else
                    {
                        string query = "INSERT INTO users(id, login, password, acctype) VALUES('', '" + userLoginBox.Text + "', '" + userPassBox.Text + "', 'user');";

                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();

                        lastid();

                        query = "INSERT INTO usersData(id, user_id, name, surname, pesel, profession) VALUES('', '" + id + "', '" + nameBox.Text + "', '" + surnameBox.Text + "','" + peselBox.Text + "','" + zawodBox.Text + "');";
                        con.Open();
                        con.ExecuteNonQuery(query);

                        con.Close();

                        MessageBox.Show("Dodano użytkownika", "Sukces");
                    }
                }
                else
                {
                    MessageBox.Show("Musisz uzupełnić każde pole", "BŁĄD");
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania nowego użytkownika", "BŁĄD");
            }
        }
    }
}
