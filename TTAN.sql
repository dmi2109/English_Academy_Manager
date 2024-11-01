USE master;
DROP DATABASE EnglishAcadmyManager; -- Xóa cơ sở dữ liệu nếu đã tồn tại
CREATE DATABASE EnglishAcadmyManager;
GO
USE EnglishAcadmyManager;
GO

-- Bảng Course
CREATE TABLE Course (
    course_id VARCHAR(10) NOT NULL PRIMARY KEY,
    course_name NVARCHAR(50) NULL,
    level VARCHAR(20) NULL,
    fee DECIMAL(18,2) NULL
);
GO

-- Bảng Student
CREATE TABLE Student (
    student_id CHAR(10) NOT NULL PRIMARY KEY,
    last_name NVARCHAR(50) NULL,
    first_name NVARCHAR(50) NULL,
    day_of_birth DATETIME NULL,
    email NVARCHAR(50) NULL,
    phone CHAR(10) NULL,
    Status BIT DEFAULT 1  -- 1 for Active, 0 for Inactive
);
GO

-- Bảng Employee
CREATE TABLE Employee (
    employee_id CHAR(10) NOT NULL PRIMARY KEY,
    last_name NVARCHAR(50) NULL,
    first_name NVARCHAR(50) NULL,
    position NVARCHAR(50) NULL,
    email NVARCHAR(50) NULL,
    phone CHAR(10) NULL,
    hire_date DATETIME NULL,
    salary DECIMAL(18,2) NULL,
    Status BIT DEFAULT 1  -- 1 for Active, 0 for Inactive
);
GO

-- Bảng Teachers
CREATE TABLE Teachers (
    teacher_id CHAR(10) NOT NULL PRIMARY KEY,
    last_name NVARCHAR(50) NULL,
    first_name NVARCHAR(50) NULL,
    email NVARCHAR(50) NULL,
    phone CHAR(10) NULL,
    Status BIT DEFAULT 1  -- 1 for Active, 0 for Inactive
);
GO

-- Bảng Classes
CREATE TABLE Classes (
    class_id CHAR(10) NOT NULL PRIMARY KEY,
    course_id VARCHAR(10) NOT NULL,
    teacher_id CHAR(10) NOT NULL,
    class_name NVARCHAR(50) NULL,
    start_date DATETIME NULL,
    end_date DATETIME NULL,
    Status BIT DEFAULT 1,  -- 1 for Active, 0 for Inactive
    FOREIGN KEY (course_id) REFERENCES Course(course_id),
    FOREIGN KEY (teacher_id) REFERENCES Teachers(teacher_id)
);
GO

-- Bảng ScheduleDetails
CREATE TABLE ScheduleDetails (
    schedule_id CHAR(10) NOT NULL PRIMARY KEY,
    start_time DATETIME NULL,
    end_time DATETIME NULL,
    room NVARCHAR(10) NULL,
    class_id CHAR(10) NOT NULL,
    FOREIGN KEY (class_id) REFERENCES Classes(class_id)
);
GO

-- Bảng Registration
CREATE TABLE Registration (
    registration_id VARCHAR(10) NOT NULL PRIMARY KEY,
    registration_date DATETIME NULL,
    student_id CHAR(10) NOT NULL,
    course_id VARCHAR(10) NOT NULL,
    status VARCHAR(30) NULL,
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    FOREIGN KEY (course_id) REFERENCES Course(course_id)
);
GO

-- Bảng Receipt
CREATE TABLE Receipt (
    receipt_id VARCHAR(10) NOT NULL PRIMARY KEY,
    payment_date DATETIME NULL,
    amount DECIMAL(18,2) NULL,
    payment_method NVARCHAR(50) NULL,
    student_id CHAR(10) NOT NULL,
    employee_id CHAR(10) NOT NULL,
    description NVARCHAR(255) NULL,
    payment_status NVARCHAR(20) NULL,
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
);
GO

-- Bảng AcademicResults
CREATE TABLE AcademicResults (
    attempt INT NOT NULL,
    average_score DECIMAL(18,2) NULL,
    final_result NVARCHAR(50) NULL,
    student_id CHAR(10) NOT NULL,
    course_id VARCHAR(10) NOT NULL,
    PRIMARY KEY (student_id, course_id, attempt),
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    FOREIGN KEY (course_id) REFERENCES Course(course_id)
);
GO

