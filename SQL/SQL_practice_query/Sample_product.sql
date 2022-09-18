create table product(productid int, productname varchar(20), price int, quantity int)
insert into product values(1, 'Pen', 10, 2)
insert into product values(2, 'Boll', 15, 2)
insert into product values(3, 'Notebook', 100, 4)

select * from product

SELECT TOP 2
    productname, 
    price
FROM
    product
ORDER BY 
    price DESC;

SELECT TOP 50 PERCENT
    productname, 
    price
FROM
    product
ORDER BY 
    price DESC;

