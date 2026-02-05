# School Management System Database Design

## Overview
This document outlines the database structure for a School Management System that handles student admissions, class management, subjects, and domains. The design is normalized and scalable for future expansions like fee management, attendance, results, etc.

---

## Entity Relationship Diagram (ERD) Overview

```
┌─────────────────────┐
│ STUDENT_PREVIOUS    │
│    _RESULTS         │
└─────────┬───────────┘
          │
┌─────────┴───┐       ┌─────────────┐       ┌─────────────┐
│   STUDENTS  │───────│ ENROLLMENTS │───────│   CLASSES   │
│  (+ gender) │       │(reg_number) │       └─────────────┘
└─────────────┘       └─────────────┘              │
                            │                      │
                            │                      │
                      ┌─────┴─────┐          ┌─────┴─────┐
                      │           │          │           │
                ┌─────────────┐  ┌─────────────┐   ┌─────────────┐
                │   DOMAINS   │  │  SUBJECTS   │   │CLASS_DOMAINS│
                └─────────────┘  └─────────────┘   └─────────────┘
                      │                │                  │
                      └────────────────┴──────────────────┘
                                       │
                               ┌───────────────┐
                               │DOMAIN_SUBJECTS│
                               └───────────────┘
```

---

## Tables Structure

### 1. Students Table
Stores all student personal and guardian information.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| student_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique student identifier |
| student_name | VARCHAR(100) | NOT NULL | Full name of student |
| gender | ENUM('MALE', 'FEMALE', 'OTHER') | NOT NULL | Student's gender |
| date_of_birth | DATE | NOT NULL | Student's date of birth |
| cnic | VARCHAR(15) | UNIQUE | Student's CNIC (if available) |
| address | TEXT | NOT NULL | Residential address |
| mark_of_identification | VARCHAR(255) | | Physical identification mark |
| previous_qualification | VARCHAR(100) | NOT NULL | Previous school/qualification |
| previous_school_name | VARCHAR(150) | | Name of previous institution |
| father_name | VARCHAR(100) | NOT NULL | Father's full name |
| father_cnic | VARCHAR(15) | NOT NULL | Father's CNIC |
| father_occupation | VARCHAR(100) | | Father's profession |
| father_mobile_no | VARCHAR(15) | NOT NULL | Father's contact number |
| created_at | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Record creation time |
| updated_at | TIMESTAMP | ON UPDATE CURRENT_TIMESTAMP | Record update time |
| is_active | BOOLEAN | DEFAULT TRUE | Student status |

---

### 2. Classes Table
Stores class/grade information (9th, 10th, 11th, 12th).

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| class_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique class identifier |
| class_name | VARCHAR(20) | NOT NULL, UNIQUE | Class name (e.g., "9th", "10th") |
| class_level | INT | NOT NULL | Numeric level (9, 10, 11, 12) |
| description | VARCHAR(255) | | Class description |

---

### 3. Domains Table
Stores domain/stream information for all classes.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| domain_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique domain identifier |
| domain_name | VARCHAR(50) | NOT NULL, UNIQUE | Domain name |
| domain_code | VARCHAR(10) | UNIQUE | Short code |
| level | ENUM('MATRIC', 'INTER') | NOT NULL | Education level |
| description | VARCHAR(255) | | Domain description |

**Available Domains:**

| Level | Domain | Code |
|-------|--------|------|
| MATRIC | Computer Science | COMP |
| MATRIC | Biology | BIO |
| MATRIC | Arts | ARTS |
| INTER | FSC Pre-Medical | FSC-MED |
| INTER | FSC Pre-Engineering | FSC-ENG |
| INTER | ICS | ICS |
| INTER | FA | FA |
| INTER | FA-IT | FA-IT |

---

### 4. Subjects Table
Master table for all subjects (reusable for fees, results, etc.).

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| subject_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique subject identifier |
| subject_name | VARCHAR(100) | NOT NULL | Full subject name |
| subject_code | VARCHAR(20) | UNIQUE | Subject short code |
| subject_type | ENUM('COMPULSORY', 'ELECTIVE', 'OPTIONAL') | DEFAULT 'COMPULSORY' | Type of subject |
| max_marks | INT | DEFAULT 100 | Maximum marks for subject |
| passing_marks | INT | DEFAULT 33 | Passing marks |
| description | VARCHAR(255) | | Subject description |

---

### 5. Class_Domains Table (Junction)
Links classes to available domains.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| class_domain_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique identifier |
| class_id | INT | FOREIGN KEY → Classes | Reference to class |
| domain_id | INT | FOREIGN KEY → Domains | Reference to domain |
| is_active | BOOLEAN | DEFAULT TRUE | Availability status |

**Unique Constraint:** (class_id, domain_id)

---

### 6. Domain_Subjects Table (Junction)
Links domains to subjects for specific classes.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| domain_subject_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique identifier |
| class_id | INT | FOREIGN KEY → Classes | Reference to class |
| domain_id | INT | FOREIGN KEY → Domains | Reference to domain |
| subject_id | INT | FOREIGN KEY → Subjects | Reference to subject |
| is_common | BOOLEAN | DEFAULT FALSE | Is it a common subject? |
| is_active | BOOLEAN | DEFAULT TRUE | Subject availability |

**Unique Constraint:** (class_id, domain_id, subject_id)

---

### 7. Enrollments Table
Stores student enrollment/admission information.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| enrollment_id | INT | PRIMARY KEY, AUTO_INCREMENT | Internal identifier (for joins) |
| student_id | INT | FOREIGN KEY → Students | Reference to student |
| class_id | INT | FOREIGN KEY → Classes | Admission class |
| domain_id | INT | FOREIGN KEY → Domains | Selected domain |
| enrollment_type | ENUM('REGULAR', 'RTS', 'SUPPLEMENTARY') | NOT NULL, DEFAULT 'REGULAR' | Type of enrollment |
| registration_number | VARCHAR(30) | NOT NULL, UNIQUE | **PRIMARY IDENTIFIER** - Auto-generated |
| academic_year | VARCHAR(9) | NOT NULL | Academic year (e.g., "2025-2026") |
| admission_date | DATE | NOT NULL | Date of admission |
| section | VARCHAR(10) | | Class section (A, B, C) |
| status | ENUM('ACTIVE', 'PASSED', 'FAILED', 'DROPPED', 'TRANSFERRED') | DEFAULT 'ACTIVE' | Enrollment status |
| created_at | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Record creation time |

> ⚠️ **IMPORTANT:** `registration_number` is the **PRIMARY IDENTIFIER** used to search and reference students throughout the system. All searches, fee records, results, and attendance should use this field.

