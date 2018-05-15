namespace QLBH
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.Staff_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Staff_Search_TextBox = new System.Windows.Forms.TextBox();
            this.Staff_Search_Button = new System.Windows.Forms.Button();
            this.Staff_Add_Button = new System.Windows.Forms.Button();
            this.Staff_Fix_Button = new System.Windows.Forms.Button();
            this.Staff_Del_Button = new System.Windows.Forms.Button();
            this.Staff_Refresh_Button = new System.Windows.Forms.Button();
            this.Staff_Back_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Staff_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_DataGridView
            // 
            this.Staff_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Staff_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staff_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Staff_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Staff_DataGridView.Name = "Staff_DataGridView";
            this.Staff_DataGridView.Size = new System.Drawing.Size(784, 240);
            this.Staff_DataGridView.TabIndex = 0;
            this.Staff_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_Picture);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // Staff_Search_TextBox
            // 
            this.Staff_Search_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Search_TextBox.Location = new System.Drawing.Point(181, 260);
            this.Staff_Search_TextBox.Name = "Staff_Search_TextBox";
            this.Staff_Search_TextBox.Size = new System.Drawing.Size(190, 23);
            this.Staff_Search_TextBox.TabIndex = 2;
            this.Staff_Search_TextBox.Enter += new System.EventHandler(this.Staff_Search_TextBox_Enter);
            this.Staff_Search_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Staff_Search_TextBox_KeyDown);
            this.Staff_Search_TextBox.Leave += new System.EventHandler(this.Staff_Search_TextBox_Leave);
            // 
            // Staff_Search_Button
            // 
            this.Staff_Search_Button.BackColor = System.Drawing.Color.Maroon;
            this.Staff_Search_Button.FlatAppearance.BorderSize = 0;
            this.Staff_Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Search_Button.ForeColor = System.Drawing.Color.White;
            this.Staff_Search_Button.Location = new System.Drawing.Point(377, 256);
            this.Staff_Search_Button.Name = "Staff_Search_Button";
            this.Staff_Search_Button.Size = new System.Drawing.Size(80, 31);
            this.Staff_Search_Button.TabIndex = 3;
            this.Staff_Search_Button.Text = "Tìm kiếm";
            this.Staff_Search_Button.UseVisualStyleBackColor = false;
            this.Staff_Search_Button.Click += new System.EventHandler(this.Staff_Search_Button_Click);
            // 
            // Staff_Add_Button
            // 
            this.Staff_Add_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Add_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic24;
            this.Staff_Add_Button.FlatAppearance.BorderSize = 0;
            this.Staff_Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Add_Button.ForeColor = System.Drawing.Color.Snow;
            this.Staff_Add_Button.Location = new System.Drawing.Point(12, 324);
            this.Staff_Add_Button.Name = "Staff_Add_Button";
            this.Staff_Add_Button.Size = new System.Drawing.Size(125, 125);
            this.Staff_Add_Button.TabIndex = 4;
            this.Staff_Add_Button.Text = "Thêm";
            this.Staff_Add_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Staff_Add_Button.UseVisualStyleBackColor = false;
            this.Staff_Add_Button.Click += new System.EventHandler(this.Staff_Add_Button_Click);
            // 
            // Staff_Fix_Button
            // 
            this.Staff_Fix_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Fix_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic26;
            this.Staff_Fix_Button.FlatAppearance.BorderSize = 0;
            this.Staff_Fix_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Fix_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Fix_Button.ForeColor = System.Drawing.Color.Snow;
            this.Staff_Fix_Button.Location = new System.Drawing.Point(143, 324);
            this.Staff_Fix_Button.Name = "Staff_Fix_Button";
            this.Staff_Fix_Button.Size = new System.Drawing.Size(125, 125);
            this.Staff_Fix_Button.TabIndex = 5;
            this.Staff_Fix_Button.Text = "Sửa";
            this.Staff_Fix_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Staff_Fix_Button.UseVisualStyleBackColor = false;
            this.Staff_Fix_Button.Click += new System.EventHandler(this.Staff_Fix_Button_Click);
            // 
            // Staff_Del_Button
            // 
            this.Staff_Del_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Del_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic25;
            this.Staff_Del_Button.FlatAppearance.BorderSize = 0;
            this.Staff_Del_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Del_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Del_Button.ForeColor = System.Drawing.Color.Snow;
            this.Staff_Del_Button.Location = new System.Drawing.Point(274, 324);
            this.Staff_Del_Button.Name = "Staff_Del_Button";
            this.Staff_Del_Button.Size = new System.Drawing.Size(125, 125);
            this.Staff_Del_Button.TabIndex = 6;
            this.Staff_Del_Button.Text = "Xoá";
            this.Staff_Del_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Staff_Del_Button.UseVisualStyleBackColor = false;
            this.Staff_Del_Button.Click += new System.EventHandler(this.Staff_Del_Button_Click);
            // 
            // Staff_Refresh_Button
            // 
            this.Staff_Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Refresh_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Staff_Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Refresh_Button.ForeColor = System.Drawing.Color.Snow;
            this.Staff_Refresh_Button.Location = new System.Drawing.Point(441, 317);
            this.Staff_Refresh_Button.Name = "Staff_Refresh_Button";
            this.Staff_Refresh_Button.Size = new System.Drawing.Size(125, 63);
            this.Staff_Refresh_Button.TabIndex = 7;
            this.Staff_Refresh_Button.Text = "Tải Lại";
            this.Staff_Refresh_Button.UseVisualStyleBackColor = false;
            this.Staff_Refresh_Button.Click += new System.EventHandler(this.Staff_Refresh_Button_Click);
            // 
            // Staff_Back_Button
            // 
            this.Staff_Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Back_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Staff_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Back_Button.ForeColor = System.Drawing.Color.Snow;
            this.Staff_Back_Button.Location = new System.Drawing.Point(441, 386);
            this.Staff_Back_Button.Name = "Staff_Back_Button";
            this.Staff_Back_Button.Size = new System.Drawing.Size(125, 63);
            this.Staff_Back_Button.TabIndex = 8;
            this.Staff_Back_Button.Text = "Trở Về";
            this.Staff_Back_Button.UseVisualStyleBackColor = false;
            this.Staff_Back_Button.Click += new System.EventHandler(this.Staff_Back_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ảnh đại diện";
            // 
            // Staff_PictureBox
            // 
            this.Staff_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Staff_PictureBox.Location = new System.Drawing.Point(572, 263);
            this.Staff_PictureBox.Name = "Staff_PictureBox";
            this.Staff_PictureBox.Size = new System.Drawing.Size(200, 200);
            this.Staff_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Staff_PictureBox.TabIndex = 9;
            this.Staff_PictureBox.TabStop = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.Pic23;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Staff_PictureBox);
            this.Controls.Add(this.Staff_Back_Button);
            this.Controls.Add(this.Staff_Refresh_Button);
            this.Controls.Add(this.Staff_Del_Button);
            this.Controls.Add(this.Staff_Fix_Button);
            this.Controls.Add(this.Staff_Add_Button);
            this.Controls.Add(this.Staff_Search_Button);
            this.Controls.Add(this.Staff_Search_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Staff_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Staff_DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Staff_Search_Button;
        private System.Windows.Forms.Button Staff_Add_Button;
        private System.Windows.Forms.Button Staff_Fix_Button;
        private System.Windows.Forms.Button Staff_Del_Button;
        private System.Windows.Forms.Button Staff_Refresh_Button;
        private System.Windows.Forms.Button Staff_Back_Button;
        private System.Windows.Forms.PictureBox Staff_PictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Staff_Search_TextBox;
    }
}