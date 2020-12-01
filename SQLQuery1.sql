/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Theater Id]
      ,[Movie]
      ,[Show]
      ,[Ticket Type]
      ,[Persons]
      ,[Cost]
      ,[Payment _Type]
  FROM [BookingTicket].[dbo].[tbl_Booking]