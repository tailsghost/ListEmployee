USE [mydb]
GO

/****** Объект: SqlProcedure [dbo].[GetPosition] Дата скрипта: 16.06.2024 22:50:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetPosition]
AS
	SELECT * FROM posts
