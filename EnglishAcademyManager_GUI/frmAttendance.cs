using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EnglishAcademyManager_BUS;
using EnglishAcademyManager_DAL.Entities;

namespace EnglishAcademyManager_GUI
{
    public partial class frmAttendance : Form
    {
        private readonly EnglishAcademyDbContext _context;
        private readonly StudentService studentService;
        private readonly AttendanceService attendanceService;

        public frmAttendance()
        {
            InitializeComponent();
            _context = new EnglishAcademyDbContext();
            studentService = new StudentService();
            attendanceService = new AttendanceService();
            LoadClasses();
            setGridViewStyle(dgvAttendance);
            cmbClasses.SelectedIndex = -1;
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.Lavender;
            dgview.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.Lavender;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadClasses()
        {
            var classes = _context.Classes
                .Select(c => new
                {
                    c.class_id,
                    Display = c.class_id + ":" + c.class_name
                })
                .Distinct()
                .ToList();

            cmbClasses.DataSource = classes;
            cmbClasses.DisplayMember = "Display";
            cmbClasses.ValueMember = "class_id";
        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedValue != null)
            {
                string classId = cmbClasses.SelectedValue.ToString();
                DateTime selectedDate = dateTimePickerAttendance.Value;
                LoadAttendanceData(classId, selectedDate);
            }
        }

        private void LoadAttendanceData(string classId, DateTime selectedDate)
        {
            var studentRegistrationInfo = studentService.GetStudentRegistrationInfo(classId);

            var attendanceRecords = attendanceService.GetAttendanceForClassAndDate(classId, selectedDate);

            dgvAttendance.AutoGenerateColumns = false;
            dgvAttendance.Columns.Clear();

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StudentId",
                HeaderText = "Student ID",
                DataPropertyName = "StudentId",
                ReadOnly = true
            });

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last Name",
                DataPropertyName = "LastName",
                ReadOnly = true
            });

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First Name",
                DataPropertyName = "FirstName",
                ReadOnly = true
            });

            dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "AttendanceCheckBox",
                HeaderText = "Present",
                Width = 50,
                ReadOnly = false
            });

            dgvAttendance.DataSource = studentRegistrationInfo;

            foreach (var student in studentRegistrationInfo)
            {
                var attendance = attendanceRecords.FirstOrDefault(a => a.student_id == student.StudentId);

                foreach (DataGridViewRow row in dgvAttendance.Rows)
                {
                    if (row.Cells["StudentId"].Value.ToString() == student.StudentId)
                    {
                        if (attendance != null)
                        {
                            row.Cells["AttendanceCheckBox"].Value = attendance.status == "Present";
                        }
                        else
                        {
                            row.Cells["AttendanceCheckBox"].Value = false;
                        }

                        string status = row.Cells["AttendanceCheckBox"].Value != null && (bool)row.Cells["AttendanceCheckBox"].Value ? "Present" : "Absent";
                        attendanceService.SaveAttendance(student.StudentId, classId, selectedDate, status);
                        break;
                    }
                }
            }
        }


        private void SaveAttendance()
        {
            string classId = cmbClasses.SelectedValue.ToString();

            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (!row.IsNewRow)
                {
                    string studentId = row.Cells["StudentId"].Value.ToString();

                    bool isPresent = Convert.ToBoolean(row.Cells["AttendanceCheckBox"].Value);
                    string status = isPresent ? "Present" : "Absent";

                    attendanceService.SaveAttendance(studentId, classId, dateTimePickerAttendance.Value, status);
                }
            }

            MessageBox.Show("Attendance saved successfully!");
        }


        private void dateTimePickerAttendance_ValueChanged_1(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedValue != null)
            {
                string classId = cmbClasses.SelectedValue.ToString();
                DateTime selectedDate = dateTimePickerAttendance.Value;
                LoadAttendanceData(classId, selectedDate);
            }
        }

        private void btnSaveAttendance_Click_1(object sender, EventArgs e)
        {
            SaveAttendance();
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {
            string classId = cmbClasses.SelectedValue.ToString();
            DateTime attendanceDate = DateTime.Now;


            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                string studentId = row.Cells["StudentId"].Value.ToString();

                string status = (bool)row.Cells["AttendanceCheckBox"].Value ? "Present" : "Absent";

                attendanceService.SaveAttendance(studentId, classId, attendanceDate, status);
            }

            MessageBox.Show("Attendance taken successfully!");
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedValue != null)
            {
                string classId = cmbClasses.SelectedValue.ToString();
                DateTime attendanceDate = DateTime.Now;

                LoadAttendanceData(classId, attendanceDate);

                MessageBox.Show("Attendance data refreshed!");
            }
            else
            {
                MessageBox.Show("Please select a class first.");
            }
        }
    }
}
