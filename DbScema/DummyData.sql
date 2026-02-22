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