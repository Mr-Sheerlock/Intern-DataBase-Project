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

        public DataTable SelectDepNos()
        {
            string query = "Select Department_Number from department;";
            return dbMan.ExecuteReader(query);
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

        public DataTable SelectDep_Loc()
        {
            string query= "Select val =CONCAT(departmentName,'- ', LocationName), Branch_ID "+
                "from department, Locations "+
                "where Branch_ID in "+
                            "("+
                            "Select BranchNo "+
                            "From Course "+
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

        public int GetCurrentYear()
        {
            string query ="select Max(Year_of_Intern) from Takes";
            if (dbMan.ExecuteScalar(query) == DBNull.Value)
            {
                return 2000;  //Base Assumption
            }
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }
    }
}
