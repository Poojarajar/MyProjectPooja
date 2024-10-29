create database employeedb
use employeedb
create table employee(employeeid int  primary key,
first_name  varchar ,
last_name varchar,
email varchar,
addressid int);

alter table employee add addressid int
drop table employee
create table addresses(addressid int primary key,
street varchar,
city varchar,
states varchar,
postalcode varchar);


create procedure 
[dbo].[createemployeewithaddress]
@first_name varchar(100),
@last_name varchar(100),
@email varchar(100),
@street varchar(255),
@city varchar(100),
@states varchar(100),
@postalcode varchar(20)
as
begin
declare @addressid int;

insert into addresses(street,city,states,postalcode)
values(@street,@city,@states,@postalcode);
set @addressid=SCOPE_IDENTITY();

insert into employee(first_name,last_name,email,addressid)
values(@first_name,@last_name,@email,@addressid);
end;

create procedure [dbo].[deleteemployee]
@employeeid int
as begin
declare @addressid int;
begin transaction;
select @addressid=addressid from employee where @employeeid=@employeeid;
delete from employee where employeeid=@employeeid;
delete from addresses where addressid=@addressid;
commit transaction;
end;

create procedure[dbo].[getallemployees]
as
begin
select e.employeeid,e.firstName,e.lastName,e.email,
a.street,a.city,a.states,a.postalcode
from employee e
inner join addresses a on e.addressid=a.addressid;
end;

create procedure [dbo].[getemployeebyid]
@employeeid int
as
begin
select e.employeeid,e.first_name,e.last_name,e.email,
a.street,a.city,a.states,a.postalcode
from employee e
inner join addresses a on e.addressid=a.addressid
where e.employeeid=@employeeid
end;

create procedure [dbo].[updateemployeewithaddress]
@employeeid int,
@first_name varchar(100),
@last_name varchar(100),
@email varchar(100),
@street varchar(255),
@city varchar(100),
@states varchar(100),
@postalcode varchar(20),
@addressid int
as
begin
update addresses
set street=@street,city=@city,states=@states,postalcode=@postalcode
where addressid=@addressid;
update employee
set first_name=@first_name,last_name=@last_name,email=@email,addressid=@addressid
where employeeid=@employeeid;
end;