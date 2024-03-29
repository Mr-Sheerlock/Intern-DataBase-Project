-------------Database creation-------------

create database Intern_DB
Go

use Intern_DB

------------Table Creation-----------------

--CREATE DOMAIN D_NUM AS INTEGER
--CHECK (D_NUM > 0 AND D_NUM < 21);

create table department
( 
Department_Number SMALLINT not null,
DepartmentName varchar(30) not null,

Primary Key( Department_Number)
)

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
Dep_No SMALLINT,

Primary key (ID),

FOREIGN KEY (Dep_No) REFERENCES Department (Department_Number) 
ON DELETE SET NULL 
ON UPDATE CASCADE
)

create table Applicant_Intern
(
ID SMALLINT not null, 
Grade_of_Entrance_Exam char,  --a constraint should be added later {A,B,C,D,E,F}
College Varchar(30),
Years_of_Experience TINYINT,  --a constraint should be added later 0,40
Status_of_application nchar(1), --should be not nulled later  --a constraint should be added later {0,1,2,3}
															--0 for ongoing, 1 for rejected, 2 for accepted, 3 for ended		
CV_Link varchar(50), 

Primary Key(ID),

FOREIGN KEY (ID) REFERENCES Accounts (ID) 
ON DELETE CASCADE 
)


create table Locations
(
Branch_ID  Smallint not null, 
LocationName varchar(30) ,
Dep_No Smallint, --should be not nulled later

Primary key (Branch_ID),

FOREIGN KEY (Dep_No) REFERENCES Department (Department_Number) 
ON DELETE CASCADE 
ON UPDATE CASCADE
)

create table Course
( 
CourseID SMALLINT not null,
CourseName varchar(30),
Capacity smallint,
Enrolled smallint, --No. of Enrolled People --we should put a constraint here to make the number never exceed the capacity 
DepNo SMALLINT, --should be not nulled later
BranchNo Smallint,

Primary key (CourseID),

FOREIGN KEY (DepNo) REFERENCES department (Department_Number)
ON DELETE CASCADE
ON UPDATE CASCADE,

FOREIGN KEY (BranchNo) REFERENCES Locations (Branch_ID)
ON DELETE No Action
ON UPDATE No Action
)


create table Lectures
( 
LectureNo Tinyint,
LectureDay varchar(10), 
Course_ID SMALLINT not null ,  
LocationID SMALLINT,  --should be not nulled later

Primary key (LectureDay,Course_ID,LocationID),

FOREIGN KEY (LocationID) REFERENCES Locations (Branch_ID) 
ON DELETE no action
ON UPDATE no action,

FOREIGN KEY (Course_ID) REFERENCES Course (CourseID) 
ON DELETE CASCADE 
ON UPDATE CASCADE

)


create table Instructs
(
Instruct_ID  SMALLINT not null,    
CourseID SMALLINT not null,

Primary Key (Instruct_ID),

FOREIGN KEY (Instruct_ID) REFERENCES Accounts (ID),
--ON DELETE no Action 
--ON UPDATE no Action,

FOREIGN KEY (CourseID) REFERENCES Course (CourseID) 
ON DELETE CASCADE
ON UPDATE no Action
)			 

create table Takes
(
App_ID  SMALLINT not null, 
CourseID SMALLINT, --should be not nulled later
Year_of_Intern SMALLINT,  --should be not nulled later  --A constraint should be added
Grade char,   --a constraint should be added later {A,B,C,D,E,F,T,W} --T for terminated --W for withdraw
												--in the case of T,W the intern should automatically be demoted to applicant

primary key(App_ID,CourseID,Year_of_Intern),

FOREIGN KEY (App_ID) REFERENCES Applicant_Intern (ID) 
ON DELETE CASCADE 
ON UPDATE CASCADE,

FOREIGN KEY (CourseID) REFERENCES Course (CourseID) 
ON DELETE CASCADE 
ON UPDATE CASCADE
)


-----------------Inserting values into Tables----------------



--Accounts

--Applicant1
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(1 ,'Ahmed','Mostafa','Joo', 'a4IW3jR1u0XoSAL9kgIXew==','1','4','M','12345678901')
--pass is lol 

--Applicant2
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(2 ,'Mostafa','Ahmed','Mostafa21', 'a4IW3jR1u0XoSAL9kgIXew==','1','4','M','12345678901')
--pass is lol 

--Applicant3
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(3 ,'John','Ahmed','JohnAliJoseph', 'a4IW3jR1u0XoSAL9kgIXew==','1','4','F','12345678901')
--pass is lol 


