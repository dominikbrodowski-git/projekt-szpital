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
    public partial class adminEditPanel : Form
    {
        connection con = new connection();
        string login,password,acctype,imie,nazwisko,pesel,zawod,spec,pwz,user_id;
        string query;

        private void usersDataLek_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string editValue, id;

            if (e.ColumnIndex == 1)
            {
                try
                {

                    editValue = usersDataLek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataLek.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET name = '" + editValue + "' WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 2)
            {
                try
                {

                    editValue = usersDataLek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataLek.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET surname = '" + editValue + "' WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 3)
            {
                try
                {

                    editValue = usersDataLek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataLek.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET pesel = " + editValue + " WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 4)
            {
                try
                {

                    editValue = usersDataLek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataLek.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET profession = '" + editValue + "' WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 5)
            {
                try
                {

                    editValue = usersDataLek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataLek.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE specialization SET specialization = '" + editValue + "' WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 6)
            {
                try
                {

                    editValue = usersDataLek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataLek.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE specialization SET pwz = " + editValue + " WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }
        }

        private void users_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string editValue, id;

            if (e.ColumnIndex == 1)
            {
                try
                {

                    editValue = users.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = users.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE users SET login = '" + editValue + "' WHERE id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 2)
            {
                try
                {

                    editValue = users.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = users.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE users SET password = '" + editValue + "' WHERE id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 3)
            {
                try
                {

                    editValue = users.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = users.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE users SET acctype = '" + editValue + "' WHERE id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

        }

        private void usersDataPiel_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            string editValue, id;

            if (e.ColumnIndex == 1)
            {
                try
                {

                    editValue = usersDataPiel.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataPiel.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET name = '" + editValue + "' WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 2)
            {
                try
                {

                    editValue = usersDataPiel.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataPiel.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET surname = '" + editValue + "' WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 3)
            {
                try
                {

                    editValue = usersDataPiel.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataPiel.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET pesel = " + editValue + " WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }

            if (e.ColumnIndex == 4)
            {
                try
                {

                    editValue = usersDataPiel.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    id = usersDataPiel.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (editValue != "")
                    {
                        query = "UPDATE usersData SET profession = '" + editValue + "' WHERE user_id=" + id + " ";
                        con.Open();
                        con.ExecuteNonQuery(query);
                        con.Close();
                        MessageBox.Show("Pomyślnie wyedytowano");
                    }
                    else
                    {
                        MessageBox.Show("Edytowane pole nie może zostać puste");
                    }
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji");
                }
            }
        }

        public adminEditPanel()
        {
            InitializeComponent();
        }

        private void backToAdmin_Click(object sender, EventArgs e)
        {
            var add = new admin();
            this.Hide();
            add.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz wyłączyć program?", "Wyłączanie programu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void editUsers_Click(object sender, EventArgs e)
        {
            if (users.Visible == false)
            {
                usersDataLek.Visible = false;
                usersDataLek.Rows.Clear();
                usersDataLek.Refresh();

                usersDataPiel.Visible = false;
                usersDataPiel.Rows.Clear();
                usersDataPiel.Refresh();

                users.ColumnCount = 4;
                users.Columns[0].Name = "ID";
                users.Columns[1].Name = "Login";
                users.Columns[2].Name = "Hasło";
                users.Columns[3].Name = "Typ konta";

                users.Columns[0].ReadOnly = true;

                con.Open();
                string query = "select id,login,password,acctype from users";
                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        login = row["login"].ToString();
                        password = row["password"].ToString();
                        acctype = row["acctype"].ToString();
                        user_id = row["id"].ToString();

                        string[] newrow = new string[] { user_id, login, password, acctype };
                        users.Rows.Add(newrow);
                    }
                }

                users.Visible = true;
                con.Close();

            }
            else
            {
                users.Visible = false;
                users.Rows.Clear();
                users.Refresh();
            }
        }

        private void editUsersData_Click(object sender, EventArgs e)
        {
            if(pielegniarka.Visible == false)
            {
                pielegniarka.Visible = true;
                lekarz.Visible = true;
            }
            else
            {
                pielegniarka.Visible = false;
                lekarz.Visible = false;
            }
        }

        private void pielegniarka_Click(object sender, EventArgs e)
        {
            if (usersDataPiel.Visible == false)
            {
                usersDataLek.Visible = false;
                usersDataLek.Rows.Clear();
                usersDataLek.Refresh();

                users.Visible = false;
                users.Rows.Clear();
                users.Refresh();

                usersDataPiel.ColumnCount = 5;
                usersDataPiel.Columns[0].Name = "ID";
                usersDataPiel.Columns[1].Name = "Imię";
                usersDataPiel.Columns[2].Name = "Nazwisko";
                usersDataPiel.Columns[3].Name = "PESEL";
                usersDataPiel.Columns[4].Name = "Zawód";

                usersDataPiel.Columns[0].ReadOnly = true;

                con.Open();
                string query = "SELECT user_id,name,surname,pesel,profession FROM usersData where profession like 'Pielegniar%'";
                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        imie = row["name"].ToString();
                        nazwisko = row["surname"].ToString();
                        pesel = row["pesel"].ToString();
                        zawod = row["profession"].ToString();
                        user_id = row["user_id"].ToString();
                        string[] newrow = new string[] { user_id, imie, nazwisko, pesel, zawod };
                        usersDataPiel.Rows.Add(newrow);
                    }
                }

                usersDataPiel.Visible = true;

                
                con.Close();
                usersDataPiel.Update();
            }
            else
            {
                usersDataPiel.Visible = false;
                usersDataPiel.Rows.Clear();
                usersDataPiel.Refresh();
            }
        }

        private void lekarz_Click(object sender, EventArgs e)
        {
            if (usersDataLek.Visible == false)
            {
                usersDataPiel.Visible = false;
                usersDataPiel.Rows.Clear();
                usersDataPiel.Refresh();

                users.Visible = false;
                users.Rows.Clear();
                users.Refresh();

                usersDataLek.ColumnCount = 7;
                usersDataLek.Columns[0].Name = "ID";
                usersDataLek.Columns[1].Name = "Imię";
                usersDataLek.Columns[2].Name = "Nazwisko";
                usersDataLek.Columns[3].Name = "PESEL";
                usersDataLek.Columns[4].Name = "Zawód";
                usersDataLek.Columns[5].Name = "Specjalizacja";
                usersDataLek.Columns[6].Name = "PWZ";

                usersDataLek.Columns[0].ReadOnly = true;

                con.Open();
                string query = "SELECT usersData.user_id,name,surname,pesel,profession,specialization,pwz FROM usersData,specialization where usersData.user_id=specialization.user_id";
                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        imie = row["name"].ToString();
                        nazwisko = row["surname"].ToString();
                        pesel = row["pesel"].ToString();
                        zawod = row["profession"].ToString();
                        spec = row["specialization"].ToString();
                        pwz = row["pwz"].ToString();
                        user_id = row["user_id"].ToString();

                        string[] newrow = new string[] { user_id, imie, nazwisko, pesel, zawod, spec, pwz };
                        usersDataLek.Rows.Add(newrow);
                    }
                }

                usersDataLek.Visible = true;
                con.Close();

            }
            else
            {
                usersDataLek.Visible = false;
                usersDataLek.Rows.Clear();
                usersDataLek.Refresh();
            }
        }
    }
}