**Unique Constraint:** (student_id, class_id, academic_year, enrollment_type)

> **Enrollment Types:**
> 
> | Type | Description | Subjects | Fee Structure |
> |------|-------------|----------|---------------|
> | REGULAR | Full-time students | All domain subjects | Full fee |
> | RTS | Revision Test Series | All domain subjects (tests only) | RTS fee (different) |
> | SUPPLEMENTARY | Re-appear students | Selected subjects only | Per-subject fee |

> **Registration Number Format:** `YY-CLASS(G)-DOMAIN-TYPE-SEQ`
> 
> | Part | Description | Example |
> |------|-------------|----------|
> | YY | Last 2 digits of year | 25 (for 2025) |
> | CLASS | Class level | 9, 10, 11, 12 |
> | (G) | Gender: (B)=Boy, (G)=Girl | (B) |
> | DOMAIN | Domain code | COMP, BIO, FSC-MED |
> | TYPE | R=Regular, T=RTS, S=Supplementary | R, T, S |
> | SEQ | Auto-increment sequence (3 digits) | 001, 002, 003 |
> 
> **Examples:**
> - `25-9(B)-COMP-R-001` → 2025, 9th class, Boy, Computer, Regular, 1st student
> - `25-10(G)-BIO-T-005` → 2025, 10th class, Girl, Biology, RTS, 5th student
> - `25-11(B)-FSC-MED-S-003` → 2025, 11th class, Boy, FSC Medical, Supplementary, 3rd student

---

### 8. Enrollment_Subjects Table (For Supplementary Students)
Stores which subjects a supplementary student has enrolled in.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| enrollment_subject_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique identifier |
| enrollment_id | INT | FOREIGN KEY → Enrollments | Reference to enrollment |
| subject_id | INT | FOREIGN KEY → Subjects | Selected subject |
| is_active | BOOLEAN | DEFAULT TRUE | Subject enrollment status |
| created_at | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Record creation time |

**Unique Constraint:** (enrollment_id, subject_id)

> **Note:** This table is used ONLY for SUPPLEMENTARY enrollment type. Regular and RTS students automatically get all domain subjects.

---

### 9. Student_Previous_Results Table
Stores ALL previous class results for complete academic history tracking.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| result_id | INT | PRIMARY KEY, AUTO_INCREMENT | Unique result identifier |
| student_id | INT | FOREIGN KEY → Students | Reference to student |
| class_name | VARCHAR(50) | NOT NULL | Class name (8th, 9th, 10th, 11th) |
| marks_obtained | INT | NOT NULL | Marks obtained |
| total_marks | INT | NOT NULL | Total marks |
| percentage | DECIMAL(5,2) | | Calculated percentage |
| grade | VARCHAR(10) | | Grade (A+, A, B, C, D, E, F) |
| board_name | VARCHAR(100) | | Board/Institution name |
| passing_year | VARCHAR(4) | | Year of passing |
| roll_number | VARCHAR(30) | | Board roll number |
| created_at | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Record creation time |

**Unique Constraint:** (student_id, class_name)

> **Previous Results Logic:**
> - Student in 9th → Must have 8th class result
> - Student in 10th → Must have 8th, 9th class results
> - Student in 11th → Must have 8th, 9th, 10th class results
> - Student in 12th → Must have 8th, 9th, 10th, 11th class results

---

## Subject Distribution

### Class 9th Subjects

#### Common Subjects (All Domains)
| Subject | Code |
|---------|------|
| English | ENG |
| Urdu | URD |
| Tarjuma-tul-Quran | TQ |
| Islamiat | IS |

#### Bio Domain Subjects
| Subject | Code |
|---------|------|
| Biology | BIO |
| Chemistry | CHEM |
| Physics | PHY |
| Mathematics | MATH |

#### Computer Domain Subjects
| Subject | Code |
|---------|------|
| Computer Science | COMP |
| Chemistry | CHEM |
| Physics | PHY |
| Mathematics | MATH |

#### Arts Domain Subjects
| Subject | Code |
|---------|------|
| Selective Islamiat | SIS |
| Punjabi | PUN |
| E-Commerce | ECOM |
| Mathematics | MATH |

---

### Class 10th Subjects

#### Common Subjects (All Domains)
| Subject | Code |
|---------|------|
| English | ENG |
| Urdu | URD |
| Tarjuma-tul-Quran | TQ |
| Pakistan Studies | PS |

> **Note:** IS (Islamiat) is replaced with PS (Pakistan Studies) in 10th class.

#### Domain subjects remain the same as 9th class.

---

### Class 11th Subjects (Intermediate Part-I)

#### Common Subjects (All Domains)
| Subject | Code |
|---------|------|
| English | ENG |
| Urdu | URD |
| Tarjuma-tul-Quran | TQ |
| Islamiat | IS |

#### FSC Pre-Medical Domain Subjects
| Subject | Code |
|---------|------|
| Biology | BIO |
| Physics | PHY |
| Chemistry | CHEM |

#### FSC Pre-Engineering (Non-Medical) Domain Subjects
| Subject | Code |
|---------|------|
| Physics | PHY |
| Chemistry | CHEM |
| Mathematics | MATH |

#### ICS Domain Subjects
| Subject | Code |
|---------|------|
| Physics | PHY |
| Mathematics | MATH |
| Computer Science | COMP |

#### FA Domain Subjects
| Subject | Code |
|---------|------|
| Education | EDU |
| Physical Education | PE |
| Elective Islamiat | EIS |

#### FA-IT Domain Subjects
| Subject | Code |
|---------|------|
| Education | EDU |
| Physical Education | PE |
| Computer Science | COMP |

---

### Class 12th Subjects (Intermediate Part-II)

#### Common Subjects (All Domains)
| Subject | Code |
|---------|------|
| English | ENG |
| Urdu | URD |
| Tarjuma-tul-Quran | TQ |
| Pakistan Studies | PS |

> **Note:** IS (Islamiat) is replaced with PS (Pakistan Studies) in 12th class.

#### Domain subjects remain the same as 11th class.

---

## SQL Commands to Create Database

