CREATE TABLE Products
(
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Price INT,
    Name NVARCHAR(20),
	Count Int
)

CREATE TABLE Categories
(
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Name NVARCHAR(20),
)

CREATE TABLE ProductCats
(
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    ProductId UNIQUEIDENTIFIER,
	CategoryId UNIQUEIDENTIFIER,
	FOREIGN KEY (ProductId)  REFERENCES Products (Id),
	FOREIGN KEY (CategoryId)  REFERENCES Categories (Id)
)
GO

insert into Products values (NEWID(), 50, 'Rye bread', 12),
(NEWID(), 55, 'Wheat bread', 10),
(NEWID(), 30, 'Bun', 12),
(NEWID(), 150, 'Herring', 12),
(NEWID(), 130, 'Mackerel', 12),
(NEWID(), 150, 'Chicken', 12),
(NEWID(), 400, 'Beef', 12),
(NEWID(), 200, 'Chicken fillet', 12),
(NEWID(), 70, 'Macaron', 12),
(NEWID(), 70, 'Gum', 12),
(NEWID(), 70, 'Apple juice', 12)


insert into Categories values (NEWID(), 'Bread'),
(NEWID(), 'Meat'),
(NEWID(), 'Poultry meat'),
(NEWID(), 'Fish'),
(NEWID(), 'Bakery'),
(NEWID(), 'Flour')

insert into ProductCats values 
(newId(),
(select Id from Products where Name = 'Rye bread'),
(select Id from Categories where Name = 'Bread'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Rye bread'),
(select Id from Categories where Name = 'Bakery'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Rye bread'),
(select Id from Categories where Name = 'Flour'))

insert into ProductCats values 
(newId(),
(select Id from Products where Name = 'Wheat bread'),
(select Id from Categories where Name = 'Bread'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Wheat bread'),
(select Id from Categories where Name = 'Bakery'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Wheat bread'),
(select Id from Categories where Name = 'Flour'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Macaron'),
(select Id from Categories where Name = 'Flour'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Bun'),
(select Id from Categories where Name = 'Flour'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Bun'),
(select Id from Categories where Name = 'Bakery'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Herring'),
(select Id from Categories where Name = 'Fish'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Mackerel'),
(select Id from Categories where Name = 'Fish'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Chicken'),
(select Id from Categories where Name = 'Meat'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Chicken'),
(select Id from Categories where Name = 'Poultry meat'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Beef'),
(select Id from Categories where Name = 'Meat'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Chicken fillet'),
(select Id from Categories where Name = 'Meat'))

insert into ProductCats values
(newId(), 
(select Id from Products where Name = 'Chicken fillet'),
(select Id from Categories where Name = 'Poultry meat'))