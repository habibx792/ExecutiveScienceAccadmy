CREATE DATABASE academyDb;
USE academyDb;

-- Domain table (e.g., Science, Arts, Commerce)
CREATE TABLE domainTb (
    domainId VARCHAR(50) NOT NULL PRIMARY KEY,
    domainName VARCHAR(50) NOT NULL
);

-- Class table (e.g., 9th, 10th, 11th) with domain reference
CREATE TABLE classTb (
    classId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    domainId VARCHAR(50) NOT NULL,
    className VARCHAR(50) NOT NULL,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE CASCADE,
    INDEX idx_domain_class (domainId, classId)
);

-- Fixed Subjects table
CREATE TABLE subjectTb (
    subjectId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    classId INT NOT NULL,
    domainId VARCHAR(50) NOT NULL,  -- Changed from INT to VARCHAR(50)
    subjectName VARCHAR(100) NOT NULL,
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE CASCADE,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE CASCADE,  -- Added missing FK
    INDEX idx_class_subject (classId),
    INDEX idx_domain_subject (domainId)
);
-- Fixed Students table
CREATE TABLE StudentTb (
    stdRegisNo VARCHAR(50) NOT NULL PRIMARY KEY,
    student_name VARCHAR(100) NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    classId INT NOT NULL,
    gender VARCHAR(10) NOT NULL,
    date_of_birth DATE NOT NULL,
    cnic VARCHAR(15) UNIQUE,
    address TEXT NOT NULL,
    mark_of_identification VARCHAR(255),
    father_name VARCHAR(100) NOT NULL,
    father_cnic VARCHAR(15) NOT NULL,
    father_occupation VARCHAR(100),
    father_mobile_no VARCHAR(15) NOT NULL,
    student_type VARCHAR(30) NOT NULL DEFAULT 'Regular',
    batchYear VARCHAR(7) not null,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    is_active BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId),
    FOREIGN KEY (classId) REFERENCES classTb(classId),
    INDEX idx_student_registration (stdRegisNo),
    INDEX idx_student_name (student_name),
    INDEX idx_father_cnic (father_cnic),
    INDEX idx_father_mobile (father_mobile_no),
    INDEX idx_gender (gender),
    INDEX idx_student_type (student_type),
    INDEX idx_batch_year (batchYear) -- Added index for batchYear
);
-- Academic records table
CREATE TABLE academicTb (
    academicId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    stdRegisNo VARCHAR(50) NOT NULL,
    previous_qualification VARCHAR(100) NOT NULL,
    previous_school_name VARCHAR(150) NOT NULL,
    TotalMarks INT NOT NULL,
    gainMarks INT NOT NULL,
    Board VARCHAR(100) NOT NULL,
    percentage DECIMAL(5,2) GENERATED ALWAYS AS (gainMarks * 100.0 / TotalMarks) STORED,
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE,
    INDEX idx_student_academic (stdRegisNo)
);

-- Student Fee Record table (corrected)
CREATE TABLE studentFeeRecord (
    feeId VARCHAR(100) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,
    Amount DOUBLE NOT NULL,
    paymentMonth VARCHAR(20) NOT NULL,
    paymentDate DATE DEFAULT (CURRENT_DATE),
    isPay BIT(1) DEFAULT 0,
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE,
    INDEX idx_student_fee (stdRegisNo)
);
-- Teachers table
CREATE TABLE teacherTb (
    teacherId VARCHAR(40) NOT NULL PRIMARY KEY,
    teacherName VARCHAR(50) NOT NULL,
    teacherQualification VARCHAR(50) NOT NULL,
    isSalaried BIT(1) DEFAULT 0,
    isPercentage BIT(1) DEFAULT 0,
    dateOfJoin DATE DEFAULT (CURRENT_DATE),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    is_active BOOLEAN DEFAULT TRUE,
    INDEX idx_teacher_name (teacherName)
);

-- Teacher Class junction table
CREATE TABLE teacherClassTb (
    teacherId VARCHAR(40) NOT NULL,
    classId INT NOT NULL,
    assigned_date DATE DEFAULT (CURRENT_DATE),
    PRIMARY KEY (teacherId, classId),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE CASCADE,
    INDEX idx_teacher_class (teacherId, classId)
);