```sql
-- =============================================
-- DATABASE CREATION
-- =============================================
CREATE DATABASE IF NOT EXISTS school_management_system;
USE school_management_system;

-- =============================================
-- TABLE: students
-- =============================================
CREATE TABLE students (
    student_id INT PRIMARY KEY AUTO_INCREMENT,
    student_name VARCHAR(100) NOT NULL,
    gender ENUM('MALE', 'FEMALE', 'OTHER') NOT NULL,
    date_of_birth DATE NOT NULL,
    cnic VARCHAR(15) UNIQUE,
    address TEXT NOT NULL,
    mark_of_identification VARCHAR(255),
    previous_qualification VARCHAR(100) NOT NULL,
    previous_school_name VARCHAR(150),
    father_name VARCHAR(100) NOT NULL,
    father_cnic VARCHAR(15) NOT NULL,
    father_occupation VARCHAR(100),
    father_mobile_no VARCHAR(15) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    is_active BOOLEAN DEFAULT TRUE,
    
    INDEX idx_student_name (student_name),
    INDEX idx_father_cnic (father_cnic),
    INDEX idx_father_mobile (father_mobile_no),
    INDEX idx_gender (gender)
);

-- =============================================
-- TABLE: classes
-- =============================================
CREATE TABLE classes (
    class_id INT PRIMARY KEY AUTO_INCREMENT,
    class_name VARCHAR(20) NOT NULL UNIQUE,
    class_level INT NOT NULL,
    description VARCHAR(255)
);

-- =============================================
-- TABLE: domains
-- =============================================
CREATE TABLE domains (
    domain_id INT PRIMARY KEY AUTO_INCREMENT,
    domain_name VARCHAR(50) NOT NULL UNIQUE,
    domain_code VARCHAR(10) UNIQUE,
    level ENUM('MATRIC', 'INTER') NOT NULL,
    description VARCHAR(255),
    
    INDEX idx_level (level)
);

-- =============================================
-- TABLE: subjects
-- =============================================
CREATE TABLE subjects (
    subject_id INT PRIMARY KEY AUTO_INCREMENT,
    subject_name VARCHAR(100) NOT NULL,
    subject_code VARCHAR(20) UNIQUE,
    subject_type ENUM('COMPULSORY', 'ELECTIVE', 'OPTIONAL') DEFAULT 'COMPULSORY',
    max_marks INT DEFAULT 100,
    passing_marks INT DEFAULT 33,
    description VARCHAR(255),
    
    INDEX idx_subject_code (subject_code)
);

-- =============================================
-- TABLE: class_domains (Junction Table)
-- =============================================
CREATE TABLE class_domains (
    class_domain_id INT PRIMARY KEY AUTO_INCREMENT,
    class_id INT NOT NULL,
    domain_id INT NOT NULL,
    is_active BOOLEAN DEFAULT TRUE,
    
    FOREIGN KEY (class_id) REFERENCES classes(class_id) ON DELETE CASCADE,
    FOREIGN KEY (domain_id) REFERENCES domains(domain_id) ON DELETE CASCADE,
    UNIQUE KEY unique_class_domain (class_id, domain_id)
);

-- =============================================
-- TABLE: domain_subjects (Junction Table)
-- =============================================
CREATE TABLE domain_subjects (
    domain_subject_id INT PRIMARY KEY AUTO_INCREMENT,
    class_id INT NOT NULL,
    domain_id INT NOT NULL,
    subject_id INT NOT NULL,
    is_common BOOLEAN DEFAULT FALSE,
    is_active BOOLEAN DEFAULT TRUE,
    
    FOREIGN KEY (class_id) REFERENCES classes(class_id) ON DELETE CASCADE,
    FOREIGN KEY (domain_id) REFERENCES domains(domain_id) ON DELETE CASCADE,
    FOREIGN KEY (subject_id) REFERENCES subjects(subject_id) ON DELETE CASCADE,
    UNIQUE KEY unique_class_domain_subject (class_id, domain_id, subject_id)
);

-- =============================================
-- TABLE: enrollments
-- registration_number is the PRIMARY IDENTIFIER for all student operations
-- =============================================
CREATE TABLE enrollments (
    enrollment_id INT PRIMARY KEY AUTO_INCREMENT,
    student_id INT NOT NULL,
    class_id INT NOT NULL,
    domain_id INT NOT NULL,
    enrollment_type ENUM('REGULAR', 'RTS', 'SUPPLEMENTARY') NOT NULL DEFAULT 'REGULAR',
    registration_number VARCHAR(30) NOT NULL UNIQUE,  -- PRIMARY IDENTIFIER: "25-9(B)-COMP-R-001"
    academic_year VARCHAR(9) NOT NULL,
    admission_date DATE NOT NULL,
    section VARCHAR(10),
    status ENUM('ACTIVE', 'PASSED', 'FAILED', 'DROPPED', 'TRANSFERRED') DEFAULT 'ACTIVE',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (class_id) REFERENCES classes(class_id) ON DELETE CASCADE,
    FOREIGN KEY (domain_id) REFERENCES domains(domain_id) ON DELETE CASCADE,
    UNIQUE KEY unique_enrollment (student_id, class_id, academic_year, enrollment_type),
    INDEX idx_academic_year (academic_year),
    INDEX idx_status (status),
    INDEX idx_enrollment_type (enrollment_type)
);

-- PRIMARY INDEX for registration_number (for fast lookups)
CREATE UNIQUE INDEX idx_primary_reg_number ON enrollments(registration_number);

-- =============================================
-- VIEW: student_directory
-- Main view for searching students by registration number
-- =============================================
CREATE VIEW student_directory AS
SELECT 
    e.registration_number,
    e.enrollment_type,
    st.student_id,
    st.student_name,
    st.gender,
    st.date_of_birth,
    st.cnic,
    st.address,
    st.father_name,
    st.father_cnic,
    st.father_mobile_no,
    c.class_name,
    c.class_level,
    d.domain_name,
    d.domain_code,
    e.academic_year,
    e.section,
    e.status,
    e.admission_date
FROM enrollments e
JOIN students st ON e.student_id = st.student_id
JOIN classes c ON e.class_id = c.class_id
JOIN domains d ON e.domain_id = d.domain_id;

-- =============================================
-- TABLE: enrollment_subjects (For Supplementary Students)
-- =============================================
CREATE TABLE enrollment_subjects (
    enrollment_subject_id INT PRIMARY KEY AUTO_INCREMENT,
    enrollment_id INT NOT NULL,
    subject_id INT NOT NULL,
    is_active BOOLEAN DEFAULT TRUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    FOREIGN KEY (enrollment_id) REFERENCES enrollments(enrollment_id) ON DELETE CASCADE,
    FOREIGN KEY (subject_id) REFERENCES subjects(subject_id) ON DELETE CASCADE,
    UNIQUE KEY unique_enrollment_subject (enrollment_id, subject_id),
    INDEX idx_enrollment_id (enrollment_id)
);

-- =============================================
-- FUNCTION: Generate Registration Number
-- Format: YY-CLASS(G)-DOMAIN-TYPE-SEQ
-- Example: 25-9(B)-COMP-R-001
-- =============================================
DELIMITER //
CREATE FUNCTION generate_registration_number(
    p_student_id INT,
    p_class_id INT,
    p_domain_id INT,
    p_enrollment_type VARCHAR(15),
    p_year VARCHAR(4)
) RETURNS VARCHAR(30)
DETERMINISTIC
BEGIN
    DECLARE v_year_short VARCHAR(2);
    DECLARE v_class_level INT;
    DECLARE v_gender_code CHAR(1);
    DECLARE v_domain_code VARCHAR(10);
    DECLARE v_type_code CHAR(1);
    DECLARE v_sequence INT;
    DECLARE v_reg_number VARCHAR(30);
    DECLARE v_pattern VARCHAR(30);
    
    -- Get last 2 digits of year
    SET v_year_short = RIGHT(p_year, 2);
    
    -- Get class level
    SELECT class_level INTO v_class_level 
    FROM classes WHERE class_id = p_class_id;
    
    -- Get gender code (B for MALE, G for FEMALE/OTHER)
    SELECT CASE gender 
        WHEN 'MALE' THEN 'B' 
        ELSE 'G' 
    END INTO v_gender_code
    FROM students WHERE student_id = p_student_id;
    
    -- Get domain code
    SELECT domain_code INTO v_domain_code 
    FROM domains WHERE domain_id = p_domain_id;
    
    -- Get enrollment type code (R=Regular, T=RTS, S=Supplementary)
    SET v_type_code = CASE p_enrollment_type
        WHEN 'REGULAR' THEN 'R'
        WHEN 'RTS' THEN 'T'
        WHEN 'SUPPLEMENTARY' THEN 'S'
        ELSE 'R'
    END;
    
    -- Build pattern for finding existing registrations
    -- Pattern: YY-CLASS(G)-DOMAIN-TYPE-%
    SET v_pattern = CONCAT(v_year_short, '-', v_class_level, '(', v_gender_code, ')-', v_domain_code, '-', v_type_code, '-%');
    
    -- Get the next sequence number
    SELECT COALESCE(MAX(
        CAST(SUBSTRING_INDEX(registration_number, '-', -1) AS UNSIGNED)
    ), 0) + 1 INTO v_sequence
    FROM enrollments
    WHERE registration_number LIKE v_pattern;
    
    -- Build registration number: YY-CLASS(G)-DOMAIN-TYPE-SEQ
    SET v_reg_number = CONCAT(
        v_year_short, '-',
        v_class_level, '(',
        v_gender_code, ')-',
        v_domain_code, '-',
        v_type_code, '-',
        LPAD(v_sequence, 3, '0')
    );
    
    RETURN v_reg_number;
END//
DELIMITER ;

-- =============================================
-- TRIGGER: Auto-generate registration number before insert
-- =============================================
DELIMITER //
CREATE TRIGGER before_enrollment_insert
BEFORE INSERT ON enrollments
FOR EACH ROW
BEGIN
    DECLARE v_year VARCHAR(4);
    
    -- Extract year from academic_year (e.g., "2025-2026" -> "2025")
    SET v_year = SUBSTRING(NEW.academic_year, 1, 4);
    
    -- Generate registration number if not provided
    IF NEW.registration_number IS NULL OR NEW.registration_number = '' THEN
        SET NEW.registration_number = generate_registration_number(
            NEW.student_id,
            NEW.class_id,
            NEW.domain_id,
            NEW.enrollment_type,
            v_year
        );
    END IF;
END//
DELIMITER ;

-- =============================================
-- TABLE: student_previous_results
-- Stores ALL previous class results for complete academic history
-- =============================================
CREATE TABLE student_previous_results (
    result_id INT PRIMARY KEY AUTO_INCREMENT,
    student_id INT NOT NULL,
    class_name VARCHAR(50) NOT NULL,                    -- 8th, 9th, 10th, 11th
    marks_obtained INT NOT NULL,
    total_marks INT NOT NULL,
    percentage DECIMAL(5,2) GENERATED ALWAYS AS 
        (ROUND((marks_obtained / total_marks) * 100, 2)) STORED,
    grade VARCHAR(10),
    board_name VARCHAR(100),
    passing_year VARCHAR(4),
    roll_number VARCHAR(30),                            -- Board roll number
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    UNIQUE KEY unique_student_class (student_id, class_name),
    INDEX idx_class_name (class_name),
    INDEX idx_passing_year (passing_year)
);

-- =============================================
-- TRIGGER: Auto-calculate grade based on percentage
-- =============================================
DELIMITER //
CREATE TRIGGER before_previous_result_insert
BEFORE INSERT ON student_previous_results
FOR EACH ROW
BEGIN
    DECLARE pct DECIMAL(5,2);
    SET pct = (NEW.marks_obtained / NEW.total_marks) * 100;
    
    IF NEW.grade IS NULL THEN
        SET NEW.grade = CASE
            WHEN pct >= 90 THEN 'A+'
            WHEN pct >= 80 THEN 'A'
            WHEN pct >= 70 THEN 'B'
            WHEN pct >= 60 THEN 'C'
            WHEN pct >= 50 THEN 'D'
            WHEN pct >= 33 THEN 'E'
            ELSE 'F'
        END;
    END IF;
END//
DELIMITER ;

-- =============================================
-- STORED PROCEDURE: Validate student has required previous results
-- Call this before enrollment to ensure all previous class results exist
-- =============================================
DELIMITER //
CREATE PROCEDURE validate_previous_results(
    IN p_student_id INT,
    IN p_class_level INT,
    OUT p_is_valid BOOLEAN,
    OUT p_missing_classes VARCHAR(255)
)
BEGIN
    DECLARE required_classes VARCHAR(255);
    DECLARE existing_classes VARCHAR(255);
    
    -- Set required classes based on enrollment class
    SET required_classes = CASE p_class_level
        WHEN 9 THEN '8th'
        WHEN 10 THEN '8th,9th'
        WHEN 11 THEN '8th,9th,10th'
        WHEN 12 THEN '8th,9th,10th,11th'
        ELSE ''
    END;
    
    -- Get existing classes for this student
    SELECT GROUP_CONCAT(class_name ORDER BY 
        CASE class_name 
            WHEN '8th' THEN 1 
            WHEN '9th' THEN 2 
            WHEN '10th' THEN 3 
            WHEN '11th' THEN 4 
        END
    ) INTO existing_classes
    FROM student_previous_results
    WHERE student_id = p_student_id;
    
    -- Check if all required classes exist
    IF existing_classes IS NULL OR existing_classes != required_classes THEN
        SET p_is_valid = FALSE;
        SET p_missing_classes = CONCAT('Required: ', required_classes, ' | Found: ', IFNULL(existing_classes, 'None'));
    ELSE
        SET p_is_valid = TRUE;
        SET p_missing_classes = NULL;
    END IF;
END//
DELIMITER ;

-- =============================================
-- INSERT DEFAULT DATA
-- =============================================

-- Insert Classes
INSERT INTO classes (class_name, class_level, description) VALUES
('9th', 9, 'Secondary School Certificate - Part I'),
('10th', 10, 'Secondary School Certificate - Part II'),
('11th', 11, 'Higher Secondary School Certificate - Part I'),
('12th', 12, 'Higher Secondary School Certificate - Part II');

-- Insert Domains (Matric Level - 9th & 10th)
INSERT INTO domains (domain_name, domain_code, level, description) VALUES
('Computer Science', 'COMP', 'MATRIC', 'Computer Science Stream - Matric'),
('Biology', 'BIO', 'MATRIC', 'Pre-Medical/Biology Stream - Matric'),
('Arts', 'ARTS', 'MATRIC', 'Arts/Humanities Stream - Matric');

-- Insert Domains (Intermediate Level - 11th & 12th)
INSERT INTO domains (domain_name, domain_code, level, description) VALUES
('FSC Pre-Medical', 'FSC-MED', 'INTER', 'Pre-Medical - Biology, Physics, Chemistry'),
('FSC Pre-Engineering', 'FSC-ENG', 'INTER', 'Pre-Engineering - Physics, Chemistry, Math'),
('ICS', 'ICS', 'INTER', 'Intermediate in Computer Science'),
('FA', 'FA', 'INTER', 'Faculty of Arts'),
('FA-IT', 'FA-IT', 'INTER', 'Faculty of Arts with IT');

-- Insert Subjects
INSERT INTO subjects (subject_name, subject_code, subject_type, description) VALUES
-- Common Subjects (All Classes)
('English', 'ENG', 'COMPULSORY', 'English Language and Literature'),
('Urdu', 'URD', 'COMPULSORY', 'Urdu Language and Literature'),
('Tarjuma-tul-Quran', 'TQ', 'COMPULSORY', 'Translation of Holy Quran'),
('Islamiat', 'IS', 'COMPULSORY', 'Islamic Studies - Class 9 & 11'),
('Pakistan Studies', 'PS', 'COMPULSORY', 'Pakistan Studies - Class 10 & 12'),

-- Science Subjects
('Mathematics', 'MATH', 'COMPULSORY', 'General Mathematics'),
('Physics', 'PHY', 'ELECTIVE', 'Physics'),
('Chemistry', 'CHEM', 'ELECTIVE', 'Chemistry'),
('Biology', 'BIO', 'ELECTIVE', 'Biology'),
('Computer Science', 'COMP', 'ELECTIVE', 'Computer Science'),

-- Arts Subjects (Matric)
('Selective Islamiat', 'SIS', 'ELECTIVE', 'Selective Islamic Studies - Matric'),
('Punjabi', 'PUN', 'ELECTIVE', 'Punjabi Language'),
('E-Commerce', 'ECOM', 'ELECTIVE', 'Electronic Commerce'),

-- Intermediate Arts Subjects (FA/FA-IT)
('Education', 'EDU', 'ELECTIVE', 'Education Studies'),
('Physical Education', 'PE', 'ELECTIVE', 'Physical Education'),
('Elective Islamiat', 'EIS', 'ELECTIVE', 'Elective Islamic Studies - Inter');

-- Link Classes to Domains
INSERT INTO class_domains (class_id, domain_id) VALUES
-- 9th Class Domains (Matric domains: COMP=1, BIO=2, ARTS=3)
(1, 1), (1, 2), (1, 3),
-- 10th Class Domains  
(2, 1), (2, 2), (2, 3),
-- 11th Class Domains (Inter domains: FSC-MED=4, FSC-ENG=5, ICS=6, FA=7, FA-IT=8)
(3, 4), (3, 5), (3, 6), (3, 7), (3, 8),
-- 12th Class Domains
(4, 4), (4, 5), (4, 6), (4, 7), (4, 8);

-- =============================================
-- Link Domains to Subjects for Class 9th
-- =============================================

-- Get IDs (assuming auto-increment starts at 1)
-- Classes: 9th=1, 10th=2
-- Domains: COMP=1, BIO=2, ARTS=3
-- Subjects: ENG=1, URD=2, TQ=3, IS=4, PS=5, MATH=6, PHY=7, CHEM=8, BIO=9, COMP=10, SIS=11, PUN=12, ECOM=13

-- 9th Class - Computer Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(1, 1, 1, TRUE),   -- English (Common)
(1, 1, 2, TRUE),   -- Urdu (Common)
(1, 1, 3, TRUE),   -- TQ (Common)
(1, 1, 4, TRUE),   -- IS (Common)
(1, 1, 6, FALSE),  -- Math
(1, 1, 7, FALSE),  -- Physics
(1, 1, 8, FALSE),  -- Chemistry
(1, 1, 10, FALSE); -- Computer

-- 9th Class - Bio Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(1, 2, 1, TRUE),   -- English (Common)
(1, 2, 2, TRUE),   -- Urdu (Common)
(1, 2, 3, TRUE),   -- TQ (Common)
(1, 2, 4, TRUE),   -- IS (Common)
(1, 2, 6, FALSE),  -- Math
(1, 2, 7, FALSE),  -- Physics
(1, 2, 8, FALSE),  -- Chemistry
(1, 2, 9, FALSE);  -- Biology

-- 9th Class - Arts Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(1, 3, 1, TRUE),   -- English (Common)
(1, 3, 2, TRUE),   -- Urdu (Common)
(1, 3, 3, TRUE),   -- TQ (Common)
(1, 3, 4, TRUE),   -- IS (Common)
(1, 3, 6, FALSE),  -- Math
(1, 3, 11, FALSE), -- Selective IS
(1, 3, 12, FALSE), -- Punjabi
(1, 3, 13, FALSE); -- E-Commerce

-- =============================================
-- Link Domains to Subjects for Class 10th
-- =============================================

-- 10th Class - Computer Domain (IS replaced with PS)
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(2, 1, 1, TRUE),   -- English (Common)
(2, 1, 2, TRUE),   -- Urdu (Common)
(2, 1, 3, TRUE),   -- TQ (Common)
(2, 1, 5, TRUE),   -- PS (Common) - Replaced IS
(2, 1, 6, FALSE),  -- Math
(2, 1, 7, FALSE),  -- Physics
(2, 1, 8, FALSE),  -- Chemistry
(2, 1, 10, FALSE); -- Computer

-- 10th Class - Bio Domain (IS replaced with PS)
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(2, 2, 1, TRUE),   -- English (Common)
(2, 2, 2, TRUE),   -- Urdu (Common)
(2, 2, 3, TRUE),   -- TQ (Common)
(2, 2, 5, TRUE),   -- PS (Common) - Replaced IS
(2, 2, 6, FALSE),  -- Math
(2, 2, 7, FALSE),  -- Physics
(2, 2, 8, FALSE),  -- Chemistry
(2, 2, 9, FALSE);  -- Biology

-- 10th Class - Arts Domain (IS replaced with PS)
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(2, 3, 1, TRUE),   -- English (Common)
(2, 3, 2, TRUE),   -- Urdu (Common)
(2, 3, 3, TRUE),   -- TQ (Common)
(2, 3, 5, TRUE),   -- PS (Common) - Replaced IS
(2, 3, 6, FALSE),  -- Math
(2, 3, 11, FALSE), -- Selective IS
(2, 3, 12, FALSE), -- Punjabi
(2, 3, 13, FALSE); -- E-Commerce

-- =============================================
-- Link Domains to Subjects for Class 11th
-- =============================================
-- Classes: 9th=1, 10th=2, 11th=3, 12th=4
-- Domains: COMP=1, BIO=2, ARTS=3, FSC-MED=4, FSC-ENG=5, ICS=6, FA=7, FA-IT=8
-- Subjects: ENG=1, URD=2, TQ=3, IS=4, PS=5, MATH=6, PHY=7, CHEM=8, BIO=9, COMP=10, SIS=11, PUN=12, ECOM=13, EDU=14, PE=15, EIS=16

-- 11th Class - FSC Pre-Medical Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(3, 4, 1, TRUE),   -- English (Common)
(3, 4, 2, TRUE),   -- Urdu (Common)
(3, 4, 3, TRUE),   -- TQ (Common)
(3, 4, 4, TRUE),   -- IS (Common)
(3, 4, 9, FALSE),  -- Biology
(3, 4, 7, FALSE),  -- Physics
(3, 4, 8, FALSE);  -- Chemistry

-- 11th Class - FSC Pre-Engineering (Non-Medical) Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(3, 5, 1, TRUE),   -- English (Common)
(3, 5, 2, TRUE),   -- Urdu (Common)
(3, 5, 3, TRUE),   -- TQ (Common)
(3, 5, 4, TRUE),   -- IS (Common)
(3, 5, 7, FALSE),  -- Physics
(3, 5, 8, FALSE),  -- Chemistry
(3, 5, 6, FALSE);  -- Math

-- 11th Class - ICS Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(3, 6, 1, TRUE),   -- English (Common)
(3, 6, 2, TRUE),   -- Urdu (Common)
(3, 6, 3, TRUE),   -- TQ (Common)
(3, 6, 4, TRUE),   -- IS (Common)
(3, 6, 7, FALSE),  -- Physics
(3, 6, 6, FALSE),  -- Math
(3, 6, 10, FALSE); -- Computer

-- 11th Class - FA Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(3, 7, 1, TRUE),   -- English (Common)
(3, 7, 2, TRUE),   -- Urdu (Common)
(3, 7, 3, TRUE),   -- TQ (Common)
(3, 7, 4, TRUE),   -- IS (Common)
(3, 7, 14, FALSE), -- Education
(3, 7, 15, FALSE), -- Physical Education
(3, 7, 16, FALSE); -- Elective Islamiat

-- 11th Class - FA-IT Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(3, 8, 1, TRUE),   -- English (Common)
(3, 8, 2, TRUE),   -- Urdu (Common)
(3, 8, 3, TRUE),   -- TQ (Common)
(3, 8, 4, TRUE),   -- IS (Common)
(3, 8, 14, FALSE), -- Education
(3, 8, 15, FALSE), -- Physical Education
(3, 8, 10, FALSE); -- Computer

-- =============================================
-- Link Domains to Subjects for Class 12th (IS replaced with PS)
-- =============================================

-- 12th Class - FSC Pre-Medical Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(4, 4, 1, TRUE),   -- English (Common)
(4, 4, 2, TRUE),   -- Urdu (Common)
(4, 4, 3, TRUE),   -- TQ (Common)
(4, 4, 5, TRUE),   -- PS (Common) - Replaced IS
(4, 4, 9, FALSE),  -- Biology
(4, 4, 7, FALSE),  -- Physics
(4, 4, 8, FALSE);  -- Chemistry

-- 12th Class - FSC Pre-Engineering (Non-Medical) Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(4, 5, 1, TRUE),   -- English (Common)
(4, 5, 2, TRUE),   -- Urdu (Common)
(4, 5, 3, TRUE),   -- TQ (Common)
(4, 5, 5, TRUE),   -- PS (Common) - Replaced IS
(4, 5, 7, FALSE),  -- Physics
(4, 5, 8, FALSE),  -- Chemistry
(4, 5, 6, FALSE);  -- Math

-- 12th Class - ICS Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(4, 6, 1, TRUE),   -- English (Common)
(4, 6, 2, TRUE),   -- Urdu (Common)
(4, 6, 3, TRUE),   -- TQ (Common)
(4, 6, 5, TRUE),   -- PS (Common) - Replaced IS
(4, 6, 7, FALSE),  -- Physics
(4, 6, 6, FALSE),  -- Math
(4, 6, 10, FALSE); -- Computer

-- 12th Class - FA Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(4, 7, 1, TRUE),   -- English (Common)
(4, 7, 2, TRUE),   -- Urdu (Common)
(4, 7, 3, TRUE),   -- TQ (Common)
(4, 7, 5, TRUE),   -- PS (Common) - Replaced IS
(4, 7, 14, FALSE), -- Education
(4, 7, 15, FALSE), -- Physical Education
(4, 7, 16, FALSE); -- Elective Islamiat

-- 12th Class - FA-IT Domain
INSERT INTO domain_subjects (class_id, domain_id, subject_id, is_common) VALUES
(4, 8, 1, TRUE),   -- English (Common)
(4, 8, 2, TRUE),   -- Urdu (Common)
(4, 8, 3, TRUE),   -- TQ (Common)
(4, 8, 5, TRUE),   -- PS (Common) - Replaced IS
(4, 8, 14, FALSE), -- Education
(4, 8, 15, FALSE), -- Physical Education
(4, 8, 10, FALSE); -- Computer
```

