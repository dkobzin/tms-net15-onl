use sample26
go

BEGIN TRANSACTION;
CREATE TABLE penguins (
    id int identity(1,1),
    species nvarchar(50),
    island nvarchar(50),
    bill_length_mm real,
    bill_depth_mm real,
    flipper_length_mm real,
    body_mass_g real,
    sex nvarchar(max),
    children_id int null,
    PRIMARY KEY (id)
);
INSERT INTO penguins VALUES('Adelie','Torgersen',39.10000000000000142,18.69999999999999929,181.0,3750.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',39.5,17.39999999999999857,186.0,3800.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',40.29999999999999715,18.0,195.0,3250.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',NULL,NULL,NULL,NULL,NULL, NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',36.70000000000000285,19.30000000000000071,193.0,3450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',39.29999999999999715,20.60000000000000143,190.0,3650.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',38.89999999999999858,17.80000000000000071,181.0,3625.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',39.20000000000000285,19.60000000000000143,195.0,4675.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',34.10000000000000142,18.10000000000000143,193.0,3475.0,NULL, NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',42.0,20.19999999999999929,190.0,4250.0,NULL, NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',37.79999999999999715,17.10000000000000143,186.0,3300.0,NULL, NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',37.79999999999999715,17.30000000000000071,180.0,3700.0,NULL, NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',41.10000000000000142,17.60000000000000143,182.0,3200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',38.60000000000000142,21.19999999999999929,191.0,3800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',34.60000000000000142,21.10000000000000143,198.0,4400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',36.60000000000000142,17.80000000000000071,185.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',38.70000000000000285,19.0,195.0,3450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',42.5,20.69999999999999929,197.0,4500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',34.39999999999999858,18.39999999999999857,184.0,3325.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',46.0,21.5,194.0,4200.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.79999999999999715,18.30000000000000071,174.0,3400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.70000000000000285,18.69999999999999929,180.0,3600.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',35.89999999999999858,19.19999999999999929,189.0,3800.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',38.20000000000000285,18.10000000000000143,185.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',38.79999999999999715,17.19999999999999929,180.0,3800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',35.29999999999999715,18.89999999999999857,187.0,3800.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',40.60000000000000142,18.60000000000000143,183.0,3550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',40.5,17.89999999999999857,187.0,3200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.89999999999999858,18.60000000000000143,172.0,3150.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',40.5,18.89999999999999857,180.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.5,16.69999999999999929,178.0,3250.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.20000000000000285,18.10000000000000143,178.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.5,17.80000000000000071,188.0,3300.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.89999999999999858,18.89999999999999857,184.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.39999999999999858,17.0,195.0,3325.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.20000000000000285,21.10000000000000143,196.0,4150.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',38.79999999999999715,20.0,190.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',42.20000000000000285,18.5,180.0,3550.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.60000000000000142,19.30000000000000071,181.0,3300.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.79999999999999715,19.10000000000000143,184.0,4650.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.5,18.0,182.0,3150.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.79999999999999715,18.39999999999999857,195.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.0,18.5,186.0,3100.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',44.10000000000000142,19.69999999999999929,196.0,4400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.0,16.89999999999999857,185.0,3000.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.60000000000000142,18.80000000000000071,190.0,4600.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',41.10000000000000142,19.0,182.0,3425.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.5,18.89999999999999857,179.0,2975.0,NULL, NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.0,17.89999999999999857,190.0,3450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',42.29999999999999715,21.19999999999999929,191.0,4150.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',39.60000000000000142,17.69999999999999929,186.0,3500.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',40.10000000000000142,18.89999999999999857,188.0,4300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',35.0,17.89999999999999857,190.0,3450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',42.0,19.5,200.0,4050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',34.5,18.10000000000000143,187.0,2900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',41.39999999999999858,18.60000000000000143,191.0,3700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',39.0,17.5,186.0,3550.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',40.60000000000000142,18.80000000000000071,193.0,3800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',36.5,16.60000000000000143,181.0,2850.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.60000000000000142,19.10000000000000143,194.0,3750.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',35.70000000000000285,16.89999999999999857,185.0,3150.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',41.29999999999999715,21.10000000000000143,195.0,4400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.60000000000000142,17.0,185.0,3600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',41.10000000000000142,18.19999999999999929,192.0,4050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',36.39999999999999858,17.10000000000000143,184.0,2850.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',41.60000000000000142,18.0,192.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',35.5,16.19999999999999929,195.0,3350.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',41.10000000000000142,19.10000000000000143,188.0,4100.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',35.89999999999999858,16.60000000000000143,190.0,3050.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',41.79999999999999715,19.39999999999999857,198.0,4450.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',33.5,19.0,190.0,3600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',39.70000000000000285,18.39999999999999857,190.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',39.60000000000000142,17.19999999999999929,196.0,3550.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',45.79999999999999715,18.89999999999999857,197.0,4150.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',35.5,17.5,190.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',42.79999999999999715,18.5,195.0,4250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',40.89999999999999858,16.80000000000000071,191.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',37.20000000000000285,19.39999999999999857,184.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',36.20000000000000285,16.10000000000000143,187.0,3550.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',42.10000000000000142,19.10000000000000143,195.0,4000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',34.60000000000000142,17.19999999999999929,189.0,3200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',42.89999999999999858,17.60000000000000143,196.0,4700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',36.70000000000000285,18.80000000000000071,187.0,3800.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',35.10000000000000142,19.39999999999999857,193.0,4200.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.29999999999999715,17.80000000000000071,191.0,3350.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',41.29999999999999715,20.30000000000000071,194.0,3550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.29999999999999715,19.5,190.0,3800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.89999999999999858,18.60000000000000143,189.0,3500.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',38.29999999999999715,19.19999999999999929,189.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',38.89999999999999858,18.80000000000000071,190.0,3600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',35.70000000000000285,18.0,202.0,3550.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',41.10000000000000142,18.10000000000000143,205.0,4300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',34.0,17.10000000000000143,185.0,3400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.60000000000000142,18.10000000000000143,186.0,4450.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.20000000000000285,17.30000000000000071,187.0,3300.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.79999999999999715,18.89999999999999857,208.0,4300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',38.10000000000000142,18.60000000000000143,190.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.29999999999999715,18.5,196.0,4350.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',33.10000000000000142,16.10000000000000143,178.0,2900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',43.20000000000000285,18.5,192.0,4100.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',35.0,17.89999999999999857,192.0,3725.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',41.0,20.0,203.0,4725.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.70000000000000285,16.0,183.0,3075.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.79999999999999715,20.0,190.0,4250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',37.89999999999999858,18.60000000000000143,193.0,2925.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',39.70000000000000285,18.89999999999999857,184.0,3550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',38.60000000000000142,17.19999999999999929,199.0,3750.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',38.20000000000000285,20.0,190.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',38.10000000000000142,17.0,181.0,3175.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',43.20000000000000285,19.0,197.0,4775.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',38.10000000000000142,16.5,198.0,3825.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',45.60000000000000142,20.30000000000000071,191.0,4600.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',39.70000000000000285,17.69999999999999929,193.0,3200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',42.20000000000000285,19.5,197.0,4275.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',39.60000000000000142,20.69999999999999929,191.0,3900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Biscoe',42.70000000000000285,18.30000000000000071,196.0,4075.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',38.60000000000000142,17.0,188.0,2900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',37.29999999999999715,20.5,199.0,3775.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',35.70000000000000285,17.0,189.0,3350.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',41.10000000000000142,18.60000000000000143,189.0,3325.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',36.20000000000000285,17.19999999999999929,187.0,3150.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',37.70000000000000285,19.80000000000000071,198.0,3500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',40.20000000000000285,17.0,176.0,3450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',41.39999999999999858,18.5,202.0,3875.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',35.20000000000000285,15.90000000000000035,186.0,3050.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',40.60000000000000142,19.0,199.0,4000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',38.79999999999999715,17.60000000000000143,191.0,3275.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',41.5,18.30000000000000071,195.0,4300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',39.0,17.10000000000000143,191.0,3050.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',44.10000000000000142,18.0,210.0,4000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',38.5,17.89999999999999857,190.0,3325.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Torgersen',43.10000000000000142,19.19999999999999929,197.0,3500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.79999999999999715,18.5,193.0,3500.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.5,18.5,199.0,4475.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',38.10000000000000142,17.60000000000000143,187.0,3425.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',41.10000000000000142,17.5,190.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',35.60000000000000142,17.5,191.0,3175.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.20000000000000285,20.10000000000000143,200.0,3975.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.0,16.5,185.0,3400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.70000000000000285,17.89999999999999857,193.0,4250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.20000000000000285,17.10000000000000143,193.0,3400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.60000000000000142,17.19999999999999929,187.0,3475.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',32.10000000000000142,15.5,188.0,3050.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',40.70000000000000285,17.0,190.0,3725.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.29999999999999715,16.80000000000000071,192.0,3000.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.0,18.69999999999999929,185.0,3650.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',39.20000000000000285,18.60000000000000143,190.0,4250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.60000000000000142,18.39999999999999857,184.0,3475.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.0,17.80000000000000071,195.0,3450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',37.79999999999999715,18.10000000000000143,193.0,3750.0,'MALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',36.0,17.10000000000000143,187.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Adelie','Dream',41.5,18.5,201.0,4000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.5,17.89999999999999857,192.0,3500.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.0,19.5,196.0,3900.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.29999999999999716,19.19999999999999929,193.0,3650.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.39999999999999858,18.69999999999999929,188.0,3525.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',52.70000000000000284,19.80000000000000071,197.0,3725.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.20000000000000285,17.80000000000000071,198.0,3950.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.10000000000000142,18.19999999999999929,178.0,3250.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.29999999999999716,18.19999999999999929,197.0,3750.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.0,18.89999999999999857,195.0,4150.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.29999999999999716,19.89999999999999857,198.0,3700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.60000000000000142,17.80000000000000071,193.0,3800.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.70000000000000284,20.30000000000000071,194.0,3775.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',47.0,17.30000000000000071,185.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',52.0,18.10000000000000143,201.0,4050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.89999999999999858,17.10000000000000143,190.0,3575.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.5,19.60000000000000143,201.0,4050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.29999999999999716,20.0,197.0,3300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',58.0,17.80000000000000071,181.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.39999999999999858,18.60000000000000143,190.0,3450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.20000000000000284,18.19999999999999929,195.0,4400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',42.39999999999999858,17.30000000000000071,181.0,3600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',48.5,17.5,191.0,3400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',43.20000000000000285,16.60000000000000143,187.0,2900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.60000000000000142,19.39999999999999857,193.0,3800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.70000000000000284,17.89999999999999857,195.0,3300.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',52.0,19.0,197.0,4150.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.5,18.39999999999999857,200.0,3400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.5,19.0,200.0,3800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.39999999999999858,17.80000000000000071,191.0,3700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',52.79999999999999716,20.0,205.0,4550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',40.89999999999999858,16.60000000000000143,187.0,3200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',54.20000000000000284,20.80000000000000071,201.0,4300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',42.5,16.69999999999999929,187.0,3350.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.0,18.80000000000000071,203.0,4100.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.70000000000000284,18.60000000000000143,195.0,3600.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',47.5,16.80000000000000071,199.0,3900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',47.60000000000000142,18.30000000000000071,195.0,3850.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',52.0,20.69999999999999929,210.0,4800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.89999999999999858,16.60000000000000143,192.0,2700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',53.5,19.89999999999999857,205.0,4500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.0,19.5,210.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.20000000000000284,17.5,187.0,3650.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.89999999999999858,19.10000000000000143,196.0,3550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.5,17.0,196.0,3500.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.89999999999999858,17.89999999999999857,196.0,3675.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.79999999999999716,18.5,201.0,4450.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.10000000000000142,17.89999999999999857,190.0,3400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.0,19.60000000000000143,212.0,4300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.5,18.69999999999999929,187.0,3250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.79999999999999716,17.30000000000000071,198.0,3675.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',48.10000000000000142,16.39999999999999857,199.0,3325.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.39999999999999858,19.0,201.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.70000000000000285,17.30000000000000071,193.0,3600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.70000000000000284,19.69999999999999929,203.0,4050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',42.5,17.30000000000000071,187.0,3350.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',52.20000000000000284,18.80000000000000071,197.0,3450.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.20000000000000285,16.60000000000000143,191.0,3250.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.29999999999999716,19.89999999999999857,203.0,4050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.20000000000000284,18.80000000000000071,202.0,3800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.60000000000000142,19.39999999999999857,194.0,3525.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',51.89999999999999858,19.5,206.0,3950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',46.79999999999999716,16.5,189.0,3650.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',45.70000000000000285,17.0,195.0,3650.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',55.79999999999999716,19.80000000000000071,207.0,4000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',43.5,18.10000000000000143,202.0,3400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',49.60000000000000142,18.19999999999999929,193.0,3775.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.79999999999999716,19.0,210.0,4100.0,'MALE', NULL);
INSERT INTO penguins VALUES('Chinstrap','Dream',50.20000000000000284,18.69999999999999929,198.0,3775.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.10000000000000142,13.19999999999999929,211.0,4500.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.0,16.30000000000000071,230.0,5700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.70000000000000284,14.09999999999999965,210.0,4450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.0,15.19999999999999929,218.0,5700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.60000000000000142,14.5,215.0,5400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.5,13.5,210.0,4550.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.39999999999999858,14.59999999999999965,211.0,4800.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.70000000000000284,15.30000000000000071,219.0,5200.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.29999999999999715,13.40000000000000035,209.0,4400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.79999999999999716,15.40000000000000035,215.0,5150.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',40.89999999999999858,13.69999999999999929,214.0,4650.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.0,16.10000000000000143,216.0,5550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.5,13.69999999999999929,214.0,4650.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.39999999999999858,14.59999999999999965,213.0,5850.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.79999999999999715,14.59999999999999965,210.0,4200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.29999999999999716,15.69999999999999929,217.0,5850.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',42.0,13.5,210.0,4150.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.20000000000000284,15.19999999999999929,221.0,6300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.20000000000000284,14.5,209.0,4800.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.70000000000000284,15.09999999999999965,222.0,5350.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.20000000000000284,14.30000000000000071,218.0,5700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.10000000000000142,14.5,215.0,5000.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.5,14.5,213.0,4400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.29999999999999716,15.80000000000000071,215.0,5050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',42.89999999999999858,13.09999999999999965,215.0,5000.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.10000000000000142,15.09999999999999965,215.0,5100.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',44.5,14.30000000000000071,216.0,4100.0,NULL, NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.79999999999999716,15.0,215.0,5650.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.20000000000000284,14.30000000000000071,210.0,4600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.0,15.30000000000000071,220.0,5550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.29999999999999716,15.30000000000000071,222.0,5250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',42.79999999999999715,14.19999999999999929,209.0,4700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.10000000000000142,14.5,207.0,5050.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',59.60000000000000142,17.0,230.0,6050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.10000000000000142,14.80000000000000071,220.0,5150.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.39999999999999858,16.30000000000000071,220.0,5400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',42.60000000000000142,13.69999999999999929,213.0,4950.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',44.39999999999999858,17.30000000000000071,219.0,5250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',44.0,13.59999999999999965,208.0,4350.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.70000000000000284,15.69999999999999929,208.0,5350.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',42.70000000000000285,13.69999999999999929,208.0,3950.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.60000000000000142,16.0,225.0,5700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.29999999999999715,13.69999999999999929,210.0,4300.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.60000000000000142,15.0,216.0,4750.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.5,15.90000000000000035,222.0,5550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.60000000000000142,13.90000000000000035,217.0,4900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.5,13.90000000000000035,210.0,4200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.5,15.90000000000000035,225.0,5400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',44.89999999999999858,13.30000000000000071,213.0,5100.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.20000000000000285,15.80000000000000071,215.0,5300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.60000000000000142,14.19999999999999929,210.0,4850.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.5,14.09999999999999965,220.0,5300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.10000000000000142,14.40000000000000035,210.0,4400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.10000000000000142,15.0,225.0,5000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.5,14.40000000000000035,217.0,4900.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.0,15.40000000000000035,220.0,5050.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.79999999999999715,13.90000000000000035,208.0,4300.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.5,15.0,220.0,5000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.20000000000000285,14.5,208.0,4450.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.39999999999999858,15.30000000000000071,224.0,5550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.29999999999999715,13.80000000000000071,208.0,4200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.20000000000000284,14.90000000000000035,221.0,5300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.70000000000000285,13.90000000000000035,214.0,4400.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',54.29999999999999716,15.69999999999999929,231.0,5650.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.79999999999999715,14.19999999999999929,219.0,4700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.79999999999999716,16.80000000000000071,230.0,5700.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.20000000000000284,14.40000000000000035,214.0,4650.0,NULL, NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.5,16.19999999999999929,229.0,5800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.5,14.19999999999999929,220.0,4700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.70000000000000284,15.0,223.0,5550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.70000000000000284,15.0,216.0,4750.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.39999999999999858,15.59999999999999965,221.0,5000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.20000000000000284,15.59999999999999965,221.0,5100.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.5,14.80000000000000071,217.0,5200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.39999999999999858,15.0,216.0,4700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.60000000000000142,16.0,230.0,5800.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.5,14.19999999999999929,209.0,4600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',51.10000000000000142,16.30000000000000071,220.0,6000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.20000000000000285,13.80000000000000071,215.0,4750.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.20000000000000285,16.39999999999999857,223.0,5950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.10000000000000142,14.5,212.0,4625.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',52.5,15.59999999999999965,221.0,5450.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.39999999999999858,14.59999999999999965,212.0,4725.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.0,15.90000000000000035,224.0,5350.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',44.89999999999999858,13.80000000000000071,212.0,4750.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.79999999999999716,17.30000000000000071,228.0,5600.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.39999999999999858,14.40000000000000035,218.0,4600.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',51.29999999999999716,14.19999999999999929,218.0,5300.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.5,14.0,212.0,4875.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',52.10000000000000142,17.0,230.0,5550.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.5,15.0,218.0,4950.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',52.20000000000000284,17.10000000000000143,228.0,5400.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.5,14.5,212.0,4750.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.5,16.10000000000000143,224.0,5650.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',44.5,14.69999999999999929,214.0,4850.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.79999999999999716,15.69999999999999929,226.0,5200.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.39999999999999858,15.80000000000000071,216.0,4925.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.89999999999999858,14.59999999999999965,222.0,4875.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.39999999999999858,14.40000000000000035,203.0,4625.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',51.10000000000000142,16.5,225.0,5250.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.5,15.0,219.0,4850.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',55.89999999999999858,17.0,228.0,5600.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.20000000000000284,15.5,215.0,4975.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.10000000000000142,15.0,228.0,5500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.29999999999999716,13.80000000000000071,216.0,4725.0,NULL, NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.79999999999999716,16.10000000000000143,215.0,5500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',41.70000000000000285,14.69999999999999929,210.0,4700.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',53.39999999999999858,15.80000000000000071,219.0,5500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.29999999999999715,14.0,208.0,4575.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.10000000000000142,15.09999999999999965,209.0,5500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.5,15.19999999999999929,216.0,5000.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.79999999999999716,15.90000000000000035,229.0,5950.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',43.5,15.19999999999999929,213.0,4650.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',51.5,16.30000000000000071,230.0,5500.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.20000000000000284,14.09999999999999965,217.0,4375.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',55.10000000000000142,16.0,230.0,5850.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',44.5,15.69999999999999929,217.0,4875.0,NULL, NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',48.79999999999999716,16.19999999999999929,222.0,6000.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',47.20000000000000284,13.69999999999999929,214.0,4925.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',NULL,NULL,NULL,NULL,NULL, NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',46.79999999999999716,14.30000000000000071,215.0,4850.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',50.39999999999999858,15.69999999999999929,222.0,5750.0,'MALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',45.20000000000000285,14.80000000000000071,212.0,5200.0,'FEMALE', NULL);
INSERT INTO penguins VALUES('Gentoo','Biscoe',49.89999999999999858,16.10000000000000143,213.0,5400.0,'MALE', NULL);
CREATE TABLE little_penguins (
                                 id int identity(1,1),
                                 species nvarchar(50),
                                 island nvarchar(50),
                                 bill_length_mm real,
                                 bill_depth_mm real,
                                 flipper_length_mm real,
                                 body_mass_g real,
                                 sex nvarchar(max),
                                 parent_id int null,
                                 primary key(id) 
);
INSERT INTO little_penguins VALUES('Gentoo','Biscoe',51.29999999999999716,14.19999999999999929,218.0,5300.0,'MALE', 1);
INSERT INTO little_penguins VALUES('Adelie','Dream',35.70000000000000285,18.0,202.0,3550.0,'FEMALE', 2);
INSERT INTO little_penguins VALUES('Adelie','Torgersen',36.60000000000000142,17.80000000000000071,185.0,3700.0,'FEMALE', 3);
INSERT INTO little_penguins VALUES('Chinstrap','Dream',55.79999999999999716,19.80000000000000071,207.0,4000.0,'MALE', 4);
INSERT INTO little_penguins VALUES('Adelie','Dream',38.10000000000000142,18.60000000000000143,190.0,3700.0,'FEMALE', 5);
INSERT INTO little_penguins VALUES('Adelie','Dream',36.20000000000000285,17.30000000000000071,187.0,3300.0,'FEMALE', 6);
INSERT INTO little_penguins VALUES('Adelie','Dream',39.5,17.80000000000000071,188.0,3300.0,'FEMALE', 7);
INSERT INTO little_penguins VALUES('Gentoo','Biscoe',42.60000000000000142,13.69999999999999929,213.0,4950.0,'FEMALE', 8);
INSERT INTO little_penguins VALUES('Gentoo','Biscoe',52.10000000000000142,17.0,230.0,5550.0,'MALE', 9);
INSERT INTO little_penguins VALUES('Adelie','Torgersen',36.70000000000000285,18.80000000000000071,187.0,3800.0,'FEMALE', 10);
COMMIT;
