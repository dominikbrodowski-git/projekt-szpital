namespace szpital
{
    partial class adminEditPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminEditPanel));
            this.editUsers = new System.Windows.Forms.Button();
            this.editUsersData = new System.Windows.Forms.Button();
            this.backToAdmin = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pielegniarka = new System.Windows.Forms.Button();
            this.lekarz = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.DataGridView();
            this.usersDataLek = new System.Windows.Forms.DataGridView();
            this.usersDataPiel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataLek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataPiel)).BeginInit();
            this.SuspendLayout();
            // 
            // editUsers
            // 
            this.editUsers.Location = new System.Drawing.Point(33, 54);
            this.editUsers.Name = "editUsers";
            this.editUsers.Size = new System.Drawing.Size(192, 25);
            this.editUsers.TabIndex = 0;
            this.editUsers.Text = "Edytuj dane do logowania";
            this.editUsers.UseVisualStyleBackColor = true;
            this.editUsers.Click += new System.EventHandler(this.editUsers_Click);
            // 
            // editUsersData
            // 
            this.editUsersData.Location = new System.Drawing.Point(258, 54);
            this.editUsersData.Name = "editUsersData";
            this.editUsersData.Size = new System.Drawing.Size(236, 25);
            this.editUsersData.TabIndex = 1;
            this.editUsersData.Text = "Edytuj dane użytkowników";
            this.editUsersData.UseVisualStyleBackColor = true;
            this.editUsersData.Click += new System.EventHandler(this.editUsersData_Click);
            // 
            // backToAdmin
            // 
            this.backToAdmin.Location = new System.Drawing.Point(633, 13);
            this.backToAdmin.Name = "backToAdmin";
            this.backToAdmin.Size = new System.Drawing.Size(139, 25);
            this.backToAdmin.TabIndex = 2;
            this.backToAdmin.Text = "Wróc do panelu";
            this.backToAdmin.UseVisualStyleBackColor = true;
            this.backToAdmin.Click += new System.EventHandler(this.backToAdmin_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(779, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(140, 25);
            this.close.TabIndex = 3;
            this.close.Text = "Wyłącz program";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pielegniarka
            // 
            this.pielegniarka.Location = new System.Drawing.Point(258, 97);
            this.pielegniarka.Name = "pielegniarka";
            this.pielegniarka.Size = new System.Drawing.Size(127, 25);
            this.pielegniarka.TabIndex = 4;
            this.pielegniarka.Text = "Pielęgniarka/arz";
            this.pielegniarka.UseVisualStyleBackColor = true;
            this.pielegniarka.Visible = false;
            this.pielegniarka.Click += new System.EventHandler(this.pielegniarka_Click);
            // 
            // lekarz
            // 
            this.lekarz.Location = new System.Drawing.Point(406, 97);
            this.lekarz.Name = "lekarz";
            this.lekarz.Size = new System.Drawing.Size(87, 25);
            this.lekarz.TabIndex = 5;
            this.lekarz.Text = "Lekarz";
            this.lekarz.UseVisualStyleBackColor = true;
            this.lekarz.Visible = false;
            this.lekarz.Click += new System.EventHandler(this.lekarz_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(33, 23);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(165, 14);
            this.text.TabIndex = 6;
            this.text.Text = "Wybierz co chcesz edytować";
            // 
            // users
            // 
            this.users.AllowUserToAddRows = false;
            this.users.AllowUserToDeleteRows = false;
            this.users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users.Location = new System.Drawing.Point(33, 160);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(560, 291);
            this.users.TabIndex = 7;
            this.users.Visible = false;
            this.users.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_CellEndEdit);
            // 
            // usersDataLek
            // 
            this.usersDataLek.AllowUserToAddRows = false;
            this.usersDataLek.AllowUserToDeleteRows = false;
            this.usersDataLek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataLek.Location = new System.Drawing.Point(59, 160);
            this.usersDataLek.Name = "usersDataLek";
            this.usersDataLek.Size = new System.Drawing.Size(839, 291);
            this.usersDataLek.TabIndex = 8;
            this.usersDataLek.Visible = false;
            this.usersDataLek.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataLek_CellEndEdit);
            // 
            // usersDataPiel
            // 
            this.usersDataPiel.AllowUserToAddRows = false;
            this.usersDataPiel.AllowUserToDeleteRows = false;
            this.usersDataPiel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataPiel.Location = new System.Drawing.Point(86, 160);
            this.usersDataPiel.Name = "usersDataPiel";
            this.usersDataPiel.Size = new System.Drawing.Size(668, 291);
            this.usersDataPiel.TabIndex = 9;
            this.usersDataPiel.Visible = false;
            this.usersDataPiel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataPiel_CellEndEdit);
            // 
            // adminEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.usersDataPiel);
            this.Controls.Add(this.usersDataLek);
            this.Controls.Add(this.users);
            this.Controls.Add(this.text);
            this.Controls.Add(this.lekarz);
            this.Controls.Add(this.pielegniarka);
            this.Controls.Add(this.close);
            this.Controls.Add(this.backToAdmin);
            this.Controls.Add(this.editUsersData);
            this.Controls.Add(this.editUsers);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminEditPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytowanie użytkowników";
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataLek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataPiel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editUsers;
        private System.Windows.Forms.Button editUsersData;
        private System.Windows.Forms.Button backToAdmin;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button pielegniarka;
        private System.Windows.Forms.Button lekarz;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.DataGridView users;
        private System.Windows.Forms.DataGridView usersDataLek;
        private System.Windows.Forms.DataGridView usersDataPiel;
    }
}