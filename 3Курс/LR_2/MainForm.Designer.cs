namespace LR_3_var3
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
            this.LabelNaimenowanie = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Button_dobav = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelSum = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelRecjiser = new System.Windows.Forms.Label();
            this.LabelOpisanie = new System.Windows.Forms.Label();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.OtchetButton = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNaimenowanie
            // 
            this.LabelNaimenowanie.AutoSize = true;
            this.LabelNaimenowanie.Location = new System.Drawing.Point(256, 25);
            this.LabelNaimenowanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNaimenowanie.Name = "LabelNaimenowanie";
            this.LabelNaimenowanie.Size = new System.Drawing.Size(44, 16);
            this.LabelNaimenowanie.TabIndex = 0;
            this.LabelNaimenowanie.Text = "label1";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DarkKhaki;
            this.Panel.Controls.Add(this.NumericUpDown);
            this.Panel.Controls.Add(this.Button_dobav);
            this.Panel.Controls.Add(this.RichTextBox);
            this.Panel.Controls.Add(this.OtchetButton);
            this.Panel.Controls.Add(this.FilmsComboBox);
            this.Panel.Controls.Add(this.LabelNumber);
            this.Panel.Controls.Add(this.LabelSum);
            this.Panel.Controls.Add(this.LabelDate);
            this.Panel.Controls.Add(this.LabelRecjiser);
            this.Panel.Controls.Add(this.LabelOpisanie);
            this.Panel.Controls.Add(this.FotoPictureBox);
            this.Panel.Controls.Add(this.LabelNaimenowanie);
            this.Panel.Location = new System.Drawing.Point(179, -2);
            this.Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(923, 492);
            this.Panel.TabIndex = 1;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(628, 255);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(136, 22);
            this.NumericUpDown.TabIndex = 10;
            // 
            // Button_dobav
            // 
            this.Button_dobav.BackColor = System.Drawing.Color.RosyBrown;
            this.Button_dobav.Location = new System.Drawing.Point(628, 284);
            this.Button_dobav.Margin = new System.Windows.Forms.Padding(4);
            this.Button_dobav.Name = "Button_dobav";
            this.Button_dobav.Size = new System.Drawing.Size(136, 48);
            this.Button_dobav.TabIndex = 9;
            this.Button_dobav.Text = "Отчёт, по второй части";
            this.Button_dobav.UseVisualStyleBackColor = false;
            this.Button_dobav.Click += new System.EventHandler(this.Button_dobav_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.RichTextBox.Location = new System.Drawing.Point(0, 359);
            this.RichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(921, 132);
            this.RichTextBox.TabIndex = 8;
            this.RichTextBox.Text = "";
            // 
            // FilmsComboBox
            // 
            this.FilmsComboBox.BackColor = System.Drawing.Color.DarkGray;
            this.FilmsComboBox.FormattingEnabled = true;
            this.FilmsComboBox.Location = new System.Drawing.Point(369, 21);
            this.FilmsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmsComboBox.Name = "FilmsComboBox";
            this.FilmsComboBox.Size = new System.Drawing.Size(261, 24);
            this.FilmsComboBox.TabIndex = 2;
            this.FilmsComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmsComboBox_SelectedIndexChanged);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(437, 206);
            this.LabelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(44, 16);
            this.LabelNumber.TabIndex = 6;
            this.LabelNumber.Text = "label6";
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Location = new System.Drawing.Point(256, 231);
            this.LabelSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(44, 16);
            this.LabelSum.TabIndex = 5;
            this.LabelSum.Text = "label5";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(256, 206);
            this.LabelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(44, 16);
            this.LabelDate.TabIndex = 4;
            this.LabelDate.Text = "label4";
            // 
            // LabelRecjiser
            // 
            this.LabelRecjiser.AutoSize = true;
            this.LabelRecjiser.Location = new System.Drawing.Point(256, 181);
            this.LabelRecjiser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRecjiser.Name = "LabelRecjiser";
            this.LabelRecjiser.Size = new System.Drawing.Size(44, 16);
            this.LabelRecjiser.TabIndex = 3;
            this.LabelRecjiser.Text = "label3";
            // 
            // LabelOpisanie
            // 
            this.LabelOpisanie.AutoSize = true;
            this.LabelOpisanie.Location = new System.Drawing.Point(256, 58);
            this.LabelOpisanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOpisanie.Name = "LabelOpisanie";
            this.LabelOpisanie.Size = new System.Drawing.Size(44, 16);
            this.LabelOpisanie.TabIndex = 2;
            this.LabelOpisanie.Text = "label2";
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(4, 15);
            this.FotoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(211, 278);
            this.FotoPictureBox.TabIndex = 1;
            this.FotoPictureBox.TabStop = false;
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.BackColor = System.Drawing.Color.RosyBrown;
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 16;
            this.FilmsListBox.Location = new System.Drawing.Point(-1, -2);
            this.FilmsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(180, 500);
            this.FilmsListBox.TabIndex = 2;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // OtchetButton
            // 
            this.OtchetButton.BackColor = System.Drawing.Color.RosyBrown;
            this.OtchetButton.Location = new System.Drawing.Point(772, 284);
            this.OtchetButton.Margin = new System.Windows.Forms.Padding(4);
            this.OtchetButton.Name = "OtchetButton";
            this.OtchetButton.Size = new System.Drawing.Size(136, 48);
            this.OtchetButton.TabIndex = 7;
            this.OtchetButton.Text = "Отчёт";
            this.OtchetButton.UseVisualStyleBackColor = false;
            this.OtchetButton.Click += new System.EventHandler(this.OtchetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1103, 489);
            this.Controls.Add(this.FilmsListBox);
            this.Controls.Add(this.Panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Кинофильмы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelNaimenowanie;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelRecjiser;
        private System.Windows.Forms.Label LabelOpisanie;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.ComboBox FilmsComboBox;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button Button_dobav;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Button OtchetButton;
    }
}

