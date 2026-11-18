namespace DemoUIComponents
{
    partial class ProductCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.labelProizvodstvo = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(295, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Состав:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(440, 71);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(115, 29);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "категория";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.Location = new System.Drawing.Point(440, 108);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(107, 24);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "количество";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartsLabel.Location = new System.Drawing.Point(385, 139);
            this.PartsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(56, 21);
            this.PartsLabel.TabIndex = 5;
            this.PartsLabel.Text = "состав";
            // 
            // labelProizvodstvo
            // 
            this.labelProizvodstvo.AutoSize = true;
            this.labelProizvodstvo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProizvodstvo.Location = new System.Drawing.Point(315, 18);
            this.labelProizvodstvo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProizvodstvo.Name = "labelProizvodstvo";
            this.labelProizvodstvo.Size = new System.Drawing.Size(158, 29);
            this.labelProizvodstvo.TabIndex = 7;
            this.labelProizvodstvo.Text = "Производство";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(759, 63);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 37);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "цена";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.ErrorImage = null;
            this.pictureBoxImage.Image = global::ProductCard.Properties.Resources.picture2;
            this.pictureBoxImage.ImageLocation = "";
            this.pictureBoxImage.InitialImage = global::ProductCard.Properties.Resources.picture2;
            this.pictureBoxImage.Location = new System.Drawing.Point(20, 18);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(254, 161);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelProizvodstvo);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(1499, 218);
            this.Load += new System.EventHandler(this.ProductCard_Load);
            this.MouseLeave += new System.EventHandler(this.ProductCard_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProductCard_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label labelProizvodstvo;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}
