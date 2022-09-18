CREATE TABLE student1
(rollNumber INT, 
name VARCHAR(30), 
class VARCHAR(30), 
section VARCHAR(1), 
mobile VARCHAR(10),
PRIMARY KEY (rollNumber, mobile));

insert into student1 values(1,'amit','dotnet','i','1234567890')
insert into student1 values(1,'amit','dotnet','i','1234567891')

select * from student1

create table order_items (order_id int ,
item_id int  ,product_id int, quantity int,
list_price int, discount int, primary key(order_id,item_id))

insert into order_items values(1,11,101,2,20,5)
insert into order_items values(1,12,102,2,20,5)
insert into order_items values(2,11,102,2,20,5)
select * from order_items

