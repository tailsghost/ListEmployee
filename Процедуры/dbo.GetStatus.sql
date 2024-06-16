USE [mydb]
GO

/****** Объект: SqlProcedure [dbo].[GetStatus] Дата скрипта: 16.06.2024 22:50:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetStatus]
AS
	SELECT * FROM status
