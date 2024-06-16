USE [mydb]
GO

/****** Объект: SqlProcedure [dbo].[GetDepartment] Дата скрипта: 16.06.2024 22:49:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetDepartment]
AS
	SELECT * FROM deps
