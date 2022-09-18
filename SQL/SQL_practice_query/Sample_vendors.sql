CREATE TABLE vendor_groups (
    group_id INT IDENTITY PRIMARY KEY,
    group_name VARCHAR (100) NOT NULL
);

CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
);

select * from vendor_groups

insert into vendors(vendor_name,group_id) values('amit',123)
select * from vendors
DROP TABLE vendors;

select * from vendors

CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        CONSTRAINT fk_group FOREIGN KEY (group_id) 
        REFERENCES vendor_groups(group_id)
);

select * from vendor_groups

insert into vendors(vendor_name,group_id) values('amit',123)
insert into vendor_groups values('mkpits')
select * from vendor_groups
insert into vendors(vendor_name,group_id) values('amit',1)
select * from vendors

insert into vendors(vendor_name,group_id) values('arjun',2)

insert into vendor_groups values('niit')
select * from vendor_groups

insert into vendors(vendor_name,group_id) values('arjun',2)
select * from vendors

insert into vendors(vendor_name,group_id) values('arpita',2)
select * from vendors
select * from vendor_groups

select * from vendor_groups
delete from vendor_groups where group_id=2
insert into vendor_groups values('aptech')
select * from vendor_groups
select * from vendors
delete from vendor_groups where group_id=3

drop table vendors
CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        constraint fk1  foreign key(group_id)
        references vendor_groups(group_id)
        on delete no action
        
        )
insert into vendors values('amit',1)
delete from vendor_groups where group_id=1

