-------------Database creation-------------

create database Intern_DB
Go

use Intern_DB

------------Table Creation-----------------
create table Accounts
(
ID varchar(30) not null,
Pass varchar(15) not null,
F_Name varchar(15),
L_Name varchar(15),
Job_Code nchar(1), --should be not nulled later 
Age  int,
Gender char,
Account_Status binary,  --the status is used for banning and such 
Dep_No varchar(3)
)

create table Applicant_Intern
(
ID varchar(30) not null,
Grade_of_Entrance_Exam char,
College Varchar(30),
Years_of_Experience int,
Status_of_application char, --should be not nulled later
CV_Link varchar(50)
)

create table department
( 
Department_Number varchar(3) not null,
DepartmentName varchar(10) not null,
)

create table Course
( 
CourseID varchar(3) not null,
CourseName varchar(10),
Active_Status binary, --should be not nulled later
DepNo varchar(3) --should be not nulled later
)

create table Lectures
( 
LectureNo int,
LectureDay varchar(10), 
Course_ID varchar(3) not null ,  
LocationID varchar(10)  --should be not nulled later
)



create table Instructs
(
Instruct_ID  varchar(30) not null,
CourseID varchar(3) not null
)

create table Takes
(
App_ID  varchar(30) not null,
CourseID varchar(3), --should be not nulled later
Year_of_Intern varchar(4),  --should be not nulled later
Grade char
)

create table Locations
(
Branch_ID  varchar(4) not null, 
LocationName varchar(20) ,
Dep_No varchar(3) --should be not nulled later
)

-----------------Inserting values into Accounts----------------
insert into Accounts (ID,Pass)
values
('1','1')





--create table Department
--(
--Dname varchar(50),
--Dnumber int,
--primary key (Dnumber),
--Mgr_SSN int,
--Mgr_Start_Date date,
--Foreign key (Mgr_SSN) references Employee,
--)

--create table Dept_Locations
--(
--Dnumber int,
--Dlocation varchar(50),
--Primary key (Dnumber,Dlocation),
--foreign key (Dnumber) references Department,
--)

--create table Project
--(
--Pname varchar(50),
--Pnumber int,
--primary key(Pnumber),
--Plocation varchar(50),
--Dnum int,
--foreign key (Dnum) references Department
--)

--create table Works_On
--(
--Essn int,
--Pno int,
--primary key (Essn,Pno),
--Hours float,
--foreign key (Essn) references Employee,
--foreign key (Pno) references Project
--)
-------------inserting Employee Foreign key--------------
--alter table Employee add foreign key (DNO) references Department

-----------------Inserting values into tables----------------
--insert into Employee 
--values
--('John','B','Smith',123456789,'1965-09-11','731 Fondren, Houston, TX','M',30000,null,null),
--('Franklin','T','Wong',333445555,'1955-12-08','638 Voss, Houston, TX','M',40000,null,null),
--('Joyce','A','English',453453453,'1972-07-31','5631 Rice, Houston, T','F',25000,null,null),
--('Ramesh','K','Narayan',666884444,'1962-09-15','975 Fire Oak, Humble, TX','M',38000,null,null),
--('James','E','Borg',888665555,'1937-11-10','450 Stone, Houston, TX','M',55000,null,null),
--('Jennifer','S','Wallace',987654321,'1941-06-20','291 Berry, Bellaire, TX','F',43000,null,null),
--('Ahmad','V','Jabbar',987987987,'1969-03-29','980 Dallas, Houston, TX','M',25000,null,null),
--('Alicia','J','Zelaya',999887777,'1968-01-19','3321,Castle, Spring, TX','F',25000,null,null)

--insert into Department
--values
--('Headquarters',1,888665555,'1981-06-19'),
--('Administration',4,987654321,'1995-01-01'),
--('Research',5,333445555,'1988-05-22')

--insert into Dept_Locations
--values
--(1	,'Houston'),
--(4	,'Stafford'),
--(5	,'Bellaire'),
--(5	,'Houston'),
--(5	,'Sugarland')

--insert into Project
--values
--('ProductX',1,'Bellaire',5),
--('ProductY',2,'Sugarland',5),
--('ProductZ',3,'Houston',5),
--('Computerization',10,'Stafford',4),
--('Reorganization',20,'Houston',1),
--('Newbenefits',30,'Stafford',4)

--insert into Works_On
--values
--(123456789	,1	,32.5),
--(123456789	,2	,7.5),
--(666884444	,3	,40),
--(453453453	,1	,20),
--(453453453	,2	,20),
--(333445555	,2	,10),
--(333445555	,3	,10),
--(333445555	,10	,10),
--(333445555	,20	,10),
--(999887777	,10	,10),
--(999887777	,30	,30),
--(987987987	,10	,35),
--(987987987	,30	,5),
--(987654321	,30	,20),
--(987654321	,20	,15),
--(888665555	,20	,null)

--update Employee set Super_SSN = 333445555, Dno = 5	where SSN = 123456789
--update Employee set Super_SSN = 888665555, Dno = 5	where SSN = 333445555
--update Employee set Super_SSN = 333445555, Dno = 5	where SSN = 453453453
--update Employee set Super_SSN = 333445555, Dno = 5	where SSN = 666884444
--update Employee set Super_SSN = NULL, Dno = 1		where SSN = 888665555
--update Employee set Super_SSN = 888665555, Dno = 4	where SSN = 987654321
--update Employee set Super_SSN = 987654321, Dno = 4	where SSN = 987987987
--update Employee set Super_SSN = 987654321, Dno = 4	where SSN = 999887777
