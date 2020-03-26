namespace AgeCalculator
{
    partial class Form1
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
            this.stdID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // stdID
            // 
            this.stdID.Location = new System.Drawing.Point(261, 89);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(100, 20);
            this.stdID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "S_Name :";
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(261, 118);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(100, 20);
            this.stdName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOB :";
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(261, 149);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(200, 20);
            this.DOB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age :";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(261, 190);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 7;
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(386, 187);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 8;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(261, 238);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 9;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 453);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stdID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AgeCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button submit;
    }
}

