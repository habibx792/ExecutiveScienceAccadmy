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
DROP TABLE IF EXISTS stdCountTB;
CREATE TABLE stdCountTB
(
    stdCountId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    stdCount INT NOT NULL DEFAULT 0
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

drop table subjectTb;
CREATE TABLE subjectTb (
    subjectId INT  NOT NULL ,
    classId INT NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    FOREIGN KEY (subjectId) REFERENCES SubjectPack(subjectId)
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE CASCADE,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE NO ACTION
);

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
drop table stdAdress;
CREATE TABLE stdAdress
(
    stdAddressId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,

    address TEXT,
    city VARCHAR(20) DEFAULT 'Faisalabad',
    country VARCHAR(30) DEFAULT 'Pakistan',

    CONSTRAINT FK_stdAdress_student
        FOREIGN KEY (stdRegisNo)
        REFERENCES StudentTb(stdRegisNo)
        ON DELETE CASCADE
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
ALTER TABLE teacherTb
ADD 
    fatherName VARCHAR(100) NULL,
    fatherCnic VARCHAR(20) NULL,
    teacherCnic VARCHAR(20) NULL;


CREATE TABLE teacherAddTb
(
    teacherAddId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    teacherId VARCHAR(40) NOT NULL,
    address TEXT,
    city VARCHAR(20) DEFAULT 'Faisalabad',
    country VARCHAR(30) DEFAULT 'Pakistan',
    FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE
);
DROP TABLE IF EXISTS teacherPaymentTb;
CREATE TABLE teacherPaymentTb
(
    teacherPaymentId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    teacherId VARCHAR(40) NOT NULL,
    teacherType VARCHAR(20) NOT NULL, -- 'Salary' or 'Percentage'
    salary DECIMAL(10,2) NULL,
    percentage DECIMAL(10,2) NULL,
    paymentDate DATE NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_teacherPayment_teacher
        FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE
);

DROP TABLE IF EXISTS teacherClassSubjectTb;

CREATE TABLE teacherClassSubjectTb (
    teacherId VARCHAR(40) NOT NULL,
    classId INT NOT NULL,
    subjectId INT NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    assigned_date DATE DEFAULT GETDATE(),

    PRIMARY KEY (teacherId, classId, subjectId),

    CONSTRAINT FK_teacherClassSubject_teacher
        FOREIGN KEY (teacherId) REFERENCES teacherTb(teacherId) ON DELETE CASCADE,

    CONSTRAINT FK_teacherClassSubject_class
        FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE NO ACTION,

    CONSTRAINT FK_teacherClassSubject_subject
        FOREIGN KEY (subjectId, classId) REFERENCES subjectTb(subjectId, classId) ON DELETE NO ACTION,

    CONSTRAINT FK_teacherClassSubject_domain
        FOREIGN KEY (domainId) REFERENCES domainTb(domainId) ON DELETE NO ACTION
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

CREATE TABLE studentAttendance
(
    attendId VARCHAR(40) NOT NULL PRIMARY KEY,
    stdRegisNo VARCHAR(50) NOT NULL,
    isPresent BIT DEFAULT 0,
    attenceType VARCHAR(15) NOT NULL,

    -- for UI display only
    day VARCHAR(20),

    -- real date used for logic
    attendDate DATE NOT NULL DEFAULT GETDATE(),

    created_at DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_studentAttendance_student
        FOREIGN KEY (stdRegisNo)
        REFERENCES StudentTb(stdRegisNo)
        ON DELETE CASCADE,

    -- prevents duplicate attendance on the same day
    CONSTRAINT UQ_studentAttendance_unique
        UNIQUE(stdRegisNo, attenceType, attendDate)
);
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




CREATE TABLE academySubjectProfitTb (
    academyProfitId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    subjectId INT NOT NULL,
    academySubjectProfit DECIMAL(10,2) DEFAULT 0.00,
    collectionMonth VARCHAR(50) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (subjectId) REFERENCES subjectTb(subjectId) ON DELETE NO ACTION
);
CREATE TABLE expenseTb (
    expenseId VARCHAR(30) NOT NULL PRIMARY KEY,
    expenseType VARCHAR(50) NOT NULL,
    expenseAmount DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    expenseDate DATE DEFAULT GETDATE(),
    expenseMonth VARCHAR(15) NOT NULL,
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

CREATE TABLE SubjectPack
(
    subjectId INT IDENTITY(1,1) PRIMARY KEY,
    subjectName VARCHAR(100) NOT NULL
);


INSERT INTO SubjectPack(subjectName) VALUES
('Urdu'),
('English'),
('Biology'),
('Chemistry'),
('Physics'),
('Mathematics'),
('Computer Science'),
('Islamiat'),
('Pakistan Studies');



USE accadmyDb;
GO

/* ============================
   1. DROP FOREIGN KEYS THAT
   REFERENCE subjectTb
============================ */

DECLARE @sql NVARCHAR(MAX) = '';

SELECT @sql += 
'ALTER TABLE ' + OBJECT_NAME(parent_object_id) +
' DROP CONSTRAINT ' + name + ';' + CHAR(10)
FROM sys.foreign_keys
WHERE referenced_object_id = OBJECT_ID('subjectTb');

EXEC sp_executesql @sql;


/* ============================
   2. DROP AND RECREATE TABLE
============================ */

IF OBJECT_ID('subjectTb','U') IS NOT NULL
DROP TABLE subjectTb;

CREATE TABLE subjectTb (
    subjectId INT NOT NULL,
    classId INT NOT NULL,
    domainId VARCHAR(50) NOT NULL,

    CONSTRAINT PK_subjectTb
        PRIMARY KEY (subjectId, classId),

    CONSTRAINT FK_subjectTb_subjectPack
        FOREIGN KEY (subjectId)
        REFERENCES SubjectPack(subjectId),

    CONSTRAINT FK_subjectTb_class
        FOREIGN KEY (classId)
        REFERENCES classTb(classId)
        ON DELETE CASCADE,

    CONSTRAINT FK_subjectTb_domain
        FOREIGN KEY (domainId)
        REFERENCES domainTb(domainId)
);


/* ============================
   3. RESTORE FOREIGN KEYS
============================ */

ALTER TABLE teacherSubjectTb
ADD CONSTRAINT FK_teacherSubjectTb_subject
FOREIGN KEY (subjectId)
REFERENCES subjectTb(subjectId);

ALTER TABLE teacherProfitTb
ADD CONSTRAINT FK_teacherProfit_subject
FOREIGN KEY (subjectId)
REFERENCES subjectTb(subjectId);

ALTER TABLE subjectWiseResultTb
ADD CONSTRAINT FK_subjectWiseResult_subject
FOREIGN KEY (subjectId)
REFERENCES subjectTb(subjectId);

ALTER TABLE academySubjectProfitTb
ADD CONSTRAINT FK_academyProfit_subject
FOREIGN KEY (subjectId)
REFERENCES subjectTb(subjectId);

GO

DROP TABLE IF EXISTS subjectTb;

CREATE TABLE subjectTb (
    subjectId INT NOT NULL,
    classId INT NOT NULL,
    domainId VARCHAR(50) NOT NULL,

    CONSTRAINT PK_subjectTb PRIMARY KEY (subjectId, classId),

    CONSTRAINT FK_subjectTb_subjectPack
        FOREIGN KEY (subjectId)
        REFERENCES SubjectPack(subjectId),

    CONSTRAINT FK_subjectTb_class
        FOREIGN KEY (classId)
        REFERENCES classTb(classId)
        ON DELETE CASCADE,

    CONSTRAINT FK_subjectTb_domain
        FOREIGN KEY (domainId)
        REFERENCES domainTb(domainId)
);