/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Movie Id]
      ,[Movie Name]
      ,[Movie Genre]
      ,[Movie Director]
      ,[Movie Length]
      ,[Languages]
      ,[Release Date]
  FROM [Movie].[dbo].[tbl_Movie]