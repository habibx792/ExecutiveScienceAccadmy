---------------------------=======================Defalut data insetion=======================
USE accadmyDb;
---set domain
insert into domainTb(domainId,domainName)
values('Prim','Primary'),
('Bio','Medical')
,('Eng','Non-Medical'),
('Comp','Computer'),
('Art','Arts');
select * from domainTb;
-----set classes
insert into classTb(domainId,className)
values('Prim','1'),
('Prim','2'),
('Prim','3'),
('Prim','4'),
('Prim','5'),
('Prim','6'),
('Prim','7'),
('Prim','8'),
('Bio','9th'),
('Comp','9th'),
('Art','9th'),
('Bio','10th'),
('Comp','10th'),
('Art','10th'),
('Bio','11th'),
('Eng','11th'),
('Comp','11th'),
('Art','11th'),
('Bio','12th'),
('Eng','12th'),
('Comp','12th'),
('Art','12th');
select * from classTb;
insert into stdCountTB(stdCountId,stdCount)
values(1,1);

select * from stdCountTB;
update stdCountTB
SET stdCount = 2
WHERE stdCountId = 1; 
insert into setStdFeeTb(amount,domainId,classId)
values(5000,'Bio',9);



INSERT INTO subjectTb VALUES
-- 9th BIO
(1,9,'Bio'),
(2,9,'Bio'),
(3,9,'Bio'),
(4,9,'Bio'),
(5,9,'Bio'),
(6,9,'Bio'),
(8,9,'Bio'),

-- 9th Computer
(1,10,'Comp'),
(2,10,'Comp'),
(7,10,'Comp'),
(4,10,'Comp'),
(5,10,'Comp'),
(6,10,'Comp'),
(8,10,'Comp'),

-- 9th Arts
(1,11,'Art'),
(2,11,'Art'),
(6,11,'Art'),
(8,11,'Art'),

-- 10th BIO
(1,12,'Bio'),
(2,12,'Bio'),
(3,12,'Bio'),
(4,12,'Bio'),
(5,12,'Bio'),
(6,12,'Bio'),
(9,12,'Bio'),

-- 10th Computer
(1,13,'Comp'),
(2,13,'Comp'),
(7,13,'Comp'),
(4,13,'Comp'),
(5,13,'Comp'),
(6,13,'Comp'),
(9,13,'Comp'),

-- 10th Arts
(1,14,'Art'),
(2,14,'Art'),
(6,14,'Art'),
(9,14,'Art'),

-- 11th BIO
(1,15,'Bio'),
(2,15,'Bio'),
(3,15,'Bio'),
(4,15,'Bio'),
(5,15,'Bio'),
(8,15,'Bio'),

-- 11th Engineering
(1,16,'Eng'),
(2,16,'Eng'),
(5,16,'Eng'),
(4,16,'Eng'),
(6,16,'Eng'),
(8,16,'Eng'),

-- 11th Computer
(1,17,'Comp'),
(2,17,'Comp'),
(7,17,'Comp'),
(6,17,'Comp'),
(5,17,'Comp'),
(8,17,'Comp'),

-- 11th Arts
(1,18,'Art'),
(2,18,'Art'),
(8,18,'Art'),

-- 12th BIO
(1,19,'Bio'),
(2,19,'Bio'),
(3,19,'Bio'),
(4,19,'Bio'),
(5,19,'Bio'),
(9,19,'Bio'),

-- 12th Engineering
(1,20,'Eng'),
(2,20,'Eng'),
(5,20,'Eng'),
(4,20,'Eng'),
(6,20,'Eng'),
(9,20,'Eng'),

-- 12th Computer
(1,21,'Comp'),
(2,21,'Comp'),
(7,21,'Comp'),
(6,21,'Comp'),
(5,21,'Comp'),
(9,21,'Comp'),

-- 12th Arts
(1,22,'Art'),
(2,22,'Art'),
(9,22,'Art');