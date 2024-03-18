-- Выведите только четные числа от 1 до 10. Пример: 2,4,6,8,10

DROP PROCEDURE IF EXISTS counter;
DELIMITER $$
CREATE PROCEDURE counter (n INT)
BEGIN
	DECLARE i VARCHAR(20) DEFAULT '';
    DECLARE ind INT DEFAULT 0;
	WHILE (ind < n - 1) DO
		SET ind = ind + 2;
		SET i = CONCAT(i, ' ', ind) ;
	END WHILE;
    SELECT i;
END$$
DELIMITER ;

CALL counter(10);