---

## Useful Queries

### 1. Search Student by Registration Number (PRIMARY SEARCH)
```sql
-- Get complete student info by registration number
SELECT * FROM student_directory 
WHERE registration_number = '25-9(B)-COMP-R-001';

-- Partial search (find all students starting with pattern)
SELECT * FROM student_directory 
WHERE registration_number LIKE '25-9%';

-- Search by class and domain
SELECT * FROM student_directory 
WHERE class_level = 9 AND domain_code = 'COMP' AND status = 'ACTIVE';
```

### 2. Get All Subjects for a Student by Registration Number
```sql
-- For REGULAR and RTS students
SELECT 
    e.registration_number,
    s.subject_name,
    s.subject_code,
    ds.is_common
FROM enrollments e
JOIN domain_subjects ds ON ds.class_id = e.class_id AND ds.domain_id = e.domain_id
JOIN subjects s ON s.subject_id = ds.subject_id
WHERE e.registration_number = '25-9(B)-COMP-R-001'
ORDER BY ds.is_common DESC, s.subject_name;

-- For SUPPLEMENTARY students
SELECT 
    e.registration_number,
    s.subject_name,
    s.subject_code
FROM enrollments e
JOIN enrollment_subjects es ON es.enrollment_id = e.enrollment_id
JOIN subjects s ON s.subject_id = es.subject_id
WHERE e.registration_number = '25-9(B)-COMP-S-001';
```

