create table student(rno int primary key,sname varchar(20),
coursename varchar(20), city varchar(20))

insert into student values(1,'rohit','dotnet','nagpur')
insert into student values(2,'roshan','aspdotnet','mumbai')
insert into student values(3,'pranjali','java','warora')
insert into student values(4,'saanvi','python','chandrapur')

select * from student
select * from student where rno in (1,3,5)

