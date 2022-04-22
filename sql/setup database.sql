create database PourDecisionDb;

create table PourDecisionDb.Categories
(
    Id int PRIMARY KEY identity (1,1),
    AlcType varchar (100) not null
);

create table PourDecisionDb.Products
(
    Id int PRIMARY key identity (1,1),
    Category int FOREIGN key references Categories(Id),
    Name varchar (100) not null,
    Price decimal not null
);

create table PourDecisionDb.Orders
(
    Id int primary key identity (1,1),
    ProductId int foreign key references Products(Id)
);