namespace QLBH
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.Bill_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Bill_Search_TextBox = new System.Windows.Forms.TextBox();
            this.Bill_Search_Button = new System.Windows.Forms.Button();
            this.Bill_Add_Button = new System.Windows.Forms.Button();
            this.Bill_Fix_Button = new System.Windows.Forms.Button();
            this.Bill_Del_Button = new System.Windows.Forms.Button();
            this.Bill_Refresh_Button = new System.Windows.Forms.Button();
            this.Bill_Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Bill_DataGridView
            // 
            this.Bill_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bill_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Bill_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bill_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bill_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Bill_DataGridView.Name = "Bill_DataGridView";
            this.Bill_DataGridView.Size = new System.Drawing.Size(784, 240);
            this.Bill_DataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // Bill_Search_TextBox
            // 
            this.Bill_Search_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Search_TextBox.Location = new System.Drawing.Point(286, 258);
            this.Bill_Search_TextBox.Name = "Bill_Search_TextBox";
            this.Bill_Search_TextBox.Size = new System.Drawing.Size(224, 23);
            this.Bill_Search_TextBox.TabIndex = 2;
            this.Bill_Search_TextBox.Enter += new System.EventHandler(this.Bill_Search_TextBox_Enter);
            this.Bill_Search_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bill_Search_TextBox_KeyDown);
            this.Bill_Search_TextBox.Leave += new System.EventHandler(this.Bill_Search_TextBox_Leave);
            // 
            // Bill_Search_Button
            // 
            this.Bill_Search_Button.BackColor = System.Drawing.Color.Maroon;
            this.Bill_Search_Button.FlatAppearance.BorderSize = 0;
            this.Bill_Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill_Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Search_Button.ForeColor = System.Drawing.Color.White;
            this.Bill_Search_Button.Location = new System.Drawing.Point(516, 253);
            this.Bill_Search_Button.Name = "Bill_Search_Button";
            this.Bill_Search_Button.Size = new System.Drawing.Size(80, 32);
            this.Bill_Search_Button.TabIndex = 3;
            this.Bill_Search_Button.Text = "Tìm kiếm";
            this.Bill_Search_Button.UseVisualStyleBackColor = false;
            this.Bill_Search_Button.Click += new System.EventHandler(this.Bill_Search_Button_Click);
            // 
            // Bill_Add_Button
            // 
            this.Bill_Add_Button.BackColor = System.Drawing.Color.Transparent;
            this.Bill_Add_Button.FlatAppearance.BorderSize = 0;
            this.Bill_Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Add_Button.ForeColor = System.Drawing.Color.Snow;
            this.Bill_Add_Button.Image = global::QLBH.Properties.Resources.Pic30;
            this.Bill_Add_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bill_Add_Button.Location = new System.Drawing.Point(12, 324);
            this.Bill_Add_Button.Name = "Bill_Add_Button";
            this.Bill_Add_Button.Size = new System.Drawing.Size(125, 125);
            this.Bill_Add_Button.TabIndex = 4;
            this.Bill_Add_Button.Text = "Thêm";
            this.Bill_Add_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bill_Add_Button.UseVisualStyleBackColor = false;
            this.Bill_Add_Button.Click += new System.EventHandler(this.Bill_Add_Button_Click);
            // 
            // Bill_Fix_Button
            // 
            this.Bill_Fix_Button.BackColor = System.Drawing.Color.Transparent;
            this.Bill_Fix_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic32;
            this.Bill_Fix_Button.FlatAppearance.BorderSize = 0;
            this.Bill_Fix_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill_Fix_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Fix_Button.ForeColor = System.Drawing.Color.Snow;
            this.Bill_Fix_Button.Location = new System.Drawing.Point(143, 324);
            this.Bill_Fix_Button.Name = "Bill_Fix_Button";
            this.Bill_Fix_Button.Size = new System.Drawing.Size(125, 125);
            this.Bill_Fix_Button.TabIndex = 5;
            this.Bill_Fix_Button.Text = "Sửa";
            this.Bill_Fix_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bill_Fix_Button.UseVisualStyleBackColor = false;
            this.Bill_Fix_Button.Click += new System.EventHandler(this.Bill_Fix_Button_Click);
            // 
            // Bill_Del_Button
            // 
            this.Bill_Del_Button.BackColor = System.Drawing.Color.Transparent;
            this.Bill_Del_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic31;
            this.Bill_Del_Button.FlatAppearance.BorderSize = 0;
            this.Bill_Del_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill_Del_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Del_Button.ForeColor = System.Drawing.Color.Snow;
            this.Bill_Del_Button.Location = new System.Drawing.Point(274, 324);
            this.Bill_Del_Button.Name = "Bill_Del_Button";
            this.Bill_Del_Button.Size = new System.Drawing.Size(125, 125);
            this.Bill_Del_Button.TabIndex = 6;
            this.Bill_Del_Button.Text = "Xoá";
            this.Bill_Del_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bill_Del_Button.UseVisualStyleBackColor = false;
            this.Bill_Del_Button.Click += new System.EventHandler(this.Bill_Del_Button_Click);
            // 
            // Bill_Refresh_Button
            // 
            this.Bill_Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.Bill_Refresh_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic27;
            this.Bill_Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Bill_Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill_Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Refresh_Button.ForeColor = System.Drawing.Color.Snow;
            this.Bill_Refresh_Button.Location = new System.Drawing.Point(516, 324);
            this.Bill_Refresh_Button.Name = "Bill_Refresh_Button";
            this.Bill_Refresh_Button.Size = new System.Drawing.Size(125, 125);
            this.Bill_Refresh_Button.TabIndex = 7;
            this.Bill_Refresh_Button.Text = "Tải lại";
            this.Bill_Refresh_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bill_Refresh_Button.UseVisualStyleBackColor = false;
            this.Bill_Refresh_Button.Click += new System.EventHandler(this.Bill_Refresh_Button_Click);
            // 
            // Bill_Back_Button
            // 
            this.Bill_Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Bill_Back_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic28;
            this.Bill_Back_Button.FlatAppearance.BorderSize = 0;
            this.Bill_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Back_Button.ForeColor = System.Drawing.Color.Snow;
            this.Bill_Back_Button.Location = new System.Drawing.Point(647, 324);
            this.Bill_Back_Button.Name = "Bill_Back_Button";
            this.Bill_Back_Button.Size = new System.Drawing.Size(125, 125);
            this.Bill_Back_Button.TabIndex = 8;
            this.Bill_Back_Button.Text = "Trở về";
            this.Bill_Back_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bill_Back_Button.UseVisualStyleBackColor = false;
            this.Bill_Back_Button.Click += new System.EventHandler(this.Bill_Back_Button_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.Pic23;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Bill_Back_Button);
            this.Controls.Add(this.Bill_Refresh_Button);
            this.Controls.Add(this.Bill_Del_Button);
            this.Controls.Add(this.Bill_Fix_Button);
            this.Controls.Add(this.Bill_Add_Button);
            this.Controls.Add(this.Bill_Search_Button);
            this.Controls.Add(this.Bill_Search_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bill_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bill_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Bill_DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bill_Search_TextBox;
        private System.Windows.Forms.Button Bill_Search_Button;
        private System.Windows.Forms.Button Bill_Add_Button;
        private System.Windows.Forms.Button Bill_Fix_Button;
        private System.Windows.Forms.Button Bill_Del_Button;
        private System.Windows.Forms.Button Bill_Refresh_Button;
        private System.Windows.Forms.Button Bill_Back_Button;
    }
}