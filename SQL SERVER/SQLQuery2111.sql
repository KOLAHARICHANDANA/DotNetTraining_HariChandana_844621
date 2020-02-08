Create Database EmployeeEFDB;

Use EmployeeEFDB;

Create Table Employee

(EmpID int Primary Key,
Name varchar(30) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);


Create Table Department
(DepID int Primary Key,
Name varchar(30) not null);


Alter Table Employee
Add Constraint Fk_DepID FOREIGN KEY(DepID) references Department(DepID);
Insert Into Department Values(1,'Admin');
Insert Into Department Values(2,'Coadmin');

Insert Into Department Values(3,'Manager');
Select * fROM Department;
Select * from Employee;
Insert Into Employee values(7,'someEmployee',11111,100000,1);

