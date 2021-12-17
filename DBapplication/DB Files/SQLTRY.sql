
--This is just an SQL file to try the queries before writing them
use Intern_DB



--insert into Accounts (ID,Pass,UserName,Account_Status)
--values
--(6, '1','Loler','0')

INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)
values
(2,'lol','lol','lol','lol','1',11,'M','0')

Select Max(ID) from Accounts
Select * from Accounts


--INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)
--values
--(1,'lol','lol','lol','lol','1',11,'M','0')
--insert into Accounts (ID,Pass, UserName )
--values
--('1','1','Loler')

--insert into Accounts (ID,Pass,UserName)
--values
--('2','2','Loler2')