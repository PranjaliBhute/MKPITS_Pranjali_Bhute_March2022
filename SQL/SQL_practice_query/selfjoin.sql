create table sales_staffs(staff_id int ,first_name varchar(20), last_name varchar(20),phone varchar(20),email varchar(50),active int,store_id int,manager_id int)
insert into sales_staffs values(1, 'Pranjali','Bhute', 1234567891, 'bhutepranjali@gmail.com',1,1,NULL)
insert into sales_staffs values(2, 'Vaibhav','Bhute', 1234567892, 'bhutevaibhav@gmail.com',1,1,1)
insert into sales_staffs values(3, 'Saanvi','Bhute', 1234567893, 'bhutesaanvi@gmail.com',1,1,2)
insert into sales_staffs values(4, 'Nilam','Bhute', 1234567894, 'bhutenilam@gmail.com',1,1,2)
insert into sales_staffs values(5, 'Aniket','Bhute', 1234567895, 'bhuteaniket@gmail.com',1,1,2)
insert into sales_staffs values(6, 'Kundan','Shende', 1234567896, 'shendekundan@gmail.com',1,2,1)
insert into sales_staffs values(7, 'Ravina','Shende', 1234567897, 'shenderavina@gmail.com',1,2,5)
insert into sales_staffs values(8, 'Komal','Shende', 1234567898, 'bhutekomal@gmail.com',1,2,5)
insert into sales_staffs values(9, 'Ramesh','Shende', 1234567899, 'shenderamesh@gmail.com',1,3,7)
insert into sales_staffs values(10, 'Vijaya','Shende', 1234567789, 'shendevijaya@gmail.com',1,3,7)

SELECT
    e.first_name + ' ' + e.last_name employee,
    m.first_name + ' ' + m.last_name manager
FROM
    sales_staffs e
INNER JOIN sales_staffs m ON m.staff_id = e.manager_id
ORDER BY
    manager;



	SELECT
    e.first_name + ' ' + e.last_name employee,
    m.first_name + ' ' + m.last_name manager
FROM
    sales_staffs e
LEFT JOIN sales_staffs m ON m.staff_id = e.manager_id
ORDER BY
    manager;


