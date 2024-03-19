-- Создайте функцию, которая принимает кол-во сек и формат их в кол-во дней часов. Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds '

DROP PROCEDURE IF EXISTS counter;
DELIMITER $$
CREATE PROCEDURE counter (param INT)
BEGIN
	DECLARE temp INT DEFAULT 0;
	DECLARE days INT DEFAULT 0;
    DECLARE hours INT DEFAULT 0;
    DECLARE minutes INT DEFAULT 0;
    DECLARE seconds INT DEFAULT 0;
    SET days = param / 86400;
    SET temp = param % (days * 86400);
    SET hours = temp / 3600;
    SET temp = temp % (hours * 3600);
    SET minutes = temp / 60;
    SET temp = temp % (minutes * 60);
    SET seconds = temp / 60;
    SELECT days, hours, minutes, seconds;
END$$
DELIMITER ;

CALL counter(456943);