-- Bảng Attendance
CREATE TABLE Attendance (
    attendance_id INT IDENTITY(1,1) PRIMARY KEY,
    student_id CHAR(10) NOT NULL,
    class_id CHAR(10) NOT NULL,
    attendance_date DATETIME NOT NULL,
    status NVARCHAR(20) NOT NULL,
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    FOREIGN KEY (class_id) REFERENCES Classes(class_id)
);
GO

-- Bảng Account
CREATE TABLE Account (
    account_id CHAR(10) NOT NULL PRIMARY KEY,
    employee_id CHAR(10) NULL,
    teacher_id CHAR(10) NULL,
    student_id CHAR(10) NULL,
    is_active BIT NULL,
    login VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    role NVARCHAR(20) NOT NULL,
    FOREIGN KEY (employee_id) REFERENCES Employee(employee_id),
    FOREIGN KEY (teacher_id) REFERENCES Teachers(teacher_id),
    FOREIGN KEY (student_id) REFERENCES Student(student_id)
);
GO


-- Thêm dữ liệu vào các bảng
INSERT INTO Course (course_id, course_name, level, fee) VALUES
('C001', 'English for Beginners', 'Beginner', 150.00),
('C002', 'Intermediate English', 'Intermediate', 200.00),
('C003', 'Advanced English', 'Advanced', 250.00),
('C004', 'Business English', 'Intermediate', 300.00),
('C005', 'IELTS Preparation', 'Advanced', 350.00),
('C006', 'TOEFL Preparation', 'Advanced', 350.00),
('C007', 'Conversational English', 'Beginner', 180.00),
('C008', 'English for Kids', 'Beginner', 130.00),
('C009', 'Academic English', 'Advanced', 320.00),
('C010', 'English Writing Skills', 'Intermediate', 220.00),
('C011', 'English Speaking Skills', 'Intermediate', 200.00),
('C012', 'English Grammar', 'Beginner', 140.00),
('C013', 'English for Tourists', 'Beginner', 160.00),
('C014', 'English Literature', 'Advanced', 300.00),
('C015', 'Pronunciation Practice', 'Intermediate', 190.00),
('C016', 'English Listening Skills', 'Beginner', 150.00),
('C017', 'English for Specific Purposes', 'Intermediate', 250.00),
('C018', 'Advanced Communication', 'Advanced', 320.00),
('C019', 'English for Health Professionals', 'Intermediate', 280.00),
('C020', 'Creative Writing in English', 'Advanced', 350.00);

INSERT INTO Teachers (teacher_id, last_name, first_name, email, phone) VALUES
('TCH001', 'Nguyen', 'An', 'an.nguyen@example.com', '0123456789'),
('TCH002', 'Tran', 'Binh', 'binh.tran@example.com', '0123456790'),
('TCH003', 'Le', 'Cam', 'cam.le@example.com', '0123456791'),
('TCH004', 'Pham', 'Duc', 'duc.pham@example.com', '0123456792'),
('TCH005', 'Hoang', 'Em', 'em.hoang@example.com', '0123456793'),
('TCH006', 'Vu', 'Fang', 'fang.vu@example.com', '0123456794'),
('TCH007', 'Nguyen', 'Hai', 'hai.nguyen@example.com', '0123456795'),
('TCH008', 'Do', 'Khanh', 'khanh.do@example.com', '0123456796'),
('TCH009', 'Bui', 'Linh', 'linh.bui@example.com', '0123456797'),
('TCH010', 'Tran', 'Minh', 'minh.tran@example.com', '0123456798'),
('TCH011', 'Nguyen', 'Nhi', 'nhi.nguyen@example.com', '0123456799'),
('TCH012', 'Le', 'Quoc', 'quoc.le@example.com', '0123456700'),
('TCH013', 'Pham', 'Rang', 'rang.pham@example.com', '0123456701'),
('TCH014', 'Hoang', 'Son', 'son.hoang@example.com', '0123456702'),
('TCH015', 'Nguyen', 'Thai', 'thai.nguyen@example.com', '0123456703'),
('TCH016', 'Vu', 'Uyen', 'uyen.vu@example.com', '0123456704'),
('TCH017', 'Tran', 'Van', 'van.tran@example.com', '0123456705'),
('TCH018', 'Bui', 'Xuan', 'xuan.bui@example.com', '0123456706'),
('TCH019', 'Do', 'Yen', 'yen.do@example.com', '0123456707'),
('TCH020', 'Le', 'Zoe', 'zoe.le@example.com', '0123456708');

