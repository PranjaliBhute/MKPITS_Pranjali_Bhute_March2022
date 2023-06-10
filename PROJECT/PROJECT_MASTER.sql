create database PROJECT_MASTER

create table Category_Master(CategoryId int primary key, CategoryName varchar(50))

create table Product_Master(ProductId int primary key , ProductName varchar(50), CategoryId int ,
                            constraint FK_1 foreign key(CategoryId)references Category_Master(CategoryId))

drop table Category_master
drop table Product_Master

select * from Category_Master
select * from Product_Master

truncate table Category_Master