namespace LoginApplication
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
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPWD = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(61, 33);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(76, 14);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "Username:";
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Location = new System.Drawing.Point(61, 71);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(74, 14);
            this.lblPWD.TabIndex = 1;
            this.lblPWD.Text = "Password:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(138, 30);
            this.tb1.MaxLength = 10;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 22);
            this.tb1.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(138, 71);
            this.tb2.MaxLength = 10;
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '*';
            this.tb2.Size = new System.Drawing.Size(100, 22);
            this.tb2.TabIndex = 3;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(64, 126);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 4;
            this.b1.Text = "Login";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(175, 126);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 5;
            this.b2.Text = "Logout";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 199);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lblPWD);
            this.Controls.Add(this.lblUN);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
    }
}