INSERT INTO Employee (employee_id, last_name, first_name, position, email, phone, hire_date, salary) VALUES
('EMP001', 'Nguyen', 'Anh', 'Manager', 'anh.nguyen@englishacademy.com', '0912345678', '2020-01-15', 30000.00),
('EMP002', 'Tr an', 'Binh', 'Admin', 'binh.tran@englishacademy.com', '0912345679', '2019-04-22', 15000.00),
('EMP003', 'Le', 'Cao', 'Employee', 'cao.le@englishacademy.com', '0912345680', '2021-09-01', 12000.00),
('EMP004', 'Pham', 'Duc', 'Teacher', 'duc.pham@englishacademy.com', '0912345681', '2018-05-12', 25000.00),
('EMP005', 'Hoang', 'Hanh', 'Teacher', 'hanh.hoang@englishacademy.com', '0912345682', '2022-03-11', 22000.00),
('EMP006', 'Vu', 'Tuan', 'Support', 'tuan.vu@englishacademy.com', '0912345683', '2020-07-08', 13000.00),
('EMP007', 'Nguyen', 'Hoa', 'Employee', 'hoa.nguyen@englishacademy.com', '0912345684', '2021-02-20', 11000.00),
('EMP008', 'Tran', 'Mai', 'Employee', 'mai.tran@englishacademy.com', '0912345685', '2019-08-15', 12500.00),
('EMP009', 'Le', 'Linh', 'Employee', 'linh.le@englishacademy.com', '0912345686', '2023-01-05', 11500.00),
('EMP010', 'Pham', 'Nam', 'Employee', 'nam.pham@englishacademy.com', '0912345687', '2022-11-03', 14000.00),
('EMP011', 'Hoang', 'Tu', 'Teacher', 'tu.hoang@englishacademy.com', '0912345688', '2020-05-09', 20000.00),
('EMP012', 'Nguyen', 'Khanh', 'Admin', 'khanh.nguyen@englishacademy.com', '0912345689', '2021-12-12', 15500.00),
('EMP013', 'Tran', 'Bich', 'Support', 'bich.tran@englishacademy.com', '0912345690', '2019-09-21', 13000.00),
('EMP014', 'Le', 'Hieu', 'Teacher', 'hieu.le@englishacademy.com', '0912345691', '2020-06-11', 22000.00),
('EMP015', 'Pham', 'Son', 'Employee', 'son.pham@englishacademy.com', '0912345692', '2021-08-30', 14000.00),
('EMP016', 'Hoang', 'Thao', 'Employee', 'thao.hoang@englishacademy.com', '0912345693', '2022-07-07', 13500.00),
('EMP017', 'Nguyen', 'Minh', 'Employee', 'minh.nguyen@englishacademy.com', '0912345694', '2023-02-14', 12500.00),
('EMP018', 'Tran', 'An', 'Teacher', 'an.tran@englishacademy.com', '0912345695', '2020-10-21', 21000.00),
('EMP019', 'Le', 'Hanh', 'Employee', 'hanh.le@englishacademy.com', '0912345696', '2021-05-30', 13000.00),
('EMP020', 'Pham', 'Tuyet', 'Manager', 'tuyet.pham@englishacademy.com', '0912345697', '2019-03-15', 32000.00);