-- Teacher Subject junction table
CREATE TABLE teacherSubjectTb (
    teacherId VARCHAR(40) NOT NULL,
    subjectId INT NOT NULL,
    assigned_date DATE DEFAULT (CURRENT_DATE),
    PRIMARY KEY (teacherId, subjectId),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,
    FOREIGN KEY (subjectId) REFERENCES subjectTb(subjectId) ON DELETE CASCADE,
    INDEX idx_teacher_subject (teacherId, subjectId)
);

-- Teacher Attendance table (MySQL syntax)
CREATE TABLE teacherAttendance (
    attendId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    teacherId VARCHAR(40) NOT NULL,
    isPresent BIT(1) DEFAULT 0,
    day VARCHAR(15),
    attendDate DATE DEFAULT (CURRENT_DATE),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,
    INDEX idx_teacher_attendance (teacherId, attendDate)
);

-- Student Attendance table (MySQL syntax)
CREATE TABLE studentAttendance (
    attendId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    stdRegisNo VARCHAR(50) NOT NULL,
    isPresent BIT(1) DEFAULT 0,
    day VARCHAR(15),
    attendDate DATE DEFAULT (CURRENT_DATE),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE,
    INDEX idx_student_attendance (stdRegisNo, attendDate)
);
CREATE TABLE feeTb (
    feeId VARCHAR(40) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,
    paymentMonth VARCHAR(15) NOT NULL,
    paymentDate DATE DEFAULT (CURRENT_DATE),
    amount DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    discount DECIMAL(10,2) DEFAULT 0.00,
    paidAmount DECIMAL(10,2) DEFAULT 0.00,
    receivedBy VARCHAR(100) NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE,
    INDEX idx_fee_student (stdRegisNo),
    INDEX idx_fee_date (paymentDate),
    INDEX idx_fee_month (paymentMonth)
);
CREATE TABLE teacherProfitTb (
    teachProfitId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    teacherId VARCHAR(40) NOT NULL,
    subjectId INT NOT NULL,
    teacherSubjectAmount DECIMAL(10,2) DEFAULT 0.00,
    collectionMonth VARCHAR(50) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,
    FOREIGN KEY (subjectId) REFERENCES subjectTb(subjectId) ON DELETE CASCADE,
    INDEX idx_teacher_profit (teacherId, collectionMonth),
    INDEX idx_subject_profit (subjectId, collectionMonth)
);
CREATE TABLE academySubjectProfitTb (
    academyProfitId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    subjectId INT NOT NULL,
    academySubjectProfit DECIMAL(10,2) DEFAULT 0.00,
    collectionMonth VARCHAR(50) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (subjectId) REFERENCES subjectTb(subjectId) ON DELETE CASCADE,
    INDEX idx_subject_month (subjectId, collectionMonth)
);
-- Expense table
CREATE TABLE expenseTb (
    expenseId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    expenseType VARCHAR(50) NOT NULL,  
    expenseAmount DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    expenseDate DATE DEFAULT (CURRENT_DATE),
    expenseMonth VARCHAR(15) NOT NULL,
    expenseDescription TEXT NULL,
    paidTo VARCHAR(100) NULL,
    paymentMethod ENUM('CASH', 'BANK', 'CHEQUE') DEFAULT 'CASH',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_expense_date (expenseDate),
    INDEX idx_expense_month (expenseMonth),
    INDEX idx_expense_type (expenseType)
);
-- Academy Report table (fixed spelling)-
CREATE TABLE academyReportTb (
    academyReportId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    reportMonth VARCHAR(15) NOT NULL UNIQUE, 
    totalRevenue DECIMAL(10,2) DEFAULT 0.00,  
    totalExpense DECIMAL(10,2) DEFAULT 0.00,
    teacherProfit DECIMAL(10,2) DEFAULT 0.00,
    academyProfit DECIMAL(10,2) DEFAULT 0.00,  -
    profitAmount DECIMAL(10,2) GENERATED ALWAYS AS (totalRevenue - totalExpense - teacherProfit) STORED,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    INDEX idx_report_month (reportMonth)
);