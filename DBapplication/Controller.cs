using System;
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

        public int GetLastID()
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
            if (Dep_no == "") {
                if (JobCode == 50)
                { //50 =2+48 
                  //Instructor
                    query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,TelephoneNumber)" +
                                      "Values ('" + ID + "','" + UserName + "','" + Password +
                                      "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                                      ",'" + Gender + "','" + status + "','" + TelephoneNumber + "');";
                }
                else
                { //Applicant or Admin
                    query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,TelephoneNumber)" +
                                "Values ('" + ID + "','" + UserName + "','" + Password +
                                "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                                ",'" + Gender + "','" + status + "','" + TelephoneNumber + "');";

                }

            }
            else
            {
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

        public DataTable SelectDepartmentNamesandNos()
        {
            string query = "Select DepartmentName, Department_Number from department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDep_Loc()
        {
            string query= "Select val =CONCAT(departmentName,'- ', LocationName), Branch_ID "+
                "from department, Locations "+
                "where Branch_ID in "+
                            "("+
                            "Select BranchNo " +   //BranchID having available courses
                            "From Course " +
                            "where Enrolled < Capacity "+
                            "AND Course.CourseID in "+
                            "("+
                                    "Select CourseID "+
                                    "From Instructs "+
			                        ") "+
                            ") " +
                            "AND Locations.Dep_No = department.Department_Number";
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
        public int CheckAvailableCourse() //Checks if there are available courses to apply
        {
            string query = "Select Count(Branch_ID) " +
                "from department, Locations " +
                "where Branch_ID in " +
                            "(" +
                            "Select BranchNo " +   //BranchID having available courses
                            "From Course " +
                            "where Enrolled < Capacity " +
                            "AND Course.CourseID in " +
                            "(" +
                                    "Select CourseID " +
                                    "From Instructs " +
                                    ") " +
                            ") " +
                            "AND Locations.Dep_No = department.Department_Number";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }


        public DataTable SelectLocations(string DepartID)
        {
            string query = "Select Branch_ID, LocationName from Locations where Dep_No= '" + DepartID + "';";
            return dbMan.ExecuteReader(query);
        }
        #endregion


        #region Takes
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

            string query = "select CourseID from Course WHERE Active_Status=1";
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
            string query = "Select Dep_No, DepartmentName , Count(*) From Accounts , department Where Job_Code = 4 AND Dep_No = Department_Number Group By Dep_No, DepartmentName  ORDER by Dep_No";
            return dbMan.ExecuteReader(query);
        }
        //Number of Interns for each Department
        public DataTable STATS_INTERNS_DEPARTMENTS()
        {
            string query = "Select Dep_No, DepartmentName , Count(*) From Accounts , department Where Job_Code = 3 AND Dep_No = Department_Number Group By Dep_No, DepartmentName  ORDER by Dep_No";
            return dbMan.ExecuteReader(query);
        }
        //Number of Instructors for each Department
        public DataTable STATS_INSTRUCTS_DEPARTMENTS()
        {
            string query = "Select Dep_No, DepartmentName , Count(*) From Accounts , department Where Job_Code = 2 AND Dep_No = Department_Number Group By Dep_No, DepartmentName  ORDER by Dep_No";
            return dbMan.ExecuteReader(query);
        }
        //Number of Dropped Applicants in All Courses year Y
        public DataTable STATS_DROPPED_COURSES(int year)
        {
            string query = "Select CourseName , Count(Grade) from Takes , Course Where Takes.CourseID = Course.CourseID AND  Year_of_Intern= " + year + "AND Grade='W' Group By CourseName";
            return dbMan.ExecuteReader(query);
        }
        //Number of Grades in Courses in Year Y in a given department D
        public DataTable STATS_GRADES_PER_DEPARTMENT_COURSES(string Departmentname, int year)
        {
            string query = "Select CourseName , Grade , Count(Grade) From Course,Takes , department Where Course.CourseID = Takes.CourseID AND Year_of_Intern =" + year + " AND Course.DepNo =Department_Number AND DepartmentName = '" + Departmentname + " ' Group By CourseName , Grade Having Grade<>'W' Order By CourseName";
            return dbMan.ExecuteReader(query);
        }
        //Available Courses X For Department D and Their Location L
        public DataTable STATS_COURSES_PER_DEPARTMENT(string Departmentname)
        {
            string query = "Select CourseName , LocationName  From Course , Locations ,department Where  Active_Status=1 AND DepNo = Department_Number AND BranchNo = Branch_ID AND DepartmentName='" + Departmentname + "'";
            return dbMan.ExecuteReader(query);
        }
        //Search for locations L for Course C 
        public DataTable STATS_LOCATION_PER_COURSE(int cid)
        {
            string query = "Select CourseName , LocationName From Course , Locations Where CourseID=" + cid + "AND Active_Status=1 AND BranchNo=Branch_ID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable STATS_COURSE_LECTURES_DATEANDTIMES(int cid)
        {
            string query = "Select LectureNo , LectureDay , LocationName From Lectures,Locations,Course WHERE  Course.CourseID =" + cid + " AND LocationID=Branch_ID AND Lectures.Course_ID=Course.CourseID AND Active_Status=1";
            return dbMan.ExecuteReader(query);
        }

        //Courses and Their Instructors Data 


        //Count For Grade G  in Course C in Year Y 
        public DataTable STATS_COURSE_YEAR_GRADE(int cid, int year, string grade)
        {
            string query = "Select Count(Grade) From Takes, Course Where Course.CourseID=" + cid + " AND Year_of_Intern=" + year + " AND Takes.CourseID=Course.CourseID AND Grade='" + grade + "'";
            return dbMan.ExecuteReader(query);
        }
        #endregion
    }
}