--Applicant4
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(4 ,'Ali','Ahmed','AliA23', 'a4IW3jR1u0XoSAL9kgIXew==','1','4','M','12345678901')
--pass is lol 


--Applicant5
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(5 ,'Tarek','Mohammed','TM1993', 'a4IW3jR1u0XoSAL9kgIXew==','1','4','M','12345678901')
--pass is lol 

--Instructor1
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(6 ,'Mohammed','Hassan','MH1951', 'a4IW3jR1u0XoSAL9kgIXew==','1','2','M','12345678901')
--pass is lol 


--Instructor2
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(7 ,'Hassan','Mohammed','HMT1948', 'a4IW3jR1u0XoSAL9kgIXew==','1','2','M','12345678901')
--pass is lol 

--Intern1
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(8 ,'Abdullha','Junior','AJ1993', 'a4IW3jR1u0XoSAL9kgIXew==','1','3','M','12345678901')
--pass is lol 

--Intern2
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(9 ,'Hussein','Junior','HJ1923', 'a4IW3jR1u0XoSAL9kgIXew==','1','3','M','12345678901')
--pass is lol 

--Intern3
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(10 ,'Amir','Junior','AJ1923', 'a4IW3jR1u0XoSAL9kgIXew==','1','3','M','12345678901')
--pass is lol 

--Intern4
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(11 ,'Amira','Junior','ArJ1923', 'a4IW3jR1u0XoSAL9kgIXew==','1','3','M','12345678901')
--pass is lol 


--Instructor3
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(12 ,'Marco','Melad','MM1948', 'a4IW3jR1u0XoSAL9kgIXew==','1','2','M','12345678901')
--pass is lol 


--Instructor4
insert into Accounts (ID,F_Name,L_Name,UserName,Pass,Account_Status,Job_Code,Gender,TelephoneNumber)
values
(13 ,'Mohamed','Ahmed','DJT1948', 'a4IW3jR1u0XoSAL9kgIXew==','1','2','M','12345678901')
--pass is lol 


--Admins

insert into Accounts (ID,Pass,UserName,Account_Status,Job_Code,Gender)
values (14,'x1D5YVXi+aeWnsNMO5Wh6w==','JeJo','1','1','M')
--password is xd


-----Departments

insert into department values (1,'R&D')
insert into department values (2,'ML')
insert into department values (3,'Sales')


--Locations 
--R&D has 2 branches
insert into Locations values(1, 'Mohandseen',1)
insert into Locations values(2, 'Helwan',1)

--ML has 2 branches
insert into Locations values(3, 'Giza',2)
insert into Locations values(4, 'Helwan',2)

--Sales has one branch
insert into Locations values (5, 'Zayed',3)




-----Courses
--First ML branch has 2 courses
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo) 
values (1,'MLone',1,0,2,3)
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo) 
values (2,'MLtwo',2,0,2,3)

-- Second ML branch has only one course
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo) 
values (3,'MLone',1,0,2,4)

--Each of R&D branchs has one course
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo)  
values (4,'R&D1',2,0,1,1)
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo)  
values (5,'R&D1',1,0,1,2)   

--Sales has only one course 
insert into Course (CourseID,CourseName,Capacity,Enrolled, DepNo,BranchNo)  
values (6,'Sales1',2,0,3,5)


----Instructs  --instructors are   6,7,11,12

insert into Instructs (CourseID,Instruct_ID)
values ('1','6')

insert into Instructs (CourseID,Instruct_ID)
values ('2','7')

insert into Instructs (CourseID,Instruct_ID)
values ('4','11')


--no, day,CID, LocID
--Lectures of MLone course in Giza
INSERT INTO Lectures Values (1,'Sunday',1,3)
INSERT INTO Lectures Values (2,'Monday',1,3)
INSERT INTO Lectures Values (3,'Tuesday',1,3)
INSERT INTO Lectures Values (4,'Wednesday',1,3)

--Lectures of MLtwo course in Helwan
INSERT INTO Lectures Values (1,'Thursday',2,4)
INSERT INTO Lectures Values (2,'Saturday',2,4)
INSERT INTO Lectures Values (3,'Sunday',2,4)
INSERT INTO Lectures Values (4,'Monday',2,4)

--Lectures of R&D1 course in Mohandseen
INSERT INTO Lectures Values (1,'Monday',4,1)
INSERT INTO Lectures Values (2,'Sunday',4,1)
INSERT INTO Lectures Values (3,'Tuesday',4,1)

--interns and applying applicants 
--Status of application
	--0 for ongoing, 1 for rejected, 2 for accepted, 3 for ended	
