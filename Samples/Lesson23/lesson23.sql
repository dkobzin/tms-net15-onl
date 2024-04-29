create view GetAllPenguins
as

select * from penguins
UNION 
select * from little_penguins

create view GetJoinPenguinsByIsland
as

select p.*, lp.id as lp_id from penguins p
	join little_penguins lp on lp.island = p.island
	

create view GetSexWithAvgFlipperLength
as

select sex, avg(flipper_length_mm) as avg_flipper_length_mm
from penguins
group by sex

create unique clustered index ind_clustered_id on penguins(id); 

create index ind_species_island on penguins(species, island);

select * from penguins
	where species is not null and island is not null

delete from penguins
where 1=1;

select * from penguins

create procedure GetPenguinsByStatus
	@status_record nvarchar(25)
as
begin
	select * from penguins
		where status_record = @status_record
end

create procedure UpdateStatusRecord
	@from_status_record nvarchar(25),
	@to_status_record nvarchar(25)
as
begin
	
	begin transaction

	begin try
		

		 update penguins
			set created_date = (
				case 
					when @from_status_record = 'Delete' then getdate()
					else NULL
					end
				),
			updated_date = (
				case 
					when @from_status_record = 'Delete' then getdate()
					else NULL
					end
				),
			status_record = 
				(
				case 
					when @to_status_record = 'Delete' then ''
					else @to_status_record
					end
			)
			where status_record = @from_status_record
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch

end


CREATE TRIGGER [dbo].[penguins_Delete_INSTEAD] ON [dbo].[penguins] INSTEAD OF DELETE
AS
BEGIN
	
	select id into #ids from deleted
	
	UPDATE penguins
	SET updated_date = GETDATE()
	, status_record = 'Delete'
	WHERE id in (select id from #ids)
	
		
END
GO

ALTER TABLE [dbo].[penguins] ENABLE TRIGGER [penguins_Delete_INSTEAD]
GO
