create table Employee(EmpId int, EmpName varchar(15),EmpContact varchar(10),EmpEmail varchar(40), EmpDepartment varchar(20),Empcity varchar(15), Empsalary varchar(15))
insert into Employee values(1, 'Pranjali', 1234567891, 'bhutepranjali@gmail.com', 'Computer', 'Nagpur', 20000.00)
insert into Employee values(2, 'Vaibhav', 1234567892, 'bhutevaibhav@gmail.com', 'Account', 'Nagpur', 10000.00)
insert into Employee values(3, 'Saanvi', 1234567893, 'bhutesaanvi@gmail.com', 'Computer', 'Nagpur', 15000.00)
insert into Employee values(4, 'Nilam', 1234567894, 'bhutenilam@gmail.com', 'Management', 'Mumbai', 12000.00)
insert into Employee values(5, 'Aniket', 1234567895, 'bhuteaniket@gmail.com', 'Management', 'Mumbai', 25000.00)
insert into Employee values(6, 'Kundan', 1234567896, 'shendekundan@gmail.com', 'Account', 'Pune', 10000.00)
insert into Employee values(7, 'Ravina', 1234567897, 'shenderavina@gmail.com', 'Computer', 'Pune', 5000.00)
insert into Employee values(8, 'Komal', 1234567898, 'bhutekomal@gmail.com', 'Computer', 'Nagpur', 8000.00)
insert into Employee values(9, 'Ramesh', 1234567899, 'shenderamesh@gmail.com', 'Management', 'Warora', 11000.00)
insert into Employee values(10, 'Vijaya', 1234567789, 'shendevijaya@gmail.com', 'Account', 'Warora', 19000.00)
select * from Employee
select * from Employee

--table-valued function

create function f1()
returns table
as 
return (select * from Employee)

select * from f1()

create function Fun_EmployeeInformation()
returns table 
as
return(select * from Employee)

select * from Fun_EmployeeInformation()

--scalar function

create function Fun_JoinEmpColumnInfo
(@EmpContact nchar(15),
@EmpEmail nvarchar(50),
@EmpCity varchar(30)
)
returns nvarchar(100)
as
begin return(select @EmpContact+' '+@EmpEmail+' '+@EmpCity)
end

select * from create function Fun_JoinEmpColumnInfo
(@EmpContact nchar(15),
@EmpEmail nvarchar(50),
@EmpCity varchar(30)
)

select * from Fun_JoinEmpColumnInfo
(@EmpContact nvarchar(15),
@EmpEmail nvarchar(50),
@EmpCity varchar(30)
)


create function Fun_JoinEmpColumnInfo
(@EmpContact char(15),
@EmpEmail varchar(50),
@EmpCity varchar(30)
)
returns varchar(100)
as
begin return(select @EmpContact+' '+@EmpEmail+' '+@EmpCity)
end

create function Fun_JoinEmpColumnInfo
(@EmpContact char(15),
@EmpEmail varchar(50),
@EmpCity varchar(30)
)

create function Fun_JoinEmpColumnInfo1(@EmpContact char(15),
@EmpEmail varchar(50),
@EmpCity varchar(30)
)
returns varchar(100)
as
begin return(select @EmpContact+' '+@EmpEmail+' '+@EmpCity)
end

select dbo.Fun_JoinEmpColumnInfo1(EmpContact,EmpEmail,EmpCity)as Details from Employee

create function Fun_Emp(@EmpContact varchar(50),  
       @EmpName varchar(50),  
       @EmpCity varchar(50)  
    )  
    returns varchar(150)  
    as  
    begin return(select @EmpContact+ ' ' +@EmpName + ' ' + @EmpCity)  
    end 

	select dbo.Fun_Emp(empcontact, empname, empcity) as 'Details' from Employee

	create function Fun_Emp1(@EmpContact varchar(50),  
       @EmpName varchar(50),  
       @EmpCity varchar(50)  
    )  
    returns varchar(150)  
    as  
    begin return(select @EmpContact+ '  ' +@EmpName + '  ' + @EmpCity)  
    end 

	select dbo.Fun_Emp1(empcontact, empname, empcity) as 'Details' from Employee

	select max(Empsalary) as Salary from Employee

	select min(salary) as Salary from Employee  

	select min(Empsalary) as Salary from Employee  