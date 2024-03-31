CREATE TABLE Skill
(
    id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name varchar(30),
    description varchar(255)
);

CREATE TABLE Type
(
    id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name varchar(30)
);

CREATE TABLE View
(
    id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name varchar(30),
    group_id INT,
    FOREIGN KEY (group_id) REFERENCES Type (id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Animal
(
    id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name varchar(30),
    birthDate DATE,
    view_id INT,
    FOREIGN KEY (view_id) REFERENCES View (id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE AnimalSkill
(
    animal_id INT NOT NULL,
    skill_id INT NOT NULL,

    PRIMARY KEY (animal_id, skill_id),
    FOREIGN KEY (animal_id) REFERENCES Animal (id)
     ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (skill_id) REFERENCES Skill (id)
     ON DELETE CASCADE  ON UPDATE CASCADE
);