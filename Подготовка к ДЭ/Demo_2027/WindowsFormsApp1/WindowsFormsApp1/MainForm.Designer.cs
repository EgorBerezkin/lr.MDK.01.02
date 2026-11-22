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
            this.panelAuth = new System.Windows.Forms.Panel();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.pictureBoxImageUser = new System.Windows.Forms.PictureBox();
            this.labelNameFirma = new System.Windows.Forms.Label();
            this.tabControlVklads = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.panelFunctional = new System.Windows.Forms.Panel();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSorting = new System.Windows.Forms.Label();
            this.PriceSortingCombobox = new System.Windows.Forms.ComboBox();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogotip = new System.Windows.Forms.PictureBox();
            this.panelStatus.SuspendLayout();
            this.panelAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUser)).BeginInit();
            this.tabControlVklads.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.panelFunctional.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotip)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.AutoScroll = true;
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Font = new System.Drawing.Font("Calibri", 7.85F, System.Drawing.FontStyle.Italic);
            this.MainLayout.Location = new System.Drawing.Point(4, 70);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(1884, 432);
            this.MainLayout.TabIndex = 0;
            this.MainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.MainLayout_Paint);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.LightCyan;
            this.panelStatus.Controls.Add(this.panelAuth);
            this.panelStatus.Controls.Add(this.labelNameFirma);
            this.panelStatus.Controls.Add(this.pictureBoxLogotip);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(4);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1900, 199);
            this.panelStatus.TabIndex = 1;
            // 
            // panelAuth
            // 
            this.panelAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAuth.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelAuth.Controls.Add(this.labelRol);
            this.panelAuth.Controls.Add(this.labelFIO);
            this.panelAuth.Controls.Add(this.pictureBoxImageUser);
            this.panelAuth.Location = new System.Drawing.Point(1284, 0);
            this.panelAuth.Margin = new System.Windows.Forms.Padding(4);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(616, 203);
            this.panelAuth.TabIndex = 4;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRol.Location = new System.Drawing.Point(275, 102);
            this.labelRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(59, 28);
            this.labelRol.TabIndex = 6;
            this.labelRol.Text = "Роль";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(227, 66);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(72, 35);
            this.labelFIO.TabIndex = 5;
            this.labelFIO.Text = "ФИО";
            // 
            // pictureBoxImageUser
            // 
            this.pictureBoxImageUser.ErrorImage = null;
            this.pictureBoxImageUser.Location = new System.Drawing.Point(20, 22);
            this.pictureBoxImageUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImageUser.Name = "pictureBoxImageUser";
            this.pictureBoxImageUser.Size = new System.Drawing.Size(167, 155);
            this.pictureBoxImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageUser.TabIndex = 5;
            this.pictureBoxImageUser.TabStop = false;
            // 
            // labelNameFirma
            // 
            this.labelNameFirma.AutoSize = true;
            this.labelNameFirma.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameFirma.Location = new System.Drawing.Point(225, 47);
            this.labelNameFirma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameFirma.Name = "labelNameFirma";
            this.labelNameFirma.Size = new System.Drawing.Size(886, 97);
            this.labelNameFirma.TabIndex = 3;
            this.labelNameFirma.Text = "ООО \"Кабачковая икра\"";
            // 
            // tabControlVklads
            // 
            this.tabControlVklads.Controls.Add(this.tabPageProducts);
            this.tabControlVklads.Controls.Add(this.tabPageOrders);
            this.tabControlVklads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVklads.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlVklads.Location = new System.Drawing.Point(0, 199);
            this.tabControlVklads.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlVklads.Name = "tabControlVklads";
            this.tabControlVklads.SelectedIndex = 0;
            this.tabControlVklads.Size = new System.Drawing.Size(1900, 551);
            this.tabControlVklads.TabIndex = 2;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.MainLayout);
            this.tabPageProducts.Controls.Add(this.panelFunctional);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 41);
            this.tabPageProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageProducts.Size = new System.Drawing.Size(1892, 506);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Товары";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // panelFunctional
            // 
            this.panelFunctional.BackColor = System.Drawing.Color.LightCyan;
            this.panelFunctional.Controls.Add(this.CategoryComboBox);
            this.panelFunctional.Controls.Add(this.labelCategory);
            this.panelFunctional.Controls.Add(this.textBoxSearch);
            this.panelFunctional.Controls.Add(this.labelSearch);
            this.panelFunctional.Controls.Add(this.labelSorting);
            this.panelFunctional.Controls.Add(this.PriceSortingCombobox);
            this.panelFunctional.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunctional.Location = new System.Drawing.Point(4, 4);
            this.panelFunctional.Margin = new System.Windows.Forms.Padding(0);
            this.panelFunctional.Name = "panelFunctional";
            this.panelFunctional.Padding = new System.Windows.Forms.Padding(5);
            this.panelFunctional.Size = new System.Drawing.Size(1884, 66);
            this.panelFunctional.TabIndex = 2;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "по убыванию",
            "по возрастанию"});
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(514, 11);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(265, 40);
            this.CategoryComboBox.TabIndex = 6;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(391, 18);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(117, 33);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Фильтр:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(908, 11);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(265, 40);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(811, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(91, 33);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Поиск:";
            // 
            // labelSorting
            // 
            this.labelSorting.AutoSize = true;
            this.labelSorting.Location = new System.Drawing.Point(15, 18);
            this.labelSorting.Name = "labelSorting";
            this.labelSorting.Size = new System.Drawing.Size(80, 33);
            this.labelSorting.TabIndex = 2;
            this.labelSorting.Text = "Цена:";
            // 
            // PriceSortingCombobox
            // 
            this.PriceSortingCombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "по убыванию",
            "по возрастанию"});
            this.PriceSortingCombobox.FormattingEnabled = true;
            this.PriceSortingCombobox.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.PriceSortingCombobox.Location = new System.Drawing.Point(101, 11);
            this.PriceSortingCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceSortingCombobox.Name = "PriceSortingCombobox";
            this.PriceSortingCombobox.Size = new System.Drawing.Size(265, 40);
            this.PriceSortingCombobox.TabIndex = 1;
            this.PriceSortingCombobox.SelectedIndexChanged += new System.EventHandler(this.PriceSortingCombobox_SelectedIndexChanged);
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 41);
            this.tabPageOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Size = new System.Drawing.Size(1892, 506);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.GridColor = System.Drawing.Color.White;
            this.dataGridViewOrders.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1884, 498);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellDoubleClick);
            // 
            // pictureBoxLogotip
            // 
            this.pictureBoxLogotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogotip.Image = global::WindowsFormsApp1.Properties.Resources.ЧудоОбувь;
            this.pictureBoxLogotip.InitialImage = global::WindowsFormsApp1.Properties.Resources.ЧудоОбувь;
            this.pictureBoxLogotip.Location = new System.Drawing.Point(-9, -11);
            this.pictureBoxLogotip.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogotip.Name = "pictureBoxLogotip";
            this.pictureBoxLogotip.Size = new System.Drawing.Size(264, 243);
            this.pictureBoxLogotip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogotip.TabIndex = 5;
            this.pictureBoxLogotip.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1900, 750);
            this.Controls.Add(this.tabControlVklads);
            this.Controls.Add(this.panelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OOO \"Кабачковая икра\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelAuth.ResumeLayout(false);
            this.panelAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUser)).EndInit();
            this.tabControlVklads.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.panelFunctional.ResumeLayout(false);
            this.panelFunctional.PerformLayout();
            this.tabPageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainLayout;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.TabControl tabControlVklads;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.Label labelNameFirma;
        private System.Windows.Forms.Panel panelAuth;
        private System.Windows.Forms.PictureBox pictureBoxImageUser;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.ComboBox PriceSortingCombobox;
        private System.Windows.Forms.Panel panelFunctional;
        private System.Windows.Forms.Label labelSorting;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.PictureBox pictureBoxLogotip;
    }
}

