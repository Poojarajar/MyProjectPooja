create database employeedb

use employeedb

create table employee(employeeid int primary key, 
firstname varchar,
lastname varchar,
email varchar, 
street varchar,
city varchar, 
states varchar,
postalcode varchar);

alter table employee add addressid int

drop table employee


---create employee and addresses table
create table Addresses(AddressID int primary key,
Street varchar,
City varchar,
States varchar,
PostalCode varchar);


create table employee(EmployeeID int primary key,
FirstName varchar,
LastName varchar,
Email varchar,
AddressID varchar);


---StorePrcedure
create procedure [dbo].[CreateEmployeeWithAddress]
@firstname varchar(100),
@lastname varchar(100),
@email varchar(100),
@street varchar(255),
@city varchar(100),
@states varchar(100),
@postalcode varchar(20)
as
begin
declare @addressid int;

--Insert into address table and get the addressid
insert into Addresses(Street, City, States,PostalCode)
values(@Street,@City,@States,@PostalCode);
SET @AddressID = SCOPE_IDENTITY();

--Insert into employee table with new addressid
insert into Employee(FirstName, LastName, Email, AddressID)
values (@FirstName, @LastName, @Email, @AddressID)
end


--storeProcedure-2

Create procedure [dbo].[DeleteEmployee]
@EmployeeID int 
as
begin
declare @AddressID int;
--start transaction
begin transaction
 --get the addressid for rollback purposes
 select @AddressID = AddressID from Employee where EmployeeID = @EmployeeID;
 --Delete the employee recode
 delete from Employee where EmployeeID = @EmployeeId;
 --Delete the address recode
 delete from Addresses where AddressID = @AddressID;
 --Commit transaction
 COMMIT Transaction
 End;
 go


 ---Storeprocedure3

 Create procedure [dbo].[GetAllEmployees]
 as
 begin
 select e.EmployeeID, e.FirstName, e.LastName, e.Email, a.Street, a.City, a.States, a.PostalCode
 from Employee e
 Inner join Addresses a On e.AddressID = a.AddressID;
 END;
 go


 --storeProcedure4

 Create Procedure[dbo].[GetEmployeeByID]
 @EmployeeID int
 as begin 
 select e.EmployeeID, e.FirstName, e.LastName, e.Email, a.Street, a.City, a.States, a.PostalCode
 from Employee e
 Inner join Addresses a On e.AddressID = a.AddressID
 where e.EmployeeID = @EmployeeID
 END;
 go


 Create Procedure [dbo].[UpdateEmployeeWithAddress]
 @EmployeeID int,
 @FirstName varchar(100),
 @LastName varchar(100),
 @Email varchar(100),
 @Street varchar(255),
 @City varchar(100),
 @States varchar(100),
 @PostalCode varchar(20),
 @AddressID int
 as 
 begin

 ---Update address table

 Update Addresses
 Set Street = @Street, city= @City, states = @States, PostalCode = @PostalCode
 Where AddressID = @AddressID;

 --update Employee table

 Update Employee
 Set FirstName = @FirstName, LastName = @LastName, Email = @Email, AddressID = @AddressID
 Where EmployeeID = @EmployeeID;
 END;
 Go