INSERT INTO Student (student_id, last_name, first_name, day_of_birth, email, phone) VALUES
('STU001', 'Nguyen', 'Khoa', '2002-05-12', 'khoa.nguyen@student.com', '0921345678'),
('STU002', 'Tran', 'Lan', '2003-06-23', 'lan.tran@student.com', '0921345679'),
('STU003', 'Le', 'Minh', '2001-07-30', 'minh.le@student.com', '0921345680'),
('STU004', 'Pham', 'Linh', '2004-08-15', 'linh.pham@student.com', '0921345681'),
('STU005', 'Hoang', 'Nam ', '2005-09-25', 'nam.hoang@student.com', '0921345682'),
('STU006', 'Nguyen', 'Hao', '2002-10-14', 'hao.nguyen@student.com', '0921345683'),
('STU007', 'Tran', 'Binh', '2003-11-05', 'binh.tran@student.com', '0921345684'),
('STU008', 'Le', 'Cao', '2000-12-11', 'cao.le@student.com', '0921345685'),
('STU009', 'Pham', 'An', '2002-01-09', 'an.pham@student.com', '0921345686'),
('STU010', 'Hoang', 'Tam', '2004-02-20', 'tam.hoang@student.com', '0921345687'),
('STU011', 'Nguyen', 'Quang', '2005-03-18', 'quang.nguyen@student.com', '0921345688'),
('STU012', 'Tran', 'Yen', '2003-04-16', 'yen.tran@student.com', '0921345689'),
('STU013', 'Le', 'Thao', '2001-05-14', 'thao.le@student.com', '0921345690'),
('STU014', 'Pham', 'Giang', '2004-06-12', 'giang.pham@student.com', '0921345691'),
('STU015', 'Hoang', 'Hanh', '2000-07-08', 'hanh.hoang@student.com', '0921345692'),
('STU016', 'Nguyen', 'Ha', '2003-08-06', 'ha.nguyen@student.com', '0921345693'),
('STU017', 'Tran', 'Tam', '2002-09-04', 'tam.tran@student.com', '0921345694'),
('STU018', 'Le', 'My', '2001-10-02', 'my.le@student.com', '0921345695'),
('STU019', 'Pham', 'Phuc', '2004-11-30', 'phuc.pham@student.com', '0921345696'),
('STU020', 'Hoang', 'Vu', '2000-12-28', 'vu.hoang@student.com', '0921345697');

INSERT INTO Classes (class_id, course_id, teacher_id, class_name, start_date, end_date) VALUES
('CLS001', 'C001', 'TCH001', 'English Basic A1', '2024-01-01', '2024-06-01'),
('CLS002', 'C002', 'TCH002', 'English Intermediate B1', '2024-01-15', '2024-07-15'),
('CLS003', 'C001', 'TCH003', 'English Basic A2', '2024-02-01', '2024-06-01'),
('CLS004', 'C003', 'TCH004', 'English Advanced C1', '2024-03-01', '2024-09-01'),
('CLS005', 'C002', 'TCH005', 'English Intermediate B2', '2024-01-15', '2024-07-15'),
('CLS006', 'C004', 'TCH006', 'TOEFL Preparation', '2024-04-01', '2024-10-01'),
('CLS007', 'C003', 'TCH007', 'English Advanced C2', '2024-05-01', '2024-11-01'),
('CLS008', 'C001', 'TCH008', 'English Basic A1', '2024-01-01', '2024-06-01'),
('CLS009', 'C002', 'TCH009', 'English Intermediate B1', '2024-06-15', '2024-12-15'),
('CLS010', 'C004', 'TCH010', 'IELTS Preparation', '2024-03-01', '2024-09-01'),
('CLS011', 'C001', 'TCH011', 'English Basic A1', '2024-02-15', '2024-07-15'),
('CLS012', 'C003', 'TCH012', 'English Advanced C1', '2024-01-20', '2024-07-20'),
('CLS013', 'C002', 'TCH013', 'English Intermediate B2', '2024-04-15', '2024-10-15'),
('CLS014', 'C004', 'TCH014', 'Business English', '2024-03-10', '2024-09-10'),
('CLS015', 'C001', 'TCH015', 'English Basic A2', '2024-05-01', '2024-11-01'),
('CLS016', 'C003', 'TCH016', 'English Advanced C2', '2024-06-01', '2024-12-01'),
('CLS017', 'C002', 'TCH017', 'English Intermediate B1', '2024-02-10', '2024-08-10'),
('CLS018', 'C001', 'TCH018', 'English Basic A1', '2024-07-01', '2024-12-01'),
('CLS019', 'C004', 'TCH019', 'TOEIC Preparation', '2024-02-15', '2024-08-15'),
('CLS020', 'C003', 'TCH020', 'English Advanced C1', '2024-05-10', '2024-11-10');

