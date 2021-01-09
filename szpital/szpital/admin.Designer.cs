namespace szpital
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.newUserBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.witaj = new System.Windows.Forms.Label();
            this.showUsers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logOut = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.shiftsEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // newUserBTN
            // 
            this.newUserBTN.Location = new System.Drawing.Point(131, 87);
            this.newUserBTN.Name = "newUserBTN";
            this.newUserBTN.Size = new System.Drawing.Size(278, 25);
            this.newUserBTN.TabIndex = 0;
            this.newUserBTN.Text = "Dodaj nowego użytkownika";
            this.newUserBTN.UseVisualStyleBackColor = true;
            this.newUserBTN.Click += new System.EventHandler(this.newUserBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(131, 118);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(278, 25);
            this.editBTN.TabIndex = 1;
            this.editBTN.Text = "Edytuj dane użytkowników";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // witaj
            // 
            this.witaj.AutoSize = true;
            this.witaj.Font = new System.Drawing.Font("Tahoma", 15F);
            this.witaj.Location = new System.Drawing.Point(32, 21);
            this.witaj.Name = "witaj";
            this.witaj.Size = new System.Drawing.Size(238, 24);
            this.witaj.TabIndex = 2;
            this.witaj.Text = "PANEL ADMINISTRATORA";
            // 
            // showUsers
            // 
            this.showUsers.Location = new System.Drawing.Point(131, 56);
            this.showUsers.Name = "showUsers";
            this.showUsers.Size = new System.Drawing.Size(278, 25);
            this.showUsers.TabIndex = 3;
            this.showUsers.Text = "Wyświetl wszystkich użytkowników";
            this.showUsers.UseVisualStyleBackColor = true;
            this.showUsers.Click += new System.EventHandler(this.showUsers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(131, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(661, 256);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(668, 24);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(87, 25);
            this.logOut.TabIndex = 5;
            this.logOut.Text = "Wyloguj się";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(763, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(128, 25);
            this.close.TabIndex = 6;
            this.close.Text = "Wyłącz program";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // shiftsEdit
            // 
            this.shiftsEdit.Location = new System.Drawing.Point(131, 149);
            this.shiftsEdit.Name = "shiftsEdit";
            this.shiftsEdit.Size = new System.Drawing.Size(278, 23);
            this.shiftsEdit.TabIndex = 7;
            this.shiftsEdit.Text = "Edytuj dyżury ";
            this.shiftsEdit.UseVisualStyleBackColor = true;
            this.shiftsEdit.Click += new System.EventHandler(this.shiftsEdit_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(938, 200);
            this.Controls.Add(this.shiftsEdit);
            this.Controls.Add(this.close);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showUsers);
            this.Controls.Add(this.witaj);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.newUserBTN);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel administratora";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newUserBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Label witaj;
        private System.Windows.Forms.Button showUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button shiftsEdit;
    }
}