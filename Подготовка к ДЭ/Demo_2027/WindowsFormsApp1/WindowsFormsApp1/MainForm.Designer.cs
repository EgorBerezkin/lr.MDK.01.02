namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.pictureBoxImageUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.panelStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Font = new System.Drawing.Font("Calibri", 7.85F, System.Drawing.FontStyle.Italic);
            this.MainLayout.Location = new System.Drawing.Point(3, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(1478, 542);
            this.MainLayout.TabIndex = 0;
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatus.BackColor = System.Drawing.Color.LightCyan;
            this.panelStatus.Controls.Add(this.panel1);
            this.panelStatus.Controls.Add(this.label1);
            this.panelStatus.Controls.Add(this.pictureBox1);
            this.panelStatus.Location = new System.Drawing.Point(-3, -7);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1506, 162);
            this.panelStatus.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.labelRol);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Controls.Add(this.pictureBoxImageUser);
            this.panel1.Location = new System.Drawing.Point(886, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 165);
            this.panel1.TabIndex = 4;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRol.Location = new System.Drawing.Point(206, 83);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(49, 23);
            this.labelRol.TabIndex = 6;
            this.labelRol.Text = "Роль";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(170, 54);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(57, 27);
            this.labelFIO.TabIndex = 5;
            this.labelFIO.Text = "ФИО";
            // 
            // pictureBoxImageUser
            // 
            this.pictureBoxImageUser.ErrorImage = null;
            this.pictureBoxImageUser.Image = global::WindowsFormsApp1.Properties.Resources.users;
            this.pictureBoxImageUser.InitialImage = global::WindowsFormsApp1.Properties.Resources.users;
            this.pictureBoxImageUser.Location = new System.Drawing.Point(15, 18);
            this.pictureBoxImageUser.Name = "pictureBoxImageUser";
            this.pictureBoxImageUser.Size = new System.Drawing.Size(125, 126);
            this.pictureBoxImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageUser.TabIndex = 5;
            this.pictureBoxImageUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "ООО \"Кабачковая икра\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Чудо_Обувь1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 204);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProducts);
            this.tabControl1.Controls.Add(this.tabPageOrders);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1492, 587);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.MainLayout);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 35);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1484, 548);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Товары";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 35);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(1484, 548);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1206, 609);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OOO \"Кабачковая икра\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainLayout;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxImageUser;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelFIO;
    }
}