INSERT INTO ScheduleDetails (schedule_id, start_time, end_time, room, class_id) VALUES
('SCH001', '2023-01-11 09:00', '2023-01-11 11:00', 'Room 101', 'CLS001'),
('SCH002', '2023-02-16 10:00', '2023-02-16 12:00', 'Room 102', 'CLS002'),
('SCH003', '2023-03-21 09:00', '2023-03-21 11:00', 'Room 103', 'CLS003'),
('SCH004', '2023-04-26 14:00', '2023-04-26 16:00', 'Room 104', 'CLS004'),
('SCH005', '2023-05-31 09:00', '2023-05-31 11:00', 'Room 105', 'CLS005'),
('SCH006', '2023-06-06 10:00', '2023-06-06 12:00', 'Room 106', 'CLS006'),
('SCH007', '2023-07-11 09:00', '2023-07-11 11:00', 'Room 107', 'CLS007'),
('SCH008', '2023-08-16 10:00', '2023-08-16 12:00', 'Room 108', 'CLS008'),
('SCH009', '2023-09-21 09:00', '2023-09-21 11:00', 'Room 109', 'CLS009'),
('SCH010', '2023-10-26 14:00', '2023-10-26 16:00', 'Room 110', 'CLS010'),
('SCH011', '2023-11-02 09:00', '2023-11-02 11:00', 'Room 111', 'CLS011'),
('SCH012', '2023-12-07 10:00', '2023-12-07 12:00', 'Room 112', 'CLS012'),
('SCH013', '2024-01-12 09:00', '2024-01-12 11:00', 'Room 113', 'CLS013'),
('SCH014', '2024-02-17 10:00', '2024-02-17 12:00', 'Room 114', 'CLS014'),
('SCH015', '2024-03-22 09:00', '2024-03-22 11:00', 'Room 115', 'CLS015'),
('SCH016', '2024-04-27 14:00', '2024-04-27 16:00', 'Room 116', 'CLS016'),
('SCH017', '2024-05-04 09:00', '2024-05-04 11:00', 'Room 117', 'CLS017'),
('SCH018', '2024-06-05 10:00', '2024-06-05 12:00', 'Room 118', 'CLS018'),
('SCH019', '2024-07-06 09:00', '2024-07-06 11:00', 'Room 119', 'CLS019'),
('SCH020', '2024-08-07 14:00', '2024-08-07 16:00', 'Room 120', 'CLS020');

INSERT INTO Registration (registration_id, student_id, course_id, registration_date) VALUES
('REG001', 'STU001', 'C001', '2023-01-15'),
('REG002', 'STU002', 'C002', '2023-02-18'),
('REG003', 'STU003', 'C003', '2023-03-10'),
('REG004', 'STU004', 'C001', '2023-04-12'),
('REG005', 'STU005', 'C002', '2023-05-15'),
('REG006', 'STU006', 'C003', '2023-06-17'),
('REG007', 'STU007', 'C004', '2023-07-20'),
('REG008', 'STU008', 'C005', '2023-08-21'),
('REG009', 'STU009', 'C006', '2023-09-22'),
('REG010', 'STU010', 'C007', '2023-10-23'),
('REG011', 'STU011', 'C008', '2023-11-24'),
('REG012', 'STU012', 'C009', '2023-12-25'),
('REG013', 'STU013', 'C010', '2023-01-26'),
('REG014', 'STU014', 'C011', '2023-02-27'),
('REG015', 'STU015', 'C012', '2023-03-28'),
('REG016', 'STU016', 'C013', '2023-04-29'),
('REG017', 'STU017', 'C014', '2023-05-30'),
('REG018', 'STU018', 'C015', '2023-06-30'), 
('REG019', 'STU019', 'C016', '2023-07-01'),
('REG020', 'STU020', 'C017', '2023-08-02');

