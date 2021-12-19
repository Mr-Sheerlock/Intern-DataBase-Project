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
        //public DataTable SelectAllEmp()
        //{
        //    string query = "SELECT * FROM Employee;";
        //    return dbMan.ExecuteReader(query);
        //}
        public int CheckifUserTaken(string UserName)
        {
            string query = "Select Count(1) from Accounts where UserName = '" + UserName + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public DataTable SelectPassword(string UserName)
        {
            string query = "Select Pass,Account_Status,Job_Code from Accounts where UserName = '" + UserName + "';";
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

        public int GetID()
        {
            string query = "Select Max(ID) from Accounts"+";";
            
            //in case there are no accounts in the DB 
            if(dbMan.ExecuteScalar(query) == DBNull.Value) 
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
                                ",'" + Gender + "'," + '1' + ",'" + Dep_no + "','" + TelephoneNumber + "');";

            }

            return dbMan.ExecuteNonQuery(query);
        }

        public int GetAdmins()
        {
            string query = "Select Max(ID) from Accounts" + ";";

            //in case there are no accounts in the DB 
            if (dbMan.ExecuteScalar(query) == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public DataTable SelectDep_Loc()
        {
            string query = "SELECT CONCAT(departmentName,'- ', LocationName) , Branch_ID  " +
                            "FROM department, Locations " +
                            "WHERE Branch_ID in " +
                            "(" +
                               "Select BranchNo " +
                               "From Course " +
                               "where Numberofinterns < Capacity " +
                               "AND Active_Status='1' "+
                             ") " +
                               "AND Locations.Dep_No = department.Department_Number;";
            return dbMan.ExecuteReader(query);
        }

    }
}
