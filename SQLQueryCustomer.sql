/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[Name]
      ,[Password]
      ,[Date of Birth]
      ,[Tickets]
      ,[Contact No]
  FROM [Customerdb].[dbo].[tbl_Customer]