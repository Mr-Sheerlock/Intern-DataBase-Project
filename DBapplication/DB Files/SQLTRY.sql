
--This is just an SQL file to try the queries before writing them
use Intern_DB


--Select LectureNo , LectureDay 
--From Lectures
--where Course_ID in 
--				(Select Course_ID 
--				from takes 
--				where App_ID= 2
--				AND Year_of_Intern = 2000)
--AND LocationID in ( Select BranchNo
--					From   Course
--					where CourseID in ( Select Course_ID 
--										from takes 
--										where App_ID= 2
--										AND Year_of_Intern =2000)
--								)


--Select val =CONCAT(departmentName,'- ', LocationName), Branch_ID 
--from department,Locations
--where Branch_ID in 
--			(
--			Select BranchNo
			
--			From Course	
			
--			where Enrolled<Capacity
--			AND Course.CourseID in (
--				Select CourseID
--				From Instructs
--			)
--			--AND  Course.CourseID not  in(
--			--	Select CourseID
--			--	From Takes
--			--	Where App_ID ='2'
--			--)
--			)
--			AND Locations.Dep_No= department.Department_Number

--Select val =CONCAT(departmentName,'- ', LocationName), Branch_ID 
--from department, Locations 
--where Branch_ID in  --123
--                (
--                Select BranchNo    --BranchID having available courses
--                From Course  
--                where Enrolled < Capacity 
--                AND Course.CourseID in ( --Courses that have instructors
--										Select CourseID 
--										From Instructs  
--										) 
--				AND  Course.CourseID not  in( 
--										Select CourseID
--										From Takes
--										Where App_ID ='2'
--										AND Grade != 'W'     --if withdrawn or terminated of failed he should be able to apply
--										AND Grade != 'T'
--										AND Grade != 'F'
										
--											)
--				AND Course.CourseID not in (
--										Select CourseID
--										From Takes
--										Where App_ID ='2'
--										AND  Grade IS NULL
--										)
--                ) 
--                AND Locations.Dep_No = department.Department_Number;


							
--Select val =CONCAT(departmentName,'- ', LocationName), Branch_ID 
--from department,Locations
--where Branch_ID in 
--			(
--			Select BranchNo
			
--			From Course	
			
--			where Enrolled<Capacity
--			AND Course.CourseID in (
--								Select CourseID
--								From Instructs
--									)
--			)
--			AND Locations.Dep_No= department.Department_Number



--Select departmentName, LocationName, Branch_ID  --Depname and branchname that have the course
--                from department, Locations 
--                where Branch_ID = 
--				(
--				Select BranchNo  --Branch that has the course 
--				From Course 
--				Where  CourseID=
--						(
--						Select CourseID  --Course that has the intern 
--						From Takes 
--						where App_ID = '2' 
--						AND  Year_of_Intern = 2000
--						)
--				)
--				AND Locations.Dep_No = department.Department_Number

--Select F_name, L_name 
--From Accounts  
--Where ID = 
--(
--Select Instruct_ID  
-- From Instructs  
-- Where CourseID =
-- (  
--  Select CourseID    
--  From Takes  
--  where App_ID = 2
--  AND Year_of_Intern = 2000
--    ) 
--  ); 


 --Select F_name, L_name From Accounts Where ID =( Select Instruct_ID From Instructs Where CourseID =( Select CourseID From Takes where App_ID ='2' AND Year_of_Intern = 2000 )); 


--Select  CourseName, F_Name,L_Name
--From  (Course left join instructs on Course.CourseID=Instructs.CourseID ),accounts
--where Course.CourseID in (
--					Select CourseID
--					From	Course
--					Where DepNo= 2
--					AND BranchNo = 3
--					)
--AND Accounts.ID = Instructs.Instruct_ID
--AND Instructs.CourseID=Course.CourseID



--Union  (Select  CourseName
--		From  Course
--		where Course.CourseID in (
--							Select CourseID
--							From	Course
--							Where DepNo= 3
--							AND BranchNo = 5
--							)
--		)




--Update Takes Set CourseID= '1' Where App_ID = '2';

--select count (1) from Applicant_Intern where ID ='2'; 

--Select Grade from Takes where App_ID= '2' AND Year_of_Intern =2000;
--Delete from Takes where App_ID= '2' AND Year_of_Intern =2000;
--select count (1) 

--from Takes 
--where App_ID = 1

--AND Year_of_Intern =2000

--insert into takes (App_ID,CourseID,Year_of_Intern) values(2,4,2000)

--Select Count(Branch_ID)
--from department,Locations
--where Branch_ID in  --BranchID having available courses
--			(
--			Select BranchNo
			
--			From Course	
			
--			where Enrolled<Capacity
--			AND Course.CourseID in (
--				Select CourseID
--				From Instructs
--			)
--			)
--			AND Locations.Dep_No= department.Department_Number

--SELECT COUNT(1)
--FROM Accounts
--WHERE username = 'lol';
--Select Department_Number from department
--insert into Accounts (ID,Pass,UserName,Account_Status)
--values
--(6 , 'a4IW3jR1u0XoSAL9kgIXew==','Loler','0')




--Select CourseName, CourseID

--From Course

--Where BranchNo= '3'
--AND Course.CourseID in (
--				Select CourseID
--				From Instructs
--			)


--Select CourseName, CourseID

--From Course

--Where BranchNo= '3'
--AND Course.CourseID in (
--				Select CourseID
--				From Instructs
--			)

--Select Max(ID) from Accounts
		

--insert into Locations values (5, 'Zayed',3)
--insert into Course (CourseID,CourseName,Active_Status,Capacity,Numberofinterns, DepNo,BranchNo) 
--values (5,'Sales1','1',60,0,3,5)

--Select distinct departmentName, LocationName
--from department,Locations
--where Department_Number in 
--			(
--			Select DepNo
			
--			From Course	
			
--			where Numberofinterns<Capacity
--			)


--Courses

--insert into Course (CourseID,CourseName,Active_Status,Capacity,Enrolled, DepNo) 
--values (1,'MLone','1',60,0,2)
--insert into Course (CourseID,CourseName,Active_Status,Capacity,Enrolled, DepNo) 
--values (2,'MLtwo','1',60,0,2)
--insert into Course (CourseID,CourseName,Active_Status,Capacity,Enrolled, DepNo) 
--values (3,'R&D1','1',60,0,1)
--insert into Course (CourseID,CourseName,Active_Status,Capacity,Enrolled, DepNo) 
--values (4,'R&D1','1',60,0,1)




--INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,TelephoneNumber)
--Values ('7','loljo','/eMMoWzYexztJ+pUEneKig==','lol','loler','4',11,'M',1,'123454');
----INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)
--values
--(1,'lol','lol','lol','lol','1',11,'M','1')
--INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)
--values
--(2,'lol','lol','lol','lol','2',11,'M','1')
--INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)
--values
--(3,'lol','lol','lol','lol','3',11,'M','1')
--INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)
--values
--(4,'lol','lol','lol','lol','4',11,'M','1')


--Select Max(ID) from Accounts
--Select * from Accounts


--INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)
--values
--(1,'lol','lol','lol','lol','1',11,'M','0')
--insert into Accounts (ID,Pass, UserName )
--values
--('1','1','Loler')

--insert into Accounts (ID,Pass,UserName)
--values
--('2','2','Loler2')

select count(App_ID) 
from takes 
where Grade is NULL 