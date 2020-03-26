namespace LoginApplication
{
    partial class Output
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
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(224, 212);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 0;
            this.b3.Text = "Exit";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(38, 212);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 1;
            this.b4.Text = "Close";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Output";
            this.Text = "Output Windows";
            this.Activated += new System.EventHandler(this.Output_Activated);
            this.Load += new System.EventHandler(this.Output_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
    }
}