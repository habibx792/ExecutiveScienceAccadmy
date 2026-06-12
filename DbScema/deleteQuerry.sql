USE accadmyDb;
GO

-- Disable foreign key checks (SQL Server doesn't have a global disable, so we delete in order)
-- Child tables referencing teacherTb
DELETE FROM teacherAttendance;
DELETE FROM teacherProfitTb;
DELETE FROM teacherAddTb;
DELETE FROM teacherPaymentTb;
DELETE FROM teacherClassSubjectTb;
DELETE FROM teacherPassword;   -- references teacherTb

-- Child tables referencing StudentTb
DELETE FROM feeTb;
DELETE FROM studentAttendance;
DELETE FROM studentPassword;
DELETE FROM stdAdress;
DELETE FROM academicTb;        -- if it references StudentTb (adjust as needed)

-- Tables referencing domainTb and classTb
DELETE FROM StudentTb;         -- references domainTb, classTb
DELETE FROM teacherTb;         -- references domainTb, classTb
DELETE FROM setStdFeeTb;       -- references domainTb, classTb
DELETE FROM subjectTb;         -- references domainTb, classTb, SubjectPack
DELETE FROM teacherClassSubjectTb; -- (already deleted above, but safe to repeat)
DELETE FROM classTb;           -- references domainTb
DELETE FROM domainTb;

-- Independent tables (no dependencies)
DELETE FROM SubjectPack;       -- referenced by subjectTb, so delete after subjectTb
DELETE FROM adminTb;
DELETE FROM expenseTb;

-- Optional: reset identity seeds if needed
-- DBCC CHECKIDENT ('tableName', RESEED, 0);