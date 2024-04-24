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

ALTER PROCEDURE GetPinguinAvgByIsland
	@island nvarchar(50)
AS 
BEGIN
	drop table #temp
	
	SELECT species, island, bill_length_mm, bill_depth_mm, flipper_length_mm, body_mass_g into #temp FROM penguins
		where island = @island
	
	insert into #temp 
		select NULL, @island, AVG(bill_length_mm), AVG(bill_depth_mm), AVG(flipper_length_mm), AVG(body_mass_g) from #temp

	select * from #temp
END

USE [hw22]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[GetPinguinAvgByIsland]
		@island = N'Torgersen'

SELECT	'Return Value' = @return_value

GO

create function GetAvgByIsland(@island nvarchar(50))
returns table 
as
return
(
	select @island as island, AVG(bill_length_mm) as avg_bill_length, AVG(bill_depth_mm) as avg_bill_depth, AVG(flipper_length_mm) as avg_flipper_length, AVG(body_mass_g) as avg_body_mass from penguins
)

select * from GetAvgByIsland('Torgersen')