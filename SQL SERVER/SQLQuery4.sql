CREATE DATABASE College
Use College;
CREATE TABLE Dues
(StuID int not null primary key,
StuName varchar(50) not null,
SSN bigint not null);
Insert Into Dues values(1,'a',1234);
Insert Into Dues values(2,'b',5678);
Insert Into Dues values(3,'c',5000);
Insert Into Dues values(4,'d',6000);

select * from Dues;
alter table Dues
add description varchar(100);
update Dues SET Description ='this is first line' Where StuID=1;
Update Dues SET Description = 'this is second line' Where StuID=2;
Update Dues SET Description = 'this is third line' Where StuID=3;
Update Dues SET Description = 'this is fourth line' Where StuID=4;
alter Table Dues
Add Constraint FK_StuID FOREIGN KEY (StuID) References Dues(StuID);
alter Table Dues
add DOB date
select * from Dues;
update Dues SET DOB ='01-1-1997';
alter Table Dues
Add Constraint chk_DOB CHECK (DOB BETWEEN '01-01-1990' AND '12-31-1999');
Insert Into Dues values(5,'b',5678,'this is second line','03-11-1993');
select max(ssn)[max ssn],min(ssn)[min ssn],avg(ssn) from Dues;
Select * From Dues;
select StuID,sum(SSN) 'total ssn' from Dues
Group By StuID
Having SUM(SSN)>=1000
Order By StuID;
Select Top(5) ssn from Dues;
Select Top(4) with ties ssn from Dues
Order By ssn;
Select  Top(4) ssn from Dues
Order By ssn DESC;
Insert Into Dues values(6,'h',91010,'this is sixth line','03-11-1995');
Insert Into Dues values(7,'s',91013,'this is seventh line','03-10-1995');
create table dept
(stuID int not null,
deptname varchar(30) not null);
select * from dept;
insert into dept values(1,'admin');
insert into dept values(2,'develpoer');
insert into dept values(3,'tester');
insert into dept values(4,'coder');
 



