### 3. Get Student Previous Results by Registration Number
```sql
SELECT 
    sd.registration_number,
    sd.student_name,
    spr.class_name AS previous_class,
    spr.marks_obtained,
    spr.total_marks,
    spr.percentage,
    spr.grade,
    spr.board_name,
    spr.passing_year
FROM student_directory sd
JOIN student_previous_results spr ON sd.student_id = spr.student_id
WHERE sd.registration_number = '25-11(B)-FSC-MED-R-001'
ORDER BY FIELD(spr.class_name, '8th', '9th', '10th', '11th');
```

### 4. Get Enrollment ID from Registration Number
```sql
-- Use this when you need enrollment_id for other operations
SELECT enrollment_id FROM enrollments 
WHERE registration_number = '25-9(B)-COMP-R-001';

-- Or create a function for convenience
DELIMITER //
CREATE FUNCTION get_enrollment_id(p_reg_number VARCHAR(30)) 
RETURNS INT
DETERMINISTIC
BEGIN
    DECLARE v_id INT;
    SELECT enrollment_id INTO v_id FROM enrollments 
    WHERE registration_number = p_reg_number;
    RETURN v_id;
END//
DELIMITER ;

-- Usage:
SELECT get_enrollment_id('25-9(B)-COMP-R-001');
```

