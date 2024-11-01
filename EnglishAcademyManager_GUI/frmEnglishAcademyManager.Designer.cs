﻿namespace EnglishAcademyManager_GUI
{
    partial class frmEnglishAcademyManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnglishAcademyManager));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconEmployee = new FontAwesome.Sharp.IconButton();
            this.btnReceipt = new FontAwesome.Sharp.IconButton();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.btnSignOut = new FontAwesome.Sharp.IconButton();
            this.btnClass = new FontAwesome.Sharp.IconButton();
            this.btnTeacher = new FontAwesome.Sharp.IconButton();
            this.btnCourse = new FontAwesome.Sharp.IconButton();
            this.btnSchedule = new FontAwesome.Sharp.IconButton();
            this.btnStudent = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMenu.Controls.Add(this.iconEmployee);
            this.panelMenu.Controls.Add(this.btnReceipt);
            this.panelMenu.Controls.Add(this.btnCheck);
            this.panelMenu.Controls.Add(this.btnSignOut);
            this.panelMenu.Controls.Add(this.btnClass);
            this.panelMenu.Controls.Add(this.btnTeacher);
            this.panelMenu.Controls.Add(this.btnCourse);
            this.panelMenu.Controls.Add(this.btnSchedule);
            this.panelMenu.Controls.Add(this.btnStudent);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 697);
            this.panelMenu.TabIndex = 2;
            // 
            // iconEmployee
            // 
            this.iconEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconEmployee.FlatAppearance.BorderSize = 0;
            this.iconEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEmployee.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconEmployee.IconColor = System.Drawing.Color.Black;
            this.iconEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmployee.IconSize = 30;
            this.iconEmployee.Location = new System.Drawing.Point(0, 502);
            this.iconEmployee.Name = "iconEmployee";
            this.iconEmployee.Size = new System.Drawing.Size(230, 60);
            this.iconEmployee.TabIndex = 10;
            this.iconEmployee.Tag = "  Nhân viên";
            this.iconEmployee.Text = "  Nhân viên";
            this.iconEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEmployee.UseVisualStyleBackColor = true;
            this.iconEmployee.Click += new System.EventHandler(this.iconEmployee_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnReceipt.IconColor = System.Drawing.Color.Black;
            this.btnReceipt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReceipt.IconSize = 30;
            this.btnReceipt.Location = new System.Drawing.Point(0, 442);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(230, 60);
            this.btnReceipt.TabIndex = 9;
            this.btnReceipt.Tag = "  Học phí     ";
            this.btnReceipt.Text = "  Học phí     ";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnCheck.IconColor = System.Drawing.Color.Black;
            this.btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheck.IconSize = 30;
            this.btnCheck.Location = new System.Drawing.Point(0, 382);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(230, 60);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Tag = "  Điểm danh";
            this.btnCheck.Text = "  Điểm danh";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnSignOut.IconColor = System.Drawing.Color.Black;
            this.btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignOut.IconSize = 30;
            this.btnSignOut.Location = new System.Drawing.Point(0, 637);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(230, 60);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Tag = "  Đăng xuất";
            this.btnSignOut.Text = "  Đăng xuất";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // btnClass
            // 
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnClass.IconColor = System.Drawing.Color.Black;
            this.btnClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClass.IconSize = 30;
            this.btnClass.Location = new System.Drawing.Point(0, 322);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(230, 60);
            this.btnClass.TabIndex = 6;
            this.btnClass.Tag = "  Lớp học   ";
            this.btnClass.Text = "  Lớp học   ";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnTeacher.IconColor = System.Drawing.Color.Black;
            this.btnTeacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeacher.IconSize = 30;
            this.btnTeacher.Location = new System.Drawing.Point(0, 262);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(230, 60);
            this.btnTeacher.TabIndex = 5;
            this.btnTeacher.Tag = "  Giáo viên";
            this.btnTeacher.Text = "  Giáo viên";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.btnCourse.IconColor = System.Drawing.Color.Black;
            this.btnCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCourse.IconSize = 30;
            this.btnCourse.Location = new System.Drawing.Point(0, 202);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(230, 60);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Tag = "  Khóa học";
            this.btnCourse.Text = "  Khóa học";
            this.btnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnSchedule.IconColor = System.Drawing.Color.Black;
            this.btnSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSchedule.IconSize = 30;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedule.Location = new System.Drawing.Point(0, 142);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(230, 60);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Tag = "  Thời khóa biểu";
            this.btnSchedule.Text = "  Thời khóa biểu";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnStudent.IconColor = System.Drawing.Color.Black;
            this.btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudent.IconSize = 30;
            this.btnStudent.Location = new System.Drawing.Point(0, 82);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(230, 60);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Tag = "  Học viên";
            this.btnStudent.Text = "  Học viên";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 82);
            this.panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(181, 82);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(179, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(51, 42);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.AliceBlue;
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(857, 60);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(722, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 27);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(767, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 27);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 23;
            this.btnExit.Location = new System.Drawing.Point(812, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Lavender;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelDesktop.Size = new System.Drawing.Size(857, 637);
            this.panelDesktop.TabIndex = 4;
            // 
            // frmEnglishAcademyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1087, 697);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmEnglishAcademyManager";
            this.Text = "frmEnglishAcademyManager";
            this.Load += new System.EventHandler(this.frmEnglishAcademyManager_Load);
            this.Resize += new System.EventHandler(this.frmEnglishAcademyManager_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconEmployee;
        private FontAwesome.Sharp.IconButton btnReceipt;
        private FontAwesome.Sharp.IconButton btnCheck;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private FontAwesome.Sharp.IconButton btnClass;
        private FontAwesome.Sharp.IconButton btnTeacher;
        private FontAwesome.Sharp.IconButton btnCourse;
        private FontAwesome.Sharp.IconButton btnSchedule;
        private FontAwesome.Sharp.IconButton btnStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelDesktop;
    }
}