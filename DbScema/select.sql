use accadmyDb;
--===== select * from 
select * from adminTb;
select * from domainTb;
select * from classTb;
select * from teacherTb;
select * from teacherAttendance;
select * from teacherProfitTb;
select * from teacherAddTb;
select * from teacherPaymentTb;
select * from teacherClassSubjectTb ;
SELECT 
    s.subjectId,
    sp.subjectName,
    c.className,
    s.domainId
FROM 
    subjectTb s
INNER JOIN 
    SubjectPack sp
    ON s.subjectId = sp.subjectId
INNER JOIN
    classTb c
    ON s.classId = c.classId
ORDER BY
    s.domainId,
    s.classId,
    s.subjectId;
    
    select * from setStdFeeTb;


select * from StudentTb;
select * from stdAdress;
select * from academicTb;
select * from feeTb;
select * from subjectTb;
select * from studentAttendance;



select * from expenseTb;



SELECT 
    s.stdRegisNo,
    s.student_name,
    FORMAT(GETDATE(),'yyyy-MM') AS paymentMonth,
    f.amount AS feeAmount
FROM StudentTb s
JOIN setStdFeeTb f 
    ON s.domainId = f.domainId 
    AND s.classId = f.classId
WHERE s.is_active = 1;

SELECT 
    s.stdRegisNo,
    s.student_name,
    FORMAT(GETDATE(),'yyyy-MM') AS paymentMonth,
    f.amount AS totalFee,
    ISNULL(ft.paidAmount,0) AS paidAmount,
    f.amount - ISNULL(ft.paidAmount,0) AS remainingFee
FROM StudentTb s
JOIN setStdFeeTb f 
    ON s.domainId = f.domainId 
    AND s.classId = f.classId
LEFT JOIN feeTb ft
    ON s.stdRegisNo = ft.stdRegisNo
    AND ft.paymentMonth = FORMAT(GETDATE(),'yyyy-MM')
WHERE s.is_active = 1;

SELECT 
    s.stdRegisNo,
    s.student_name,
    d.domainName,
    c.className,
    f.amount
FROM StudentTb s
JOIN domainTb d
    ON s.domainId = d.domainId
JOIN classTb c
    ON c.domainId = s.domainId
    AND c.className =
        CASE 
            WHEN s.classId <= 8 THEN CAST(s.classId AS VARCHAR)
            ELSE CONCAT(s.classId,'th')
        END
LEFT JOIN setStdFeeTb f
    ON f.domainId = c.domainId
    AND f.classId = c.classId
WHERE s.stdRegisNo = '26-10-Bio-B-34';

insert into setStdFeeTb(amount,domainId,classId)
values(32320,'Bio',12);
select * from setStdFeeTb;
select * from classTb;
select * from StudentTb;
TRUNCATE TABLE setStdFeeTb;