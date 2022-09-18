create table orders(orderid int primary key,orddate date,custid int)
create table orderdetails(orderid int,product_name varchar(20),
quantity int,constraint fk1 foreign key (orderid)
references orders(orderid))

insert into orders values(1,'2022-9-7',101)
select * from orders
insert into orderdetails values(1,'mouse',5)
insert into orderdetails values(1,'keyboard',5)
select * from orderdetails

delete from orders where orderid=1

insert into orders values(2,'2022-9-7',102)
select * from orders
insert into orderdetails values(2,'mouse',2)
select * from orderdetails
delete from orders where orderid=2
delete from orderdetails where orderid=2
delete from orders where orderid=2

