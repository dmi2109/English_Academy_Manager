using System;
using System.Windows.Forms;

namespace EnglishAcademyManager_GUI
{
    partial class frmAttendance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.btnTakeAttendance = new System.Windows.Forms.Button();
            this.btnSaveAttendance = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.dateTimePickerAttendance = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCourseID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClasses
            // 
            this.cmbClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(109, 3);
            this.cmbClasses.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(458, 30);
            this.cmbClasses.TabIndex = 0;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.cmbClasses_SelectedIndexChanged);
            // 
            // btnTakeAttendance
            // 
            this.btnTakeAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAttendance.Location = new System.Drawing.Point(603, 640);
            this.btnTakeAttendance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTakeAttendance.Name = "btnTakeAttendance";
            this.btnTakeAttendance.Size = new System.Drawing.Size(139, 38);
            this.btnTakeAttendance.TabIndex = 2;
            this.btnTakeAttendance.Text = "Điểm Danh";
            this.btnTakeAttendance.UseVisualStyleBackColor = true;
            this.btnTakeAttendance.Click += new System.EventHandler(this.btnTakeAttendance_Click);
            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAttendance.Location = new System.Drawing.Point(764, 640);
            this.btnSaveAttendance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.Size = new System.Drawing.Size(142, 38);
            this.btnSaveAttendance.TabIndex = 3;
            this.btnSaveAttendance.Text = "Lưu";
            this.btnSaveAttendance.UseVisualStyleBackColor = true;
            this.btnSaveAttendance.Click += new System.EventHandler(this.btnSaveAttendance_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(943, 640);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 38);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(18, 119);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 62;
            this.dgvAttendance.RowTemplate.Height = 28;
            this.dgvAttendance.Size = new System.Drawing.Size(1036, 493);
            this.dgvAttendance.TabIndex = 5;
            // 
            // dateTimePickerAttendance
            // 
            this.dateTimePickerAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAttendance.Location = new System.Drawing.Point(636, 2);
            this.dateTimePickerAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            this.dateTimePickerAttendance.Size = new System.Drawing.Size(411, 28);
            this.dateTimePickerAttendance.TabIndex = 6;
            this.dateTimePickerAttendance.ValueChanged += new System.EventHandler(this.dateTimePickerAttendance_ValueChanged_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1078, 56);
            this.lblTitle.TabIndex = 60;
            this.lblTitle.Text = "THÔNG TIN HỌC VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.87697F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.12303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 437F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerAttendance, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbClasses, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCourseID, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 36);
            this.tableLayoutPanel1.TabIndex = 61;
            // 
            // lblCourseID
            // 
            this.lblCourseID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCourseID.Location = new System.Drawing.Point(4, 0);
            this.lblCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(99, 36);
            this.lblCourseID.TabIndex = 9;
            this.lblCourseID.Text = "Chọn Lớp";
            this.lblCourseID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1078, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveAttendance);
            this.Controls.Add(this.btnTakeAttendance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAttendance";
            this.Text = "Attendance Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Button btnTakeAttendance;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Button btnRefresh;
        private DataGridView dgvAttendance;
        private DateTimePicker dateTimePickerAttendance;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCourseID;
    }
}
