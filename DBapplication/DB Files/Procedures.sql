
--Procedures SQL file
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
