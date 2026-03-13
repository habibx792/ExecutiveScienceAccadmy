use accadmyDb;
CREATE DATABASE accadmyDb;
GO

USE accadmyDb;
GO

---==================================== General Tables =========================================
CREATE TABLE adminTb
(
    adminCnic VARCHAR(20) NOT NULL PRIMARY KEY,
    userName VARCHAR(20) NOT NULL,
    password VARCHAR(20) NOT NULL
);
create table stdCountTB
(
    stdCountId int not null primary key,
    stdCount int not null
);

CREATE TABLE domainTb (
    domainId VARCHAR(50) NOT NULL PRIMARY KEY,
    domainName VARCHAR(50) NOT NULL
);

CREATE TABLE classTb (
    classId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    domainId VARCHAR(50) NOT NULL,
    className VARCHAR(50) NOT NULL,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE CASCADE
);


CREATE TABLE subjectTb (
    subjectId INT  NOT NULL ,
    classId INT NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    FOREIGN KEY (subjectId) REFERENCES SubjectPack(subjectId)
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE CASCADE,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE NO ACTION
);
ALTER TABLE subjectTb
DROP COLUMN subjectsName;

---======================================= Student Tables ======================================
CREATE TABLE StudentTb (
    stdRegisNo VARCHAR(50) NOT NULL PRIMARY KEY,
    student_name VARCHAR(100) NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    classId INT NOT NULL,
    gender VARCHAR(10) NOT NULL,
    date_of_birth DATE NOT NULL,
    cnic VARCHAR(15) UNIQUE,
    father_name VARCHAR(100) NOT NULL,
    father_cnic VARCHAR(15) NOT NULL,
    father_occupation VARCHAR(100),
    father_mobile_no VARCHAR(15) NOT NULL,
    student_type VARCHAR(30) NOT NULL DEFAULT 'Regular',
    batchYear VARCHAR(7) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE NO ACTION,
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE NO ACTION
);

CREATE TABLE academicTb (
    academicId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,
    previous_qualification VARCHAR(100) NOT NULL,
    passingYear VARCHAR(5) NOT NULL,
    registrationNo VARCHAR(14) NOT NULL,
    previous_school_name VARCHAR(150) NOT NULL,
    TotalMarks INT NOT NULL,
    gainMarks INT NOT NULL,
    board VARCHAR(100) NOT NULL,
    percentage AS (gainMarks * 100.0 / TotalMarks) PERSISTED,
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE
);

CREATE TABLE stdAdress
(
    stdRegisNo VARCHAR(50) NOT NULL,
    stdAddressId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    address TEXT,
    city VARCHAR(20) DEFAULT 'Faisalabad',
    country VARCHAR(30) DEFAULT 'Pakistan'
);

---========================================= Teacher Tables =======================================
CREATE TABLE teacherTb (
    teacherId VARCHAR(40) NOT NULL PRIMARY KEY,
    teacherName VARCHAR(50) NOT NULL,
    teacherQualification VARCHAR(50) NOT NULL,
    isSalaried BIT DEFAULT 0,
    isPercentage BIT DEFAULT 0,
    dateOfJoin DATE DEFAULT GETDATE(),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1
);

CREATE TABLE teacherAddTb
(
    teacherAddId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    teacherId VARCHAR(40) NOT NULL,
    address TEXT,
    city VARCHAR(20) DEFAULT 'Faisalabad',
    country VARCHAR(30) DEFAULT 'Pakistan',
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE
);

CREATE TABLE teacherClassTb (
    teacherId VARCHAR(40) NOT NULL,
    classId INT NOT NULL,
    assigned_date DATE DEFAULT GETDATE(),
    PRIMARY KEY (teacherId, classId),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE NO ACTION
);

CREATE TABLE teacherSubjectTb (
    teacherId VARCHAR(40) NOT NULL,
    subjectId INT NOT NULL,
    assigned_date DATE DEFAULT GETDATE(),
    PRIMARY KEY (teacherId, subjectId),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,
    FOREIGN KEY (subjectId) REFERENCES subjectTb(subjectId) ON DELETE NO ACTION
);

---============================ Student & Teacher Attendance ===================================
CREATE TABLE teacherAttendance (
    attendId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    teacherId VARCHAR(40) NOT NULL,
    isPresent BIT DEFAULT 0,
    day VARCHAR(15),
    attendDate DATE DEFAULT GETDATE(),
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE
);

CREATE TABLE studentAttendance (
    attendId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,
    isPresent BIT DEFAULT 0,
    attenceType VARCHAR(15) NOT NULL,
    day VARCHAR(15),
    attendDate DATE DEFAULT GETDATE(),
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE
);
-- 1. Create a new table with the desired schema
CREATE TABLE studentAttendanceNew (
    attendId VARCHAR(20) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,
    isPresent BIT DEFAULT 0,
    attenceType VARCHAR(15) NOT NULL,
    day VARCHAR(15),
    attendDate DATE DEFAULT GETDATE(),
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE
);

