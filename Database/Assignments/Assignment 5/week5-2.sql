-- Recovery
USE [master]
RESTORE DATABASE [Netflix] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\Netflix.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5
GO

-- Transaction