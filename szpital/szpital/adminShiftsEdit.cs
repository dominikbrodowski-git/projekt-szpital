using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szpital
{
    public partial class adminShiftsEdit : Form
    {
        public adminShiftsEdit()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
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
    }
}