-- 2. Copy all data from the old table
INSERT INTO studentAttendanceNew (attendId, stdRegisNo, isPresent, attenceType, day, attendDate, created_at)
SELECT CAST(attendId AS VARCHAR(20)), stdRegisNo, isPresent, attenceType, day, attendDate, created_at
FROM studentAttendance;

-- 3. Drop the old table
DROP TABLE studentAttendance;

-- 4. Rename the new table to the original name
EXEC sp_rename 'studentAttendanceNew', 'studentAttendance';
---========================================= Fee & Profit Tables ================================
CREATE TABLE feeTb (
    feeId VARCHAR(40) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,
    paymentMonth VARCHAR(15) NOT NULL,
    paymentDate DATE DEFAULT GETDATE(),
    amount DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    discount DECIMAL(10,2) DEFAULT 0.00,
    paidAmount DECIMAL(10,2) DEFAULT 0.00,
    receivedBy VARCHAR(100) NULL,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE
);
ALTER TABLE feeTb
ADD isPaid BIT NOT NULL DEFAULT 0;


CREATE TABLE teacherProfitTb (
    teachProfitId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    teacherId VARCHAR(40) NOT NULL,
    subjectId INT NOT NULL,
    teacherSubjectAmount DECIMAL(10,2) DEFAULT 0.00,
    collectionMonth VARCHAR(50) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,
    FOREIGN KEY (subjectId) REFERENCES subjectTb(subjectId) ON DELETE NO ACTION
);

---========================================= Admin Tables ========================================
CREATE TABLE StdResult
(
    stdRegisNo VARCHAR(50) NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    classId INT NOT NULL,
    resultDate DATE NOT NULL DEFAULT GETDATE(),
    gainedMakr INT NOT NULL,
    totalMark INT DEFAULT 100,
    CONSTRAINT PK_StdResult PRIMARY KEY (stdRegisNo, classId, resultDate),
    CONSTRAINT FK_StdResult_Student FOREIGN KEY (stdRegisNo) REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE,
    CONSTRAINT FK_StdResult_Domain FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE NO ACTION,
    CONSTRAINT FK_StdResult_Class FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE NO ACTION
);
CREATE TABLE subjectWiseResultTb
(
    stdRegisNo VARCHAR(50) NOT NULL,
    subjectId INT NOT NULL,
    classId INT NOT NULL,
    resultDate DATE NOT NULL,
    gainedMark INT NOT NULL,
    totalMark INT DEFAULT 100,

    CONSTRAINT PK_subjectWiseResult 
        PRIMARY KEY (stdRegisNo, subjectId, resultDate),

    CONSTRAINT FK_subjectWiseResult_student 
        FOREIGN KEY (stdRegisNo) 
        REFERENCES StudentTb(stdRegisNo) ON DELETE CASCADE,

    CONSTRAINT FK_subjectWiseResult_subject 
        FOREIGN KEY (subjectId) 
        REFERENCES subjectTb(subjectId) ON DELETE CASCADE,

    CONSTRAINT FK_subjectWiseResult_class 
        FOREIGN KEY (classId) 
        REFERENCES classTb(classId) ON DELETE NO ACTION
);
CREATE TABLE setMark
(
    setMarkId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    domainId VARCHAR(50) NOT NULL,
    classId INT NOT NULL,
    totalMark INT DEFAULT 100
);

CREATE TABLE setStdFeeTb (
    setFeeId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    amount FLOAT NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    classId INT NOT NULL,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE CASCADE,
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE NO ACTION
);

CREATE TABLE teacherSalaySetTb
(
    teacherSalarySetId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    teacherId VARCHAR(40) NOT NULL,
    salary DECIMAL(10,2) NOT NULL,
    salaryDate DATE NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE
);

CREATE TABLE setTeacherPercentageTB
(
    teacherSalarySetId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    teacherId VARCHAR(40) NOT NULL,
    percentag DECIMAL(10,2) NOT NULL,
    percenDate DATE NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE
);

CREATE TABLE academySubjectProfitTb (
    academyProfitId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    subjectId INT NOT NULL,
    academySubjectProfit DECIMAL(10,2) DEFAULT 0.00,
    collectionMonth VARCHAR(50) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (subjectId) REFERENCES subjectTb(subjectId) ON DELETE NO ACTION
);

CREATE TABLE expenseTb (
    expenseId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    expenseType VARCHAR(50) NOT NULL,
    expenseAmount DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    expenseDate DATE DEFAULT GETDATE(),
    expenseMonth VARCHAR(15) NOT NULL,
    expenseDescription TEXT NULL,
    paidTo VARCHAR(100) NULL,
    paymentMethod VARCHAR(20) DEFAULT 'CASH',
    created_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE academyReportTb (
    academyReportId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    reportMonth VARCHAR(15) NOT NULL UNIQUE,
    totalRevenue DECIMAL(10,2) DEFAULT 0.00,
    totalExpense DECIMAL(10,2) DEFAULT 0.00,
    teacherProfit DECIMAL(10,2) DEFAULT 0.00,
    academyProfit DECIMAL(10,2) DEFAULT 0.00,
    profitAmount AS (totalRevenue - totalExpense - teacherProfit) PERSISTED,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE()
);
