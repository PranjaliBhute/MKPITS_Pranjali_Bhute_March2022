create table mkp(id int primary key,sname varchar(20),
coursename varchar(20), city varchar(20))

insert into mkp values(1,'rohit','dotnet','nagpur')
insert into mkp values(2,'roshan','aspdotnet','mumbai')
insert into mkp values(3,'pranjali','java','warora')
insert into mkp values(4,'saanvi','python','chandrapur')
select * from mkp

select coursename,count(*) from mkp
where city='nagpur'
group by coursename

create table student(studid int primary key,studname varchar(20),
coursename varchar(20), city varchar(20),state varchar(20))

insert into student values(1,'Pranjali','dotnet','nagpur','Maharashtra')
insert into student values(2,'Saanvi','java','mumbai','Maharashtra')
insert into student values(3,'Komal','dotnet','chandrapur','Maharashtra')
insert into student values(4,'Vaibhav','dotnet','nagpur','Maharashtra')
insert into student values(5,'Pranjali','java','mumbai','Maharashtra')


select * from student
select city,COUNT(*) from student
where state = 'Maharashtra'
group by city

select city,COUNT(*) from student
where state = 'Maharashtra'
group by city
having COUNT(*) > 2
select * from student

select city,COUNT(*) from student
where state = 'Maharashtra'
group by city
having COUNT(*) > 1
