use hw22
go

select id, species, island from penguins
-- where  species like '%Adelie%' and island like '%Torgersen%'
where  bill_length_mm > 10