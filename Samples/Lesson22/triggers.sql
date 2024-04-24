use hw22
go

CREATE  TRIGGER penguins_Insert ON penguins AFTER INSERT
AS
BEGIN
	
	insert into penguins_history(id, species, island, bill_length_mm, bill_depth_mm, flipper_length_mm,  body_mass_g, sex, created_date, updated_date, status_record)
	select id, species, island, bill_length_mm, bill_depth_mm, flipper_length_mm,  body_mass_g, sex, GETDATE(), NULL,  'Created'
	FROM inserted

	UPDATE penguins
	SET created_date = GETDATE()
	, status_record = 'Created'
	WHERE id = (Select id FROM inserted)

	
END

INSERT INTO penguins VALUES('Imperor1','Fire Earth',49.10000000000000142,48.69999999999999929,581.0,3750.0,'MALE', NULL, NULL, NULL);


select * from  penguins
	where species = 'Imperor1'

select * from penguins_history
	where id = 346

CREATE TRIGGER penguins_Update ON penguins AFTER UPDATE
AS
BEGIN
	
	insert into penguins_history(id, species, island, bill_length_mm, bill_depth_mm, flipper_length_mm,  body_mass_g, sex, created_date, updated_date, status_record)
	select id, species, island, bill_length_mm, bill_depth_mm, flipper_length_mm,  body_mass_g, sex, created_date, GETDATE(), 'Updated'
	FROM inserted
		
	UPDATE penguins
	SET updated_date = GETDATE()
	, status_record = 'Updated'
	WHERE id = (Select id FROM inserted)
	
END

update penguins
	set body_mass_g = 3750
	where id = 346

select * from  penguins
	where species = 'Imperor1'

select * from penguins_history
	where id = 346

CREATE TRIGGER penguins_Delete ON penguins AFTER DELETE
AS
BEGIN
	
	insert into penguins_history(id, species, island, bill_length_mm, bill_depth_mm, flipper_length_mm,  body_mass_g, sex, created_date, updated_date, status_record)
	select id, species, island, bill_length_mm, bill_depth_mm, flipper_length_mm,  body_mass_g, sex, created_date, GETDATE(), 'Delete'
	FROM deleted
		
END

delete from penguins
	where  id = 346

select * from  penguins
	where species = 'Imperor1'

select * from penguins_history
	where id = 346