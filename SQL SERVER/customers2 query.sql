/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [CustomerID]
      ,[Name]
      ,[Address]
      ,[Country]
      ,[CompanyName]
  FROM [CustomerInfoDB].[dbo].[Customers]