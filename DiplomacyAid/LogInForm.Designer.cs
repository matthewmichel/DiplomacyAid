namespace DiplomacyAid
{
    partial class LogInForm
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
            this.LogIn_Lbl = new System.Windows.Forms.Label();
            this.username_Lbl = new System.Windows.Forms.Label();
            this.password_Lbl = new System.Windows.Forms.Label();
            this.username_Txt = new System.Windows.Forms.TextBox();
            this.password_Txt = new System.Windows.Forms.TextBox();
            this.logIn_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn_Lbl
            // 
            this.LogIn_Lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogIn_Lbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_Lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LogIn_Lbl.Location = new System.Drawing.Point(0, 0);
            this.LogIn_Lbl.Name = "LogIn_Lbl";
            this.LogIn_Lbl.Size = new System.Drawing.Size(243, 43);
            this.LogIn_Lbl.TabIndex = 0;
            this.LogIn_Lbl.Text = "Log In";
            this.LogIn_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_Lbl
            // 
            this.username_Lbl.AutoSize = true;
            this.username_Lbl.Location = new System.Drawing.Point(13, 80);
            this.username_Lbl.Name = "username_Lbl";
            this.username_Lbl.Size = new System.Drawing.Size(61, 13);
            this.username_Lbl.TabIndex = 1;
            this.username_Lbl.Text = "Username: ";
            // 
            // password_Lbl
            // 
            this.password_Lbl.AutoSize = true;
            this.password_Lbl.Location = new System.Drawing.Point(16, 118);
            this.password_Lbl.Name = "password_Lbl";
            this.password_Lbl.Size = new System.Drawing.Size(56, 13);
            this.password_Lbl.TabIndex = 2;
            this.password_Lbl.Text = "Password:";
            // 
            // username_Txt
            // 
            this.username_Txt.Location = new System.Drawing.Point(80, 77);
            this.username_Txt.Name = "username_Txt";
            this.username_Txt.Size = new System.Drawing.Size(151, 20);
            this.username_Txt.TabIndex = 3;
            this.username_Txt.Text = "gamemaster";
            // 
            // password_Txt
            // 
            this.password_Txt.Location = new System.Drawing.Point(80, 115);
            this.password_Txt.Name = "password_Txt";
            this.password_Txt.PasswordChar = '*';
            this.password_Txt.Size = new System.Drawing.Size(151, 20);
            this.password_Txt.TabIndex = 4;
            this.password_Txt.Text = "password";
            // 
            // logIn_Btn
            // 
            this.logIn_Btn.Location = new System.Drawing.Point(19, 163);
            this.logIn_Btn.Name = "logIn_Btn";
            this.logIn_Btn.Size = new System.Drawing.Size(212, 23);
            this.logIn_Btn.TabIndex = 5;
            this.logIn_Btn.Text = "Log In";
            this.logIn_Btn.UseVisualStyleBackColor = true;
            this.logIn_Btn.Click += new System.EventHandler(this.LogIn_Btn_Click);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.logIn_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 212);
            this.Controls.Add(this.logIn_Btn);
            this.Controls.Add(this.password_Txt);
            this.Controls.Add(this.username_Txt);
            this.Controls.Add(this.password_Lbl);
            this.Controls.Add(this.username_Lbl);
            this.Controls.Add(this.LogIn_Lbl);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogIn_Lbl;
        private System.Windows.Forms.Label username_Lbl;
        private System.Windows.Forms.Label password_Lbl;
        private System.Windows.Forms.TextBox username_Txt;
        private System.Windows.Forms.TextBox password_Txt;
        private System.Windows.Forms.Button logIn_Btn;
    }
}