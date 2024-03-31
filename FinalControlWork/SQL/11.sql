CREATE TABLE LittleAnimal AS
SELECT id, name, birthDate, 
datediff(curdate(),birthDate) DIV 31 as age, view_id 
from Animal
WHERE date_add(birthDate, INTERVAL 1 YEAR) < curdate() 
AND date_add(birthDate, INTERVAL 3 YEAR) > curdate();