### 5. Enroll a New Student
```sql
-- =============================================
-- REGULAR STUDENT ENROLLMENT
-- =============================================
INSERT INTO students (
    student_name, gender, date_of_birth, cnic, address,
    mark_of_identification, previous_qualification, previous_school_name,
    father_name, father_cnic, father_occupation, father_mobile_no
) VALUES (
    'Ahmed Ali', 'MALE', '2010-05-15', NULL, 'House 123, Street 5, Lahore',
    'Mole on left cheek', 'Middle School', 'Govt. High School Lahore',
    'Muhammad Ali', '35201-1234567-1', 'Teacher', '0300-1234567'
);

SET @new_student_id = LAST_INSERT_ID();

-- Add previous class results
INSERT INTO student_previous_results (
    student_id, class_name, marks_obtained, total_marks, board_name, passing_year
) VALUES (
    @new_student_id, '8th', 450, 550, 'BISE Lahore', '2024'
);

-- Enroll as REGULAR student (registration_number auto-generated)
INSERT INTO enrollments (
    student_id, class_id, domain_id, enrollment_type, academic_year, admission_date, section
) VALUES (
    @new_student_id, 1, 1, 'REGULAR', '2025-2026', CURDATE(), 'A'
);

-- Get the generated registration number
SELECT registration_number FROM enrollments WHERE student_id = @new_student_id;
-- Result: 25-9(B)-COMP-R-001
```

