USE [mydb]
GO

/****** Объект: SqlProcedure [dbo].[getPersonalSort] Дата скрипта: 16.06.2024 22:49:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getPersonalSort]
	@SortColumn  nvarchar(30) = 'last_name',
	@SortDirection varchar(10) = '',
	@FilterStatus varchar(10) = '',
	@FilterDepartment varchar(10) = '',
	@FilterPosition varchar(10) = '',
	@FilterText varchar(100) = ''
AS 
	SELECT persons.id, 
			(last_name + SPACE(1) + SUBSTRING(first_name, 1, 1) + '.' + SPACE(1) + SUBSTRING(second_name, 1, 1) + '.') AS FullName,
			date_employ, date_uneploy,
			deps.name AS deps,
			status.name AS status,
			posts.name AS post
			FROM persons
			JOIN deps ON deps.id = persons.id_dep
			JOIN status ON status.id = persons.status
			JOIN posts ON posts.id = persons.id_post



			WHERE 
				(persons.status like (@FilterStatus  + '%') and persons.id_dep like (@FilterDepartment  + '%') and persons.id_post like (@FilterPosition  + '%') and lower(last_name) like lower(@FilterText + '%'))

			ORDER BY 
				CASE
					WHEN @SortDirection = 'ASC' and @SortColumn in ('first_name', 'second_name', 'last_name', 'deps', 'status', 'posts')
						THEN
							CASE @SortColumn
								WHEN 'last_name' THEN last_name
								WHEN 'deps' THEN deps.name
								WHEN 'status' THEN status.name
								WHEN 'posts' THEN posts.name
							END
				END ASC,
				CASE
					WHEN @SortDirection = 'ASC' and @SortColumn in ('date_employ', 'date_uneploy')
						THEN
							CASE @SortColumn
								WHEN 'date_employ' THEN date_employ
								WHEN 'date_uneploy' THEN date_uneploy
							END
				END ASC,
				CASE
					WHEN @SortDirection = 'DESC' and @SortColumn in ('first_name', 'second_name', 'last_name', 'deps', 'status', 'posts')
						THEN
							CASE @SortColumn
								WHEN 'last_name' THEN last_name
								WHEN 'deps' THEN deps.name
								WHEN 'status' THEN status.name
								WHEN 'posts' THEN posts.name
							END
				END DESC,
				CASE
					WHEN @SortDirection = 'DESC' and @SortColumn in ('date_employ', 'date_uneploy')
						THEN
							CASE @SortColumn
								WHEN 'date_employ' THEN date_employ
								WHEN 'date_uneploy' THEN date_uneploy
							END
				END DESC
