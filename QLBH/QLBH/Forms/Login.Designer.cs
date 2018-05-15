namespace QLBH
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_CheckBox = new System.Windows.Forms.CheckBox();
            this.Login_Pass_TextBox = new System.Windows.Forms.TextBox();
            this.Login_ID_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Login_Exit_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Login_CheckBox);
            this.groupBox1.Controls.Add(this.Login_Pass_TextBox);
            this.groupBox1.Controls.Add(this.Login_ID_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập Hệ Thống Quản Lý";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLBH.Properties.Resources.Login01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::QLBH.Properties.Resources.Login01;
            this.pictureBox1.Location = new System.Drawing.Point(350, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login_CheckBox
            // 
            this.Login_CheckBox.AutoSize = true;
            this.Login_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_CheckBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.Login_CheckBox.Location = new System.Drawing.Point(121, 102);
            this.Login_CheckBox.Name = "Login_CheckBox";
            this.Login_CheckBox.Size = new System.Drawing.Size(139, 21);
            this.Login_CheckBox.TabIndex = 4;
            this.Login_CheckBox.Text = "Ghi nhớ mật khẩu";
            this.Login_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Login_Pass_TextBox
            // 
            this.Login_Pass_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Pass_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Login_Pass_TextBox.Location = new System.Drawing.Point(121, 73);
            this.Login_Pass_TextBox.Name = "Login_Pass_TextBox";
            this.Login_Pass_TextBox.Size = new System.Drawing.Size(223, 23);
            this.Login_Pass_TextBox.TabIndex = 3;
            this.Login_Pass_TextBox.Enter += new System.EventHandler(this.Login_Pass_TextBox_Enter);
            this.Login_Pass_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Pass_TextBox_KeyDown);
            this.Login_Pass_TextBox.Leave += new System.EventHandler(this.Login_Pass_TextBox_Leave);
            // 
            // Login_ID_TextBox
            // 
            this.Login_ID_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_ID_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Login_ID_TextBox.Location = new System.Drawing.Point(121, 41);
            this.Login_ID_TextBox.Name = "Login_ID_TextBox";
            this.Login_ID_TextBox.Size = new System.Drawing.Size(223, 23);
            this.Login_ID_TextBox.TabIndex = 2;
            this.Login_ID_TextBox.TextChanged += new System.EventHandler(this.Login_ID_TextBox_TextChanged);
            this.Login_ID_TextBox.Enter += new System.EventHandler(this.Login_ID_TextBox_Enter);
            this.Login_ID_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_ID_TextBox_KeyDown);
            this.Login_ID_TextBox.Leave += new System.EventHandler(this.Login_ID_TextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.Transparent;
            this.Login_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Login_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Login_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Login_Button.Location = new System.Drawing.Point(12, 320);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(460, 46);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Đăng Nhập";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Exit_Button
            // 
            this.Login_Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Login_Exit_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Login_Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Exit_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Login_Exit_Button.Location = new System.Drawing.Point(12, 372);
            this.Login_Exit_Button.Name = "Login_Exit_Button";
            this.Login_Exit_Button.Size = new System.Drawing.Size(460, 46);
            this.Login_Exit_Button.TabIndex = 6;
            this.Login_Exit_Button.Text = "Thoát";
            this.Login_Exit_Button.UseVisualStyleBackColor = false;
            this.Login_Exit_Button.Click += new System.EventHandler(this.Login_Exit_Button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLBH.Properties.Resources.Login021;
            this.ClientSize = new System.Drawing.Size(484, 430);
            this.Controls.Add(this.Login_Exit_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Login_CheckBox;
        private System.Windows.Forms.TextBox Login_Pass_TextBox;
        private System.Windows.Forms.TextBox Login_ID_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Login_Exit_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}