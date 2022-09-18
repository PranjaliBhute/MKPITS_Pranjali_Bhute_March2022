--Creating a simple stored procedure

create table product(product_name varchar(20),list_price varchar(20))
insert into product values('Pen',20)
insert into product values('Bat',500)
insert into product values('PenDrive',800)
insert into product values('Mobile',20000)
insert into product values('NoteBook',200)
select * from product

SELECT 
	product_name, 
	list_price
FROM 
	product
ORDER BY 
	product_name;

create procedure prod1
as 
begin
select * from product
end;

exec prod1


CREATE PROCEDURE uspProductList
AS
BEGIN
    SELECT 
        product_name, 
        list_price
    FROM 
        product
    ORDER BY 
        product_name;
END;

--Executing a stored procedure

EXECUTE sp_name;

EXEC uspProductList;

--Modifying a stored procedure

alter procedure prod2
as
begin
select product_name,list_price from product
order by list_price
end;

alter procedure prod1
as
begin
select product_name,list_price from product
order by list_price
end;
exec prod1;

ALTER PROCEDURE uspProductList
    AS
    BEGIN
        SELECT 
            product_name, 
            list_price
        FROM 
            product
        ORDER BY 
            list_price 
    END;

EXEC uspProductList;

--Deleting a stored procedure

DROP PROCEDURE uspProductList;

--Creating a stored procedure with one parameter

SELECT
    product_name,
    list_price
FROM 
    product
ORDER BY
    list_price;

	CREATE PROCEDURE uspFindProducts
AS
BEGIN
    SELECT
        product_name,
        list_price
    FROM 
        production.product
    ORDER BY
        list_price;
END;

create proc prod3(@minprice as decimal)
as
begin
select * from product
where list_price > @minprice
order by list_price
end;

exec prod3 120
exec prod3 220

create proc pp2(@pn as varchar(20))
as
begin 
select * from product
where product_name=@pn
end

exec pp2 'Bat'
exec pp2 'PenDrive'


create proc prod5(@pname as varchar(20))
as
begin
select * from product
where product_name = @pname
order by product_name
end;

exec prod5 'Mobile'
exec prod5 'Pen'

--stored proc with 2 parameters
create proc prod6(@pname as varchar(20),@p as decimal)
as
begin
select * from product
where product_name = @pname
and list_price >= @p
order by product_name
end;

exec prod6 'Pen',20
exec prod6 'PenDrive',800


--Creating a stored procedure with multiple parameters

create proc prod7(@minp as decimal,@maxp as decimal)
as
begin
select * from product
where list_price > @minp and list_price < @maxp
order by product_name
end;

exec prod7 20,800

create proc prod8(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from product
where list_price > @minp and list_price < @maxp
and product_name=@pn
order by product_name
end;

exec prod8 @minp=120,@maxp=500,@pn='NoteBook'