--Applicants

Insert Into Applicant_Intern Values (2,'A','Cairo University',0,0,'uwu.com')
Insert Into Applicant_Intern Values (3,'B','MIT',0,0,'uwu.com')
Insert Into Applicant_Intern Values (4,'C','Harvard',1,0,'uwu.com')
Insert Into Applicant_Intern Values (5,'D','TITS',2,0,'uwu.com')


--Interns 8,9,10
Insert Into Applicant_Intern Values (8,'A','University of Toronto',0,2,'uwu.com')
Insert Into Applicant_Intern Values (9,'A','University of Toronto',0,2,'uwu.com')
Insert Into Applicant_Intern Values (10,'A','University of Toronto',0,2,'uwu.com')


--ID, CID,year,grade
INSERT INTO Takes Values (2,1,2000,'A')

--INSERT INTO Takes Values (1,1,2020,'A')
--INSERT INTO Takes Values (1,3,2020,'W')
--INSERT INTO Takes Values (1,5,2020,'B')
--INSERT INTO Takes Values (2,1,2020,'B')
--INSERT INTO Takes Values (2,2,2020,'W')
--INSERT INTO Takes Values (2,3,2020,'A')
--INSERT INTO Takes Values (3,1,2020,'C')
--INSERT INTO Takes Values (3,2,2020,'D')
--INSERT INTO Takes Values (3,4,2020,'W')
--INSERT INTO Takes Values (4,2,2020,'A')
--INSERT INTO Takes Values (4,3,2020,'A')
--INSERT INTO Takes Values (4,5,2020,'A')
--INSERT INTO Takes Values (5,1,2020,'C')
--INSERT INTO Takes Values (5,2,2020,'B')
--INSERT INTO Takes Values (5,3,2020,'A')
--INSERT INTO Takes Values (5,4,2020,'A')





---Proceduress--------
use Intern_DB
Go
----------------Stored Procedures----------------------------
CREATE PROCEDURE GET_DROPPED_COURSES
@year int
AS 
Select CourseName , Course.CourseID ,count(*) from Course, Takes where Takes.CourseID = Course.CourseID AND Grade= 'W' AND Year_of_Intern = @year group By Course.CourseID , CourseName
GO 


CREATE PROCEDURE STATS_GRADES_PER_DEPARTMENT_COURSES 
@year int ,
@Dname varchar(30)
AS 
Select CourseName , Grade , Count(Grade) From Course,Takes , department Where Course.CourseID = Takes.CourseID AND Year_of_Intern = @year  AND Course.DepNo =Department_Number AND DepartmentName = @Dname Group By CourseName , Grade Having Grade<>'W' Order By CourseName
GO 

CREATE PROCEDURE STATS_COURSE_YEAR_GRADE 
@cid int , @year int , @grade varchar(1)
AS 
Select CourseName , count(Grade) from Course,Takes where Takes.CourseID= @cid AND Takes.CourseID= Course.CourseID AND Year_of_Intern= @year AND Grade= @grade group by CourseName
GO 

CREATE PROCEDURE CheckAvailableCourse 
AS 
Select Count(Branch_ID)
                from department, Locations 
                where Branch_ID in 
							(
                            Select BranchNo    --//BranchID having available courses
                            From Course 
                            where Enrolled < Capacity 
                            AND Course.CourseID in 
									(
                                    Select CourseID 
                                    From Instructs 
                                    ) 
                            ) 
                            AND Locations.Dep_No = department.Department_Number
GO 


CREATE PROCEDURE SelectDep_Loc 
@appid smallint
AS 
Select val =CONCAT(departmentName,'- ', LocationName), Branch_ID 
               from department, Locations 
               where Branch_ID in 
                            (
                                Select BranchNo    --//BranchID having available courses
                                From Course 
                                where Enrolled < Capacity 
                                AND Course.CourseID in 
										(
                                        Select CourseID --//Courses having instructors
                                        From Instructs 
			                            ) 
                                AND Course.CourseID not in ( 
                                                            Select CourseID From Takes 
                                                            Where App_ID =  @appid     --//if withdrawn or terminated of failed he should be able to apply
                                                            AND Grade != 'W' 
                                                            AND Grade != 'T' 
                                                            AND Grade != 'F' 
                                                            ) 

                                AND Course.CourseID not in (
                                                            Select CourseID From Takes      --//if Grade = NULL that means that he has already applied or he is taking the course
                                                            Where App_ID = @appid
                                                            AND  Grade IS NULL 
                                                            ) 
                            ) 
                            AND Locations.Dep_No = department.Department_Number
GO 