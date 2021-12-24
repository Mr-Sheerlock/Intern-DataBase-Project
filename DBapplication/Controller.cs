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
       
        public int InsertAccount(int ID, string UserName, string Password, string FName, string Lname, char JobCode, int Age, char Gender, string TelephoneNumber ,string Dep_no="")
        {
            string query;
            if (Dep_no == "") {
                if (JobCode == 50)
                { //50 =2+48 
                  //Instructor
                    query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,TelephoneNumber)" +
                                      "Values ('" + ID + "','" + UserName + "','" + Password +
                                      "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                                      ",'" + Gender + "'," + '0' + ",'" + TelephoneNumber + "');";
                }
                else
                { //Applicant
                    query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,TelephoneNumber)" +
                                "Values ('" + ID + "','" + UserName + "','" + Password +
                                "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                                ",'" + Gender + "'," + '1' + ",'" + TelephoneNumber + "');";

                }

            }
            else
            {
                query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status,Dep_No,TelephoneNumber)" +
                                "Values ('" + ID + "','" + UserName + "','" + Password +
                                "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                                ",'" + Gender + "'," + '0' + ",'" + Dep_no + "','" + TelephoneNumber + "');";
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
        public DataTable SelectDep()
        {
            string query = "Select departmentName,Department_Number from department;";
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

    }
}