### 6. Update Student by Registration Number
```sql
-- Update student status
UPDATE enrollments SET status = 'PASSED' 
WHERE registration_number = '25-9(B)-COMP-R-001';

-- Update student section
UPDATE enrollments SET section = 'B' 
WHERE registration_number = '25-9(B)-COMP-R-001';

-- Update student personal info using registration number
UPDATE students st
JOIN enrollments e ON st.student_id = e.student_id
SET st.address = 'New Address, Lahore'
WHERE e.registration_number = '25-9(B)-COMP-R-001';
```

### 7. Enroll Supplementary Student with Selected Subjects
```sql
-- Step 1: Enroll as supplementary
INSERT INTO enrollments (
    student_id, class_id, domain_id, enrollment_type, academic_year, admission_date
) VALUES (
    @supp_student_id, 1, 1, 'SUPPLEMENTARY', '2025-2026', CURDATE()
);

-- Get the registration number
SET @supp_reg = (SELECT registration_number FROM enrollments WHERE enrollment_id = LAST_INSERT_ID());
-- Result: 25-9(B)-COMP-S-001

-- Step 2: Add selected subjects using registration number
INSERT INTO enrollment_subjects (enrollment_id, subject_id)
SELECT 
    (SELECT enrollment_id FROM enrollments WHERE registration_number = @supp_reg),
    subject_id
FROM subjects WHERE subject_code IN ('MATH', 'PHY');
-- This student only enrolled for Math and Physics
```

### 8. Search and Filter Students
```sql
-- Search by partial registration number
SELECT * FROM student_directory 
WHERE registration_number LIKE '25-9%' AND status = 'ACTIVE';

-- Search by name (when reg number unknown)
SELECT * FROM student_directory 
WHERE student_name LIKE '%Ahmed%';

-- Search by father's mobile
SELECT * FROM student_directory 
WHERE father_mobile_no = '0300-1234567';

-- Get all RTS students
SELECT * FROM student_directory 
WHERE enrollment_type = 'RTS' AND academic_year = '2025-2026';

-- Get all supplementary students with their subjects
SELECT 
    sd.registration_number,
    sd.student_name,
    sd.class_name,
    GROUP_CONCAT(s.subject_name) AS subjects
FROM student_directory sd
JOIN enrollments e ON sd.registration_number = e.registration_number
JOIN enrollment_subjects es ON e.enrollment_id = es.enrollment_id
JOIN subjects s ON es.subject_id = s.subject_id
WHERE sd.enrollment_type = 'SUPPLEMENTARY'
GROUP BY sd.registration_number, sd.student_name, sd.class_name;
```

### 9. Count Students by Category
```sql
SELECT 
    class_name,
    domain_name,
    enrollment_type,
    COUNT(*) as total_students
FROM student_directory
WHERE academic_year = '2025-2026' AND status = 'ACTIVE'
GROUP BY class_name, domain_name, enrollment_type
ORDER BY class_level, domain_name, enrollment_type;
```

