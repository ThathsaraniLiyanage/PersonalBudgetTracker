CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	date_create DATE NULL,
)

SELECT * FROM users

--CREATE TABLE categories(
--	id INT PRIMARY KEY IDENTITY(1,1),
--	category VARCHAR(MAX) NULL,
--	type VARCHAR(MAX) NULL,
--	status VARCHAR(MAX) NULL,
--	date_insert DATE null
--)

CREATE TABLE categories (
    id INT PRIMARY KEY,
    category NVARCHAR(100),
    type NVARCHAR(50),
    status NVARCHAR(50)
);


SELECT * FROM catergories

SELECT * FROM categories

SELECT *
FROM information_schema.tables
WHERE table_name = 'categories';


--INSERT INTO categories(category, type, status, date_insert)VALUES('defr', 1, 0, '2024-06-21')
--INSERT INTO categories(category, type, status, date_insert)VALUES('deddee', 1, 0, '2014-06-21')
select DB_NAME() AS DatabaseName

 --DELETE FROM categories WHERE id = 2;

 CREATE TABLE income(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	item VARCHAR(MAX) NULL,
	income NVARCHAR NULL,
	description TEXT NULL,
	date_income	DATE NULL,
	date_insert	DATE NULL
	)

	SELECT * FROM income
	select DB_NAME() AS DatabaseName

	CREATE TABLE expenses(
		id INT PRIMARY KEY IDENTITY(1,1),
		category VARCHAR(MAX) NULL,
		item VARCHAR(MAX) NULL,
		cost FLOAT NULL,
		description VARCHAR(MAX) NULL,
		date_expense DATE NULL,
		date_insert DATE NULL
	)

	SELECT * FROM expenses