create database StudentManagement;

use StudentManagement;

create table Student (
StudentID int primary key not null,
FirstName varchar(15) Not null,
LastName varchar(20) not null,
DOB date not null,
Email varchar(30) not null
);


Insert into Student( StudentID, FirstName, LastName, DOB, Email)
values
(1, 'Pooja', 'R', '2003/02/26', 'pooja@gmail.com'),
(2, 'Sowmiya', 'A', '2003/02/09', 'Sowmiya@gmail.com'),
(3, 'Shiny', 'star', '2002/09/25', 'shinystar@gmail.com'),
(4, 'Priya', 'P', '2002/12/09', 'priya@gmail.com');