INSERT INTO AcademicResults (attempt, average_score, final_result, student_id, course_id) VALUES
(1, 85.50, 'Passed', 'STU001', 'C001'),
(2, 78.00, 'Passed', 'STU001', 'C002'),
(3, 90.00, 'Passed', 'STU002', 'C001'),
(1, 88.00, 'Passed', 'STU003', 'C002'),
(2, 76.50, 'Passed', 'STU003', 'C003'),
(1, 82.00, 'Passed', 'STU004', 'C004'),
(2, 79.00, 'Passed', 'STU004', 'C001'),
(3, 84.50, 'Passed', 'STU005', 'C002'),
(1, 91.00, 'Passed', 'STU006', 'C003'),
(2, 85.50, 'Passed', 'STU006', 'C004'),
(3, 87.00, 'Passed', 'STU007', 'C005'),
(1, 88.00, 'Passed', 'STU008', 'C006'),
(2, 90.00, 'Passed', 'STU009', 'C007'),
(1, 77.00, 'Passed', 'STU010', 'C008'),
(2, 80.00, 'Passed', 'STU011', 'C009'),
(1, 89.00, 'Passed', 'STU012', 'C010'),
(2, 92.00, 'Passed', 'STU013', 'C011'),
(3, 83.00, 'Passed', 'STU014', 'C012'),
(1, 81.50, 'Passed', 'STU015', 'C013'),
(2, 86.00, 'Passed', 'STU016', 'C014');

INSERT INTO Receipt (receipt_id, payment_date, amount, payment_method, student_id, employee_id, description, payment_status) VALUES
('REC001', '2023-01-01', 500.00, 'Cash', 'STU001', 'EMP001', 'Payment for course A', 'Completed'),
('REC002', '2023-01-02', 600.00, 'Credit Card', 'STU002', 'EMP002', 'Payment for course B', 'Completed'),
('REC003', '2023-01-03', 550.00, 'Bank Transfer', 'STU003', 'EMP003', 'Payment for course C', 'Pending'),
('REC004', '2023-01-04', 700.00, 'Cash', 'STU004', 'EMP004', 'Payment for course D', 'Completed'),
('REC005', '2023-01-05', 800.00, 'Credit Card', 'STU005', 'EMP005', 'Payment for course E', 'Completed'),
('REC006', '2023-01-06', 750.00 , 'Bank Transfer', 'STU001', 'EMP001', 'Payment for course F', 'Pending'),
('REC007', '2023-01-07', 650.00, 'Cash', 'STU002', 'EMP002', 'Payment for course G', 'Completed'),
('REC008', '2023-01-08', 500.00, 'Credit Card', 'STU003', 'EMP003', 'Payment for course H', 'Pending'),
('REC009', '2023-01-09', 600.00, 'Bank Transfer', 'STU004', 'EMP004', 'Payment for course I', 'Completed'),
('REC010', '2023-01-10', 550.00, 'Cash', 'STU005', 'EMP005', 'Payment for course J', 'Completed'),
('REC011', '2023-01-11', 700.00, 'Credit Card', 'STU001', 'EMP001', 'Payment for course K', 'Completed'),
('REC012', '2023-01-12', 800.00, 'Bank Transfer', 'STU002', 'EMP002', 'Payment for course L', 'Completed'),
('REC013', '2023-01-13', 750.00, 'Cash', 'STU003', 'EMP003', 'Payment for course M', 'Pending'),
('REC014', '2023-01-14', 650.00, 'Credit Card', 'STU004', 'EMP004', 'Payment for course N', 'Completed'),
('REC015', '2023-01-15', 600.00, 'Bank Transfer', 'STU005', 'EMP005', 'Payment for course O', 'Pending'),
('REC016', '2023-01-16', 500.00, 'Cash', 'STU001', 'EMP001', 'Payment for course P', 'Completed'),
('REC017', '2023-01-17', 600.00, 'Credit Card', 'STU002', 'EMP002', 'Payment for course Q', 'Completed'),
('REC018', '2023-01-18', 550.00, 'Bank Transfer', 'STU003', 'EMP003', 'Payment for course R', 'Pending'),
('REC019', '2023-01-19', 700.00, 'Cash', 'STU004', 'EMP004', 'Payment for course S', 'Completed'),
('REC020', '2023-01-20', 800.00, 'Credit Card', 'STU005', 'EMP005', 'Payment for course T', 'Completed');

