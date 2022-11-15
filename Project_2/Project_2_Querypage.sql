create table Item_master(Item_Id int primary key,Item_Name varchar(50),Category varchar(50),Rate decimal,Balance_Quantity int)
select * from Item_master

create table Department_mast(Department_Id int primary key,Department_Name varchar(50))
select * from Department_mast

create table Vendor_mast(Vendor_Id int primary key,Vendor_Name varchar(50))
select * from Vendor_mast

create table Transactions(Transaction_Id int primary key,Item_Id int,Transaction_Date datetime not null,
                         Department_Id int,Vendor_Id int, Quantity int not null,
						 constraint FK1 foreign key(Item_Id) references Item_master(Item_Id), 
						 constraint FK2 foreign key(Department_Id) references Department_mast(Department_Id), 
						 constraint FK3 foreign key(Vendor_Id) references Vendor_mast(Vendor_Id))

create table Users_Details(Id int identity,username varchar(50),password varchar(50))




select * from Item_master
select * from Department_mast
select * from Vendor_mast
select * from Transactions

select * from Users_Details

insert into Users_Details values('Pranjali','pranjali')


truncate table Users_Details