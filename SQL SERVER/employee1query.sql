/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [EmpID]
      ,[EmpName]
      ,[SSN]
      ,[Salary]
      ,[DepID]
  FROM [EmployeeDB].[dbo].[Employee]