USE [hw21]
GO

SELECT distinct id
		,[species]
      , [island]
      ,[bill_length_mm]
      ,[bill_depth_mm]
      ,[flipper_length_mm]
      ,[body_mass_g]
      ,[sex]
  FROM [dbo].[penguins]
  -- WHERE island like 'Biscoe%'
  -- where species like '%d%'
  -- where island in ('Biscoe', 'Dream')
  -- where id between 10 and 20
  where island = 'Biscoe' OR species = 'Adelie'
  --ORDER BY sex DESC
  --OFFSET 2 ROWS
  --FETCH NEXT 10 ROWS only
GO

SELECT flipper_length_mm / 10.0 AS flipper_cm,
       body_mass_g / 1000.0 AS weight_kg,
       island AS where_found
FROM penguins

SELECT flipper_length_mm / 10.0 AS flipper_cm,
       body_mass_g / 1000.0 AS weight_kg,
       island AS where_found
FROM penguins


SELECT DISTINCT id
				,species,
                sex,
                island
FROM penguins
WHERE island = 'Biscoe'
  AND sex IS NULL;


SELECT MAX(bill_length_mm) AS longest_bill,
       MIN(flipper_length_mm) AS shortest_flipper,
       AVG(bill_length_mm) / AVG(bill_depth_mm) AS weird_ratio
FROM penguins;

SELECT COUNT(*) AS count_star,
       COUNT(sex) AS count_specific,
       COUNT(DISTINCT sex) AS count_distinct
FROM penguins;


SELECT AVG(body_mass_g) AS average_mass_g
FROM penguins
GROUP BY sex;

SELECT sex,
       AVG(body_mass_g) AS average_mass_g
FROM penguins
GROUP BY sex;


SELECT sex,
       AVG(body_mass_g) AS average_mass_g
FROM penguins
GROUP BY sex
HAVING AVG(body_mass_g) > 4000.0;


select p.*, lp.* from penguins p
	left join little_penguins lp on p.species = lp.species
	

select top 1 * from penguins p

INSERT INTO penguins VALUES('Imperor','Fire Earth',49.10000000000000142,48.69999999999999929,281.0,3750.0,'MALE');

select * from penguins p where species = 'Imperor'

update penguins
	set body_mass_g = 2750
	where id = 345

delete from penguins
	where  id = 345

alter table little_penguins
	add fatherId int, motherId int;

alter table little_penguins
	add constraint FK_FATHERID FOREIGN KEY(fatherId)
	REFErences penguins(id);

alter table little_penguins
	add constraint FK_motherID FOREIGN KEY(motherId)
	REFErences penguins(id);

select p.*, lp.* from penguins p
	-- left join little_penguins lp on p.id = lp.fatherId OR p.id = lp.motherId
	-- right join little_penguins lp on p.id = lp.fatherId OR p.id = lp.motherId
	full join little_penguins lp on p.id = lp.fatherId OR p.id = lp.motherId

delete from little_penguins
where id > 0

CREATE TABLE little_penguins_copy (
	id INT IDENTITY(1, 1), 
    species nvarchar(50),
    island nvarchar(50),
    bill_length_mm real,
    bill_depth_mm real,
    flipper_length_mm real,
    body_mass_g real,
    sex nvarchar(max),
	PRIMARY KEY (id) 
);

select * into little_penguins_copy from little_penguins 

select * into #little_penguins_temp from little_penguins 

drop table little_penguins_copy

select * from #little_penguins_temp

create database for_drop

drop database for_drop