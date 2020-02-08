CREATE DATABASE EmployeeDB
USE EmployeeDB;
CREATE TABLE Employee
(EmpID int not null PRIMARY KEY,
EmpName varchar(50) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);
Insert Into Employee Values(1,'chandu',1234,15.0000,1);
Insert Into Employee values(2,'hari',5678,22.0000,2);
Insert Into Employee values(3,'nani',4345,44.0000,3);
select EmpID,EmpName,Salary from Employee where DepID<3;
Select * from Employee;