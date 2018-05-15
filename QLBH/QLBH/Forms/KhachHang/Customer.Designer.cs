namespace QLBH
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.Customer_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer_Search_TextBox = new System.Windows.Forms.TextBox();
            this.Customer_Search_Button = new System.Windows.Forms.Button();
            this.Customer_Add_Button = new System.Windows.Forms.Button();
            this.Customer_Fix_Button = new System.Windows.Forms.Button();
            this.Customer_Del_Button = new System.Windows.Forms.Button();
            this.Customer_Refresh_Button = new System.Windows.Forms.Button();
            this.Customer_Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_DataGridView
            // 
            this.Customer_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Customer_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Customer_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customer_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Customer_DataGridView.Name = "Customer_DataGridView";
            this.Customer_DataGridView.Size = new System.Drawing.Size(784, 240);
            this.Customer_DataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng:";
            // 
            // Customer_Search_TextBox
            // 
            this.Customer_Search_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Search_TextBox.Location = new System.Drawing.Point(292, 264);
            this.Customer_Search_TextBox.Name = "Customer_Search_TextBox";
            this.Customer_Search_TextBox.Size = new System.Drawing.Size(216, 23);
            this.Customer_Search_TextBox.TabIndex = 2;
            this.Customer_Search_TextBox.Enter += new System.EventHandler(this.Customer_Search_TextBox_Enter);
            this.Customer_Search_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Customer_Search_TextBox_KeyDown);
            this.Customer_Search_TextBox.Leave += new System.EventHandler(this.Customer_Search_TextBox_Leave);
            // 
            // Customer_Search_Button
            // 
            this.Customer_Search_Button.BackColor = System.Drawing.Color.Maroon;
            this.Customer_Search_Button.FlatAppearance.BorderSize = 0;
            this.Customer_Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Search_Button.ForeColor = System.Drawing.Color.Snow;
            this.Customer_Search_Button.Location = new System.Drawing.Point(516, 260);
            this.Customer_Search_Button.Name = "Customer_Search_Button";
            this.Customer_Search_Button.Size = new System.Drawing.Size(84, 31);
            this.Customer_Search_Button.TabIndex = 3;
            this.Customer_Search_Button.Text = "Tìm Kiếm";
            this.Customer_Search_Button.UseVisualStyleBackColor = false;
            this.Customer_Search_Button.Click += new System.EventHandler(this.Customer_Search_Button_Click);
            // 
            // Customer_Add_Button
            // 
            this.Customer_Add_Button.BackColor = System.Drawing.Color.Transparent;
            this.Customer_Add_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic24;
            this.Customer_Add_Button.FlatAppearance.BorderSize = 0;
            this.Customer_Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Add_Button.ForeColor = System.Drawing.Color.Snow;
            this.Customer_Add_Button.Location = new System.Drawing.Point(12, 324);
            this.Customer_Add_Button.Name = "Customer_Add_Button";
            this.Customer_Add_Button.Size = new System.Drawing.Size(125, 125);
            this.Customer_Add_Button.TabIndex = 4;
            this.Customer_Add_Button.Text = "Thêm";
            this.Customer_Add_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customer_Add_Button.UseVisualStyleBackColor = false;
            this.Customer_Add_Button.Click += new System.EventHandler(this.Customer_Add_Button_Click);
            // 
            // Customer_Fix_Button
            // 
            this.Customer_Fix_Button.BackColor = System.Drawing.Color.Transparent;
            this.Customer_Fix_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic26;
            this.Customer_Fix_Button.FlatAppearance.BorderSize = 0;
            this.Customer_Fix_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_Fix_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Fix_Button.ForeColor = System.Drawing.Color.Snow;
            this.Customer_Fix_Button.Location = new System.Drawing.Point(143, 324);
            this.Customer_Fix_Button.Name = "Customer_Fix_Button";
            this.Customer_Fix_Button.Size = new System.Drawing.Size(125, 125);
            this.Customer_Fix_Button.TabIndex = 5;
            this.Customer_Fix_Button.Text = "Sửa";
            this.Customer_Fix_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customer_Fix_Button.UseVisualStyleBackColor = false;
            this.Customer_Fix_Button.Click += new System.EventHandler(this.Customer_Fix_Button_Click);
            // 
            // Customer_Del_Button
            // 
            this.Customer_Del_Button.BackColor = System.Drawing.Color.Transparent;
            this.Customer_Del_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic25;
            this.Customer_Del_Button.FlatAppearance.BorderSize = 0;
            this.Customer_Del_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_Del_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Del_Button.ForeColor = System.Drawing.Color.Snow;
            this.Customer_Del_Button.Location = new System.Drawing.Point(274, 324);
            this.Customer_Del_Button.Name = "Customer_Del_Button";
            this.Customer_Del_Button.Size = new System.Drawing.Size(125, 125);
            this.Customer_Del_Button.TabIndex = 6;
            this.Customer_Del_Button.Text = "Xoá";
            this.Customer_Del_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customer_Del_Button.UseVisualStyleBackColor = false;
            this.Customer_Del_Button.Click += new System.EventHandler(this.Customer_Del_Button_Click);
            // 
            // Customer_Refresh_Button
            // 
            this.Customer_Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.Customer_Refresh_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic27;
            this.Customer_Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Customer_Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Refresh_Button.ForeColor = System.Drawing.Color.Snow;
            this.Customer_Refresh_Button.Location = new System.Drawing.Point(516, 324);
            this.Customer_Refresh_Button.Name = "Customer_Refresh_Button";
            this.Customer_Refresh_Button.Size = new System.Drawing.Size(125, 125);
            this.Customer_Refresh_Button.TabIndex = 7;
            this.Customer_Refresh_Button.Text = "Tải Lại";
            this.Customer_Refresh_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customer_Refresh_Button.UseVisualStyleBackColor = false;
            this.Customer_Refresh_Button.Click += new System.EventHandler(this.Customer_Refresh_Button_Click);
            // 
            // Customer_Back_Button
            // 
            this.Customer_Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Customer_Back_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic28;
            this.Customer_Back_Button.FlatAppearance.BorderSize = 0;
            this.Customer_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Back_Button.ForeColor = System.Drawing.Color.Snow;
            this.Customer_Back_Button.Location = new System.Drawing.Point(647, 324);
            this.Customer_Back_Button.Name = "Customer_Back_Button";
            this.Customer_Back_Button.Size = new System.Drawing.Size(125, 125);
            this.Customer_Back_Button.TabIndex = 8;
            this.Customer_Back_Button.Text = "Trở Về";
            this.Customer_Back_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customer_Back_Button.UseVisualStyleBackColor = false;
            this.Customer_Back_Button.Click += new System.EventHandler(this.Customer_Back_Button_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.Pic23;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Customer_Back_Button);
            this.Controls.Add(this.Customer_Refresh_Button);
            this.Controls.Add(this.Customer_Del_Button);
            this.Controls.Add(this.Customer_Fix_Button);
            this.Controls.Add(this.Customer_Add_Button);
            this.Controls.Add(this.Customer_Search_Button);
            this.Controls.Add(this.Customer_Search_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customer_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Customer_DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Customer_Search_TextBox;
        private System.Windows.Forms.Button Customer_Search_Button;
        private System.Windows.Forms.Button Customer_Add_Button;
        private System.Windows.Forms.Button Customer_Fix_Button;
        private System.Windows.Forms.Button Customer_Del_Button;
        private System.Windows.Forms.Button Customer_Refresh_Button;
        private System.Windows.Forms.Button Customer_Back_Button;
    }
}