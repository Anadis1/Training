USE HumanFriends;
DELETE FROM Animal WHERE view_id = 2;

CREATE TABLE HorseDonkey AS
SELECT * from Animal WHERE view_id = 1
UNION
SELECT * from Animal WHERE view_id = 3;