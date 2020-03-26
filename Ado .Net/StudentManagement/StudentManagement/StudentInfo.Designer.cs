namespace StudentManagement
{
    partial class StudentInfo
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
            this.PNLRegistration = new System.Windows.Forms.Panel();
            this.GRPDataView = new System.Windows.Forms.GroupBox();
            this.CHKPython = new System.Windows.Forms.CheckBox();
            this.LblActions = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.CHKAndroid = new System.Windows.Forms.CheckBox();
            this.CHKPHP = new System.Windows.Forms.CheckBox();
            this.CHKJava = new System.Windows.Forms.CheckBox();
            this.CHKDNet = new System.Windows.Forms.CheckBox();
            this.DGVDetails = new System.Windows.Forms.DataGridView();
            this.CBOActions = new System.Windows.Forms.ComboBox();
            this.GRPRegistration = new System.Windows.Forms.GroupBox();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.BTNNew = new System.Windows.Forms.Button();
            this.BTNLast = new System.Windows.Forms.Button();
            this.BTNNext = new System.Windows.Forms.Button();
            this.BTNPrevious = new System.Windows.Forms.Button();
            this.BTNFirst = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.PBXImage = new System.Windows.Forms.PictureBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.DTPCourseJoined = new System.Windows.Forms.DateTimePicker();
            this.LBLDateJoined = new System.Windows.Forms.Label();
            this.CBOCourse = new System.Windows.Forms.ComboBox();
            this.LblCourse = new System.Windows.Forms.Label();
            this.CHKMale = new System.Windows.Forms.CheckBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtStudentNo = new System.Windows.Forms.TextBox();
            this.LBLStudentNo = new System.Windows.Forms.Label();
            this.OPNDialog = new System.Windows.Forms.OpenFileDialog();
            this.PNLRegistration.SuspendLayout();
            this.GRPDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).BeginInit();
            this.GRPRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLRegistration
            // 
            this.PNLRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLRegistration.Controls.Add(this.GRPDataView);
            this.PNLRegistration.Controls.Add(this.GRPRegistration);
            this.PNLRegistration.Location = new System.Drawing.Point(35, 13);
            this.PNLRegistration.Name = "PNLRegistration";
            this.PNLRegistration.Size = new System.Drawing.Size(657, 497);
            this.PNLRegistration.TabIndex = 0;
            // 
            // GRPDataView
            // 
            this.GRPDataView.Controls.Add(this.CHKPython);
            this.GRPDataView.Controls.Add(this.LblActions);
            this.GRPDataView.Controls.Add(this.DTPDate);
            this.GRPDataView.Controls.Add(this.CHKAndroid);
            this.GRPDataView.Controls.Add(this.CHKPHP);
            this.GRPDataView.Controls.Add(this.CHKJava);
            this.GRPDataView.Controls.Add(this.CHKDNet);
            this.GRPDataView.Controls.Add(this.DGVDetails);
            this.GRPDataView.Controls.Add(this.CBOActions);
            this.GRPDataView.Location = new System.Drawing.Point(6, 294);
            this.GRPDataView.Name = "GRPDataView";
            this.GRPDataView.Size = new System.Drawing.Size(643, 198);
            this.GRPDataView.TabIndex = 1;
            this.GRPDataView.TabStop = false;
            this.GRPDataView.Text = "Data View";
            // 
            // CHKPython
            // 
            this.CHKPython.AutoSize = true;
            this.CHKPython.Location = new System.Drawing.Point(58, 143);
            this.CHKPython.Name = "CHKPython";
            this.CHKPython.Size = new System.Drawing.Size(78, 20);
            this.CHKPython.TabIndex = 8;
            this.CHKPython.Text = "Python";
            this.CHKPython.UseVisualStyleBackColor = true;
            this.CHKPython.Visible = false;
            // 
            // LblActions
            // 
            this.LblActions.AutoSize = true;
            this.LblActions.Location = new System.Drawing.Point(9, 23);
            this.LblActions.Name = "LblActions";
            this.LblActions.Size = new System.Drawing.Size(67, 16);
            this.LblActions.TabIndex = 7;
            this.LblActions.Text = "Actions:";
            // 
            // DTPDate
            // 
            this.DTPDate.Location = new System.Drawing.Point(9, 169);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(200, 23);
            this.DTPDate.TabIndex = 6;
            this.DTPDate.Visible = false;
            // 
            // CHKAndroid
            // 
            this.CHKAndroid.AutoSize = true;
            this.CHKAndroid.Location = new System.Drawing.Point(129, 116);
            this.CHKAndroid.Name = "CHKAndroid";
            this.CHKAndroid.Size = new System.Drawing.Size(83, 20);
            this.CHKAndroid.TabIndex = 5;
            this.CHKAndroid.Text = "Android";
            this.CHKAndroid.UseVisualStyleBackColor = true;
            this.CHKAndroid.Visible = false;
            // 
            // CHKPHP
            // 
            this.CHKPHP.AutoSize = true;
            this.CHKPHP.Location = new System.Drawing.Point(9, 116);
            this.CHKPHP.Name = "CHKPHP";
            this.CHKPHP.Size = new System.Drawing.Size(56, 20);
            this.CHKPHP.TabIndex = 4;
            this.CHKPHP.Text = "PHP";
            this.CHKPHP.UseVisualStyleBackColor = true;
            this.CHKPHP.Visible = false;
            // 
            // CHKJava
            // 
            this.CHKJava.AutoSize = true;
            this.CHKJava.Location = new System.Drawing.Point(151, 79);
            this.CHKJava.Name = "CHKJava";
            this.CHKJava.Size = new System.Drawing.Size(61, 20);
            this.CHKJava.TabIndex = 3;
            this.CHKJava.Text = "Java";
            this.CHKJava.UseVisualStyleBackColor = true;
            this.CHKJava.Visible = false;
            // 
            // CHKDNet
            // 
            this.CHKDNet.AutoSize = true;
            this.CHKDNet.Location = new System.Drawing.Point(9, 82);
            this.CHKDNet.Name = "CHKDNet";
            this.CHKDNet.Size = new System.Drawing.Size(130, 20);
            this.CHKDNet.TabIndex = 2;
            this.CHKDNet.Text = "Microsoft .NET";
            this.CHKDNet.UseVisualStyleBackColor = true;
            this.CHKDNet.Visible = false;
            // 
            // DGVDetails
            // 
            this.DGVDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetails.Location = new System.Drawing.Point(230, 23);
            this.DGVDetails.Name = "DGVDetails";
            this.DGVDetails.Size = new System.Drawing.Size(404, 169);
            this.DGVDetails.TabIndex = 1;
            // 
            // CBOActions
            // 
            this.CBOActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOActions.FormattingEnabled = true;
            this.CBOActions.Location = new System.Drawing.Point(9, 49);
            this.CBOActions.Name = "CBOActions";
            this.CBOActions.Size = new System.Drawing.Size(203, 24);
            this.CBOActions.Sorted = true;
            this.CBOActions.TabIndex = 0;
            this.CBOActions.SelectedIndexChanged += new System.EventHandler(this.CBOActions_SelectedIndexChanged);
            // 
            // GRPRegistration
            // 
            this.GRPRegistration.Controls.Add(this.BTNDelete);
            this.GRPRegistration.Controls.Add(this.BTNUpdate);
            this.GRPRegistration.Controls.Add(this.BTNSearch);
            this.GRPRegistration.Controls.Add(this.BTNInsert);
            this.GRPRegistration.Controls.Add(this.BTNNew);
            this.GRPRegistration.Controls.Add(this.BTNLast);
            this.GRPRegistration.Controls.Add(this.BTNNext);
            this.GRPRegistration.Controls.Add(this.BTNPrevious);
            this.GRPRegistration.Controls.Add(this.BTNFirst);
            this.GRPRegistration.Controls.Add(this.BtnBrowse);
            this.GRPRegistration.Controls.Add(this.PBXImage);
            this.GRPRegistration.Controls.Add(this.LblGender);
            this.GRPRegistration.Controls.Add(this.DTPCourseJoined);
            this.GRPRegistration.Controls.Add(this.LBLDateJoined);
            this.GRPRegistration.Controls.Add(this.CBOCourse);
            this.GRPRegistration.Controls.Add(this.LblCourse);
            this.GRPRegistration.Controls.Add(this.CHKMale);
            this.GRPRegistration.Controls.Add(this.TxtName);
            this.GRPRegistration.Controls.Add(this.LblName);
            this.GRPRegistration.Controls.Add(this.TxtStudentNo);
            this.GRPRegistration.Controls.Add(this.LBLStudentNo);
            this.GRPRegistration.Location = new System.Drawing.Point(6, 4);
            this.GRPRegistration.Name = "GRPRegistration";
            this.GRPRegistration.Size = new System.Drawing.Size(643, 283);
            this.GRPRegistration.TabIndex = 0;
            this.GRPRegistration.TabStop = false;
            this.GRPRegistration.Text = "Student  Registration";
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(456, 252);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(75, 23);
            this.BTNDelete.TabIndex = 21;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(366, 253);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(75, 23);
            this.BTNUpdate.TabIndex = 20;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(276, 253);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(75, 23);
            this.BTNSearch.TabIndex = 19;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNInsert
            // 
            this.BTNInsert.Location = new System.Drawing.Point(183, 253);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(75, 23);
            this.BTNInsert.TabIndex = 18;
            this.BTNInsert.Text = "Insert";
            this.BTNInsert.UseVisualStyleBackColor = true;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // BTNNew
            // 
            this.BTNNew.Location = new System.Drawing.Point(93, 253);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(75, 23);
            this.BTNNew.TabIndex = 17;
            this.BTNNew.Text = "New";
            this.BTNNew.UseVisualStyleBackColor = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // BTNLast
            // 
            this.BTNLast.Location = new System.Drawing.Point(412, 208);
            this.BTNLast.Name = "BTNLast";
            this.BTNLast.Size = new System.Drawing.Size(75, 23);
            this.BTNLast.TabIndex = 16;
            this.BTNLast.Text = ">>|";
            this.BTNLast.UseVisualStyleBackColor = true;
            this.BTNLast.Click += new System.EventHandler(this.BTNLast_Click);
            // 
            // BTNNext
            // 
            this.BTNNext.Location = new System.Drawing.Point(322, 208);
            this.BTNNext.Name = "BTNNext";
            this.BTNNext.Size = new System.Drawing.Size(75, 23);
            this.BTNNext.TabIndex = 15;
            this.BTNNext.Text = ">>";
            this.BTNNext.UseVisualStyleBackColor = true;
            this.BTNNext.Click += new System.EventHandler(this.BTNNext_Click);
            // 
            // BTNPrevious
            // 
            this.BTNPrevious.Location = new System.Drawing.Point(230, 208);
            this.BTNPrevious.Name = "BTNPrevious";
            this.BTNPrevious.Size = new System.Drawing.Size(75, 23);
            this.BTNPrevious.TabIndex = 14;
            this.BTNPrevious.Text = "<<";
            this.BTNPrevious.UseVisualStyleBackColor = true;
            this.BTNPrevious.Click += new System.EventHandler(this.BTNPrevious_Click);
            // 
            // BTNFirst
            // 
            this.BTNFirst.Location = new System.Drawing.Point(137, 208);
            this.BTNFirst.Name = "BTNFirst";
            this.BTNFirst.Size = new System.Drawing.Size(75, 23);
            this.BTNFirst.TabIndex = 13;
            this.BTNFirst.Text = "|<<";
            this.BTNFirst.UseVisualStyleBackColor = true;
            this.BTNFirst.Click += new System.EventHandler(this.BTNFirst_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(459, 166);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(136, 34);
            this.BtnBrowse.TabIndex = 12;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // PBXImage
            // 
            this.PBXImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBXImage.Location = new System.Drawing.Point(408, 41);
            this.PBXImage.Name = "PBXImage";
            this.PBXImage.Size = new System.Drawing.Size(215, 119);
            this.PBXImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXImage.TabIndex = 11;
            this.PBXImage.TabStop = false;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(405, 20);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(65, 16);
            this.LblGender.TabIndex = 10;
            this.LblGender.Text = "Gender:";
            // 
            // DTPCourseJoined
            // 
            this.DTPCourseJoined.Location = new System.Drawing.Point(157, 154);
            this.DTPCourseJoined.Name = "DTPCourseJoined";
            this.DTPCourseJoined.Size = new System.Drawing.Size(207, 23);
            this.DTPCourseJoined.TabIndex = 9;
            // 
            // LBLDateJoined
            // 
            this.LBLDateJoined.AutoSize = true;
            this.LBLDateJoined.Location = new System.Drawing.Point(19, 154);
            this.LBLDateJoined.Name = "LBLDateJoined";
            this.LBLDateJoined.Size = new System.Drawing.Size(120, 16);
            this.LBLDateJoined.TabIndex = 8;
            this.LBLDateJoined.Text = "Date of Joining:";
            // 
            // CBOCourse
            // 
            this.CBOCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOCourse.FormattingEnabled = true;
            this.CBOCourse.Location = new System.Drawing.Point(157, 110);
            this.CBOCourse.Name = "CBOCourse";
            this.CBOCourse.Size = new System.Drawing.Size(207, 24);
            this.CBOCourse.Sorted = true;
            this.CBOCourse.TabIndex = 7;
            // 
            // LblCourse
            // 
            this.LblCourse.AutoSize = true;
            this.LblCourse.Location = new System.Drawing.Point(19, 116);
            this.LblCourse.Name = "LblCourse";
            this.LblCourse.Size = new System.Drawing.Size(64, 16);
            this.LblCourse.TabIndex = 6;
            this.LblCourse.Text = "Course:";
            // 
            // CHKMale
            // 
            this.CHKMale.AutoSize = true;
            this.CHKMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHKMale.Checked = true;
            this.CHKMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKMale.Location = new System.Drawing.Point(562, 19);
            this.CHKMale.Name = "CHKMale";
            this.CHKMale.Size = new System.Drawing.Size(61, 20);
            this.CHKMale.TabIndex = 5;
            this.CHKMale.Text = "Male";
            this.CHKMale.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(157, 72);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(207, 23);
            this.TxtName.TabIndex = 3;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(19, 75);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(116, 16);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Student Name:";
            // 
            // TxtStudentNo
            // 
            this.TxtStudentNo.Location = new System.Drawing.Point(157, 34);
            this.TxtStudentNo.Name = "TxtStudentNo";
            this.TxtStudentNo.Size = new System.Drawing.Size(100, 23);
            this.TxtStudentNo.TabIndex = 1;
            // 
            // LBLStudentNo
            // 
            this.LBLStudentNo.AutoSize = true;
            this.LBLStudentNo.Location = new System.Drawing.Point(19, 37);
            this.LBLStudentNo.Name = "LBLStudentNo";
            this.LBLStudentNo.Size = new System.Drawing.Size(93, 16);
            this.LBLStudentNo.TabIndex = 0;
            this.LBLStudentNo.Text = "Student No:";
            // 
            // OPNDialog
            // 
            this.OPNDialog.FileName = "openFileDialog1";
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(726, 522);
            this.Controls.Add(this.PNLRegistration);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.PNLRegistration.ResumeLayout(false);
            this.GRPDataView.ResumeLayout(false);
            this.GRPDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).EndInit();
            this.GRPRegistration.ResumeLayout(false);
            this.GRPRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLRegistration;
        private System.Windows.Forms.GroupBox GRPRegistration;
        private System.Windows.Forms.TextBox TxtStudentNo;
        private System.Windows.Forms.Label LBLStudentNo;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblCourse;
        private System.Windows.Forms.CheckBox CHKMale;
        private System.Windows.Forms.ComboBox CBOCourse;
        private System.Windows.Forms.Label LBLDateJoined;
        private System.Windows.Forms.DateTimePicker DTPCourseJoined;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.PictureBox PBXImage;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BTNLast;
        private System.Windows.Forms.Button BTNNext;
        private System.Windows.Forms.Button BTNPrevious;
        private System.Windows.Forms.Button BTNFirst;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.Button BTNNew;
        private System.Windows.Forms.GroupBox GRPDataView;
        private System.Windows.Forms.DataGridView DGVDetails;
        private System.Windows.Forms.ComboBox CBOActions;
        private System.Windows.Forms.CheckBox CHKAndroid;
        private System.Windows.Forms.CheckBox CHKPHP;
        private System.Windows.Forms.CheckBox CHKJava;
        private System.Windows.Forms.CheckBox CHKDNet;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Label LblActions;
        private System.Windows.Forms.OpenFileDialog OPNDialog;
        private System.Windows.Forms.CheckBox CHKPython;
    }
}

