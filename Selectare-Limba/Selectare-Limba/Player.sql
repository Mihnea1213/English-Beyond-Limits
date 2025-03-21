/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Nume]
      ,[Prenume]
      ,[Parola]
      ,[Email]
  FROM [tempdb].[dbo].[Player]