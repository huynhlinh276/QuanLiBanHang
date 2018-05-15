namespace QLBH
{
    partial class Revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revenue));
            this.Revenue_Day_Button = new System.Windows.Forms.Button();
            this.Revenue_Month_Button = new System.Windows.Forms.Button();
            this.Revenue_Year_Button = new System.Windows.Forms.Button();
            this.Revenue_Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Revenue_Day_Button
            // 
            this.Revenue_Day_Button.BackColor = System.Drawing.Color.Transparent;
            this.Revenue_Day_Button.FlatAppearance.BorderSize = 0;
            this.Revenue_Day_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Revenue_Day_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue_Day_Button.ForeColor = System.Drawing.Color.Snow;
            this.Revenue_Day_Button.Image = global::QLBH.Properties.Resources.Pic191;
            this.Revenue_Day_Button.Location = new System.Drawing.Point(12, 12);
            this.Revenue_Day_Button.Name = "Revenue_Day_Button";
            this.Revenue_Day_Button.Size = new System.Drawing.Size(200, 200);
            this.Revenue_Day_Button.TabIndex = 0;
            this.Revenue_Day_Button.Text = "Theo Ngày";
            this.Revenue_Day_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Revenue_Day_Button.UseVisualStyleBackColor = false;
            this.Revenue_Day_Button.Click += new System.EventHandler(this.Revenue_Day_Button_Click);
            // 
            // Revenue_Month_Button
            // 
            this.Revenue_Month_Button.BackColor = System.Drawing.Color.Transparent;
            this.Revenue_Month_Button.FlatAppearance.BorderSize = 0;
            this.Revenue_Month_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Revenue_Month_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue_Month_Button.ForeColor = System.Drawing.Color.Snow;
            this.Revenue_Month_Button.Image = global::QLBH.Properties.Resources.Pic201;
            this.Revenue_Month_Button.Location = new System.Drawing.Point(222, 12);
            this.Revenue_Month_Button.Name = "Revenue_Month_Button";
            this.Revenue_Month_Button.Size = new System.Drawing.Size(200, 200);
            this.Revenue_Month_Button.TabIndex = 1;
            this.Revenue_Month_Button.Text = "Theo Tháng";
            this.Revenue_Month_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Revenue_Month_Button.UseVisualStyleBackColor = false;
            this.Revenue_Month_Button.Click += new System.EventHandler(this.Revenue_Month_Button_Click);
            // 
            // Revenue_Year_Button
            // 
            this.Revenue_Year_Button.BackColor = System.Drawing.Color.Transparent;
            this.Revenue_Year_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic21;
            this.Revenue_Year_Button.FlatAppearance.BorderSize = 0;
            this.Revenue_Year_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Revenue_Year_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue_Year_Button.ForeColor = System.Drawing.Color.Snow;
            this.Revenue_Year_Button.Location = new System.Drawing.Point(12, 219);
            this.Revenue_Year_Button.Name = "Revenue_Year_Button";
            this.Revenue_Year_Button.Size = new System.Drawing.Size(200, 200);
            this.Revenue_Year_Button.TabIndex = 2;
            this.Revenue_Year_Button.Text = "Theo Năm";
            this.Revenue_Year_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Revenue_Year_Button.UseVisualStyleBackColor = false;
            this.Revenue_Year_Button.Click += new System.EventHandler(this.Revenue_Year_Button_Click);
            // 
            // Revenue_Back_Button
            // 
            this.Revenue_Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Revenue_Back_Button.BackgroundImage = global::QLBH.Properties.Resources.Pic221;
            this.Revenue_Back_Button.FlatAppearance.BorderSize = 0;
            this.Revenue_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Revenue_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue_Back_Button.ForeColor = System.Drawing.Color.Snow;
            this.Revenue_Back_Button.Location = new System.Drawing.Point(222, 219);
            this.Revenue_Back_Button.Name = "Revenue_Back_Button";
            this.Revenue_Back_Button.Size = new System.Drawing.Size(200, 200);
            this.Revenue_Back_Button.TabIndex = 3;
            this.Revenue_Back_Button.Text = "Trở về";
            this.Revenue_Back_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Revenue_Back_Button.UseVisualStyleBackColor = false;
            this.Revenue_Back_Button.Click += new System.EventHandler(this.Revenue_Back_Button_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.Pic18;
            this.ClientSize = new System.Drawing.Size(434, 431);
            this.Controls.Add(this.Revenue_Back_Button);
            this.Controls.Add(this.Revenue_Year_Button);
            this.Controls.Add(this.Revenue_Month_Button);
            this.Controls.Add(this.Revenue_Day_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Revenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Revenue_Day_Button;
        private System.Windows.Forms.Button Revenue_Month_Button;
        private System.Windows.Forms.Button Revenue_Year_Button;
        private System.Windows.Forms.Button Revenue_Back_Button;
    }
}