namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelNameAuth = new System.Windows.Forms.Label();
            this.pictureBoxLogotip = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelTextLogotip = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLoginClient = new System.Windows.Forms.Button();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotip)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelStatus.BackColor = System.Drawing.Color.LightCyan;
            this.panelStatus.Controls.Add(this.labelNameAuth);
            this.panelStatus.Controls.Add(this.pictureBoxLogotip);
            this.panelStatus.Controls.Add(this.labelName);
            this.panelStatus.Location = new System.Drawing.Point(-32, -2);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(749, 153);
            this.panelStatus.TabIndex = 4;
            // 
            // labelNameAuth
            // 
            this.labelNameAuth.AutoSize = true;
            this.labelNameAuth.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameAuth.Location = new System.Drawing.Point(360, 94);
            this.labelNameAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameAuth.Name = "labelNameAuth";
            this.labelNameAuth.Size = new System.Drawing.Size(213, 40);
            this.labelNameAuth.TabIndex = 5;
            this.labelNameAuth.Text = "Авторизация";
            // 
            // pictureBoxLogotip
            // 
            this.pictureBoxLogotip.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Чудо_Обувь1;
            this.pictureBoxLogotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogotip.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogotip.InitialImage")));
            this.pictureBoxLogotip.Location = new System.Drawing.Point(27, -11);
            this.pictureBoxLogotip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogotip.Name = "pictureBoxLogotip";
            this.pictureBoxLogotip.Size = new System.Drawing.Size(197, 175);
            this.pictureBoxLogotip.TabIndex = 2;
            this.pictureBoxLogotip.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(233, 28);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(479, 53);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "ООО \"Кабачковая икра\"";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(136, 177);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(567, 48);
            this.textBoxLogin.TabIndex = 5;
            // 
            // labelTextLogotip
            // 
            this.labelTextLogotip.AutoSize = true;
            this.labelTextLogotip.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextLogotip.Location = new System.Drawing.Point(13, 180);
            this.labelTextLogotip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextLogotip.Name = "labelTextLogotip";
            this.labelTextLogotip.Size = new System.Drawing.Size(111, 40);
            this.labelTextLogotip.TabIndex = 6;
            this.labelTextLogotip.Text = "Логин:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(481, 247);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(223, 57);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLoginClient
            // 
            this.buttonLoginClient.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginClient.Location = new System.Drawing.Point(251, 247);
            this.buttonLoginClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoginClient.Name = "buttonLoginClient";
            this.buttonLoginClient.Size = new System.Drawing.Size(225, 57);
            this.buttonLoginClient.TabIndex = 8;
            this.buttonLoginClient.Text = "Войти как гость";
            this.buttonLoginClient.UseVisualStyleBackColor = true;
            this.buttonLoginClient.Click += new System.EventHandler(this.buttonLoginClient_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 318);
            this.Controls.Add(this.buttonLoginClient);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelTextLogotip);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.panelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox pictureBoxLogotip;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameAuth;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelTextLogotip;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLoginClient;
    }
}