---

## Future Expansion Tables

> **Note:** All future tables should use `registration_number` to reference students (via enrollments table) for consistency.

### Fee Management (Suggested Structure)

```sql
-- Fee Types Table
CREATE TABLE fee_types (
    fee_type_id INT PRIMARY KEY AUTO_INCREMENT,
    fee_name VARCHAR(100) NOT NULL,
    fee_code VARCHAR(20) UNIQUE,
    description VARCHAR(255)
);

-- Fee Structure Table (Links fees to classes/domains/enrollment_type)
CREATE TABLE fee_structure (
    fee_structure_id INT PRIMARY KEY AUTO_INCREMENT,
    fee_type_id INT NOT NULL,
    class_id INT NOT NULL,
    domain_id INT,
    enrollment_type ENUM('REGULAR', 'RTS', 'SUPPLEMENTARY') NOT NULL,
    subject_id INT,                          -- For per-subject fees (SUPPLEMENTARY)
    amount DECIMAL(10, 2) NOT NULL,
    academic_year VARCHAR(9) NOT NULL,
    due_day INT DEFAULT 10,
    
    FOREIGN KEY (fee_type_id) REFERENCES fee_types(fee_type_id),
    FOREIGN KEY (class_id) REFERENCES classes(class_id),
    FOREIGN KEY (domain_id) REFERENCES domains(domain_id),
    FOREIGN KEY (subject_id) REFERENCES subjects(subject_id)
);

-- Fee Payments Table (Uses registration_number)
CREATE TABLE fee_payments (
    payment_id INT PRIMARY KEY AUTO_INCREMENT,
    registration_number VARCHAR(30) NOT NULL,    -- PRIMARY REFERENCE
    fee_structure_id INT NOT NULL,
    month VARCHAR(7) NOT NULL,                   -- Format: YYYY-MM
    amount_paid DECIMAL(10, 2) NOT NULL,
    payment_date DATE NOT NULL,
    payment_method ENUM('CASH', 'BANK', 'ONLINE') DEFAULT 'CASH',
    receipt_number VARCHAR(50) UNIQUE,
    remarks TEXT,
    
    FOREIGN KEY (registration_number) REFERENCES enrollments(registration_number),
    FOREIGN KEY (fee_structure_id) REFERENCES fee_structure(fee_structure_id),
    INDEX idx_reg_number (registration_number)
);
```

### Results/Examination (Suggested Structure)

```sql
-- Exams Table
CREATE TABLE exams (
    exam_id INT PRIMARY KEY AUTO_INCREMENT,
    exam_name VARCHAR(100) NOT NULL,
    exam_type ENUM('MONTHLY', 'MIDTERM', 'FINAL', 'BOARD') NOT NULL,
    class_id INT NOT NULL,
    academic_year VARCHAR(9) NOT NULL,
    start_date DATE,
    end_date DATE,
    
    FOREIGN KEY (class_id) REFERENCES classes(class_id)
);

-- Results Table (Uses registration_number)
CREATE TABLE results (
    result_id INT PRIMARY KEY AUTO_INCREMENT,
    registration_number VARCHAR(30) NOT NULL,    -- PRIMARY REFERENCE
    exam_id INT NOT NULL,
    subject_id INT NOT NULL,
    marks_obtained INT NOT NULL,
    remarks VARCHAR(255),
    
    FOREIGN KEY (registration_number) REFERENCES enrollments(registration_number),
    FOREIGN KEY (exam_id) REFERENCES exams(exam_id),
    FOREIGN KEY (subject_id) REFERENCES subjects(subject_id),
    UNIQUE KEY unique_result (registration_number, exam_id, subject_id),
    INDEX idx_reg_number (registration_number)
);
```

### Attendance (Suggested Structure)

```sql
CREATE TABLE attendance (
    attendance_id INT PRIMARY KEY AUTO_INCREMENT,
    registration_number VARCHAR(30) NOT NULL,    -- PRIMARY REFERENCE
    attendance_date DATE NOT NULL,
    status ENUM('PRESENT', 'ABSENT', 'LATE', 'LEAVE') NOT NULL,
    remarks VARCHAR(255),
    
    FOREIGN KEY (registration_number) REFERENCES enrollments(registration_number),
    UNIQUE KEY unique_attendance (registration_number, attendance_date),
    INDEX idx_reg_number (registration_number)
);
```

---

## Key Design Decisions

1. **Normalized Structure**: Tables are designed to minimize data redundancy.

2. **Reusable Subjects Table**: The subjects table can be linked to:
   - Fee calculations (subject-wise fees)
   - Result management
   - Timetable scheduling
   - Teacher assignments

3. **Flexible Domain-Subject Mapping**: The `domain_subjects` junction table allows:
   - Different subjects for different classes in the same domain
   - Easy addition of new subjects
   - Marking common vs domain-specific subjects

4. **Enrollment-Based Tracking**: All student activities (fees, results, attendance) link through enrollments, ensuring:
   - Historical data preservation
   - Multi-year tracking
   - Easy promotion/demotion handling

5. **Soft Deletes**: Using `is_active` flags instead of hard deletes for data integrity.

---

## Notes

- All CNIC fields accept 13-digit Pakistani CNIC format (XXXXX-XXXXXXX-X)
- Mobile numbers should include country code (+92)
- Academic year format: "YYYY-YYYY" (e.g., "2025-2026")
- The database uses MySQL/MariaDB syntax
- Indexes are added on frequently searched columns

---

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0 | 2026-02-05 | Initial database design with student, class, domain, subject tables |
| 1.1 | 2026-02-05 | Added previous marks tracking in enrollments, 11th/12th class domains (FSC-Medical, FSC-Engineering, ICS, FA, FA-IT), new subjects (Education, Physical Education, Elective Islamiat) |
| 1.2 | 2026-02-05 | Added gender field to students, created student_previous_results table for complete academic history, changed roll_number to user-defined registration_number, added validation stored procedure |
| 1.3 | 2026-02-05 | Implemented auto-increment registration number with format "YY-CLASS(G)-DOMAIN-SEQ" (e.g., 25-9(B)-COMP-001), added function and trigger for auto-generation |
| 1.4 | 2026-02-05 | Added enrollment_type (REGULAR, RTS, SUPPLEMENTARY), created enrollment_subjects table for supplementary students to select specific subjects, updated registration format to include type code (R/T/S) |
| 1.5 | 2026-02-05 | Made registration_number the PRIMARY IDENTIFIER for all student operations, created student_directory view, updated all queries and future tables to use registration_number as the main search key |
