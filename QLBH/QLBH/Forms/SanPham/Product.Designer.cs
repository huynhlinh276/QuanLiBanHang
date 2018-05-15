namespace QLBH
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.Product_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Product_Search_TextBox = new System.Windows.Forms.TextBox();
            this.Product_Search_Button = new System.Windows.Forms.Button();
            this.Product_Add_Button = new System.Windows.Forms.Button();
            this.Product_Fix_Button = new System.Windows.Forms.Button();
            this.Product_Del_Button = new System.Windows.Forms.Button();
            this.Product_Refresh_Button = new System.Windows.Forms.Button();
            this.Product_Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Product_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_DataGridView
            // 
            this.Product_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Product_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Product_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Product_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Product_DataGridView.Name = "Product_DataGridView";
            this.Product_DataGridView.Size = new System.Drawing.Size(784, 240);
            this.Product_DataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // Product_Search_TextBox
            // 
            this.Product_Search_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Search_TextBox.Location = new System.Drawing.Point(283, 257);
            this.Product_Search_TextBox.Name = "Product_Search_TextBox";
            this.Product_Search_TextBox.Size = new System.Drawing.Size(207, 23);
            this.Product_Search_TextBox.TabIndex = 2;
            this.Product_Search_TextBox.Enter += new System.EventHandler(this.Product_Search_TextBox_Enter);
            this.Product_Search_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Product_Search_TextBox_KeyDown);
            this.Product_Search_TextBox.Leave += new System.EventHandler(this.Product_Search_TextBox_Leave);
            // 
            // Product_Search_Button
            // 
            this.Product_Search_Button.BackColor = System.Drawing.Color.Maroon;
            this.Product_Search_Button.FlatAppearance.BorderSize = 0;
            this.Product_Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Search_Button.ForeColor = System.Drawing.Color.White;
            this.Product_Search_Button.Location = new System.Drawing.Point(496, 253);
            this.Product_Search_Button.Name = "Product_Search_Button";
            this.Product_Search_Button.Size = new System.Drawing.Size(80, 30);
            this.Product_Search_Button.TabIndex = 3;
            this.Product_Search_Button.Text = "Tìm kiếm";
            this.Product_Search_Button.UseVisualStyleBackColor = false;
            this.Product_Search_Button.Click += new System.EventHandler(this.Product_Search_Button_Click);
            // 
            // Product_Add_Button
            // 
            this.Product_Add_Button.BackColor = System.Drawing.Color.Transparent;
            this.Product_Add_Button.FlatAppearance.BorderSize = 0;
            this.Product_Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Add_Button.ForeColor = System.Drawing.Color.Snow;
            this.Product_Add_Button.Image = global::QLBH.Properties.Resources.Pic30;
            this.Product_Add_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Product_Add_Button.Location = new System.Drawing.Point(12, 324);
            this.Product_Add_Button.Name = "Product_Add_Button";
            this.Product_Add_Button.Size = new System.Drawing.Size(125, 125);
            this.Product_Add_Button.TabIndex = 5;
            this.Product_Add_Button.Text = "Thêm";
            this.Product_Add_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Product_Add_Button.UseVisualStyleBackColor = false;
            this.Product_Add_Button.Click += new System.EventHandler(this.Product_Add_Button_Click);
            // 
            // Product_Fix_Button
            // 
            this.Product_Fix_Button.BackColor = System.Drawing.Color.Transparent;
            this.Product_Fix_Button.FlatAppearance.BorderSize = 0;
            this.Product_Fix_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Fix_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Fix_Button.ForeColor = System.Drawing.Color.Snow;
            this.Product_Fix_Button.Image = global::QLBH.Properties.Resources.Pic32;
            this.Product_Fix_Button.Location = new System.Drawing.Point(143, 324);
            this.Product_Fix_Button.Name = "Product_Fix_Button";
            this.Product_Fix_Button.Size = new System.Drawing.Size(125, 125);
            this.Product_Fix_Button.TabIndex = 6;
            this.Product_Fix_Button.Text = "Sửa";
            this.Product_Fix_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Product_Fix_Button.UseVisualStyleBackColor = false;
            this.Product_Fix_Button.Click += new System.EventHandler(this.Product_Fix_Button_Click);
            // 
            // Product_Del_Button
            // 
            this.Product_Del_Button.BackColor = System.Drawing.Color.Transparent;
            this.Product_Del_Button.FlatAppearance.BorderSize = 0;
            this.Product_Del_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Del_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Del_Button.ForeColor = System.Drawing.Color.Snow;
            this.Product_Del_Button.Image = global::QLBH.Properties.Resources.Pic31;
            this.Product_Del_Button.Location = new System.Drawing.Point(274, 324);
            this.Product_Del_Button.Name = "Product_Del_Button";
            this.Product_Del_Button.Size = new System.Drawing.Size(125, 125);
            this.Product_Del_Button.TabIndex = 7;
            this.Product_Del_Button.Text = "Xoá";
            this.Product_Del_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Product_Del_Button.UseVisualStyleBackColor = false;
            this.Product_Del_Button.Click += new System.EventHandler(this.Product_Del_Button_Click);
            // 
            // Product_Refresh_Button
            // 
            this.Product_Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.Product_Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Product_Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Refresh_Button.ForeColor = System.Drawing.Color.Snow;
            this.Product_Refresh_Button.Image = global::QLBH.Properties.Resources.Pic27;
            this.Product_Refresh_Button.Location = new System.Drawing.Point(516, 324);
            this.Product_Refresh_Button.Name = "Product_Refresh_Button";
            this.Product_Refresh_Button.Size = new System.Drawing.Size(125, 125);
            this.Product_Refresh_Button.TabIndex = 8;
            this.Product_Refresh_Button.Text = "Tải Lại";
            this.Product_Refresh_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Product_Refresh_Button.UseVisualStyleBackColor = false;
            this.Product_Refresh_Button.Click += new System.EventHandler(this.Product_Refresh_Button_Click);
            // 
            // Product_Back_Button
            // 
            this.Product_Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Product_Back_Button.FlatAppearance.BorderSize = 0;
            this.Product_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Back_Button.ForeColor = System.Drawing.Color.Snow;
            this.Product_Back_Button.Image = global::QLBH.Properties.Resources.Pic28;
            this.Product_Back_Button.Location = new System.Drawing.Point(647, 324);
            this.Product_Back_Button.Name = "Product_Back_Button";
            this.Product_Back_Button.Size = new System.Drawing.Size(125, 125);
            this.Product_Back_Button.TabIndex = 9;
            this.Product_Back_Button.Text = "Trở Về";
            this.Product_Back_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Product_Back_Button.UseVisualStyleBackColor = false;
            this.Product_Back_Button.Click += new System.EventHandler(this.Product_Back_Button_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.Pic23;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Product_Back_Button);
            this.Controls.Add(this.Product_Refresh_Button);
            this.Controls.Add(this.Product_Del_Button);
            this.Controls.Add(this.Product_Fix_Button);
            this.Controls.Add(this.Product_Add_Button);
            this.Controls.Add(this.Product_Search_Button);
            this.Controls.Add(this.Product_Search_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Product_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Product_DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Product_Search_TextBox;
        private System.Windows.Forms.Button Product_Search_Button;
        private System.Windows.Forms.Button Product_Add_Button;
        private System.Windows.Forms.Button Product_Fix_Button;
        private System.Windows.Forms.Button Product_Del_Button;
        private System.Windows.Forms.Button Product_Refresh_Button;
        private System.Windows.Forms.Button Product_Back_Button;
    }
}