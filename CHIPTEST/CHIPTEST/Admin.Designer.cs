namespace CHIPTEST
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginField1 = new System.Windows.Forms.TextBox();
            this.passField1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.close1Button = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "          Вход для мастеров \r\nсервисного центра \"CHIP TEST\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(56, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // loginField1
            // 
            this.loginField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField1.Location = new System.Drawing.Point(151, 158);
            this.loginField1.Name = "loginField1";
            this.loginField1.Size = new System.Drawing.Size(245, 22);
            this.loginField1.TabIndex = 10;
            // 
            // passField1
            // 
            this.passField1.Location = new System.Drawing.Point(151, 214);
            this.passField1.Name = "passField1";
            this.passField1.Size = new System.Drawing.Size(245, 20);
            this.passField1.TabIndex = 11;
            this.passField1.UseSystemPasswordChar = true;
            this.passField1.TextChanged += new System.EventHandler(this.passField1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(151, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close1Button
            // 
            this.close1Button.AutoSize = true;
            this.close1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close1Button.Location = new System.Drawing.Point(413, 9);
            this.close1Button.Name = "close1Button";
            this.close1Button.Size = new System.Drawing.Size(16, 16);
            this.close1Button.TabIndex = 13;
            this.close1Button.Text = "X";
            this.close1Button.Click += new System.EventHandler(this.close1Button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(256, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Регистрация мастера";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(441, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.close1Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passField1);
            this.Controls.Add(this.loginField1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Вход мастеров ";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Admin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Admin_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginField1;
        private System.Windows.Forms.TextBox passField1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label close1Button;
        private System.Windows.Forms.Button button2;
    }
}