INSERT INTO Account (account_id, employee_id, teacher_id, student_id, is_active, login, password, role) VALUES
('ACC001', 'EMP001', NULL, NULL, 1, 'admin', 'password1', 'admin'),
('ACC002', 'EMP002', NULL, NULL, 1, 'employee1', 'password2', 'employee'),
('ACC003', NULL, 'TCH001', NULL, 1, 'teacher1', 'password3', 'teacher'),
('ACC004', NULL, 'TCH002', NULL, 1, 'teacher2', 'password4', 'teacher'),
('ACC005', NULL, NULL, 'STU001', 1, 'student1', 'password5', 'student'),
('ACC006', NULL, NULL, 'STU002', 1, 'student2', 'password6', 'student'),
('ACC007', NULL, NULL, 'STU003', 1, 'student3', 'password7', 'student'),
('ACC008', NULL, NULL, 'STU004', 1, 'student4', 'password8', 'student'),
('ACC009', NULL, NULL, 'STU005', 1, 'student5', 'password9', 'student'),
('ACC010', NULL, NULL, 'STU006', 1, 'student6', 'password10', 'student'),
('ACC011', NULL, NULL, 'STU007', 1, 'student7', 'password11', 'student'),
('ACC012', NULL, NULL, 'STU008', 1, 'student8', 'password12', 'student'),
('ACC013', NULL, NULL, 'STU009', 1, 'student9', 'password13', 'student'),
('ACC014', NULL, NULL, 'STU010', 1, ' student10', 'password14', 'student'),
('ACC015', NULL, NULL, 'STU011', 1, 'student11', 'password15', 'student'),
('ACC016', NULL, NULL, 'STU012', 1, 'student12', 'password16', 'student'),
('ACC017', NULL, NULL, 'STU013', 1, 'student13', 'password17', 'student'),
('ACC018', NULL, NULL, 'STU014', 1, 'student14', 'password18', 'student'),
('ACC019', NULL, NULL, 'STU015', 1, 'student15', 'password19', 'student'),
('ACC020', NULL, NULL, 'STU016', 1, 'student16', 'password20', 'student');

INSERT INTO Attendance (student_id, class_id, attendance_date, status) VALUES
('STU001', 'CLS001', '2024-10-01', 'Present'),
('STU002', 'CLS001', '2024-10-01', 'Absent'),
('STU003', 'CLS001', '2024-10-01', 'Present'),
('STU004', 'CLS001', '2024-10-01', 'Present'),
('STU005', 'CLS001', '2024-10-01', 'Absent'),
('STU006', 'CLS002', '2024-10-01', 'Present'),
('STU007', 'CLS002', '2024-10-01', 'Present'),
('STU008', 'CLS002', '2024-10-01', 'Absent'),
('STU009', 'CLS003', '2024-10-01', 'Present'),
('STU010', 'CLS003', '2024-10-01', 'Present'),
('STU011', 'CLS003', '2024-10-01', 'Absent'),
('STU012', 'CLS003', '2024-10-01', 'Present'),
('STU013', 'CLS004', '2024-10-01', 'Present'),
('STU014', 'CLS004', '2024-10-01', 'Absent'),
('STU015', 'CLS004', '2024-10-01', 'Present'),
('STU016', 'CLS004', '2024-10-01', 'Absent'),
('STU017', 'CLS005', '2024-10-01', 'Present'),
('STU018', 'CLS005', '2024-10-01', 'Present'),
('STU019', 'CLS005', '2024-10-01', 'Absent'),
('STU020', 'CLS005', '2024-10-01', 'Present');

UPDATE Teachers
SET Status = 1 -- Set to Active (1) or 0 for Inactive based on your business logic
WHERE Status is NULL;

ALTER TABLE Student
ADD Status BIT DEFAULT 1;  -- 1 for Active, 0 for Inactive

UPDATE Student
SET Status = 1 -- Set to Active (1) or 0 for Inactive based on your business logic
WHERE Status is NULL;

ALTER TABLE Employee
ADD Status BIT DEFAULT 1;  -- 1 for Active, 0 for Inactive

UPDATE Employee
SET Status = 1 -- Set to Active (1) or 0 for Inactive based on your business logic
WHERE Status is NULL;

ALTER TABLE Classes
ADD Status BIT DEFAULT 1;  -- 1 for Active, 0 for Inactive

UPDATE Classes
SET Status = 1 -- Set to Active (1) or 0 for Inactive based on your business logic
WHERE Status is NULL;


SELECT * FROM Course;
SELECT * FROM Teachers;
SELECT * FROM Employee;
SELECT * FROM Student;
SELECT * FROM Classes;
SELECT * FROM ScheduleDetails;
SELECT * FROM Registration;
SELECT * FROM AcademicResults;
SELECT * FROM Receipt;
SELECT * FROM Account;
SELECT * FROM Attendance;