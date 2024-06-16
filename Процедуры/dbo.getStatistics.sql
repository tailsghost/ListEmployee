USE [mydb]
GO

/****** Объект: SqlProcedure [dbo].[getStatistics] Дата скрипта: 16.06.2024 22:50:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getStatistics]
@Status int,
@FromDate datetime,
@ToDate datetime
AS
BEGIN
DECLARE @statement NVARCHAR(MAX),
@function NVARCHAR(100)

IF (@Status = 2) -- Необходимо подставить ID для действующего сотрудника из таблицы status
SET @function = 'persons.date_employ'
ELSE IF (@Status = 1) -- Необходимо подставить ID для уволившегося сотрудника из таблицы status
SET @function = 'persons.date_uneploy'

SET @statement = N'
SELECT CONVERT(date, ' + @function + ') AS Date,
COUNT(*) AS row
FROM persons
JOIN status ON status.id = persons.status
WHERE
status.id = @Status AND 
((' + @function + ' >= @FromDate AND ' + @function + ' <= @ToDate OR ' + @function + ' IS NULL ))

GROUP BY ' + @function +''

EXEC sp_executesql @statement,
N'@Status varchar(100), @FromDate datetime, @ToDate datetime',
@Status, @FromDate, @ToDate
END
