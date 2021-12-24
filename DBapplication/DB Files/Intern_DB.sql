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
Gender char not null, --a constraint should be added later {M,F}
Account_Status nchar(1) not null,  --the status is used for getting confirmation from admin and such --a constraint should be added later {0,1} 0-pending 1-active
TelephoneNumber varchar(11),
Dep_No varchar(3)

Primary key (ID)

)

create table Applicant_Intern
(
ID SMALLINT not null, 
Grade_of_Entrance_Exam char,  --a constraint should be added later {A,B,C,D,E,F}
College Varchar(30),
Years_of_Experience TINYINT,  --a constraint should be added later 0,40
Status_of_application nchar(1), --should be not nulled later  --a constraint should be added later {0,1,2}
															--0 for ongoing, 1 for rejected, 2 for accepted
			
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
Capacity smallint,
Enrolled smallint, --No. of Enrolled People --we should put a constraint here to make the number never exceed the capacity 
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
Grade char   --a constraint should be added later {A,B,C,D,E,F,T,W} --T for terminated --W for withdraw
												--in the case of T,W the intern should automatically be demoted to applicant

primary key(App_ID,CourseID,Year_of_Intern)

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
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code,Gender)
values
(1 , 'a4IW3jR1u0XoSAL9kgIXew==','Lol','1','4','M')
--pass is lol 
--Applicant2
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code,Gender)
values
(2 , 'a4IW3jR1u0XoSAL9kgIXew==','Loler','1','4','M')

--pass is lol 
--Instructor1
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code,Gender)
values
(3 , 'a4IW3jR1u0XoSAL9kgIXew==','LolInstr','1','2','F')
--Instructor2
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code,Gender)
values
(4 , 'a4IW3jR1u0XoSAL9kgIXew==','LolInstr2','1','2','M')
--instructor3
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code,Gender)
values
(5 , 'a4IW3jR1u0XoSAL9kgIXew==','LolInstr3','1','2','F')
--instructor4
insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code,Gender)
values
(6 , 'a4IW3jR1u0XoSAL9kgIXew==','LolInstr4','1','2','M')

insert into department values (1,'R&D')
insert into department values (2,'ML')
insert into department values (3,'Sales')

insert into Locations values(1, 'Giza',1)
insert into Locations values(2, 'Helwan',1)
insert into Locations values(3, 'Giza',2)
insert into Locations values(4, 'Helwan',2)
insert into Locations values (5, 'Zayed',3)

insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo) 
values (1,'MLone',5,0,2,3)
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo) 
values (2,'MLtwo',5,0,2,4)
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo)  
values (3,'R&D1',5,0,1,1)
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo)  
values (4,'R&D1',5,0,1,2)   
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo)  
values (5,'Sales1',5,0,3,5)
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo) 
values (6,'MLone',5,0,2,3)
--8alebn handtr n-associate el course bl mkan m4 bl department


--Insert in instructs 

insert into Instructs (CourseID,Instruct_ID)
values ('1','3')

insert into Instructs (CourseID,Instruct_ID)
values ('4','4')

insert into Instructs (CourseID,Instruct_ID)
values ('6','6')


--insert into takes (App_ID,CourseID,Year_of_Intern) values(2,4,2000)
