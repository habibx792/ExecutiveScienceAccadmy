CREATE DATABASE academyDb;
USE academyDb;

-- Project Schema

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

-- Subjects table
CREATE TABLE subjectTb (
    subjectId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    classId INT NOT NULL,
    domainId int not null,
    subjectName VARCHAR(100) NOT NULL,
    FOREIGN KEY (classId) REFERENCES classTb(classId) ON DELETE CASCADE,
    INDEX idx_class_subject (classId)
);

-- Students table
CREATE TABLE StudentTb (
    stdRegisNo VARCHAR(50) NOT NULL PRIMARY KEY,
    student_name VARCHAR(100) NOT NULL,
    domainId VARCHAR(50) NOT NULL,
    gender ENUM('MALE', 'FEMALE', 'OTHER') NOT NULL,
    date_of_birth DATE NOT NULL,
    cnic VARCHAR(15) UNIQUE,
    address TEXT NOT NULL,
    mark_of_identification VARCHAR(255),
    father_name VARCHAR(100) NOT NULL,
    father_cnic VARCHAR(15) NOT NULL,
    father_occupation VARCHAR(100),
    father_mobile_no VARCHAR(15) NOT NULL,
    classId INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    is_active BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (domainId) REFERENCES domainTb(domainId),
    FOREIGN KEY (classId) REFERENCES classTb(classId),
    INDEX idx_student_registration (stdRegisNo),
    INDEX idx_student_name (student_name),
    INDEX idx_father_cnic (father_cnic),
    INDEX idx_father_mobile (father_mobile_no),
    INDEX idx_gender (gender)
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

create table studentFeeRecord
(
    feeId varchar(100)not null primary key,
    stdRegisNo VARCHAR(50) NOT NULL,
    Amount double not null,
    paymentDate date current date autoumatically (today date )
    paymentMonth varchar(20) not null,
    isPay bit auto (0)
    
);