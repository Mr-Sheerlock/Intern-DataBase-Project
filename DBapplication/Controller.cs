﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }



        #region Accounts


        public DataTable SelectAllUsers()
        {
            string query = "Select * from Accounts;";
            return dbMan.ExecuteReader(query);
        }

        public string SelectUsername(int id)
        {
            string query = "Select UserName from Accounts where ID =  " + id + ";";
            return (dbMan.ExecuteReader(query)).Rows[0][0].ToString();
        }


       
        public int CheckifUserTaken(string UserName)
        {
            string query = "Select Count(1) from Accounts where UserName = '" + UserName + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }
        public DataTable SelectPassword(string UserName)
        {
            string query = "Select Pass,Account_Status,Job_Code,ID from Accounts where UserName = '" + UserName + "';";
            return dbMan.ExecuteReader(query);
        }

        public int ChangePassword(string UserName,string Pas)
        {
            string query = "Update Accounts Set Pass='" + Pas + "' where UserName = '" + UserName + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int GetLastUserID()
        {
            string query = "Select Max(ID) from Accounts" + ";";

            //in case there are no accounts in the DB 
            if (dbMan.ExecuteScalar(query) == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int updateAccount(int ID, string UserName, string Password, string FName, string Lname, char JobCode, int Age, char Gender, char status, string TelephoneNumber, string Dep_no = "")
        {
            string query;
            if (Dep_no == "")
            {
                query = "Update Accounts Set"
                               + " UserName = '" + UserName + "',"
                               + " Pass = '" + Password + "',"
                               + " F_Name = '" + FName + "',"
                               + " L_Name = '" + Lname + "',"
                               + " Job_Code = '" + JobCode + "',"
                               + " Age = " + Age + ","
                               + " Gender = '" + Gender + "',"
                               + " Account_Status = '" + status + "',"
                               + " TelephoneNumber = '" + TelephoneNumber + "'"
                               + " Where ID = " + ID + ";";
            }
            else
            {
                query = "Update Accounts Set"
                   + " UserName = '" + UserName + "',"
                   + " Pass = '" + Password + "',"
                   + " F_Name = '" + FName + "',"
                   + " L_Name = '" + Lname + "',"
                   + " Job_Code = '" + JobCode + "',"
                   + " Age = " + Age + ","
                   + " Gender = '" + Gender + "',"
                   + " Account_Status = '" + status + "',"
                   + " TelephoneNumber = '" + TelephoneNumber + "',"
                   + " Dep_No = '" + Dep_no + "'"
                   + " Where ID = " + ID + ";";
            }
            
            

            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertAccount(int ID, string UserName, string Password, string FName, string Lname, char JobCode, int Age, char Gender, char status ,string TelephoneNumber ,string Dep_no="")
        {
            string query;
            //we didn't need to check on job code because we don't allow instructors to have no dep number
            if (Dep_no == "") {
                
            //Applicant
            query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,TelephoneNumber)" +
                        "Values ('" + ID + "','" + UserName + "','" + Password +
                        "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                        ",'" + Gender + "','" + status + "','" + TelephoneNumber + "');";
            }
            else
            {
                //instructor

                query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,Dep_No,TelephoneNumber)" +
                                "Values ('" + ID + "','" + UserName + "','" + Password +
                                "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                                ",'" + Gender + "','" + status + "','" + Dep_no + "','" + TelephoneNumber + "');";
            }

            return dbMan.ExecuteNonQuery(query);
        }

        public int ChangeFromApptoIntern(string AppID)
        {
            string query = "Update Accounts Set Job_Code='3' Where ID = '" +AppID+ "';";
            return dbMan.ExecuteNonQuery(query);    
        }

        public int ChangeFromInterntoApp(string InternID)
        {
            string query = "Update Accounts Set Job_Code='4' Where ID = '" + InternID + "';";
            return dbMan.ExecuteNonQuery(query);
        }



        public DataTable SelectCourse_Instructor(string DepID, string BranchID)
        {
            //left join shows the null values unlike natural join
            //and that was its syntax...

            string query = "Select CourseName, F_Name, L_Name " +
                            "From (Course left join instructs on Course.CourseID=Instructs.CourseID ),accounts " +
                            "where Course.CourseID in ( " +
                                                "Select CourseID " +
                                                "From    Course " +
                                                "Where DepNo= '" + DepID + "' " +
                                                "AND BranchNo= '" + BranchID + "' " +
                                                ") " +
                            "AND Accounts.ID = Instructs.Instruct_ID; ";
            return dbMan.ExecuteReader(query);
        }

        #endregion



        #region Department


        public int GetLastDepNumber()
        {
            string query = "Select Max(Department_Number) from Department" + ";";

            //in case there are no accounts in the DB 
            if (dbMan.ExecuteScalar(query) == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }
        public int insertDepartment(int id, string name)
        {
            string query = "Insert into Department Values( " + id + ", '" + name + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteDepartment(int id)
        {
            string query = "delete from Department where Department_Number =  " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateDepartment(int id ,string name)
        {
            string query = "Update Department Set DepartmentName = '" + name +  "' where Department_Number =  " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int CheckifDepNameTaken(string name)
        {
            string query = "Select Count(1) from Department where DepartmentName = '" + name + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }
        public DataTable SelectDepartmentNamesandNos()
        {
            string query = "Select DepartmentName, Department_Number from department;";
            return dbMan.ExecuteReader(query);
        }

        //public DataTable SelectDep_Loc(string appID)
        //{
        //    string query= "Select val =CONCAT(departmentName,'- ', LocationName), Branch_ID "+
        //        "from department, Locations "+
        //        "where Branch_ID in "+
        //                    "("+
        //                        "Select BranchNo " +   //BranchID having available courses
        //                        "From Course " +
        //                        "where Enrolled < Capacity "+
        //                        "AND Course.CourseID in "+
        //                        "("+
        //                                "Select CourseID "+ //Courses having instructors
        //                                "From Instructs "+
        //                       ") "+
        //                        "AND Course.CourseID not in ( " +
        //                                                    "Select CourseID From Takes " +
        //                                                    "Where App_ID ='" + appID +"' " +    //if withdrawn or terminated of failed he should be able to apply
        //                                                    "AND Grade != 'W' " +
        //                                                    "AND Grade != 'T' " +
        //                                                    "AND Grade != 'F' " +
        //                                                    ") "+

        //                        "AND Course.CourseID not in (" +
        //                                                    "Select CourseID From Takes " +     //if Grade = NULL that means that he has already applied or he is taking the course
        //                                                    "Where App_ID ='" + appID + "' " +
        //                                                    "AND  Grade IS NULL " +
        //                                                    ") " +
        //                    ") " +
        //                    "AND Locations.Dep_No = department.Department_Number";
        //    return dbMan.ExecuteReader(query);
        //}

        //STORED PROC 5
        public DataTable SelectDep_Loc(string appID)
        {
            string query = "EXECUTE SelectDep_Loc @appid= '" +appID +"';";
            return dbMan.ExecuteReader(query);
        }

         
     

        public DataTable SelectDepHavingCourse(string InterID, int CurrentYear)
        {
            string query = "Select departmentName, LocationName, Branch_ID  " +  //Depname and branchname that have the course
                "From department, Locations " +
                "Where Branch_ID =" +
                "( " +
                "Select BranchNo " +//Branch that has the course
                 "From Course " +
                 "Where  CourseID = " +
                          "( " +
                              "Select CourseID " +//Course that has the intern
                              "From Takes " +
                              "where App_ID ='" + InterID + "' " +
                              "AND Year_of_Intern = " + CurrentYear  +
                           ") " +
                 ") " +
                 "AND Locations.Dep_No = department.Department_Number;";
                return dbMan.ExecuteReader(query);

        }

        public DataTable SelectDepartments()
        {
            string query = "Select * from department;";
            return dbMan.ExecuteReader(query);
        }

        #endregion



        #region Course 
        public DataTable SelectCourse(string BranchID)
        {
            string query = "Select CourseName, CourseID " +
                            "From Course " +
                            "Where BranchNo = '" + BranchID +"' "+
                            "AND Course.CourseID in ( " +
                                            "Select CourseID " +
                                            "From Instructs " +
                                        "); ";
            return dbMan.ExecuteReader(query);
        }
       
        public int ApplytoCourse(string AppID,string CourseID,int CurrentYear)
        {

            string query = "Insert into Takes(App_ID, CourseID, Year_of_Intern) " +
                            "values( '" + AppID + "', '"+CourseID+"', "+CurrentYear + ");";
            return dbMan.ExecuteNonQuery(query);
        }



        #endregion


        #region Locations

        //THIS CHECKS USING BRANCH THOUGH!!
        //public int CheckAvailableCourse() //Checks if there are available courses to apply
        //{
        //    string query = "Select Count(Branch_ID) " +
        //        "from department, Locations " +
        //        "where Branch_ID in " +
        //                    "(" +
        //                    "Select BranchNo " +   //BranchID having available courses
        //                    "From Course " +
        //                    "where Enrolled < Capacity " +
        //                    "AND Course.CourseID in " +
        //                    "(" +
        //                            "Select CourseID " +
        //                            "From Instructs " +
        //                            ") " +
        //                    ") " +
        //                    "AND Locations.Dep_No = department.Department_Number";
        //    return Convert.ToInt16(dbMan.ExecuteScalar(query));
        //}

        //Stored Proc 4
        public int CheckAvailableCourse() //Checks if there are available courses to apply
        {
            string query = "EXECUTE CheckAvailableCourse;";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        //public DataTable STATS_DROPPED_COURSES(int year)
        //{
        //     / / EDITED 27 / 12 by ozer to get which course, which ID and what number of drops in that course
        //    string query = "EXECUTE GET_DROPPED_COURSES @year=" + year;

        //    return dbMan.ExecuteReader(query);
        //}


        public DataTable SelectLocations(string DepartID)
        {
            string query = "Select Branch_ID, LocationName from Locations where Dep_No= '" + DepartID + "';";
            return dbMan.ExecuteReader(query);
        }
        #endregion


        #region Takes

        public int CheckCurrentYear()
        {
            string query = "select count(App_ID) "
                            + "from takes "
                            + "where Grade is NULL;";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int CheckifApplied(string AppID, int CurrentYear)
        {

            string query = "select count (1) " +
                            "from Takes " +
                            "where App_ID ='" + AppID + "' " +
                            "AND Year_of_Intern =" + CurrentYear + ";";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int ChangeApplication(string AppID, string CourseID)
        {

            string query = "Update Takes Set CourseID= '" + CourseID + "' " +
                            "Where App_ID = '" + AppID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int GetCurrentYear()
        {
            string query ="select Max(Year_of_Intern) from Takes";
            if (dbMan.ExecuteScalar(query) == DBNull.Value)
            {
                return 2000;  //Base Assumption
            }
            if (CheckCurrentYear() == 0)
            {
                return Convert.ToInt16(dbMan.ExecuteScalar(query))+1; //there are no active courses = we are in the next year
            }
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }
        public DataTable GetGrade(string internID, int currentYear)
        {
            string query = "Select Grade from Takes where App_ID= '" + internID+ "' AND Year_of_Intern =" + currentYear+ ";";
            return dbMan.ExecuteReader(query);
        }

        public int CancelApplication(string AppID, int CurrentYear)
        {

            string query = "Delete from Takes where App_ID= '" + AppID + "' AND Year_of_Intern ="+ CurrentYear+";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DropCourse(string AppID)
        {

            string query = "Update Takes Set Grade = 'W' where App_ID = '" + AppID + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        public int SetAllintapp()
        {

            string query = "Update Accounts Set Job_Code= '4' where Job_Code='3'";
            return dbMan.ExecuteNonQuery(query);
        }

        #endregion


        #region Applicant_Intern
        public int CheckiffullyRegistered(string AppID)
        {

            string query = "select count (1) " +
                            "from Applicant_Intern " +
                            "where ID ='" + AppID + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int CompleteRegistration(string AppID, string CollegeName, int YearsofXP, string CV)
        {

            string query = "insert into Applicant_Intern (ID, College, Years_of_Experience, CV_Link, Status_of_application) " +
                            "values('" +AppID  +"', '" +CollegeName + "', " + YearsofXP + ", '" + CV + "', '0');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetApplicationStatus(string AppID, int currentYear)
        {
            string query = "Select Status_of_application from Applicant_Intern where ID= '" + AppID + "';";
            return dbMan.ExecuteReader(query);
        }
        #endregion

        #region Instructs

        public DataTable SelectInstructorName(string InternID , int CurrentYear)
        {
            string query = "Select F_name, L_name " +
                            "From Accounts " +
                            "Where ID =" +
                            "( " +
                            "Select Instruct_ID " +
                             "From Instructs " +
                             "Where CourseID ="+
                             "( " + 
                              "Select CourseID " +    //Course that has the intern
                              "From Takes " +
                              "where App_ID ='" +InternID + "' " +
                              "AND Year_of_Intern = " + CurrentYear +
                                " )" + 
                              "); ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPendingInstructors()
        {
            string query = " Select ID, UserName, F_Name, L_Name, Job_Code, Age, Gender, Account_Status, TelephoneNumber, Dep_No From Accounts Where Account_Status = 0 AND Job_Code = 2";
            return dbMan.ExecuteReader(query);
        }

        public int approveInstructor(int id)
        {
            string query = "Update Accounts Set Account_Status = 1 Where ID = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteInstructor(int id)
        {
            string query = "Delete Accounts Where ID = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        #endregion

        #region Lectures
        public DataTable SelectLectures(string InternID, int CurrentYear)
        {

            string query = " Select LectureNo, LectureDay " +
                " From Lectures where Course_ID in " +
                                            "(Select Course_ID " +
                                            "from takes " +
                                            "where App_ID= '" + InternID + "' " +
                                            "AND Year_of_Intern ='" + CurrentYear + "' " +
                                            ") " +
                                "AND LocationID in " +
                                            "(Select BranchNo " +
                                            "From   Course " +
                                            "where CourseID in " +
                                                        "(Select Course_ID " +
                                                        "from takes " +
                                                        "where App_ID= '" + InternID + "' " +
                                                        "AND Year_of_Intern ='" + CurrentYear + "' " +
                                                        ") " +
                                        ");";
                 return dbMan.ExecuteReader(query);
        }

        #endregion


        #region Statistics
        //OZER'S PART BEGINS HERE 
        //PRIVATE PROPERTY 
        // GET DEPARTMENT NAMES 
        public DataTable SelectDepartmentNames()
        {
            string query = "select DepartmentName from Department";
            return dbMan.ExecuteReader(query);
        }
        //GET LOCATION NAMES 
        public DataTable SelectLocationNames()
        {
            string query = "select Distinct LocationName from Locations";
            return dbMan.ExecuteReader(query);
        }
        //GET COURSES NAMES 
        public DataTable SelectCourseID()
        {
            //EDITED 27/12 by ozer to get active courses by instructors
            string query = "select Distinct CourseID from Instructs";
            return dbMan.ExecuteReader(query);
        }
        //GET COURSE NAME 
        public DataTable SelectCourseBranch()
        {
            //EDITED 27/12 by ozer to get active courses by instructors
            string query = "select CourseName, from Course,Instructs where Course.CourseID = Instructs.CourseID Order By Instructs.CourseID";
            return dbMan.ExecuteReader(query);
        }
        //GET BRANCH IDS
        public DataTable SelectBranchIDs()
        {
            string query = "Select Branch_ID from Locations";
            return dbMan.ExecuteReader(query);
        }
        //Number of Applicants For Each Department
        public DataTable STATS_APPLICANTS_DEPARTMENTS()
        {
            //EDITED BY OZER AT 27/12 
            string query = "Select Dep_No, DepartmentName , Count(*) From Accounts , department Where Job_Code = 4 AND Account_Status = 1 AND Dep_No = Department_Number Group By Dep_No, DepartmentName  ORDER by Dep_No";
            return dbMan.ExecuteReader(query);
        }
        //Number of Interns for each Department
        public DataTable STATS_INTERNS_DEPARTMENTS()
        {
            //EDITED BY OZER AT 27/12 to get them by their account status 
            string query = "Select Dep_No, DepartmentName , Count(*) From Accounts , department Where Job_Code = 3 AND Account_Status = 1 AND Dep_No = Department_Number Group By Dep_No, DepartmentName  ORDER by Dep_No";
            return dbMan.ExecuteReader(query);
        }
        //Number of Instructors for each Department
        public DataTable STATS_INSTRUCTS_DEPARTMENTS()
        {
            //EDITE BY OZER AT 27/12 to get them by their account status 
            string query = "Select Dep_No, DepartmentName , Count(*) From Accounts , department Where Job_Code = 2 AND Account_Status = 1 AND Dep_No = Department_Number Group By Dep_No, DepartmentName  ORDER by Dep_No";
            return dbMan.ExecuteReader(query);
        }
        //Number of Dropped Applicants in All Courses year Y

        //Stored Proc 1
        public DataTable STATS_DROPPED_COURSES(int year)
        {
             // EDITED 27 / 12 by ozer to get which course, which ID and what number of drops in that course
            string query = "EXECUTE GET_DROPPED_COURSES @year=" + year;

            return dbMan.ExecuteReader(query);
        }

        //public DataTable STATS_DROPPED_COURSES(int year)
        //{
        //    // EDITED 27/12 by ozer to get which course , which ID and what number of drops in that course 
        //    string query = "Select CourseName , Course.CourseID ,count(*) from Course, Takes where Takes.CourseID = Course.CourseID AND Grade='W' AND Year_of_Intern=" + year + " group by CourseName , Course.CourseID";

        //    return dbMan.ExecuteReader(query);
        //}


        //Number of Grades in Courses in Year Y in a given department D

        //Stored Proc 2
        public DataTable STATS_GRADES_PER_DEPARTMENT_COURSES(string Departmentname, int year)
        {
            string query = "EXECUTE STATS_GRADES_PER_DEPARTMENT_COURSES @year=" + year + ",@Dname='" + Departmentname + "'";
            return dbMan.ExecuteReader(query);
        }

        //public DataTable STATS_GRADES_PER_DEPARTMENT_COURSES(string Departmentname, int year)
        //{
        //    string query = "Select CourseName , Grade , Count(Grade) From Course,Takes , department Where Course.CourseID = Takes.CourseID AND Year_of_Intern =" + year + " AND Course.DepNo =Department_Number AND DepartmentName = '" + Departmentname + " ' Group By CourseName , Grade Having Grade<>'W' Order By CourseName";
        //    return dbMan.ExecuteReader(query);
        //}
        //Available Courses X For Department D and Their Location L
        public DataTable STATS_COURSES_PER_DEPARTMENT(string Departmentname)
        {
            //updated 6/1
            string query = "Select CourseName , LocationName  From Course ,Instructs, Locations ,department Where Instructs.CourseID=Course.CourseID AND BranchNo=Branch_ID AND DepNo=Department_Number AND DepartmentName='" + Departmentname + "'";
            return dbMan.ExecuteReader(query);
        }
        //Search for locations L for Course C 
        public DataTable STATS_LOCATION_PER_COURSE(int cid)
        //updated on 6/1
        {
            string query = "Select CourseName , LocationName From Course , Locations Where CourseID=" + cid + " AND BranchNo=Branch_ID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable STATS_COURSE_LECTURES_DATEANDTIMES(int cid)
        {
            //EDITED BY OZER on 6/1 
            string query = "Select CourseName , LectureNo , LectureDay , LocationName From Course, Lectures,Locations,Instructs WHERE LocationID=Branch_ID AND Course_ID=Instructs.CourseID AND Instructs.CourseID=Course.CourseID AND Course_ID=" + cid;
            return dbMan.ExecuteReader(query);
        }

        //Courses and Their Instructors Data 


        //Stored Proc 3

        //Count For Grade G  in Course C in Year Y 
        public DataTable STATS_COURSE_YEAR_GRADE(int cid, int year, string grade)
        {
            //updated on 6/1
            string query = "EXEC STATS_COURSE_YEAR_GRADE @year=" + year + " ,@cid=" + cid + ", @grade='" + grade + "'";
            return dbMan.ExecuteReader(query);
        }

        //public DataTable STATS_COURSE_YEAR_GRADE(int cid, int year, string grade)
        //{
        //    //updated on 6/1
        //    string query = "select CourseName , count(Grade) from Course,Takes where Takes.CourseID=" + cid + "AND Takes.CourseID= Course.CourseID AND Year_of_Intern=" + year + "AND Grade='" + grade + "' group by CourseName";
        //    return dbMan.ExecuteReader(query);
        //}
        #endregion


        #region Instructors
        public DataTable SelectApplicants(string ApplicantID, int Year)
        {
            string query = "Select DISTINCT Student.ID, Student.F_Name, Student.L_Name, Grade_of_Entrance_Exam, Years_of_Experience, College, Student.Gender, Student.TelephoneNumber" +
                " From Accounts AS Student, Accounts AS Instructor, Applicant_Intern, Takes, Course, Instructs" +
                " Where Student.ID = Applicant_Intern.ID" +
                " AND (Status_of_application = 0 OR  Status_of_application = 3)  " +
                " AND Applicant_Intern.ID = Takes.App_ID " +
                " AND Takes.CourseID = Course.CourseID " +
                " AND Instructs.CourseID = Course.CourseID " +
                " AND Instructs.Instruct_ID= '" + ApplicantID + "' " +
                " AND Takes.Year_of_Intern= '" + Year +"' ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectInterns(string ApplicantID, int currentyear)
        {
            string query = "Select DISTINCT Student.ID, Student.F_Name, Student.L_Name, Takes.CourseID,Takes.Grade, Student.Gender, Student.TelephoneNumber" +
                " From Accounts AS Student, Accounts AS Instructor, Applicant_Intern, Takes, Course, Instructs" +
                " Where Student.ID = Applicant_Intern.ID" +
                " AND Status_of_application = 2 " +
                " AND Applicant_Intern.ID = Takes.App_ID " +
                " AND Takes.CourseID = Course.CourseID " +
                " AND Instructs.CourseID = Course.CourseID " +
                " AND Instructs.Instruct_ID= '" + ApplicantID + "' "+
                "AND Takes.Year_of_Intern= '"+ currentyear +"';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectLecturesdate(string ApplicantID)
        {
            string query = "Select DISTINCT LectureNo, LectureDay" +
                " from Instructs, Course, Lectures" +
                " Where Lectures.Course_ID= Course.CourseID" +
                " AND Instructs.CourseID = Course.CourseID" +
                " AND Instructs.Instruct_ID= '" + ApplicantID + "' ";
            return dbMan.ExecuteReader(query);
        }

        public int ChangeDate(string NewDay, string ApplicantID, string LectNumber)
        {

            string query = "Update Lectures Set LectureDay = '" + NewDay + "' " +
                " Where Lectures.LectureNo = '" + LectNumber + "' " +
                " AND Lectures.Course_ID in ( Select Course.CourseID" +
                " from Course, Lectures, Instructs" +
                " Where Course.CourseID = Lectures.Course_ID" +
                " AND Course.CourseID = Instructs.CourseID" +
                " AND Instructs.Instruct_ID ='" + ApplicantID + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int approveApplicant(int id)
        {
            string query = "Update Applicant_intern Set Status_of_application = 2 Where ID = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RejectApplicant(int id)
        {
            string query = "Update Applicant_intern Set Status_of_application = 1 Where ID = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetGradeA(int id, int year)
        {
            string query = "Update Takes Set Grade = 'A' Where App_ID = " + id + "AND Year_of_Intern = " + year + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetGradeB(int id, int year)
        {
            string query = "Update Takes Set Grade = 'B' Where App_ID = " + id + "AND Year_of_Intern = " + year + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int SetGradeC(int id, int year)
        {
            string query = "Update Takes Set Grade = 'C' Where App_ID = " + id + "AND Year_of_Intern = " + year + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int SetGradeD(int id, int year)
        {
            string query = "Update Takes Set Grade = 'D' Where App_ID = " + id + "AND Year_of_Intern = " + year + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int SetGradeF(int id, int year)
        {
            string query = "Update Takes Set Grade = 'F' Where App_ID = " + id + "AND Year_of_Intern = " + year + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetGradeT(int id, int year)
        {
            string query = "Update Takes Set Grade = 'T' Where App_ID = " + id + "AND Year_of_Intern = " + year + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        //public int deleteIntern(int id)
        //{
        //    string query = "Delete Applicant_Intern Where ID = " + id + ";";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int ChangetoCompl(int id)
        {
            string query = "Update Applicant_Intern Set Status_of_application = 3 Where ID = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InternToApp(int id)
        {
            string query = "Update Accounts Set Job_Code = 4 Where ID = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AppToIntern(int id)
        {
            string query = "Update Accounts Set Job_Code = 3 Where ID = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAdminInfo()
        {
            string query = "Select UserName, F_Name, L_Name, Age, Gender, TelephoneNumber From Accounts Where Job_Code = 1";
            return dbMan.ExecuteReader(query);
        }

        public DataTable CheckYearEnd()
        {
            string query = "Select Count(*) From Takes Where Grade IS NULL";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Countapplicants(string ApplicantID)
        {
            string query = "Select Count(*) From Accounts where Accounts.ID in (Select DISTINCT Student.ID" +
               " From Accounts AS Student, Accounts AS Instructor, Applicant_Intern, Takes, Course, Instructs" +
               " Where Student.ID = Applicant_Intern.ID" +
               " AND Status_of_application = 0 " +
               " AND Applicant_Intern.ID = Takes.App_ID " +
               " AND Takes.CourseID = Course.CourseID " +
               " AND Instructs.CourseID = Course.CourseID " +
               " AND Instructs.Instruct_ID= '" + ApplicantID + "' )";
            return dbMan.ExecuteReader(query);
        }

        #endregion


    }
}
