CREATE TABLE Student (      
      id int PRIMARY KEY IDENTITY,     
      admission_no varchar(45) NOT NULL,  
      first_name varchar(45) NOT NULL,      
      last_name varchar(45) NOT NULL,  
      age int,  
      city varchar(25) NOT NULL      
    );

CREATE TABLE Fee (   
      admission_no varchar(45) NOT NULL,  
      course varchar(45) NOT NULL,      
      amount_paid int,    
    );

	 INSERT INTO Student (admission_no, first_name, last_name, age, city)       
    VALUES (3354,'Luisa', 'Evans', 13, 'Texas'),       
    (2135, 'Paul', 'Ward', 15, 'Alaska'),       
    (4321, 'Peter', 'Bennett', 14, 'California'),    
    (4213,'Carlos', 'Patterson', 17, 'New York'),       
    (5112, 'Rose', 'Huges', 16, 'Florida'),  
    (6113, 'Marielia', 'Simmons', 15, 'Arizona'),    
    (7555,'Antonio', 'Butler', 14, 'New York'),       
    (8345, 'Diego', 'Cox', 13, 'California');  
   
INSERT INTO Fee (admission_no, course, amount_paid)       
    VALUES (3354,'Java', 20000),       
    (7555, 'Android', 22000),       
    (4321, 'Python', 18000),    
    (8345,'SQL', 15000),       
    (5112, 'Machine Learning', 30000);  


	select * from student
	select * from Fee

	--Inner join cmd
	 SELECT Student.admission_no, Student.first_name, Student.last_name, Fee.course, Fee.amount_paid  
    FROM Student  
    INNER JOIN Fee  
    ON Student.admission_no = Fee.admission_no; 

	--Cross join cmd
	SELECT Student.admission_no, Student.first_name, 
    Student.last_name, Fee.course, Fee.amount_paid  
    FROM Student  
    CROSS JOIN Fee  
    
	 SELECT Student.admission_no, Student.first_name, Student.last_name, Fee.course, Fee.amount_paid  
    FROM Student  
    CROSS JOIN Fee  
    WHERE Student.admission_no = Fee.admission_no;

	--Left outer join cmd
	SELECT Student.admission_no, Student.first_name, Student.last_name, Fee.course, Fee.amount_paid  
    FROM Student  
    LEFT OUTER JOIN Fee  
    ON Student.admission_no = Fee.admission_no; 

	--right outer join cmd
	SELECT Student.admission_no, Student.first_name, Student.last_name, Fee.course, Fee.amount_paid  
    FROM Student  
    RIGHT OUTER JOIN Fee  
    ON Student.admission_no = Fee.admission_no;

	--Full outer join cmd
	SELECT Student.admission_no, Student.first_name, Student.last_name, Fee.course, Fee.amount_paid  
    FROM Student  
    FULL OUTER JOIN Fee  
    ON Student.admission_no = Fee.admission_no;

	--Self join cmd
	 SELECT S1.first_name, S2.last_name, S2.city  
    FROM Student S1, Student S2  
    WHERE S1.id <> S2.iD AND S1.city = S2.city  
    ORDER BY S2.city;

	create table customer(custid int, custname varchar(20), custstate varchar(20), custcity varchar(20))
	insert into customer values(1,'Pranjali','MH','Nagpur')
	insert into customer values(2,'Ravina','MH','Bhopal')
	insert into customer values(3,'Vaibhav','UP','Mumbai')
	insert into customer values(4,'Kundan','MP','Pune')
	insert into customer values(5,'Komal','AP','Nagpur')
	select * from customer

	SELECT S1.custname, S2.custstate, S2.custcity  
    FROM customer S1, customer S2  
    WHERE S1.custid <> S2.custiD AND S1.custcity = S2.custcity  
    ORDER BY S2.custcity;  

