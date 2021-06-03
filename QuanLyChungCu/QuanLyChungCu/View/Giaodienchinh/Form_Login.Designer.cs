namespace QuanLyChungCu
{
    partial class Form_Login
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
            System.Windows.Forms.PictureBox pictureBox1;
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkbox_remember = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_sai = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Image = global::QuanLyChungCu.Properties.Resources.building41;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(523, 346);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(471, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(40, 39);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "X";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Plum;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Purple;
            this.txt_username.Location = new System.Drawing.Point(68, 430);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(390, 26);
            this.txt_username.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(68, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 1);
            this.panel1.TabIndex = 2;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.Purple;
            this.lb_username.Location = new System.Drawing.Point(63, 382);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(104, 28);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Tài Khoản";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.Purple;
            this.lb_password.Location = new System.Drawing.Point(63, 485);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(100, 28);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "Mật Khẩu";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Plum;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Purple;
            this.txt_password.Location = new System.Drawing.Point(68, 531);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(390, 26);
            this.txt_password.TabIndex = 6;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Location = new System.Drawing.Point(68, 563);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 1);
            this.panel2.TabIndex = 3;
            // 
            // checkbox_remember
            // 
            this.checkbox_remember.AutoSize = true;
            this.checkbox_remember.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.checkbox_remember.FlatAppearance.BorderSize = 0;
            this.checkbox_remember.FlatAppearance.CheckedBackColor = System.Drawing.Color.Purple;
            this.checkbox_remember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.checkbox_remember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.checkbox_remember.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_remember.ForeColor = System.Drawing.Color.Purple;
            this.checkbox_remember.Location = new System.Drawing.Point(297, 584);
            this.checkbox_remember.Name = "checkbox_remember";
            this.checkbox_remember.Size = new System.Drawing.Size(161, 30);
            this.checkbox_remember.TabIndex = 7;
            this.checkbox_remember.Text = "Nhớ Tài Khoản";
            this.checkbox_remember.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Purple;
            this.btn_login.Location = new System.Drawing.Point(68, 689);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(390, 61);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_sai
            // 
            this.lb_sai.AutoSize = true;
            this.lb_sai.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sai.ForeColor = System.Drawing.Color.Crimson;
            this.lb_sai.Location = new System.Drawing.Point(123, 639);
            this.lb_sai.Name = "lb_sai";
            this.lb_sai.Size = new System.Drawing.Size(261, 28);
            this.lb_sai.TabIndex = 10;
            this.lb_sai.Text = "Sai tài khoản hay mật khẩu";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(523, 785);
            this.Controls.Add(this.lb_sai);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.checkbox_remember);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkbox_remember;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_sai;
    }
}