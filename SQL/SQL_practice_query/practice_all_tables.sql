CREATE TABLE quotations(quotation_no INT IDENTITY PRIMARY KEY,
valid_from DATE NOT NULL,
valid_to DATE NOT NULL);

ALTER TABLE quotations 
ADD description VARCHAR (255) NOT NULL;

--ALTER TABLE table_name 
--ALTER COLUMN column_name new_data_type(size);

CREATE TABLE t1(c INT);
INSERT INTO t1 values (1), (2),(3);
alter table t1 alter column c varchar(2);
select * from table t1

select * from table1

insert into table1 values(4)
select * from t1
insert into t1 values(4)
insert into t1 values('a')
select * from t1

insert into t1 values('@');

create table t2(c varchar(10));
insert into t2 values('SQL Server'), ('Modify'), ('Column')
alter table t2 alter column c varchar(50);
select * from t2




