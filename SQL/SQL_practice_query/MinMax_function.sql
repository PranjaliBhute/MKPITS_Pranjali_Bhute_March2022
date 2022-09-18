create table product(productid int, productname varchar(20), price int, quantity int)
insert into product values(1, 'Pen', 10, 2)
insert into product values(2, 'Boll', 15, 2)
insert into product values(3, 'Notebook', 100, 4)
--max func cmd
SELECT productid,productname, quantity, price  
    FROM product  
    WHERE price = (  
    SELECT Max(price) AS "Minimum Quantity"   
    FROM product)

	select * from product

	SELECT productname, MIN(price) AS "Minimum price"   
    FROM product 
    GROUP BY productname  
    HAVING MIN(price)>15;

	create table fees(rno int, fdate date,amount int)
insert into fees values(1,'2002-2-2',1200),
(1,'2002-3-2',1300),(1,'2002-2-4',1200),(2,'2002-2-2',100),
(2,'2002-2-3',1200)

select * from fees
select rno,sum(amount) from fees
group by rno

select * from product
select count(price) as 'total' from product

select count(price) as 'total' from product 
where productname ='pen'

select productname,count(price) as 'total' from product
group by productname

--subquery

create table orders (orderid int , custid int, orderdate date,
productname varchar(20),qty int)

exec sp_help customer
create table orders (orderid int , custid int, orderdate date,
productname varchar(20),qty int)
insert into orders values(1,1,'2022-2-2','mouse',5)
insert into orders values(1,1,'2022-2-2','keyboard',5)
insert into orders values(2,2,'2022-2-2','desktop',5)
insert into orders values(2,2,'2022-2-2','ram',5)
insert into orders values(3,3,'2022-2-2','laptop',5)
insert into orders values(4,3,'2022-1-2','mouse',5)
insert into orders values(5,4,'2022-2-2','mouse',5)
insert into orders values(6,4,'2022-2-2','ram',5)
insert into orders values(7,5,'2022-2-2','desktop',5)
insert into orders values(7,5,'2022-2-2','ram',5)
select * from orders


create table customer(custid int, custname varchar(20), custaddress varchar(40))
insert into customer values(1, 'Saanvi', 'Pratap nagar')
insert into customer values(2, 'Pranjali', 'Bajaj nagar')
insert into customer values(3, 'Komal', 'Ravi nagar')
insert into customer values(4, 'Pranjal', 'Bajaj nagar')
insert into customer values(5, 'Vaibhav', 'Laxmi nagar')
insert into customer values(6, 'Ravina', 'Chatrapati nagar')
insert into customer values(7, 'Kundan', 'Bajaj nagar')
insert into customer values(8, 'Aniket', 'Pratap nagar')
insert into customer values(9, 'Nilam', 'Ravi nagar')
insert into customer values(10, 'Vaibhav', 'Pratap nagar')
select * from customer

select custid from customer where custaddress='Pratap nagar'
select * from orders

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where custaddress='Pratap nagar')

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where custaddress='Ravi nagar')

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where custaddress='Bajaj nagar')

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where custaddress='Laxmi nagar')
order by orderdate desc


--view

create view p1 
as select * from product 
where price > 250 

select * from p1

