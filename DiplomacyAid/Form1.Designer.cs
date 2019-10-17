namespace DiplomacyAid
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_Lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginSignoutMenu_Placeholder = new System.Windows.Forms.ToolStripMenuItem();
            this.logIn_ToolstripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOut_ToolstripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.currentSeason_Lbl = new System.Windows.Forms.Label();
            this.diplomacyPhase_Btn = new System.Windows.Forms.Button();
            this.orderWritingPhase_Btn = new System.Windows.Forms.Button();
            this.orderExecutionPhase_Btn = new System.Windows.Forms.Button();
            this.resultsPhase_Btn = new System.Windows.Forms.Button();
            this.redistributionPhase_Btn = new System.Windows.Forms.Button();
            this.currentPhase_Lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Diplomacy Aid";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcome_Lbl
            // 
            this.welcome_Lbl.AutoSize = true;
            this.welcome_Lbl.Location = new System.Drawing.Point(12, 168);
            this.welcome_Lbl.Name = "welcome_Lbl";
            this.welcome_Lbl.Size = new System.Drawing.Size(55, 13);
            this.welcome_Lbl.TabIndex = 1;
            this.welcome_Lbl.Text = "Welcome.";
            this.welcome_Lbl.Click += new System.EventHandler(this.Welcome_Lbl_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginSignoutMenu_Placeholder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginSignoutMenu_Placeholder
            // 
            this.loginSignoutMenu_Placeholder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logIn_ToolstripItem,
            this.signOut_ToolstripItem});
            this.loginSignoutMenu_Placeholder.Name = "loginSignoutMenu_Placeholder";
            this.loginSignoutMenu_Placeholder.Size = new System.Drawing.Size(109, 20);
            this.loginSignoutMenu_Placeholder.Text = "Log In / Sign Out";
            // 
            // logIn_ToolstripItem
            // 
            this.logIn_ToolstripItem.Name = "logIn_ToolstripItem";
            this.logIn_ToolstripItem.Size = new System.Drawing.Size(180, 22);
            this.logIn_ToolstripItem.Text = "Log In";
            this.logIn_ToolstripItem.Click += new System.EventHandler(this.LogInToolStripMenuItem1_Click_1);
            // 
            // signOut_ToolstripItem
            // 
            this.signOut_ToolstripItem.Name = "signOut_ToolstripItem";
            this.signOut_ToolstripItem.Size = new System.Drawing.Size(180, 22);
            this.signOut_ToolstripItem.Text = "Sign Out";
            this.signOut_ToolstripItem.Click += new System.EventHandler(this.SignOut_ToolstripItem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Season:";
            // 
            // currentSeason_Lbl
            // 
            this.currentSeason_Lbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSeason_Lbl.Location = new System.Drawing.Point(463, 75);
            this.currentSeason_Lbl.Name = "currentSeason_Lbl";
            this.currentSeason_Lbl.Size = new System.Drawing.Size(112, 32);
            this.currentSeason_Lbl.TabIndex = 4;
            this.currentSeason_Lbl.Text = "Fall";
            this.currentSeason_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // diplomacyPhase_Btn
            // 
            this.diplomacyPhase_Btn.Location = new System.Drawing.Point(15, 184);
            this.diplomacyPhase_Btn.Name = "diplomacyPhase_Btn";
            this.diplomacyPhase_Btn.Size = new System.Drawing.Size(234, 41);
            this.diplomacyPhase_Btn.TabIndex = 5;
            this.diplomacyPhase_Btn.Text = "Initiate Diplomacy Phase";
            this.diplomacyPhase_Btn.UseVisualStyleBackColor = true;
            this.diplomacyPhase_Btn.Click += new System.EventHandler(this.DiplomacyPhase_Btn_Click);
            // 
            // orderWritingPhase_Btn
            // 
            this.orderWritingPhase_Btn.Location = new System.Drawing.Point(15, 231);
            this.orderWritingPhase_Btn.Name = "orderWritingPhase_Btn";
            this.orderWritingPhase_Btn.Size = new System.Drawing.Size(234, 41);
            this.orderWritingPhase_Btn.TabIndex = 6;
            this.orderWritingPhase_Btn.Text = "Initiate Order Writing Phase";
            this.orderWritingPhase_Btn.UseVisualStyleBackColor = true;
            this.orderWritingPhase_Btn.Click += new System.EventHandler(this.OrderWritingPhase_Btn_Click);
            // 
            // orderExecutionPhase_Btn
            // 
            this.orderExecutionPhase_Btn.Location = new System.Drawing.Point(15, 278);
            this.orderExecutionPhase_Btn.Name = "orderExecutionPhase_Btn";
            this.orderExecutionPhase_Btn.Size = new System.Drawing.Size(234, 41);
            this.orderExecutionPhase_Btn.TabIndex = 7;
            this.orderExecutionPhase_Btn.Text = "Initiate Order Execution Phase";
            this.orderExecutionPhase_Btn.UseVisualStyleBackColor = true;
            this.orderExecutionPhase_Btn.Click += new System.EventHandler(this.OrderExecutionPhase_Btn_Click);
            // 
            // resultsPhase_Btn
            // 
            this.resultsPhase_Btn.Location = new System.Drawing.Point(15, 325);
            this.resultsPhase_Btn.Name = "resultsPhase_Btn";
            this.resultsPhase_Btn.Size = new System.Drawing.Size(234, 41);
            this.resultsPhase_Btn.TabIndex = 8;
            this.resultsPhase_Btn.Text = "Initiate Results Phase";
            this.resultsPhase_Btn.UseVisualStyleBackColor = true;
            this.resultsPhase_Btn.Click += new System.EventHandler(this.ResultsPhase_Btn_Click);
            // 
            // redistributionPhase_Btn
            // 
            this.redistributionPhase_Btn.Location = new System.Drawing.Point(15, 372);
            this.redistributionPhase_Btn.Name = "redistributionPhase_Btn";
            this.redistributionPhase_Btn.Size = new System.Drawing.Size(234, 41);
            this.redistributionPhase_Btn.TabIndex = 9;
            this.redistributionPhase_Btn.Text = "Initiate Redistribution Phase";
            this.redistributionPhase_Btn.UseVisualStyleBackColor = true;
            this.redistributionPhase_Btn.Click += new System.EventHandler(this.RedistributionPhase_Btn_Click);
            // 
            // currentPhase_Lbl
            // 
            this.currentPhase_Lbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPhase_Lbl.Location = new System.Drawing.Point(272, 107);
            this.currentPhase_Lbl.Name = "currentPhase_Lbl";
            this.currentPhase_Lbl.Size = new System.Drawing.Size(303, 32);
            this.currentPhase_Lbl.TabIndex = 11;
            this.currentPhase_Lbl.Text = "Beginning Game";
            this.currentPhase_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phase:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(763, 479);
            this.Controls.Add(this.currentPhase_Lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.redistributionPhase_Btn);
            this.Controls.Add(this.resultsPhase_Btn);
            this.Controls.Add(this.orderExecutionPhase_Btn);
            this.Controls.Add(this.orderWritingPhase_Btn);
            this.Controls.Add(this.diplomacyPhase_Btn);
            this.Controls.Add(this.currentSeason_Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcome_Lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Diplomacy Aid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome_Lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginSignoutMenu_Placeholder;
        private System.Windows.Forms.ToolStripMenuItem logIn_ToolstripItem;
        private System.Windows.Forms.ToolStripMenuItem signOut_ToolstripItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentSeason_Lbl;
        private System.Windows.Forms.Button diplomacyPhase_Btn;
        private System.Windows.Forms.Button orderWritingPhase_Btn;
        private System.Windows.Forms.Button orderExecutionPhase_Btn;
        private System.Windows.Forms.Button resultsPhase_Btn;
        private System.Windows.Forms.Button redistributionPhase_Btn;
        private System.Windows.Forms.Label currentPhase_Lbl;
        private System.Windows.Forms.Label label5;
    }
}

