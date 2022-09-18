create table customer(id int primary key,first_name varchar(20),last_name varchar(20),
coursename varchar(20), city varchar(20),state varchar(20))

insert into customer values(1,'Pranjali','Bhute','dotnet','nagpur','Maharashtra')
insert into customer values(2,'Saanvi','Bhute','java','mumbai','Maharashtra')
insert into customer values(3,'Komal','Shende','dotnet','chandrapur','Maharashtra')
insert into customer values(4,'Vaibhav','Bhute','dotnet','nagpur','Maharashtra')
insert into customer values(5,'Pranjali','Shende','java','mumbai','Maharashtra')
select * from customer

select first_name,last_name from customer
order by first_name

select first_name,last_name from customer
order by first_name desc

select first_name,last_name from customer
order by last_name


select first_name,last_name from customer
order by last_name 

select first_name,last_name from customer
order by first_name,last_name

SELECT
    city,
    first_name
   FROM
    customer
ORDER BY
    city,
    first_name;

	SELECT
    city,
    first_name
   FROM
    customer
ORDER BY
    city desc

	SELECT
    city,
    first_name
   FROM
    customer
ORDER BY
    city desc,
	first_name asc;



select distinct first_name from customer



select * from customer where id=1
select * from customer where id>4
select * from customer where first_name='Pranjali'
select * from customer where city='nagpur'


select * from customer where first_name='Pranjali' and  city='nagpur'
select * from customer where first_name='Saanvi' and  last_name='Bhute'

select * from customer where id>3 and  first_name='Vaibhav'

select * from customer where first_name like '%Pranjali%'

select * from customer where first_name like 'a%t'