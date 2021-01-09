namespace szpital
{
    partial class adminAddPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminAddPanel));
            this.adminAcc = new System.Windows.Forms.Button();
            this.userAcc = new System.Windows.Forms.Button();
            this.kogo = new System.Windows.Forms.Label();
            this.backToAdmin = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.adminLogin = new System.Windows.Forms.Label();
            this.adminPass = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.Label();
            this.zawod = new System.Windows.Forms.Label();
            this.pwz = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.Label();
            this.adminLoginBox = new System.Windows.Forms.TextBox();
            this.userLoginBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.peselBox = new System.Windows.Forms.TextBox();
            this.zawodBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pwzBox = new System.Windows.Forms.TextBox();
            this.adminPassBox = new System.Windows.Forms.TextBox();
            this.userPassBox = new System.Windows.Forms.TextBox();
            this.specBox = new System.Windows.Forms.TextBox();
            this.adminAddBtn = new System.Windows.Forms.Button();
            this.userAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminAcc
            // 
            this.adminAcc.Location = new System.Drawing.Point(51, 50);
            this.adminAcc.Name = "adminAcc";
            this.adminAcc.Size = new System.Drawing.Size(180, 25);
            this.adminAcc.TabIndex = 17;
            this.adminAcc.Text = "Konto administrator";
            this.adminAcc.UseVisualStyleBackColor = true;
            this.adminAcc.Click += new System.EventHandler(this.adminAcc_Click);
            // 
            // userAcc
            // 
            this.userAcc.Location = new System.Drawing.Point(269, 50);
            this.userAcc.Name = "userAcc";
            this.userAcc.Size = new System.Drawing.Size(192, 25);
            this.userAcc.TabIndex = 18;
            this.userAcc.Text = "Konto pracownika szpitala";
            this.userAcc.UseVisualStyleBackColor = true;
            this.userAcc.Click += new System.EventHandler(this.userAcc_Click);
            // 
            // kogo
            // 
            this.kogo.AutoSize = true;
            this.kogo.Location = new System.Drawing.Point(48, 21);
            this.kogo.Name = "kogo";
            this.kogo.Size = new System.Drawing.Size(118, 14);
            this.kogo.TabIndex = 19;
            this.kogo.Text = "Kogo chcesz dodać?";
            // 
            // backToAdmin
            // 
            this.backToAdmin.Location = new System.Drawing.Point(614, 14);
            this.backToAdmin.Name = "backToAdmin";
            this.backToAdmin.Size = new System.Drawing.Size(163, 25);
            this.backToAdmin.TabIndex = 20;
            this.backToAdmin.Text = "Wróć do panelu";
            this.backToAdmin.UseVisualStyleBackColor = true;
            this.backToAdmin.Click += new System.EventHandler(this.backToAdmin_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(784, 14);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(128, 25);
            this.close.TabIndex = 21;
            this.close.Text = "Wyłącz program";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // adminLogin
            // 
            this.adminLogin.AutoSize = true;
            this.adminLogin.Location = new System.Drawing.Point(51, 99);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(36, 14);
            this.adminLogin.TabIndex = 22;
            this.adminLogin.Text = "Login";
            this.adminLogin.Visible = false;
            // 
            // adminPass
            // 
            this.adminPass.AutoSize = true;
            this.adminPass.Location = new System.Drawing.Point(266, 99);
            this.adminPass.Name = "adminPass";
            this.adminPass.Size = new System.Drawing.Size(35, 14);
            this.adminPass.TabIndex = 22;
            this.adminPass.Text = "Hasło";
            this.adminPass.Visible = false;
            // 
            // userLogin
            // 
            this.userLogin.AutoSize = true;
            this.userLogin.Location = new System.Drawing.Point(51, 133);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(36, 14);
            this.userLogin.TabIndex = 22;
            this.userLogin.Text = "Login";
            this.userLogin.Visible = false;
            // 
            // userPass
            // 
            this.userPass.AutoSize = true;
            this.userPass.Location = new System.Drawing.Point(266, 133);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(35, 14);
            this.userPass.TabIndex = 22;
            this.userPass.Text = "Hasło";
            this.userPass.Visible = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(51, 165);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(30, 14);
            this.name.TabIndex = 22;
            this.name.Text = "Imie";
            this.name.Visible = false;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(51, 197);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(56, 14);
            this.surname.TabIndex = 22;
            this.surname.Text = "Nazwisko";
            this.surname.Visible = false;
            // 
            // pesel
            // 
            this.pesel.AutoSize = true;
            this.pesel.Location = new System.Drawing.Point(51, 223);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(35, 14);
            this.pesel.TabIndex = 22;
            this.pesel.Text = "Pesel";
            this.pesel.Visible = false;
            // 
            // zawod
            // 
            this.zawod.AutoSize = true;
            this.zawod.Location = new System.Drawing.Point(51, 253);
            this.zawod.Name = "zawod";
            this.zawod.Size = new System.Drawing.Size(44, 14);
            this.zawod.TabIndex = 22;
            this.zawod.Text = "Zawód";
            this.zawod.Visible = false;
            // 
            // pwz
            // 
            this.pwz.AutoSize = true;
            this.pwz.Location = new System.Drawing.Point(266, 165);
            this.pwz.Name = "pwz";
            this.pwz.Size = new System.Drawing.Size(33, 14);
            this.pwz.TabIndex = 22;
            this.pwz.Text = "PWZ";
            this.pwz.Visible = false;
            // 
            // spec
            // 
            this.spec.AutoSize = true;
            this.spec.Location = new System.Drawing.Point(266, 197);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(73, 14);
            this.spec.TabIndex = 22;
            this.spec.Text = "Specjalizacja";
            this.spec.Visible = false;
            // 
            // adminLoginBox
            // 
            this.adminLoginBox.Location = new System.Drawing.Point(120, 96);
            this.adminLoginBox.Name = "adminLoginBox";
            this.adminLoginBox.Size = new System.Drawing.Size(116, 22);
            this.adminLoginBox.TabIndex = 23;
            this.adminLoginBox.Visible = false;
            // 
            // userLoginBox
            // 
            this.userLoginBox.Location = new System.Drawing.Point(120, 132);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(116, 22);
            this.userLoginBox.TabIndex = 23;
            this.userLoginBox.Visible = false;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(120, 193);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(116, 22);
            this.surnameBox.TabIndex = 23;
            this.surnameBox.Visible = false;
            // 
            // peselBox
            // 
            this.peselBox.Location = new System.Drawing.Point(120, 223);
            this.peselBox.Name = "peselBox";
            this.peselBox.Size = new System.Drawing.Size(116, 22);
            this.peselBox.TabIndex = 23;
            this.peselBox.Visible = false;
            // 
            // zawodBox
            // 
            this.zawodBox.Location = new System.Drawing.Point(120, 250);
            this.zawodBox.Name = "zawodBox";
            this.zawodBox.Size = new System.Drawing.Size(116, 22);
            this.zawodBox.TabIndex = 23;
            this.zawodBox.Visible = false;
            this.zawodBox.TextChanged += new System.EventHandler(this.zawodBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(120, 161);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(116, 22);
            this.nameBox.TabIndex = 23;
            this.nameBox.Visible = false;
            // 
            // pwzBox
            // 
            this.pwzBox.Location = new System.Drawing.Point(353, 161);
            this.pwzBox.Name = "pwzBox";
            this.pwzBox.Size = new System.Drawing.Size(116, 22);
            this.pwzBox.TabIndex = 23;
            this.pwzBox.Visible = false;
            // 
            // adminPassBox
            // 
            this.adminPassBox.Location = new System.Drawing.Point(353, 96);
            this.adminPassBox.Name = "adminPassBox";
            this.adminPassBox.Size = new System.Drawing.Size(116, 22);
            this.adminPassBox.TabIndex = 23;
            this.adminPassBox.Visible = false;
            // 
            // userPassBox
            // 
            this.userPassBox.Location = new System.Drawing.Point(353, 129);
            this.userPassBox.Name = "userPassBox";
            this.userPassBox.Size = new System.Drawing.Size(116, 22);
            this.userPassBox.TabIndex = 23;
            this.userPassBox.Visible = false;
            // 
            // specBox
            // 
            this.specBox.Location = new System.Drawing.Point(353, 197);
            this.specBox.Name = "specBox";
            this.specBox.Size = new System.Drawing.Size(116, 22);
            this.specBox.TabIndex = 23;
            this.specBox.Visible = false;
            // 
            // adminAddBtn
            // 
            this.adminAddBtn.Location = new System.Drawing.Point(624, 93);
            this.adminAddBtn.Name = "adminAddBtn";
            this.adminAddBtn.Size = new System.Drawing.Size(220, 25);
            this.adminAddBtn.TabIndex = 24;
            this.adminAddBtn.Text = "Dodaj nowego użytkownika";
            this.adminAddBtn.UseVisualStyleBackColor = true;
            this.adminAddBtn.Visible = false;
            this.adminAddBtn.Click += new System.EventHandler(this.adminAddBtn_Click);
            // 
            // userAddBtn
            // 
            this.userAddBtn.Location = new System.Drawing.Point(624, 193);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Size = new System.Drawing.Size(220, 25);
            this.userAddBtn.TabIndex = 25;
            this.userAddBtn.Text = "Dodaj nowego użytkownika";
            this.userAddBtn.UseVisualStyleBackColor = true;
            this.userAddBtn.Visible = false;
            this.userAddBtn.Click += new System.EventHandler(this.userAddBtn_Click);
            // 
            // adminAddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(933, 311);
            this.Controls.Add(this.userAddBtn);
            this.Controls.Add(this.adminAddBtn);
            this.Controls.Add(this.specBox);
            this.Controls.Add(this.userPassBox);
            this.Controls.Add(this.adminPassBox);
            this.Controls.Add(this.pwzBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.zawodBox);
            this.Controls.Add(this.peselBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.userLoginBox);
            this.Controls.Add(this.adminLoginBox);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.pwz);
            this.Controls.Add(this.zawod);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.adminPass);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.close);
            this.Controls.Add(this.backToAdmin);
            this.Controls.Add(this.kogo);
            this.Controls.Add(this.userAcc);
            this.Controls.Add(this.adminAcc);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminAddPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowego użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adminAcc;
        private System.Windows.Forms.Button userAcc;
        private System.Windows.Forms.Label kogo;
        private System.Windows.Forms.Button backToAdmin;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label adminLogin;
        private System.Windows.Forms.Label adminPass;
        private System.Windows.Forms.Label userLogin;
        private System.Windows.Forms.Label userPass;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label pesel;
        private System.Windows.Forms.Label zawod;
        private System.Windows.Forms.Label pwz;
        private System.Windows.Forms.Label spec;
        private System.Windows.Forms.TextBox adminLoginBox;
        private System.Windows.Forms.TextBox userLoginBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox peselBox;
        private System.Windows.Forms.TextBox zawodBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox pwzBox;
        private System.Windows.Forms.TextBox adminPassBox;
        private System.Windows.Forms.TextBox userPassBox;
        private System.Windows.Forms.TextBox specBox;
        private System.Windows.Forms.Button adminAddBtn;
        private System.Windows.Forms.Button userAddBtn;
    }
}