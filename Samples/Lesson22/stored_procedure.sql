use hw22
go

CREATE PROCEDURE GetAllPunguins AS
BEGIN
	SELECT * FROM penguins
END
Go

DECLARE	@return_value int

EXEC	@return_value = [dbo].[GetAllPunguins]

SELECT	'Return Value' = @return_value

GO

CREATE PROCEDURE GetPinguinById
	@id int
AS 
BEGIN
	SELECT * FROM penguins
		where id = @id
END

USE [hw22]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[GetPinguinById]
		@id = 1

SELECT	'Return Value' = @return_value

GO