USE [mydb]
GO

/****** Объект: SqlProcedure [dbo].[getStatisticsStatus] Дата скрипта: 16.06.2024 22:50:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getStatisticsStatus]
	@Status int = 1
AS
	SELECT persons.status,
	COUNT(*) AS row
	FROM persons
	WHERE
		persons.status = @Status
	GROUP BY persons.status
