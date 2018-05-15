namespace QLBH
{
    partial class BillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDetail));
            this.BillDetail_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BillDetail_BillCode_TextBox = new System.Windows.Forms.TextBox();
            this.BillDetail_ProductCode_TextBox = new System.Windows.Forms.TextBox();
            this.BillDetail_Search_Button = new System.Windows.Forms.Button();
            this.BillDetail_Add_Button = new System.Windows.Forms.Button();
            this.BillDetail_Fix_Button = new System.Windows.Forms.Button();
            this.BillDetail_Del_Button = new System.Windows.Forms.Button();
            this.BillDetail_Back_Button = new System.Windows.Forms.Button();
            this.BillDetail_Refresh_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetail_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillDetail_DataGridView
            // 
            this.BillDetail_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDetail_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillDetail_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDetail_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDetail_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.BillDetail_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.BillDetail_DataGridView.Name = "BillDetail_DataGridView";
            this.BillDetail_DataGridView.Size = new System.Drawing.Size(784, 240);
            this.BillDetail_DataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // BillDetail_BillCode_TextBox
            // 
            this.BillDetail_BillCode_TextBox.Location = new System.Drawing.Point(109, 26);
            this.BillDetail_BillCode_TextBox.Name = "BillDetail_BillCode_TextBox";
            this.BillDetail_BillCode_TextBox.Size = new System.Drawing.Size(177, 23);
            this.BillDetail_BillCode_TextBox.TabIndex = 3;
            this.BillDetail_BillCode_TextBox.Enter += new System.EventHandler(this.BillDetail_BillCode_TextBox_Enter);
            this.BillDetail_BillCode_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillDetail_BillCode_TextBox_KeyDown);
            this.BillDetail_BillCode_TextBox.Leave += new System.EventHandler(this.BillDetail_BillCode_TextBox_Leave);
            // 
            // BillDetail_ProductCode_TextBox
            // 
            this.BillDetail_ProductCode_TextBox.Location = new System.Drawing.Point(109, 55);
            this.BillDetail_ProductCode_TextBox.Name = "BillDetail_ProductCode_TextBox";
            this.BillDetail_ProductCode_TextBox.Size = new System.Drawing.Size(177, 23);
            this.BillDetail_ProductCode_TextBox.TabIndex = 4;
            this.BillDetail_ProductCode_TextBox.Enter += new System.EventHandler(this.BillDetail_ProductCode_TextBox_Enter);
            this.BillDetail_ProductCode_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillDetail_ProductCode_TextBox_KeyDown);
            this.BillDetail_ProductCode_TextBox.Leave += new System.EventHandler(this.BillDetail_ProductCode_TextBox_Leave);
            // 
            // BillDetail_Search_Button
            // 
            this.BillDetail_Search_Button.BackColor = System.Drawing.Color.Maroon;
            this.BillDetail_Search_Button.FlatAppearance.BorderSize = 0;
            this.BillDetail_Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillDetail_Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDetail_Search_Button.ForeColor = System.Drawing.Color.White;
            this.BillDetail_Search_Button.Location = new System.Drawing.Point(292, 26);
            this.BillDetail_Search_Button.Name = "BillDetail_Search_Button";
            this.BillDetail_Search_Button.Size = new System.Drawing.Size(69, 52);
            this.BillDetail_Search_Button.TabIndex = 5;
            this.BillDetail_Search_Button.Text = "Tìm kiếm";
            this.BillDetail_Search_Button.UseVisualStyleBackColor = false;
            this.BillDetail_Search_Button.Click += new System.EventHandler(this.BillDetail_Search_Button_Click);
            // 
            // BillDetail_Add_Button
            // 
            this.BillDetail_Add_Button.BackColor = System.Drawing.Color.Transparent;
            this.BillDetail_Add_Button.FlatAppearance.BorderSize = 0;
            this.BillDetail_Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillDetail_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDetail_Add_Button.ForeColor = System.Drawing.Color.Snow;
            this.BillDetail_Add_Button.Image = global::QLBH.Properties.Resources.Pic30;
            this.BillDetail_Add_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BillDetail_Add_Button.Location = new System.Drawing.Point(12, 286);
            this.BillDetail_Add_Button.Name = "BillDetail_Add_Button";
            this.BillDetail_Add_Button.Size = new System.Drawing.Size(125, 125);
            this.BillDetail_Add_Button.TabIndex = 6;
            this.BillDetail_Add_Button.Text = "Thêm";
            this.BillDetail_Add_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BillDetail_Add_Button.UseVisualStyleBackColor = false;
            this.BillDetail_Add_Button.Click += new System.EventHandler(this.BillDetail_Add_Button_Click);
            // 
            // BillDetail_Fix_Button
            // 
            this.BillDetail_Fix_Button.BackColor = System.Drawing.Color.Transparent;
            this.BillDetail_Fix_Button.FlatAppearance.BorderSize = 0;
            this.BillDetail_Fix_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillDetail_Fix_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDetail_Fix_Button.ForeColor = System.Drawing.Color.Snow;
            this.BillDetail_Fix_Button.Image = global::QLBH.Properties.Resources.Pic32;
            this.BillDetail_Fix_Button.Location = new System.Drawing.Point(143, 286);
            this.BillDetail_Fix_Button.Name = "BillDetail_Fix_Button";
            this.BillDetail_Fix_Button.Size = new System.Drawing.Size(125, 125);
            this.BillDetail_Fix_Button.TabIndex = 7;
            this.BillDetail_Fix_Button.Text = "Sửa";
            this.BillDetail_Fix_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BillDetail_Fix_Button.UseVisualStyleBackColor = false;
            this.BillDetail_Fix_Button.Click += new System.EventHandler(this.BillDetail_Fix_Button_Click);
            // 
            // BillDetail_Del_Button
            // 
            this.BillDetail_Del_Button.BackColor = System.Drawing.Color.Transparent;
            this.BillDetail_Del_Button.FlatAppearance.BorderSize = 0;
            this.BillDetail_Del_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillDetail_Del_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDetail_Del_Button.ForeColor = System.Drawing.Color.Snow;
            this.BillDetail_Del_Button.Image = global::QLBH.Properties.Resources.Pic31;
            this.BillDetail_Del_Button.Location = new System.Drawing.Point(274, 286);
            this.BillDetail_Del_Button.Name = "BillDetail_Del_Button";
            this.BillDetail_Del_Button.Size = new System.Drawing.Size(125, 125);
            this.BillDetail_Del_Button.TabIndex = 8;
            this.BillDetail_Del_Button.Text = "Xoá";
            this.BillDetail_Del_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BillDetail_Del_Button.UseVisualStyleBackColor = false;
            this.BillDetail_Del_Button.Click += new System.EventHandler(this.BillDetail_Del_Button_Click);
            // 
            // BillDetail_Back_Button
            // 
            this.BillDetail_Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.BillDetail_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillDetail_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDetail_Back_Button.ForeColor = System.Drawing.Color.Snow;
            this.BillDetail_Back_Button.Location = new System.Drawing.Point(647, 349);
            this.BillDetail_Back_Button.Name = "BillDetail_Back_Button";
            this.BillDetail_Back_Button.Size = new System.Drawing.Size(125, 100);
            this.BillDetail_Back_Button.TabIndex = 10;
            this.BillDetail_Back_Button.Text = "Trở Về";
            this.BillDetail_Back_Button.UseVisualStyleBackColor = false;
            this.BillDetail_Back_Button.Click += new System.EventHandler(this.BillDetail_Back_Button_Click);
            // 
            // BillDetail_Refresh_Button
            // 
            this.BillDetail_Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.BillDetail_Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillDetail_Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDetail_Refresh_Button.ForeColor = System.Drawing.Color.Snow;
            this.BillDetail_Refresh_Button.Location = new System.Drawing.Point(414, 349);
            this.BillDetail_Refresh_Button.Name = "BillDetail_Refresh_Button";
            this.BillDetail_Refresh_Button.Size = new System.Drawing.Size(125, 100);
            this.BillDetail_Refresh_Button.TabIndex = 11;
            this.BillDetail_Refresh_Button.Text = "Tải Lại";
            this.BillDetail_Refresh_Button.UseVisualStyleBackColor = false;
            this.BillDetail_Refresh_Button.Click += new System.EventHandler(this.BillDetail_Refresh_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BillDetail_Search_Button);
            this.groupBox1.Controls.Add(this.BillDetail_BillCode_TextBox);
            this.groupBox1.Controls.Add(this.BillDetail_ProductCode_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(405, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 94);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Sản phẩm";
            // 
            // BillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.Pic23;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BillDetail_Refresh_Button);
            this.Controls.Add(this.BillDetail_Back_Button);
            this.Controls.Add(this.BillDetail_Del_Button);
            this.Controls.Add(this.BillDetail_Fix_Button);
            this.Controls.Add(this.BillDetail_Add_Button);
            this.Controls.Add(this.BillDetail_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hoá Đơn";
            this.Load += new System.EventHandler(this.BillDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDetail_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BillDetail_DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BillDetail_BillCode_TextBox;
        private System.Windows.Forms.TextBox BillDetail_ProductCode_TextBox;
        private System.Windows.Forms.Button BillDetail_Search_Button;
        private System.Windows.Forms.Button BillDetail_Add_Button;
        private System.Windows.Forms.Button BillDetail_Fix_Button;
        private System.Windows.Forms.Button BillDetail_Del_Button;
        private System.Windows.Forms.Button BillDetail_Back_Button;
        private System.Windows.Forms.Button BillDetail_Refresh_Button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}