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
    public partial class admin : Form
    {
        connection con = new connection();
        string name, surname, pesel, prof, spec, pwz;

        private void showUsers_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Visible == false)
            {
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Imie";
                dataGridView1.Columns[1].Name = "Nazwisko";
                dataGridView1.Columns[2].Name = "Pesel";
                dataGridView1.Columns[3].Name = "Zawód";
                dataGridView1.Columns[4].Name = "Specjalizacja";
                dataGridView1.Columns[5].Name = "PWZ";

                con.Open();
                string query = "SELECT name,surname,pesel,profession,specialization,pwz FROM usersData LEFT JOIN specialization ON usersData.user_id=specialization.user_id";
                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        name = row["name"].ToString();
                        surname = row["surname"].ToString();
                        pesel = row["pesel"].ToString();
                        prof = row["profession"].ToString();
                        spec = row["specialization"].ToString();
                        pwz = row["pwz"].ToString();


                        string[] newrow = new string[] { name, surname, pesel, prof, spec, pwz };
                        dataGridView1.Rows.Add(newrow);
                    }
                }

                Size = new Size(938, 490);
                dataGridView1.Visible = true;
                con.Close();

            }
            else
            {
                Size = new Size(938, 200);
                dataGridView1.Visible = false;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }  
        }

        public admin()
        {
            InitializeComponent();
        }

        private void shiftsEdit_Click(object sender, EventArgs e)
        {
            var add = new adminShiftsEdit();
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

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz się wylogować?", "Wyloguj się", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var add = new login();
                this.Hide();
                add.Show();
            }
        }

        private void newUserBTN_Click(object sender, EventArgs e)
        {
            var add = new adminAddPanel();
            this.Hide();
            add.Show();

        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            var add = new adminEditPanel();
            this.Hide();
            add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
