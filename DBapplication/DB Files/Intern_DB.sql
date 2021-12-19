-------------Database creation-------------

create database Intern_DB
Go

use Intern_DB

------------Table Creation-----------------
create table Accounts
(
ID SMALLINT not null,
UserName varchar(20),
Pass varchar(30) not null,
F_Name varchar(15),
L_Name varchar(15),
Job_Code nchar(1), --should be not nulled later  --a constraint should be added later {1,2,3,4} 1-admin 2-instructor 3-intern 4-applicant
Age  TINYINT, --a constraint should be added later (0,140)
Gender char, --a constraint should be added later {M,F}
Account_Status nchar(1),  --the status is used for getting confirmation from admin and such --a constraint should be added later {0,1} 0-pending 1-active
TelephoneNumber varchar(10),
Dep_No varchar(3)

Primary key (ID)

)

create table Applicant_Intern
(
ID SMALLINT not null, 
Grade_of_Entrance_Exam char,  --a constraint should be added later {A,B,C,D,E,F}
College Varchar(30),
Years_of_Experience TINYINT,  --a constraint should be added later 0,40
Status_of_application binary(1), --should be not nulled later 
CV_Link varchar(50) 
)

create table department
( 
Department_Number SMALLINT not null,
DepartmentName varchar(30) not null,
)

create table Course
( 
CourseID SMALLINT not null,
CourseName varchar(30),
Active_Status char, --should be not nulled later
Capacity smallint,
Numberofinterns smallint, --we should put a constraint here to make the number never exceed the capacity 
DepNo SMALLINT, --should be not nulled later
BranchNo Smallint

Primary key (CourseID)
)

create table Lectures
( 
LectureNo Tinyint,
LectureDay varchar(10), 
Course_ID SMALLINT not null ,  
LocationID SMALLINT  --should be not nulled later
)



create table Instructs
(
Instruct_ID  SMALLINT not null,
CourseID SMALLINT not null
)

create table Takes
(
App_ID  SMALLINT not null, 
CourseID SMALLINT, --should be not nulled later
Year_of_Intern SMALLINT,  --should be not nulled later  --A constraint should be added
Grade char   --a constraint should be added later {A,B,C,D,E,F,T}
)

create table Locations
(
Branch_ID  Smallint not null, 
LocationName varchar(30) ,
Dep_No Smallint --should be not nulled later

Primary key (Branch_ID)
)



-----------------Inserting values into Accounts----------------

--Applicant1
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code)
values
(1 , 'a4IW3jR1u0XoSAL9kgIXew==','Lol','1','4')
--pass is lol 
--Applicant2
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code)
values
(2 , 'a4IW3jR1u0XoSAL9kgIXew==','Loler','1','4')

--pass is lol 

insert into department values (1,'R&D')
insert into department values (2,'ML')
insert into department values (3,'Sales')

insert into Locations values(1, 'Giza',1)
insert into Locations values(2, 'Helwan',1)
insert into Locations values(3, 'Giza',2)
insert into Locations values(4, 'Helwan',2)
insert into Locations values (5, 'Zayed',3)

insert into Course (CourseID,CourseName,Active_Status,Capacity,Numberofinterns, DepNo,BranchNo) 
values (1,'MLone','1',60,0,2,3)
insert into Course (CourseID,CourseName,Active_Status,Capacity,Numberofinterns, DepNo,BranchNo) 
values (2,'MLtwo','1',60,0,2,4)
insert into Course (CourseID,CourseName,Active_Status,Capacity,Numberofinterns, DepNo,BranchNo) 
values (3,'R&D1','1',60,0,1,1)
insert into Course (CourseID,CourseName,Active_Status,Capacity,Numberofinterns, DepNo,BranchNo) 
values (4,'R&D1','1',60,0,1,2)   
insert into Course (CourseID,CourseName,Active_Status,Capacity,Numberofinterns, DepNo,BranchNo) 
values (5,'Sales1','1',60,0,3,5)
--8alebn handtr n-associate el course bl mkan m4 bl department


