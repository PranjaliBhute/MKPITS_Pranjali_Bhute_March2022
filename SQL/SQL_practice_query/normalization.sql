create table EMPLOYEE(EMP_ID INT,EMP_NAME VARCHAR(15),EMP_PHONE INT,EMP_STATE VARCHAR(15)) 
insert into EMPLOYEE values(1,'Pranjali',7755911644,'Maha')
insert into EMPLOYEE values(2,'Ravina',7755911641,'Maha')
Drop table EMPLOYEE

create table employee(emp_id int, emp_name varchar(20),emp_phone int,emp_state varchar(20))
insert into employee values(1,'Pranjali',7755911644,'MH')

create table teacher_detail (teacher_id int primary key,teacher_age
int)
create table teacher_subject(teacher_id int,subject varchar(20),
constraint t1 foreign key(teacher_id) references teacher_detail
(teacher_id))
insert into teacher_subject values(111,'chemistry')
insert into teacher_detail values(111,30)
insert into teacher_subject values(111,'chemistry')



drop table employee
create table EMPLOYEE(emp_id int primary key, emp_name varchar(20),emp_phone int,emp_state varchar(20))

create table teachers(teacher_id int primary key,teacher_name
varchar(20),country varchar(20),city varchar(20), state varchar(20))
insert into teachers values(1,'stephan','india','nagpur','mah')
insert into teachers values(2,'morris','india','nagpur','mah')
insert into teachers values(3,'daniel','india','nagpur','mah')
insert into teachers values(4,'fransis','india','mumbai','mah')
select * from teachers


insert into EMPLOYEE values(1,'Pranjali',7755911644,'MH')
drop table EMPLOYEE

create table EMPLOYEE(EMP_ID INT,EMP_NAME VARCHAR(20),EMP_PHONE VARCHAR(10),EMP_STATE VARCHAR(20))
insert into EMPLOYEE values(1,'Pranjali',7755911644,'MH')
insert into EMPLOYEE values(2,'Pranali',7755911641,'UP')
insert into EMPLOYEE values(3,'Vaibhav',7755911642,'MH')
insert into EMPLOYEE values(4,'Saanvi',7755911643,'MP')
insert into EMPLOYEE values(5,'Komal',7755911645,'MH')
insert into EMPLOYEE values(6,'Nilam',1155911644,'MH')
insert into EMPLOYEE values(7,'Aniket',7722911644,'MP')
insert into EMPLOYEE values(8,'Ravina',7755911744,'UP')
insert into EMPLOYEE values(9,'Vijaya',7755911622,'MH')
insert into EMPLOYEE values(10,'Ramesh',7766911644,'UP')
insert into EMPLOYEE values(11,'Kundan',7755914544,'MH')
select * from EMPLOYEE